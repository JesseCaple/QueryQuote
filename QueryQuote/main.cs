using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryQuote
{
    public partial class Main : Form, IMessageFilter
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Main()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN && Control.FromHandle(m.HWnd) == this)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        private void QuoteifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                string text = Clipboard.GetText().Replace("\"", "");
                using (StringWriter writer = new StringWriter())
                using (StringReader reader = new StringReader(text))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = line.TrimEnd();
                        for (int i = 0; i < line.Length; i++)
                        {
                            char c = line[i];
                            if (!char.IsWhiteSpace(c))
                            {
                                writer.WriteLine(line.Substring(0, i) + "\"" + line.Substring(i) + "\"");
                                break;
                            }
                        }
                    }
                    text = writer.ToString();
                }
                Clipboard.SetText(text);
            }
            catch (Exception) { }
        }

        private void DeQuoteifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Clipboard.GetText().Replace("\"", ""));
            }
            catch (Exception) { }
        }
    }
}
