namespace TrailGuard
{
    partial class ParentMDIRescueForm
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
            lblMenuOptions = new Label();
            btnMaintainRescues = new ReaLTaiizor.Controls.ForeverButton();
            btnOverduePermits = new ReaLTaiizor.Controls.ForeverButton();
            btnChangeMode = new ReaLTaiizor.Controls.ForeverButton();
            pnlHeader.SuspendLayout();
            pnlSidebarMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(56, 146, 89);
            pnlHeader.Controls.Add(btnChangeMode);
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
            lblModeTitle.Size = new Size(143, 30);
            lblModeTitle.TabIndex = 3;
            lblModeTitle.Text = "Rescue Mode";
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
            pnlSidebarMenu.Controls.Add(lblMenuOptions);
            pnlSidebarMenu.Controls.Add(btnMaintainRescues);
            pnlSidebarMenu.Controls.Add(btnOverduePermits);
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
            btnLogout.Click += btnLogout_Click;
            // 
            // lblMenuOptions
            // 
            lblMenuOptions.AutoSize = true;
            lblMenuOptions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuOptions.ForeColor = Color.White;
            lblMenuOptions.Location = new Point(12, 8);
            lblMenuOptions.Name = "lblMenuOptions";
            lblMenuOptions.Size = new Size(118, 21);
            lblMenuOptions.TabIndex = 5;
            lblMenuOptions.Text = "Menu Options";
            // 
            // btnMaintainRescues
            // 
            btnMaintainRescues.BackColor = Color.Transparent;
            btnMaintainRescues.BaseColor = Color.FromArgb(14, 76, 39);
            btnMaintainRescues.Font = new Font("Segoe UI", 12F);
            btnMaintainRescues.Location = new Point(-3, 99);
            btnMaintainRescues.Name = "btnMaintainRescues";
            btnMaintainRescues.Rounded = false;
            btnMaintainRescues.Size = new Size(203, 40);
            btnMaintainRescues.TabIndex = 3;
            btnMaintainRescues.Text = "Maintain Rescues";
            btnMaintainRescues.TextColor = Color.FromArgb(243, 243, 243);
            btnMaintainRescues.Click += btnMaintainRescues_Click;
            // 
            // btnOverduePermits
            // 
            btnOverduePermits.BackColor = Color.Transparent;
            btnOverduePermits.BaseColor = Color.FromArgb(14, 76, 39);
            btnOverduePermits.Font = new Font("Segoe UI", 12F);
            btnOverduePermits.Location = new Point(-3, 37);
            btnOverduePermits.Name = "btnOverduePermits";
            btnOverduePermits.Rounded = false;
            btnOverduePermits.Size = new Size(203, 40);
            btnOverduePermits.TabIndex = 2;
            btnOverduePermits.Text = "Overdue Permits";
            btnOverduePermits.TextColor = Color.FromArgb(243, 243, 243);
            btnOverduePermits.Click += btnOverduePermits_Click;
            // 
            // btnChangeMode
            // 
            btnChangeMode.BackColor = Color.Transparent;
            btnChangeMode.BaseColor = Color.FromArgb(14, 76, 39);
            btnChangeMode.Font = new Font("Segoe UI", 12F);
            btnChangeMode.Location = new Point(1224, 18);
            btnChangeMode.Name = "btnChangeMode";
            btnChangeMode.Rounded = false;
            btnChangeMode.Size = new Size(120, 40);
            btnChangeMode.TabIndex = 6;
            btnChangeMode.Text = "Change Mode";
            btnChangeMode.TextColor = Color.FromArgb(243, 243, 243);
            btnChangeMode.Click += btnChangeMode_Click;
            // 
            // ParentMDIRescueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 654);
            Controls.Add(pnlSidebarMenu);
            Controls.Add(pnlHeader);
            IsMdiContainer = true;
            Name = "ParentMDIRescueForm";
            Text = "TrailGuard";
            Load += ParentMDIRescueForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebarMenu.ResumeLayout(false);
            pnlSidebarMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlSidebarMenu;
        private ReaLTaiizor.Controls.ForeverButton btnOverduePermits;
        private ReaLTaiizor.Controls.ForeverButton btnMaintainRescues;
        private Label lblModeTitle;
        private Label lblMenuOptions;
        private ReaLTaiizor.Controls.ForeverButton btnLogout;
        private ReaLTaiizor.Controls.ForeverButton btnChangeMode;
    }
}