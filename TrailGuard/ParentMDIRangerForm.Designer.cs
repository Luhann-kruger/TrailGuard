namespace TrailGuard
{
    partial class ParentMDIRangerForm
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
            pnlSidebarMenu = new Panel();
            btnAskTrailGuardAI = new ReaLTaiizor.Controls.ForeverButton();
            btnLogout = new ReaLTaiizor.Controls.ForeverButton();
            btnMaintainHikers = new ReaLTaiizor.Controls.ForeverButton();
            btnMaintainPermits = new ReaLTaiizor.Controls.ForeverButton();
            pnlHeader.SuspendLayout();
            pnlSidebarMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(56, 146, 89);
            pnlHeader.Controls.Add(lblModeTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1454, 72);
            pnlHeader.TabIndex = 1;
            // 
            // lblModeTitle
            // 
            lblModeTitle.AutoSize = true;
            lblModeTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeTitle.ForeColor = Color.White;
            lblModeTitle.Location = new Point(582, 24);
            lblModeTitle.Name = "lblModeTitle";
            lblModeTitle.Size = new Size(146, 30);
            lblModeTitle.TabIndex = 3;
            lblModeTitle.Text = "Ranger Mode";
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
            // pnlSidebarMenu
            // 
            pnlSidebarMenu.BackColor = Color.FromArgb(14, 76, 39);
            pnlSidebarMenu.Controls.Add(btnAskTrailGuardAI);
            pnlSidebarMenu.Controls.Add(btnLogout);
            pnlSidebarMenu.Controls.Add(btnMaintainHikers);
            pnlSidebarMenu.Controls.Add(btnMaintainPermits);
            pnlSidebarMenu.Location = new Point(1, 70);
            pnlSidebarMenu.Name = "pnlSidebarMenu";
            pnlSidebarMenu.Size = new Size(203, 581);
            pnlSidebarMenu.TabIndex = 2;
            // 
            // btnAskTrailGuardAI
            // 
            btnAskTrailGuardAI.BackColor = Color.Transparent;
            btnAskTrailGuardAI.BaseColor = Color.FromArgb(14, 76, 39);
            btnAskTrailGuardAI.Font = new Font("Segoe UI", 12F);
            btnAskTrailGuardAI.Location = new Point(-3, 440);
            btnAskTrailGuardAI.Name = "btnAskTrailGuardAI";
            btnAskTrailGuardAI.Rounded = false;
            btnAskTrailGuardAI.Size = new Size(203, 40);
            btnAskTrailGuardAI.TabIndex = 4;
            btnAskTrailGuardAI.Text = "Ask TrailGaurd AI";
            btnAskTrailGuardAI.TextColor = Color.FromArgb(243, 243, 243);
            btnAskTrailGuardAI.Click += btnAskTrailGuardAI_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BaseColor = Color.FromArgb(255, 87, 87);
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.Location = new Point(43, 518);
            btnLogout.Name = "btnLogout";
            btnLogout.Rounded = false;
            btnLogout.Size = new Size(101, 29);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // btnMaintainHikers
            // 
            btnMaintainHikers.BackColor = Color.Transparent;
            btnMaintainHikers.BaseColor = Color.FromArgb(14, 76, 39);
            btnMaintainHikers.Font = new Font("Segoe UI", 12F);
            btnMaintainHikers.Location = new Point(-3, 99);
            btnMaintainHikers.Name = "btnMaintainHikers";
            btnMaintainHikers.Rounded = false;
            btnMaintainHikers.Size = new Size(203, 40);
            btnMaintainHikers.TabIndex = 3;
            btnMaintainHikers.Text = "Maintain Hikers";
            btnMaintainHikers.TextColor = Color.FromArgb(243, 243, 243);
            btnMaintainHikers.Click += btnMaintainHikers_Click;
            // 
            // btnMaintainPermits
            // 
            btnMaintainPermits.BackColor = Color.Transparent;
            btnMaintainPermits.BaseColor = Color.FromArgb(14, 76, 39);
            btnMaintainPermits.Font = new Font("Segoe UI", 12F);
            btnMaintainPermits.Location = new Point(-3, 37);
            btnMaintainPermits.Name = "btnMaintainPermits";
            btnMaintainPermits.Rounded = false;
            btnMaintainPermits.Size = new Size(203, 40);
            btnMaintainPermits.TabIndex = 2;
            btnMaintainPermits.Text = "Maintain Permits";
            btnMaintainPermits.TextColor = Color.FromArgb(243, 243, 243);
            btnMaintainPermits.Click += btnMaintainPermits_Click;
            // 
            // ParentMDIRangerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 654);
            Controls.Add(pnlSidebarMenu);
            Controls.Add(pnlHeader);
            IsMdiContainer = true;
            Name = "ParentMDIRangerForm";
            Text = "TrailGuard";
            Load += ParentMDIRangerForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebarMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Panel pnlSidebarMenu;
        private ReaLTaiizor.Controls.ForeverButton btnLogout;
        private ReaLTaiizor.Controls.ForeverButton btnGenerateReport;
        private ReaLTaiizor.Controls.ForeverButton btnMaintainHikers;
        private ReaLTaiizor.Controls.ForeverButton btnMaintainPermits;
        private ReaLTaiizor.Controls.ForeverButton btnAskTrailGuardAI;
    }
}