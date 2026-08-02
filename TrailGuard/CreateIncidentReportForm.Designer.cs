namespace TrailGuard
{
    partial class CreateIncidentReportForm
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
            lblCreateIncidentReportTitle = new Label();
            btnCancel = new ReaLTaiizor.Controls.ForeverButton();
            btnCreateIncidentReport = new ReaLTaiizor.Controls.ForeverButton();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(56, 146, 89);
            pnlHeader.Controls.Add(lblModeTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(864, 45);
            pnlHeader.TabIndex = 0;
            // 
            // lblModeTitle
            // 
            lblModeTitle.AutoSize = true;
            lblModeTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeTitle.ForeColor = Color.White;
            lblModeTitle.Location = new Point(360, 10);
            lblModeTitle.Name = "lblModeTitle";
            lblModeTitle.Size = new Size(130, 25);
            lblModeTitle.TabIndex = 1;
            lblModeTitle.Text = "Rescue Mode";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(106, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TrailGuard";
            // 
            // lblCreateIncidentReportTitle
            // 
            lblCreateIncidentReportTitle.AutoSize = true;
            lblCreateIncidentReportTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateIncidentReportTitle.Location = new Point(60, 65);
            lblCreateIncidentReportTitle.Name = "lblCreateIncidentReportTitle";
            lblCreateIncidentReportTitle.Size = new Size(230, 30);
            lblCreateIncidentReportTitle.TabIndex = 1;
            lblCreateIncidentReportTitle.Text = "Create Incident report";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BaseColor = Color.FromArgb(84, 84, 84);
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(470, 500);
            btnCancel.Name = "btnCancel";
            btnCancel.Rounded = false;
            btnCancel.Size = new Size(101, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.FromArgb(243, 243, 243);
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreateIncidentReport
            // 
            btnCreateIncidentReport.BackColor = Color.Transparent;
            btnCreateIncidentReport.BaseColor = Color.FromArgb(44, 123, 102);
            btnCreateIncidentReport.Font = new Font("Segoe UI", 12F);
            btnCreateIncidentReport.Location = new Point(600, 500);
            btnCreateIncidentReport.Name = "btnCreateIncidentReport";
            btnCreateIncidentReport.Rounded = false;
            btnCreateIncidentReport.Size = new Size(200, 29);
            btnCreateIncidentReport.TabIndex = 9;
            btnCreateIncidentReport.Text = "Create Incident Report";
            btnCreateIncidentReport.TextColor = Color.FromArgb(243, 243, 243);
            btnCreateIncidentReport.Click += btnCreateIncidentReport_Click;
            // 
            // CreateIncidentReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(864, 581);
            Controls.Add(btnCreateIncidentReport);
            Controls.Add(btnCancel);
            Controls.Add(lblCreateIncidentReportTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateIncidentReportForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Incident Report";
            Load += CreateIncidentReportForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Label lblCreateIncidentReportTitle;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
        private ReaLTaiizor.Controls.ForeverButton btnCreateIncidentReport;
    }
}