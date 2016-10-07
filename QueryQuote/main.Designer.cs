namespace QueryQuote
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.QuoteifyButton = new System.Windows.Forms.Button();
            this.DeQuoteifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuoteifyButton
            // 
            this.QuoteifyButton.Location = new System.Drawing.Point(12, 12);
            this.QuoteifyButton.Name = "QuoteifyButton";
            this.QuoteifyButton.Size = new System.Drawing.Size(75, 23);
            this.QuoteifyButton.TabIndex = 1;
            this.QuoteifyButton.Text = "Quoteify";
            this.QuoteifyButton.UseVisualStyleBackColor = true;
            this.QuoteifyButton.Click += new System.EventHandler(this.QuoteifyButton_Click);
            // 
            // DeQuoteifyButton
            // 
            this.DeQuoteifyButton.Location = new System.Drawing.Point(93, 12);
            this.DeQuoteifyButton.Name = "DeQuoteifyButton";
            this.DeQuoteifyButton.Size = new System.Drawing.Size(75, 23);
            this.DeQuoteifyButton.TabIndex = 2;
            this.DeQuoteifyButton.Text = "DeQuoteify";
            this.DeQuoteifyButton.UseVisualStyleBackColor = true;
            this.DeQuoteifyButton.Click += new System.EventHandler(this.DeQuoteifyButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 47);
            this.ControlBox = false;
            this.Controls.Add(this.DeQuoteifyButton);
            this.Controls.Add(this.QuoteifyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button QuoteifyButton;
        private System.Windows.Forms.Button DeQuoteifyButton;
    }
}

