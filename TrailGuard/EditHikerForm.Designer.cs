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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblIDNumber = new Label();
            txtIDNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblEmailAddress = new Label();
            txtEmailAddress = new TextBox();
            lblHomeAddress = new Label();
            txtHomeAddress = new TextBox();
            lblMedicalNotes = new Label();
            txtMedicalNotes = new TextBox();
            lblEmergencyContactName = new Label();
            txtEmergencyContactName = new TextBox();
            lblEmergencyContactNumber = new Label();
            txtEmergencyContactNumber = new TextBox();
            lblRelationshipToParticipant = new Label();
            txtRelationshipToParticipant = new TextBox();
            btnCancel = new ReaLTaiizor.Controls.ForeverButton();
            btnSave = new ReaLTaiizor.Controls.ForeverButton();
            pnlHeader.SuspendLayout();
            pnlFormContent.SuspendLayout();
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
            lblModeTitle.Text = "Ranger Mode";
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
            // lblEditHikerTitle
            // 
            lblEditHikerTitle.AutoSize = true;
            lblEditHikerTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditHikerTitle.Location = new Point(60, 65);
            lblEditHikerTitle.Name = "lblEditHikerTitle";
            lblEditHikerTitle.Size = new Size(104, 30);
            lblEditHikerTitle.TabIndex = 1;
            lblEditHikerTitle.Text = "Edit Hiker";
            // 
            // pnlFormContent
            // 
            pnlFormContent.BackColor = Color.White;
            pnlFormContent.Controls.Add(lblFirstName);
            pnlFormContent.Controls.Add(txtFirstName);
            pnlFormContent.Controls.Add(lblLastName);
            pnlFormContent.Controls.Add(txtLastName);
            pnlFormContent.Controls.Add(lblIDNumber);
            pnlFormContent.Controls.Add(txtIDNumber);
            pnlFormContent.Controls.Add(lblPhoneNumber);
            pnlFormContent.Controls.Add(txtPhoneNumber);
            pnlFormContent.Controls.Add(lblEmailAddress);
            pnlFormContent.Controls.Add(txtEmailAddress);
            pnlFormContent.Controls.Add(lblHomeAddress);
            pnlFormContent.Controls.Add(txtHomeAddress);
            pnlFormContent.Controls.Add(lblMedicalNotes);
            pnlFormContent.Controls.Add(txtMedicalNotes);
            pnlFormContent.Controls.Add(lblEmergencyContactName);
            pnlFormContent.Controls.Add(txtEmergencyContactName);
            pnlFormContent.Controls.Add(lblEmergencyContactNumber);
            pnlFormContent.Controls.Add(txtEmergencyContactNumber);
            pnlFormContent.Controls.Add(lblRelationshipToParticipant);
            pnlFormContent.Controls.Add(txtRelationshipToParticipant);
            pnlFormContent.Location = new Point(60, 105);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.Size = new Size(740, 400);
            pnlFormContent.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F);
            lblFirstName.Location = new Point(30, 20);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(72, 19);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.ScrollBar;
            txtFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(30, 42);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(300, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F);
            lblLastName.Location = new Point(30, 80);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(71, 19);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.ScrollBar;
            txtLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(30, 102);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(300, 27);
            txtLastName.TabIndex = 3;
            // 
            // lblIDNumber
            // 
            lblIDNumber.AutoSize = true;
            lblIDNumber.Font = new Font("Segoe UI", 10F);
            lblIDNumber.Location = new Point(30, 140);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(72, 19);
            lblIDNumber.TabIndex = 4;
            lblIDNumber.Text = "ID Number";
            // 
            // txtIDNumber
            // 
            txtIDNumber.BackColor = SystemColors.ScrollBar;
            txtIDNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDNumber.Location = new Point(30, 162);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(300, 27);
            txtIDNumber.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 10F);
            lblPhoneNumber.Location = new Point(30, 200);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(97, 19);
            lblPhoneNumber.TabIndex = 6;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.ScrollBar;
            txtPhoneNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(30, 222);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(300, 27);
            txtPhoneNumber.TabIndex = 7;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new Font("Segoe UI", 10F);
            lblEmailAddress.Location = new Point(30, 260);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(93, 19);
            lblEmailAddress.TabIndex = 8;
            lblEmailAddress.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BackColor = SystemColors.ScrollBar;
            txtEmailAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailAddress.Location = new Point(30, 282);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(300, 27);
            txtEmailAddress.TabIndex = 9;
            // 
            // lblHomeAddress
            // 
            lblHomeAddress.AutoSize = true;
            lblHomeAddress.Font = new Font("Segoe UI", 10F);
            lblHomeAddress.Location = new Point(390, 20);
            lblHomeAddress.Name = "lblHomeAddress";
            lblHomeAddress.Size = new Size(97, 19);
            lblHomeAddress.TabIndex = 10;
            lblHomeAddress.Text = "Home Address";
            // 
            // txtHomeAddress
            // 
            txtHomeAddress.BackColor = SystemColors.ScrollBar;
            txtHomeAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHomeAddress.Location = new Point(390, 42);
            txtHomeAddress.Multiline = true;
            txtHomeAddress.Name = "txtHomeAddress";
            txtHomeAddress.Size = new Size(300, 60);
            txtHomeAddress.TabIndex = 11;
            // 
            // lblMedicalNotes
            // 
            lblMedicalNotes.AutoSize = true;
            lblMedicalNotes.Font = new Font("Segoe UI", 10F);
            lblMedicalNotes.Location = new Point(390, 112);
            lblMedicalNotes.Name = "lblMedicalNotes";
            lblMedicalNotes.Size = new Size(93, 19);
            lblMedicalNotes.TabIndex = 12;
            lblMedicalNotes.Text = "Medical Notes";
            // 
            // txtMedicalNotes
            // 
            txtMedicalNotes.BackColor = SystemColors.ScrollBar;
            txtMedicalNotes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMedicalNotes.Location = new Point(390, 134);
            txtMedicalNotes.Multiline = true;
            txtMedicalNotes.Name = "txtMedicalNotes";
            txtMedicalNotes.Size = new Size(300, 60);
            txtMedicalNotes.TabIndex = 13;
            // 
            // lblEmergencyContactName
            // 
            lblEmergencyContactName.AutoSize = true;
            lblEmergencyContactName.Font = new Font("Segoe UI", 10F);
            lblEmergencyContactName.Location = new Point(390, 204);
            lblEmergencyContactName.Name = "lblEmergencyContactName";
            lblEmergencyContactName.Size = new Size(168, 19);
            lblEmergencyContactName.TabIndex = 14;
            lblEmergencyContactName.Text = "Emergency Contact Name";
            // 
            // txtEmergencyContactName
            // 
            txtEmergencyContactName.BackColor = SystemColors.ScrollBar;
            txtEmergencyContactName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmergencyContactName.Location = new Point(390, 226);
            txtEmergencyContactName.Name = "txtEmergencyContactName";
            txtEmergencyContactName.Size = new Size(300, 27);
            txtEmergencyContactName.TabIndex = 15;
            // 
            // lblEmergencyContactNumber
            // 
            lblEmergencyContactNumber.AutoSize = true;
            lblEmergencyContactNumber.Font = new Font("Segoe UI", 10F);
            lblEmergencyContactNumber.Location = new Point(390, 260);
            lblEmergencyContactNumber.Name = "lblEmergencyContactNumber";
            lblEmergencyContactNumber.Size = new Size(184, 19);
            lblEmergencyContactNumber.TabIndex = 16;
            lblEmergencyContactNumber.Text = "Emergency Contact Number";
            // 
            // txtEmergencyContactNumber
            // 
            txtEmergencyContactNumber.BackColor = SystemColors.ScrollBar;
            txtEmergencyContactNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmergencyContactNumber.Location = new Point(390, 282);
            txtEmergencyContactNumber.Name = "txtEmergencyContactNumber";
            txtEmergencyContactNumber.Size = new Size(300, 27);
            txtEmergencyContactNumber.TabIndex = 17;
            // 
            // lblRelationshipToParticipant
            // 
            lblRelationshipToParticipant.AutoSize = true;
            lblRelationshipToParticipant.Font = new Font("Segoe UI", 10F);
            lblRelationshipToParticipant.Location = new Point(390, 316);
            lblRelationshipToParticipant.Name = "lblRelationshipToParticipant";
            lblRelationshipToParticipant.Size = new Size(174, 19);
            lblRelationshipToParticipant.TabIndex = 18;
            lblRelationshipToParticipant.Text = "Relationship To Participant";
            // 
            // txtRelationshipToParticipant
            // 
            txtRelationshipToParticipant.BackColor = SystemColors.ScrollBar;
            txtRelationshipToParticipant.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRelationshipToParticipant.Location = new Point(390, 338);
            txtRelationshipToParticipant.Name = "txtRelationshipToParticipant";
            txtRelationshipToParticipant.Size = new Size(300, 27);
            txtRelationshipToParticipant.TabIndex = 19;
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
            pnlFormContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Label lblEditHikerTitle;
        private Panel pnlFormContent;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblIDNumber;
        private TextBox txtIDNumber;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblEmailAddress;
        private TextBox txtEmailAddress;
        private Label lblHomeAddress;
        private TextBox txtHomeAddress;
        private Label lblMedicalNotes;
        private TextBox txtMedicalNotes;
        private Label lblEmergencyContactName;
        private TextBox txtEmergencyContactName;
        private Label lblEmergencyContactNumber;
        private TextBox txtEmergencyContactNumber;
        private Label lblRelationshipToParticipant;
        private TextBox txtRelationshipToParticipant;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
        private ReaLTaiizor.Controls.ForeverButton btnSave;
    }
}