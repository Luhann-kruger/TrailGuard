namespace TrailGuard
{
    partial class LoginForm
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblLoginTitle = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new ReaLTaiizor.Controls.ForeverButton();
            btnShowHidePassword = new ReaLTaiizor.Controls.ForeverButton();
            btnLoginDetails = new ReaLTaiizor.Controls.ForeverButton();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(56, 146, 89);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(2, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(687, 72);
            pnlHeader.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(151, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "TrailGuard";
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.Location = new Point(301, 141);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(94, 40);
            lblLoginTitle.TabIndex = 6;
            lblLoginTitle.Text = "Login";
            lblLoginTitle.Click += lblLoginTitle_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(157, 234);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(108, 25);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "Username: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(157, 308);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 25);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password: ";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(271, 236);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(213, 23);
            txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(271, 308);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(213, 23);
            txtPassword.TabIndex = 10;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BaseColor = Color.FromArgb(44, 123, 102);
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(271, 376);
            btnLogin.Name = "btnLogin";
            btnLogin.Rounded = false;
            btnLogin.Size = new Size(139, 41);
            btnLogin.TabIndex = 23;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.FromArgb(243, 243, 243);
            btnLogin.Click += btnLogin_Click;
            // 
            // btnShowHidePassword
            // 
            btnShowHidePassword.BackColor = Color.Transparent;
            btnShowHidePassword.BaseColor = Color.Silver;
            btnShowHidePassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowHidePassword.Location = new Point(490, 308);
            btnShowHidePassword.Name = "btnShowHidePassword";
            btnShowHidePassword.Rounded = false;
            btnShowHidePassword.Size = new Size(74, 25);
            btnShowHidePassword.TabIndex = 24;
            btnShowHidePassword.Text = "Show";
            btnShowHidePassword.TextColor = Color.FromArgb(64, 64, 64);
            btnShowHidePassword.Click += btnShowHidePassword_Click;
            // 
            // btnLoginDetails
            // 
            btnLoginDetails.BackColor = Color.Transparent;
            btnLoginDetails.BaseColor = Color.DimGray;
            btnLoginDetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoginDetails.Location = new Point(14, 533);
            btnLoginDetails.Name = "btnLoginDetails";
            btnLoginDetails.Rounded = false;
            btnLoginDetails.Size = new Size(97, 25);
            btnLoginDetails.TabIndex = 25;
            btnLoginDetails.Text = "Login Details";
            btnLoginDetails.TextColor = Color.White;
            btnLoginDetails.Click += btnLoginDetails_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(689, 570);
            Controls.Add(btnLoginDetails);
            Controls.Add(btnShowHidePassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblLoginTitle);
            Controls.Add(pnlHeader);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblLoginTitle;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ReaLTaiizor.Controls.ForeverButton btnLogin;
        private ReaLTaiizor.Controls.ForeverButton btnShowHidePassword;
        private ReaLTaiizor.Controls.ForeverButton btnLoginDetails;
    }
}