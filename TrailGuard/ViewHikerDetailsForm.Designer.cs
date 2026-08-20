namespace TrailGuard
{
    partial class ViewHikerDetailsForm
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
            lblViewHikerDetailsTitle = new Label();
            pnlFormContent = new Panel();
            rtxtMedicalNotes = new RichTextBox();
            txtEmailAddress = new TextBox();
            txtHomeAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtIDNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblMedicalNotes = new Label();
            lblHomeAdress = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblIDNumber = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            btnBack = new ReaLTaiizor.Controls.ForeverButton();
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
            // lblViewHikerDetailsTitle
            // 
            lblViewHikerDetailsTitle.AutoSize = true;
            lblViewHikerDetailsTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewHikerDetailsTitle.Location = new Point(60, 65);
            lblViewHikerDetailsTitle.Name = "lblViewHikerDetailsTitle";
            lblViewHikerDetailsTitle.Size = new Size(192, 30);
            lblViewHikerDetailsTitle.TabIndex = 1;
            lblViewHikerDetailsTitle.Text = "View Hiker Details";
            // 
            // pnlFormContent
            // 
            pnlFormContent.BackColor = Color.White;
            pnlFormContent.Controls.Add(rtxtMedicalNotes);
            pnlFormContent.Controls.Add(txtEmailAddress);
            pnlFormContent.Controls.Add(txtHomeAddress);
            pnlFormContent.Controls.Add(txtPhoneNumber);
            pnlFormContent.Controls.Add(txtIDNumber);
            pnlFormContent.Controls.Add(txtLastName);
            pnlFormContent.Controls.Add(txtFirstName);
            pnlFormContent.Controls.Add(lblMedicalNotes);
            pnlFormContent.Controls.Add(lblHomeAdress);
            pnlFormContent.Controls.Add(lblEmail);
            pnlFormContent.Controls.Add(lblPhoneNumber);
            pnlFormContent.Controls.Add(lblIDNumber);
            pnlFormContent.Controls.Add(lblLastName);
            pnlFormContent.Controls.Add(lblFirstName);
            pnlFormContent.Location = new Point(60, 105);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.Size = new Size(753, 429);
            pnlFormContent.TabIndex = 2;
            // 
            // rtxtMedicalNotes
            // 
            rtxtMedicalNotes.Location = new Point(189, 279);
            rtxtMedicalNotes.Name = "rtxtMedicalNotes";
            rtxtMedicalNotes.Size = new Size(271, 94);
            rtxtMedicalNotes.TabIndex = 23;
            rtxtMedicalNotes.Text = "";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(189, 197);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(145, 23);
            txtEmailAddress.TabIndex = 21;
            // 
            // txtHomeAddress
            // 
            txtHomeAddress.Location = new Point(189, 237);
            txtHomeAddress.Name = "txtHomeAddress";
            txtHomeAddress.Size = new Size(145, 23);
            txtHomeAddress.TabIndex = 22;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(189, 156);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(145, 23);
            txtPhoneNumber.TabIndex = 20;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(189, 118);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(145, 23);
            txtIDNumber.TabIndex = 19;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(189, 80);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(145, 23);
            txtLastName.TabIndex = 18;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(189, 42);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(145, 23);
            txtFirstName.TabIndex = 17;
            // 
            // lblMedicalNotes
            // 
            lblMedicalNotes.AutoSize = true;
            lblMedicalNotes.Location = new Point(27, 281);
            lblMedicalNotes.Name = "lblMedicalNotes";
            lblMedicalNotes.Size = new Size(86, 15);
            lblMedicalNotes.TabIndex = 30;
            lblMedicalNotes.Text = "Medical Notes:";
            // 
            // lblHomeAdress
            // 
            lblHomeAdress.AutoSize = true;
            lblHomeAdress.Location = new Point(28, 240);
            lblHomeAdress.Name = "lblHomeAdress";
            lblHomeAdress.Size = new Size(81, 15);
            lblHomeAdress.TabIndex = 29;
            lblHomeAdress.Text = "Home Adress:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(28, 201);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(27, 161);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(91, 15);
            lblPhoneNumber.TabIndex = 27;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblIDNumber
            // 
            lblIDNumber.AutoSize = true;
            lblIDNumber.Location = new Point(29, 124);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(68, 15);
            lblIDNumber.TabIndex = 26;
            lblIDNumber.Text = "ID Number:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(28, 87);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 25;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(25, 50);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 24;
            lblFirstName.Text = "First Name:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BaseColor = Color.FromArgb(84, 84, 84);
            btnBack.Font = new Font("Segoe UI", 12F);
            btnBack.Location = new Point(60, 552);
            btnBack.Name = "btnBack";
            btnBack.Rounded = false;
            btnBack.Size = new Size(101, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.TextColor = Color.FromArgb(243, 243, 243);
            btnBack.Click += btnBack_Click;
            // 
            // ViewHikerDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(864, 581);
            Controls.Add(pnlFormContent);
            Controls.Add(lblViewHikerDetailsTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewHikerDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View Hiker Details";
            Load += ViewHikerDetailsForm_Load;
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
        private Label lblViewHikerDetailsTitle;
        private Panel pnlFormContent;
        private ReaLTaiizor.Controls.ForeverButton btnBack;
        private RichTextBox rtxtMedicalNotes;
        private TextBox txtEmailAddress;
        private TextBox txtHomeAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtIDNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblMedicalNotes;
        private Label lblHomeAdress;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblIDNumber;
        private Label lblLastName;
        private Label lblFirstName;
    }
}