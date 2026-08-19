namespace TrailGuard
{
    partial class EditHikerForm
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
            lblEditHikerTitle = new Label();
            pnlFormContent = new Panel();
            gBoxEmergencyInfo = new GroupBox();
            cbRelationship = new ComboBox();
            lblRelationship = new Label();
            lblEmergencyPhoneNum = new Label();
            lblEmergencyFirstName = new Label();
            txtEmergencyFirstName = new TextBox();
            txtEmergencyPhoneNum = new TextBox();
            gBoxHikerInfo = new GroupBox();
            lblMedicalNotes = new Label();
            lblHomeAddress = new Label();
            lblEmailAddress = new Label();
            lblPhoneNumber = new Label();
            lblIDnum = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtIDnum = new TextBox();
            txtEmailAddress = new TextBox();
            txtHomeAddress = new TextBox();
            rtxtMedicalNotes = new RichTextBox();
            txtPhoneNum = new TextBox();
            btnCancel = new ReaLTaiizor.Controls.ForeverButton();
            btnSave = new ReaLTaiizor.Controls.ForeverButton();
            pnlHeader.SuspendLayout();
            pnlFormContent.SuspendLayout();
            gBoxEmergencyInfo.SuspendLayout();
            gBoxHikerInfo.SuspendLayout();
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
            lblModeTitle.Size = new Size(133, 25);
            lblModeTitle.TabIndex = 1;
            lblModeTitle.Text = "Ranger Mode";
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
            // lblEditHikerTitle
            // 
            lblEditHikerTitle.AutoSize = true;
            lblEditHikerTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditHikerTitle.Location = new Point(60, 65);
            lblEditHikerTitle.Name = "lblEditHikerTitle";
            lblEditHikerTitle.Size = new Size(110, 30);
            lblEditHikerTitle.TabIndex = 1;
            lblEditHikerTitle.Text = "Edit Hiker";
            // 
            // pnlFormContent
            // 
            pnlFormContent.BackColor = Color.White;
            pnlFormContent.Controls.Add(gBoxEmergencyInfo);
            pnlFormContent.Controls.Add(gBoxHikerInfo);
            pnlFormContent.Location = new Point(60, 105);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.Size = new Size(740, 400);
            pnlFormContent.TabIndex = 2;
            // 
            // gBoxEmergencyInfo
            // 
            gBoxEmergencyInfo.Controls.Add(cbRelationship);
            gBoxEmergencyInfo.Controls.Add(lblRelationship);
            gBoxEmergencyInfo.Controls.Add(lblEmergencyPhoneNum);
            gBoxEmergencyInfo.Controls.Add(lblEmergencyFirstName);
            gBoxEmergencyInfo.Controls.Add(txtEmergencyFirstName);
            gBoxEmergencyInfo.Controls.Add(txtEmergencyPhoneNum);
            gBoxEmergencyInfo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gBoxEmergencyInfo.Location = new Point(395, 20);
            gBoxEmergencyInfo.Name = "gBoxEmergencyInfo";
            gBoxEmergencyInfo.Size = new Size(327, 202);
            gBoxEmergencyInfo.TabIndex = 3;
            gBoxEmergencyInfo.TabStop = false;
            gBoxEmergencyInfo.Text = "Emergency Contact Information";
            // 
            // cbRelationship
            // 
            cbRelationship.Font = new Font("Segoe UI", 9F);
            cbRelationship.FormattingEnabled = true;
            cbRelationship.Location = new Point(30, 131);
            cbRelationship.Name = "cbRelationship";
            cbRelationship.Size = new Size(269, 23);
            cbRelationship.TabIndex = 14;
            // 
            // lblRelationship
            // 
            lblRelationship.AutoSize = true;
            lblRelationship.Font = new Font("Segoe UI", 9F);
            lblRelationship.Location = new Point(30, 104);
            lblRelationship.Name = "lblRelationship";
            lblRelationship.Size = new Size(149, 15);
            lblRelationship.TabIndex = 13;
            lblRelationship.Text = "Relationship to Participant:";
            // 
            // lblEmergencyPhoneNum
            // 
            lblEmergencyPhoneNum.AutoSize = true;
            lblEmergencyPhoneNum.Font = new Font("Segoe UI", 9F);
            lblEmergencyPhoneNum.Location = new Point(30, 70);
            lblEmergencyPhoneNum.Name = "lblEmergencyPhoneNum";
            lblEmergencyPhoneNum.Size = new Size(91, 15);
            lblEmergencyPhoneNum.TabIndex = 12;
            lblEmergencyPhoneNum.Text = "Phone Number:";
            // 
            // lblEmergencyFirstName
            // 
            lblEmergencyFirstName.AutoSize = true;
            lblEmergencyFirstName.Font = new Font("Segoe UI", 9F);
            lblEmergencyFirstName.Location = new Point(30, 36);
            lblEmergencyFirstName.Name = "lblEmergencyFirstName";
            lblEmergencyFirstName.Size = new Size(67, 15);
            lblEmergencyFirstName.TabIndex = 11;
            lblEmergencyFirstName.Text = "First Name:";
            // 
            // txtEmergencyFirstName
            // 
            txtEmergencyFirstName.Font = new Font("Segoe UI", 9F);
            txtEmergencyFirstName.Location = new Point(148, 28);
            txtEmergencyFirstName.Name = "txtEmergencyFirstName";
            txtEmergencyFirstName.Size = new Size(151, 23);
            txtEmergencyFirstName.TabIndex = 0;
            // 
            // txtEmergencyPhoneNum
            // 
            txtEmergencyPhoneNum.Font = new Font("Segoe UI", 9F);
            txtEmergencyPhoneNum.Location = new Point(148, 62);
            txtEmergencyPhoneNum.Name = "txtEmergencyPhoneNum";
            txtEmergencyPhoneNum.Size = new Size(151, 23);
            txtEmergencyPhoneNum.TabIndex = 1;
            // 
            // gBoxHikerInfo
            // 
            gBoxHikerInfo.Controls.Add(lblMedicalNotes);
            gBoxHikerInfo.Controls.Add(lblHomeAddress);
            gBoxHikerInfo.Controls.Add(lblEmailAddress);
            gBoxHikerInfo.Controls.Add(lblPhoneNumber);
            gBoxHikerInfo.Controls.Add(lblIDnum);
            gBoxHikerInfo.Controls.Add(lblLastName);
            gBoxHikerInfo.Controls.Add(lblFirstName);
            gBoxHikerInfo.Controls.Add(txtFirstName);
            gBoxHikerInfo.Controls.Add(txtLastName);
            gBoxHikerInfo.Controls.Add(txtIDnum);
            gBoxHikerInfo.Controls.Add(txtEmailAddress);
            gBoxHikerInfo.Controls.Add(txtHomeAddress);
            gBoxHikerInfo.Controls.Add(rtxtMedicalNotes);
            gBoxHikerInfo.Controls.Add(txtPhoneNum);
            gBoxHikerInfo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gBoxHikerInfo.Location = new Point(18, 20);
            gBoxHikerInfo.Name = "gBoxHikerInfo";
            gBoxHikerInfo.Size = new Size(350, 360);
            gBoxHikerInfo.TabIndex = 2;
            gBoxHikerInfo.TabStop = false;
            gBoxHikerInfo.Text = "Hiker Information";
            // 
            // lblMedicalNotes
            // 
            lblMedicalNotes.AutoSize = true;
            lblMedicalNotes.Font = new Font("Segoe UI", 9F);
            lblMedicalNotes.Location = new Point(28, 236);
            lblMedicalNotes.Name = "lblMedicalNotes";
            lblMedicalNotes.Size = new Size(86, 15);
            lblMedicalNotes.TabIndex = 13;
            lblMedicalNotes.Text = "Medical Notes:";
            // 
            // lblHomeAddress
            // 
            lblHomeAddress.AutoSize = true;
            lblHomeAddress.Font = new Font("Segoe UI", 9F);
            lblHomeAddress.Location = new Point(28, 206);
            lblHomeAddress.Name = "lblHomeAddress";
            lblHomeAddress.Size = new Size(88, 15);
            lblHomeAddress.TabIndex = 13;
            lblHomeAddress.Text = "Home Address:";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new Font("Segoe UI", 9F);
            lblEmailAddress.Location = new Point(28, 172);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(84, 15);
            lblEmailAddress.TabIndex = 12;
            lblEmailAddress.Text = "Email Address:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F);
            lblPhoneNumber.Location = new Point(28, 138);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(91, 15);
            lblPhoneNumber.TabIndex = 11;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblIDnum
            // 
            lblIDnum.AutoSize = true;
            lblIDnum.FlatStyle = FlatStyle.System;
            lblIDnum.Font = new Font("Segoe UI", 9F);
            lblIDnum.Location = new Point(28, 104);
            lblIDnum.Name = "lblIDnum";
            lblIDnum.Size = new Size(68, 15);
            lblIDnum.TabIndex = 10;
            lblIDnum.Text = "ID Number:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F);
            lblLastName.Location = new Point(28, 70);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(28, 36);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9F);
            txtFirstName.Location = new Point(169, 28);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(151, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9F);
            txtLastName.Location = new Point(169, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(151, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtIDnum
            // 
            txtIDnum.Font = new Font("Segoe UI", 9F);
            txtIDnum.Location = new Point(169, 96);
            txtIDnum.Name = "txtIDnum";
            txtIDnum.Size = new Size(151, 23);
            txtIDnum.TabIndex = 2;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Font = new Font("Segoe UI", 9F);
            txtEmailAddress.Location = new Point(169, 164);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(151, 23);
            txtEmailAddress.TabIndex = 4;
            // 
            // txtHomeAddress
            // 
            txtHomeAddress.Font = new Font("Segoe UI", 9F);
            txtHomeAddress.Location = new Point(169, 198);
            txtHomeAddress.Name = "txtHomeAddress";
            txtHomeAddress.Size = new Size(151, 23);
            txtHomeAddress.TabIndex = 5;
            // 
            // rtxtMedicalNotes
            // 
            rtxtMedicalNotes.Font = new Font("Segoe UI", 9F);
            rtxtMedicalNotes.Location = new Point(28, 263);
            rtxtMedicalNotes.Name = "rtxtMedicalNotes";
            rtxtMedicalNotes.Size = new Size(292, 82);
            rtxtMedicalNotes.TabIndex = 6;
            rtxtMedicalNotes.Text = "";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Font = new Font("Segoe UI", 9F);
            txtPhoneNum.Location = new Point(169, 130);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(151, 23);
            txtPhoneNum.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BaseColor = Color.FromArgb(84, 84, 84);
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(560, 525);
            btnCancel.Name = "btnCancel";
            btnCancel.Rounded = false;
            btnCancel.Size = new Size(101, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.FromArgb(243, 243, 243);
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BaseColor = Color.FromArgb(44, 123, 102);
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(680, 525);
            btnSave.Name = "btnSave";
            btnSave.Rounded = false;
            btnSave.Size = new Size(101, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.FromArgb(243, 243, 243);
            btnSave.Click += btnSave_Click;
            // 
            // EditHikerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(864, 581);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(pnlFormContent);
            Controls.Add(lblEditHikerTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditHikerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Hiker";
            Load += EditHikerForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFormContent.ResumeLayout(false);
            gBoxEmergencyInfo.ResumeLayout(false);
            gBoxEmergencyInfo.PerformLayout();
            gBoxHikerInfo.ResumeLayout(false);
            gBoxHikerInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Label lblEditHikerTitle;
        private Panel pnlFormContent;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
        private ReaLTaiizor.Controls.ForeverButton btnSave;
        private GroupBox gBoxEmergencyInfo;
        private ComboBox cbRelationship;
        private Label lblRelationship;
        private Label lblEmergencyPhoneNum;
        private Label lblEmergencyFirstName;
        private TextBox txtEmergencyFirstName;
        private TextBox txtEmergencyPhoneNum;
        private GroupBox gBoxHikerInfo;
        private Label lblMedicalNotes;
        private Label lblHomeAddress;
        private Label lblEmailAddress;
        private Label lblPhoneNumber;
        private Label lblIDnum;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtIDnum;
        private TextBox txtEmailAddress;
        private TextBox txtHomeAddress;
        private RichTextBox rtxtMedicalNotes;
        private TextBox txtPhoneNum;
    }
}