namespace TrailGuard
{
    partial class viewDetailsForm
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
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            lblCheckInTime = new Label();
            label9 = new Label();
            lblExpectedReturn = new Label();
            label7 = new Label();
            lblDate = new Label();
            label5 = new Label();
            lblStatus = new Label();
            label3 = new Label();
            lblTrail = new Label();
            label1 = new Label();
            label2 = new Label();
            dgvParticipants = new DataGridView();
            panel3 = new Panel();
            lblMedicalNotes = new Label();
            label8 = new Label();
            lblHomeAddress = new Label();
            label11 = new Label();
            lblEmail = new Label();
            label13 = new Label();
            lblEmergencyContact = new Label();
            label15 = new Label();
            lblName = new Label();
            label17 = new Label();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(56, 146, 89);
            pnlHeader.Controls.Add(lblModeTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1147, 96);
            pnlHeader.TabIndex = 5;
            // 
            // lblModeTitle
            // 
            lblModeTitle.AutoSize = true;
            lblModeTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeTitle.ForeColor = Color.White;
            lblModeTitle.Location = new Point(921, 33);
            lblModeTitle.Name = "lblModeTitle";
            lblModeTitle.Size = new Size(191, 37);
            lblModeTitle.TabIndex = 3;
            lblModeTitle.Text = "Ranger Mode";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(14, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(187, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "TrailGuard";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Location = new Point(419, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 59);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(202, 38);
            label4.TabIndex = 6;
            label4.Text = "Permit Details";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblCheckInTime);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lblExpectedReturn);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblTrail);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(212, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(743, 193);
            panel2.TabIndex = 8;
            // 
            // lblCheckInTime
            // 
            lblCheckInTime.AutoSize = true;
            lblCheckInTime.Location = new Point(422, 90);
            lblCheckInTime.Name = "lblCheckInTime";
            lblCheckInTime.Size = new Size(15, 20);
            lblCheckInTime.TabIndex = 9;
            lblCheckInTime.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(422, 70);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 8;
            label9.Text = "Check-in time";
            // 
            // lblExpectedReturn
            // 
            lblExpectedReturn.AutoSize = true;
            lblExpectedReturn.Location = new Point(117, 141);
            lblExpectedReturn.Name = "lblExpectedReturn";
            lblExpectedReturn.Size = new Size(15, 20);
            lblExpectedReturn.TabIndex = 7;
            lblExpectedReturn.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 121);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 6;
            label7.Text = "Expected return";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(117, 91);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(15, 20);
            lblDate.TabIndex = 5;
            lblDate.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 71);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 4;
            label5.Text = "Date";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(422, 35);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(15, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 15);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // lblTrail
            // 
            lblTrail.AutoSize = true;
            lblTrail.Location = new Point(117, 36);
            lblTrail.Name = "lblTrail";
            lblTrail.Size = new Size(15, 20);
            lblTrail.TabIndex = 1;
            lblTrail.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 15);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Trail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 373);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 9;
            label2.Text = "Participants";
            // 
            // dgvParticipants
            // 
            dgvParticipants.AllowUserToAddRows = false;
            dgvParticipants.AllowUserToDeleteRows = false;
            dgvParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipants.Location = new Point(215, 396);
            dgvParticipants.Name = "dgvParticipants";
            dgvParticipants.ReadOnly = true;
            dgvParticipants.RowHeadersWidth = 51;
            dgvParticipants.Size = new Size(736, 118);
            dgvParticipants.TabIndex = 10;
            dgvParticipants.SelectionChanged += dgvParticipants_SelectionChanged_1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Menu;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblMedicalNotes);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblHomeAddress);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(lblEmergencyContact);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(lblName);
            panel3.Controls.Add(label17);
            panel3.Location = new Point(212, 520);
            panel3.Name = "panel3";
            panel3.Size = new Size(739, 220);
            panel3.TabIndex = 11;
            // 
            // lblMedicalNotes
            // 
            lblMedicalNotes.AutoSize = true;
            lblMedicalNotes.Location = new Point(422, 153);
            lblMedicalNotes.Name = "lblMedicalNotes";
            lblMedicalNotes.Size = new Size(15, 20);
            lblMedicalNotes.TabIndex = 9;
            lblMedicalNotes.Text = "-";
            lblMedicalNotes.Click += lblMedicalNotes_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(422, 133);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 8;
            label8.Text = "Medical notes";
            // 
            // lblHomeAddress
            // 
            lblHomeAddress.AutoSize = true;
            lblHomeAddress.Location = new Point(115, 173);
            lblHomeAddress.Name = "lblHomeAddress";
            lblHomeAddress.Size = new Size(15, 20);
            lblHomeAddress.TabIndex = 7;
            lblHomeAddress.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(115, 153);
            label11.Name = "label11";
            label11.Size = new Size(105, 20);
            label11.TabIndex = 6;
            label11.Text = "Home address";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(115, 113);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(15, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(115, 93);
            label13.Name = "label13";
            label13.Size = new Size(46, 20);
            label13.TabIndex = 4;
            label13.Text = "Email";
            // 
            // lblEmergencyContact
            // 
            lblEmergencyContact.AutoSize = true;
            lblEmergencyContact.Location = new Point(422, 60);
            lblEmergencyContact.Name = "lblEmergencyContact";
            lblEmergencyContact.Size = new Size(15, 20);
            lblEmergencyContact.TabIndex = 3;
            lblEmergencyContact.Text = "-";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(422, 39);
            label15.Name = "label15";
            label15.Size = new Size(135, 20);
            label15.TabIndex = 2;
            label15.Text = "Emergency contact";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(115, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(15, 20);
            lblName.TabIndex = 1;
            lblName.Text = "-";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(115, 39);
            label17.Name = "label17";
            label17.Size = new Size(49, 20);
            label17.TabIndex = 0;
            label17.Text = "Name";
            // 
            // viewDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1147, 743);
            Controls.Add(panel3);
            Controls.Add(dgvParticipants);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "viewDetailsForm";
            Text = "viewDetailsForm";
            Load += viewDetailsForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Panel panel1;
        private Panel panel2;
        private Label lblCheckInTime;
        private Label label9;
        private Label lblExpectedReturn;
        private Label label7;
        private Label lblDate;
        private Label label5;
        private Label lblStatus;
        private Label label3;
        private Label lblTrail;
        private Label label1;
        private Label label4;
        private Label label2;
        private DataGridView dgvParticipants;
        private Panel panel3;
        private Label lblMedicalNotes;
        private Label label8;
        private Label lblHomeAddress;
        private Label label11;
        private Label lblEmail;
        private Label label13;
        private Label lblEmergencyContact;
        private Label label15;
        private Label lblName;
        private Label label17;
    }
}