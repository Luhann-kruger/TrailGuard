namespace TrailGuard
{
    partial class ModesForm
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
            lblModeTitle = new Label();
            lblTitle = new Label();
            lblRoleTitle = new Label();
            btnRangerMode = new ReaLTaiizor.Controls.ForeverButton();
            btnAdminMode = new ReaLTaiizor.Controls.ForeverButton();
            btnRescueMode = new ReaLTaiizor.Controls.ForeverButton();
            btnLogout = new ReaLTaiizor.Controls.ForeverButton();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(56, 146, 89);
            pnlHeader.Controls.Add(lblModeTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(1, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(690, 72);
            pnlHeader.TabIndex = 6;
            // 
            // lblModeTitle
            // 
            lblModeTitle.AutoSize = true;
            lblModeTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeTitle.ForeColor = Color.White;
            lblModeTitle.Location = new Point(512, 24);
            lblModeTitle.Name = "lblModeTitle";
            lblModeTitle.Size = new Size(134, 30);
            lblModeTitle.TabIndex = 7;
            lblModeTitle.Text = "Select Mode";
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
            // lblRoleTitle
            // 
            lblRoleTitle.AutoSize = true;
            lblRoleTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoleTitle.Location = new Point(61, 92);
            lblRoleTitle.Name = "lblRoleTitle";
            lblRoleTitle.Size = new Size(564, 40);
            lblRoleTitle.TabIndex = 7;
            lblRoleTitle.Text = "Username, you can access these Modes:";
            // 
            // btnRangerMode
            // 
            btnRangerMode.BackColor = Color.Transparent;
            btnRangerMode.BaseColor = Color.FromArgb(44, 123, 102);
            btnRangerMode.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRangerMode.Location = new Point(203, 167);
            btnRangerMode.Name = "btnRangerMode";
            btnRangerMode.Rounded = false;
            btnRangerMode.Size = new Size(260, 41);
            btnRangerMode.TabIndex = 24;
            btnRangerMode.Text = "Ranger Mode";
            btnRangerMode.TextColor = Color.FromArgb(243, 243, 243);
            btnRangerMode.Click += btnRangerMode_Click;
            // 
            // btnAdminMode
            // 
            btnAdminMode.BackColor = Color.Transparent;
            btnAdminMode.BaseColor = Color.FromArgb(44, 123, 102);
            btnAdminMode.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminMode.Location = new Point(203, 245);
            btnAdminMode.Name = "btnAdminMode";
            btnAdminMode.Rounded = false;
            btnAdminMode.Size = new Size(260, 41);
            btnAdminMode.TabIndex = 25;
            btnAdminMode.Text = "Admin Mode";
            btnAdminMode.TextColor = Color.FromArgb(243, 243, 243);
            btnAdminMode.Click += btnAdminMode_Click;
            // 
            // btnRescueMode
            // 
            btnRescueMode.BackColor = Color.Transparent;
            btnRescueMode.BaseColor = Color.FromArgb(44, 123, 102);
            btnRescueMode.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRescueMode.Location = new Point(203, 324);
            btnRescueMode.Name = "btnRescueMode";
            btnRescueMode.Rounded = false;
            btnRescueMode.Size = new Size(260, 41);
            btnRescueMode.TabIndex = 26;
            btnRescueMode.Text = "Rescue Mode";
            btnRescueMode.TextColor = Color.FromArgb(243, 243, 243);
            btnRescueMode.Click += btnRescueMode_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BaseColor = Color.FromArgb(255, 87, 87);
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.Location = new Point(575, 407);
            btnLogout.Name = "btnLogout";
            btnLogout.Rounded = false;
            btnLogout.Size = new Size(94, 31);
            btnLogout.TabIndex = 27;
            btnLogout.Text = "Logout";
            btnLogout.TextColor = Color.FromArgb(243, 243, 243);
            btnLogout.Click += btnLogout_Click;
            // 
            // ModesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(691, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnRescueMode);
            Controls.Add(btnAdminMode);
            Controls.Add(btnRangerMode);
            Controls.Add(lblRoleTitle);
            Controls.Add(pnlHeader);
            Name = "ModesForm";
            Text = "ModesForm";
            Load += ModesForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblModeTitle;
        private Label lblRoleTitle;
        private ReaLTaiizor.Controls.ForeverButton btnRangerMode;
        private ReaLTaiizor.Controls.ForeverButton btnAdminMode;
        private ReaLTaiizor.Controls.ForeverButton btnRescueMode;
        private ReaLTaiizor.Controls.ForeverButton btnLogout;
    }
}