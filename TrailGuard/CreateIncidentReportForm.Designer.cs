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
            lblPermitID = new Label();
            lblPermitIDValue = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblActionTaken = new Label();
            txtActionTaken = new TextBox();
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
            lblModeTitle.Size = new Size(129, 25);
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
            lblTitle.Size = new Size(105, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TrailGuard";
            // 
            // lblCreateIncidentReportTitle
            // 
            lblCreateIncidentReportTitle.AutoSize = true;
            lblCreateIncidentReportTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateIncidentReportTitle.Location = new Point(60, 65);
            lblCreateIncidentReportTitle.Name = "lblCreateIncidentReportTitle";
            lblCreateIncidentReportTitle.Size = new Size(240, 30);
            lblCreateIncidentReportTitle.TabIndex = 1;
            lblCreateIncidentReportTitle.Text = "Create Incident report";
            // 
            // lblPermitID
            // 
            lblPermitID.AutoSize = true;
            lblPermitID.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPermitID.Location = new Point(60, 105);
            lblPermitID.Name = "lblPermitID";
            lblPermitID.Size = new Size(70, 19);
            lblPermitID.TabIndex = 2;
            lblPermitID.Text = "Permit ID:";
            // 
            // lblPermitIDValue
            // 
            lblPermitIDValue.AutoSize = true;
            lblPermitIDValue.Font = new Font("Segoe UI", 10F);
            lblPermitIDValue.Location = new Point(136, 105);
            lblPermitIDValue.Name = "lblPermitIDValue";
            lblPermitIDValue.Size = new Size(14, 19);
            lblPermitIDValue.TabIndex = 3;
            lblPermitIDValue.Text = "-";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.Location = new Point(60, 140);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(215, 19);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Enter incident description.";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(60, 165);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(380, 160);
            txtDescription.TabIndex = 5;
            // 
            // lblActionTaken
            // 
            lblActionTaken.AutoSize = true;
            lblActionTaken.Font = new Font("Segoe UI", 10F);
            lblActionTaken.Location = new Point(60, 340);
            lblActionTaken.Name = "lblActionTaken";
            lblActionTaken.Size = new Size(210, 19);
            lblActionTaken.TabIndex = 6;
            lblActionTaken.Text = "Enter actions that will be taken";
            // 
            // txtActionTaken
            // 
            txtActionTaken.BackColor = Color.White;
            txtActionTaken.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtActionTaken.Location = new Point(60, 365);
            txtActionTaken.Multiline = true;
            txtActionTaken.Name = "txtActionTaken";
            txtActionTaken.ScrollBars = ScrollBars.Vertical;
            txtActionTaken.Size = new Size(380, 90);
            txtActionTaken.TabIndex = 7;
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
            Controls.Add(txtActionTaken);
            Controls.Add(lblActionTaken);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblPermitIDValue);
            Controls.Add(lblPermitID);
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
        private Label lblPermitID;
        private Label lblPermitIDValue;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblActionTaken;
        private TextBox txtActionTaken;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
        private ReaLTaiizor.Controls.ForeverButton btnCreateIncidentReport;
    }
}