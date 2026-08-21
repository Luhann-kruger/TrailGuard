namespace TrailGuard
{
    partial class ChatForm
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnClose = new ReaLTaiizor.Controls.ForeverButton();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 4);
            webView21.Name = "webView21";
            webView21.Size = new Size(479, 423);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BaseColor = Color.FromArgb(35, 168, 109);
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(172, 433);
            btnClose.Name = "btnClose";
            btnClose.Rounded = false;
            btnClose.Size = new Size(134, 40);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.TextColor = Color.FromArgb(243, 243, 243);
            btnClose.Click += btnClose_Click;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 478);
            Controls.Add(btnClose);
            Controls.Add(webView21);
            Name = "ChatForm";
            Text = "Trail Guard AI";
            Load += ChatForm_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private ReaLTaiizor.Controls.ForeverButton btnClose;
    }
}