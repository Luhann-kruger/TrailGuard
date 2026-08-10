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
            txtIncidentDescription = new ReaLTaiizor.Controls.MaterialRichTextBox();
            txtActionsToBeTaken = new ReaLTaiizor.Controls.MaterialRichTextBox();
            gbHikerDetails = new ReaLTaiizor.Controls.ParrotGroupBox();
            lblTrailName = new ReaLTaiizor.Controls.SkyLabel();
            lblExReturnTime = new ReaLTaiizor.Controls.SkyLabel();
            lblMedicalNotes = new ReaLTaiizor.Controls.SkyLabel();
            lblName = new ReaLTaiizor.Controls.SkyLabel();
            lblTitleDescrption = new ReaLTaiizor.Controls.SkyLabel();
            lblTitleActions = new ReaLTaiizor.Controls.SkyLabel();
            lblSeverityOfSituation = new ReaLTaiizor.Controls.SkyLabel();
            pnlHeader.SuspendLayout();
            gbHikerDetails.SuspendLayout();
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
            lblModeTitle.Location = new Point(710, 9);
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
            btnCancel.Location = new Point(419, 525);
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
            btnCreateIncidentReport.Location = new Point(603, 525);
            btnCreateIncidentReport.Name = "btnCreateIncidentReport";
            btnCreateIncidentReport.Rounded = false;
            btnCreateIncidentReport.Size = new Size(200, 29);
            btnCreateIncidentReport.TabIndex = 9;
            btnCreateIncidentReport.Text = "Create Incident Report";
            btnCreateIncidentReport.TextColor = Color.FromArgb(243, 243, 243);
            btnCreateIncidentReport.Click += btnCreateIncidentReport_Click;
            // 
            // txtIncidentDescription
            // 
            txtIncidentDescription.BackColor = Color.FromArgb(255, 255, 255);
            txtIncidentDescription.BorderStyle = BorderStyle.None;
            txtIncidentDescription.Depth = 0;
            txtIncidentDescription.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIncidentDescription.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtIncidentDescription.Hint = "Eg... Hikers got lost in the mountains. Has severe asthma allergy";
            txtIncidentDescription.Location = new Point(419, 125);
            txtIncidentDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtIncidentDescription.Name = "txtIncidentDescription";
            txtIncidentDescription.Size = new Size(384, 136);
            txtIncidentDescription.TabIndex = 13;
            txtIncidentDescription.Text = "";
            // 
            // txtActionsToBeTaken
            // 
            txtActionsToBeTaken.BackColor = Color.FromArgb(255, 255, 255);
            txtActionsToBeTaken.BorderStyle = BorderStyle.None;
            txtActionsToBeTaken.Depth = 0;
            txtActionsToBeTaken.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtActionsToBeTaken.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtActionsToBeTaken.Hint = "Deploy/Inform Rescue Unit ";
            txtActionsToBeTaken.Location = new Point(419, 334);
            txtActionsToBeTaken.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtActionsToBeTaken.Name = "txtActionsToBeTaken";
            txtActionsToBeTaken.Size = new Size(384, 136);
            txtActionsToBeTaken.TabIndex = 14;
            txtActionsToBeTaken.Text = "";
            // 
            // gbHikerDetails
            // 
            gbHikerDetails.BorderColor = Color.DarkGreen;
            gbHikerDetails.BorderWidth = 1;
            gbHikerDetails.Controls.Add(lblTrailName);
            gbHikerDetails.Controls.Add(lblExReturnTime);
            gbHikerDetails.Controls.Add(lblMedicalNotes);
            gbHikerDetails.Controls.Add(lblName);
            gbHikerDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbHikerDetails.Location = new Point(60, 104);
            gbHikerDetails.Name = "gbHikerDetails";
            gbHikerDetails.ShowText = true;
            gbHikerDetails.Size = new Size(288, 239);
            gbHikerDetails.TabIndex = 20;
            gbHikerDetails.TabStop = false;
            gbHikerDetails.Text = "Permit Details";
            gbHikerDetails.TextColor = Color.DarkGreen;
            // 
            // lblTrailName
            // 
            lblTrailName.AutoSize = true;
            lblTrailName.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrailName.ForeColor = Color.DarkGreen;
            lblTrailName.Location = new Point(6, 141);
            lblTrailName.Name = "lblTrailName";
            lblTrailName.Size = new Size(93, 16);
            lblTrailName.TabIndex = 32;
            lblTrailName.Text = "Trail Name :";
            // 
            // lblExReturnTime
            // 
            lblExReturnTime.AutoSize = true;
            lblExReturnTime.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExReturnTime.ForeColor = Color.DarkGreen;
            lblExReturnTime.Location = new Point(6, 183);
            lblExReturnTime.Name = "lblExReturnTime";
            lblExReturnTime.Size = new Size(179, 16);
            lblExReturnTime.TabIndex = 31;
            lblExReturnTime.Text = "Expected Return Time : ";
            // 
            // lblMedicalNotes
            // 
            lblMedicalNotes.AutoSize = true;
            lblMedicalNotes.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicalNotes.ForeColor = Color.DarkGreen;
            lblMedicalNotes.Location = new Point(6, 78);
            lblMedicalNotes.Name = "lblMedicalNotes";
            lblMedicalNotes.Size = new Size(121, 16);
            lblMedicalNotes.TabIndex = 30;
            lblMedicalNotes.Text = "Medical Notes : ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.DarkGreen;
            lblName.Location = new Point(6, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(58, 16);
            lblName.TabIndex = 28;
            lblName.Text = "Name :";
            // 
            // lblTitleDescrption
            // 
            lblTitleDescrption.AutoSize = true;
            lblTitleDescrption.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleDescrption.ForeColor = Color.DarkGreen;
            lblTitleDescrption.Location = new Point(419, 96);
            lblTitleDescrption.Name = "lblTitleDescrption";
            lblTitleDescrption.Size = new Size(203, 16);
            lblTitleDescrption.TabIndex = 31;
            lblTitleDescrption.Text = "Description Of The Incident";
            // 
            // lblTitleActions
            // 
            lblTitleActions.AutoSize = true;
            lblTitleActions.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleActions.ForeColor = Color.DarkGreen;
            lblTitleActions.Location = new Point(419, 305);
            lblTitleActions.Name = "lblTitleActions";
            lblTitleActions.Size = new Size(108, 16);
            lblTitleActions.TabIndex = 32;
            lblTitleActions.Text = "Actions Taken";
            // 
            // lblSeverityOfSituation
            // 
            lblSeverityOfSituation.AutoSize = true;
            lblSeverityOfSituation.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSeverityOfSituation.ForeColor = Color.DarkGreen;
            lblSeverityOfSituation.Location = new Point(60, 387);
            lblSeverityOfSituation.Name = "lblSeverityOfSituation";
            lblSeverityOfSituation.Size = new Size(111, 16);
            lblSeverityOfSituation.TabIndex = 33;
            lblSeverityOfSituation.Text = "Severity Label";
            // 
            // CreateIncidentReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(864, 581);
            Controls.Add(lblSeverityOfSituation);
            Controls.Add(lblTitleDescrption);
            Controls.Add(lblTitleActions);
            Controls.Add(gbHikerDetails);
            Controls.Add(txtActionsToBeTaken);
            Controls.Add(txtIncidentDescription);
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
            gbHikerDetails.ResumeLayout(false);
            gbHikerDetails.PerformLayout();
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
        private ReaLTaiizor.Controls.MaterialRichTextBox txtIncidentDescription;
        private ReaLTaiizor.Controls.MaterialRichTextBox txtActionsToBeTaken;
        private ReaLTaiizor.Controls.ParrotGroupBox gbHikerDetails;
        private ReaLTaiizor.Controls.SkyLabel lblName;
        private ReaLTaiizor.Controls.SkyLabel lblMedicalNotes;
        private ReaLTaiizor.Controls.SkyLabel lblTitleDescrption;
        private ReaLTaiizor.Controls.SkyLabel lblTitleActions;
        private ReaLTaiizor.Controls.SkyLabel lblTrailName;
        private ReaLTaiizor.Controls.SkyLabel lblExReturnTime;
        private ReaLTaiizor.Controls.SkyLabel lblSeverityOfSituation;
    }
}