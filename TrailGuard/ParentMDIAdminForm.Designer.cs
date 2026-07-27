namespace TrailGuard
{
    partial class ParentMDIAdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblModeTitle = new Label();
            lblTitle = new Label();
            pnlSidebarMenu = new Panel();
            btnLogout = new ReaLTaiizor.Controls.ForeverButton();
            btnGenerateReport = new ReaLTaiizor.Controls.ForeverButton();
            btnMaintainParks = new ReaLTaiizor.Controls.ForeverButton();
            btnMaintainTrails = new ReaLTaiizor.Controls.ForeverButton();
            pnlHeader.SuspendLayout();
            pnlSidebarMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(56, 146, 89);
            pnlHeader.Controls.Add(lblModeTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1454, 72);
            pnlHeader.TabIndex = 0;
            // 
            // lblModeTitle
            // 
            lblModeTitle.AutoSize = true;
            lblModeTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeTitle.ForeColor = Color.White;
            lblModeTitle.Location = new Point(582, 24);
            lblModeTitle.Name = "lblModeTitle";
            lblModeTitle.Size = new Size(142, 30);
            lblModeTitle.TabIndex = 3;
            lblModeTitle.Text = "Admin Mode";
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
            pnlSidebarMenu.Controls.Add(btnLogout);
            pnlSidebarMenu.Controls.Add(btnGenerateReport);
            pnlSidebarMenu.Controls.Add(btnMaintainParks);
            pnlSidebarMenu.Controls.Add(btnMaintainTrails);
            pnlSidebarMenu.Location = new Point(0, 71);
            pnlSidebarMenu.Name = "pnlSidebarMenu";
            pnlSidebarMenu.Size = new Size(203, 581);
            pnlSidebarMenu.TabIndex = 1;
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
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.Transparent;
            btnGenerateReport.BaseColor = Color.FromArgb(14, 76, 39);
            btnGenerateReport.Font = new Font("Segoe UI", 12F);
            btnGenerateReport.Location = new Point(0, 162);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Rounded = false;
            btnGenerateReport.Size = new Size(203, 40);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Reports";
            btnGenerateReport.TextColor = Color.FromArgb(243, 243, 243);
            btnGenerateReport.Click += this.btnGenerateReport_Click;
            // 
            // btnMaintainParks
            // 
            btnMaintainParks.BackColor = Color.Transparent;
            btnMaintainParks.BaseColor = Color.FromArgb(14, 76, 39);
            btnMaintainParks.Font = new Font("Segoe UI", 12F);
            btnMaintainParks.Location = new Point(-3, 99);
            btnMaintainParks.Name = "btnMaintainParks";
            btnMaintainParks.Rounded = false;
            btnMaintainParks.Size = new Size(203, 40);
            btnMaintainParks.TabIndex = 3;
            btnMaintainParks.Text = "Maintain Parks";
            btnMaintainParks.TextColor = Color.FromArgb(243, 243, 243);
            btnMaintainParks.Click += btnMaintainParks_Click;
            // 
            // btnMaintainTrails
            // 
            btnMaintainTrails.BackColor = Color.Transparent;
            btnMaintainTrails.BaseColor = Color.FromArgb(14, 76, 39);
            btnMaintainTrails.Font = new Font("Segoe UI", 12F);
            btnMaintainTrails.Location = new Point(-3, 37);
            btnMaintainTrails.Name = "btnMaintainTrails";
            btnMaintainTrails.Rounded = false;
            btnMaintainTrails.Size = new Size(203, 40);
            btnMaintainTrails.TabIndex = 2;
            btnMaintainTrails.Text = "Maintain Trails";
            btnMaintainTrails.TextColor = Color.FromArgb(243, 243, 243);
            btnMaintainTrails.Click += btnMaintainTrails_Click;
            // 
            // ParentMDIAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 654);
            Controls.Add(pnlSidebarMenu);
            Controls.Add(pnlHeader);
            IsMdiContainer = true;
            Name = "ParentMDIAdminForm";
            Text = "TrailGuard";
            Load += ParentMDIAdminForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebarMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlSidebarMenu;
        private ReaLTaiizor.Controls.ForeverButton btnMaintainParks;
        private ReaLTaiizor.Controls.ForeverButton btnMaintainTrails;
        private ReaLTaiizor.Controls.ForeverButton btnGenerateReport;
        private Label lblModeTitle;
        private ReaLTaiizor.Controls.ForeverButton btnLogout;
    }
}
