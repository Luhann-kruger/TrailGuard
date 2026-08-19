namespace TrailGuard
{
    partial class editPermitForm
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
            lblEditPermitTitle = new Label();
            dtpExpectedReturnTime = new DateTimePicker();
            dtpPermitDate = new DateTimePicker();
            cmbSelectTrail = new ComboBox();
            lblExpectedReturnTime = new Label();
            lblSelectDate = new Label();
            lblSelectTrail = new Label();
            lblSelectPark = new Label();
            cmbSelectPark = new ComboBox();
            pnlAddParticipants = new Panel();
            btnReloadAll = new ReaLTaiizor.Controls.ForeverButton();
            label1 = new Label();
            dgvParticipants = new DataGridView();
            btnSearchParticipant = new ReaLTaiizor.Controls.ForeverButton();
            txtSearchParticipant = new TextBox();
            lblAddParticipantHeading = new Label();
            btnUpdatePermit = new ReaLTaiizor.Controls.ForeverButton();
            btnCancel = new ReaLTaiizor.Controls.ForeverButton();
            pnlHeader.SuspendLayout();
            pnlAddParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(56, 146, 89);
            pnlHeader.Controls.Add(lblModeTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1004, 72);
            pnlHeader.TabIndex = 4;
            // 
            // lblModeTitle
            // 
            lblModeTitle.AutoSize = true;
            lblModeTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeTitle.ForeColor = Color.White;
            lblModeTitle.Location = new Point(806, 25);
            lblModeTitle.Name = "lblModeTitle";
            lblModeTitle.Size = new Size(146, 30);
            lblModeTitle.TabIndex = 3;
            lblModeTitle.Text = "Ranger Mode";
            lblModeTitle.Click += lblModeTitle_Click;
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
            // lblEditPermitTitle
            // 
            lblEditPermitTitle.AutoSize = true;
            lblEditPermitTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditPermitTitle.Location = new Point(28, 113);
            lblEditPermitTitle.Name = "lblEditPermitTitle";
            lblEditPermitTitle.Size = new Size(168, 40);
            lblEditPermitTitle.TabIndex = 5;
            lblEditPermitTitle.Text = "Edit Permit";
            // 
            // dtpExpectedReturnTime
            // 
            dtpExpectedReturnTime.CustomFormat = "HH:mm:ss";
            dtpExpectedReturnTime.Format = DateTimePickerFormat.Custom;
            dtpExpectedReturnTime.Location = new Point(699, 246);
            dtpExpectedReturnTime.Name = "dtpExpectedReturnTime";
            dtpExpectedReturnTime.ShowUpDown = true;
            dtpExpectedReturnTime.Size = new Size(200, 23);
            dtpExpectedReturnTime.TabIndex = 20;
            dtpExpectedReturnTime.ValueChanged += dtpExpectedReturnTime_ValueChanged;
            // 
            // dtpPermitDate
            // 
            dtpPermitDate.Location = new Point(159, 247);
            dtpPermitDate.Name = "dtpPermitDate";
            dtpPermitDate.Size = new Size(200, 23);
            dtpPermitDate.TabIndex = 19;
            dtpPermitDate.ValueChanged += dtpPermitDate_ValueChanged;
            // 
            // cmbSelectTrail
            // 
            cmbSelectTrail.FormattingEnabled = true;
            cmbSelectTrail.Location = new Point(670, 170);
            cmbSelectTrail.Name = "cmbSelectTrail";
            cmbSelectTrail.Size = new Size(229, 23);
            cmbSelectTrail.TabIndex = 18;
            cmbSelectTrail.SelectedIndexChanged += cmbSelectTrail_SelectedIndexChanged;
            // 
            // lblExpectedReturnTime
            // 
            lblExpectedReturnTime.AutoSize = true;
            lblExpectedReturnTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpectedReturnTime.Location = new Point(499, 247);
            lblExpectedReturnTime.Name = "lblExpectedReturnTime";
            lblExpectedReturnTime.Size = new Size(181, 21);
            lblExpectedReturnTime.TabIndex = 17;
            lblExpectedReturnTime.Text = "Expected Return Time:";
            // 
            // lblSelectDate
            // 
            lblSelectDate.AutoSize = true;
            lblSelectDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectDate.Location = new Point(37, 247);
            lblSelectDate.Name = "lblSelectDate";
            lblSelectDate.Size = new Size(100, 21);
            lblSelectDate.TabIndex = 16;
            lblSelectDate.Text = "Select Date:";
            // 
            // lblSelectTrail
            // 
            lblSelectTrail.AutoSize = true;
            lblSelectTrail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectTrail.Location = new Point(499, 170);
            lblSelectTrail.Name = "lblSelectTrail";
            lblSelectTrail.Size = new Size(97, 21);
            lblSelectTrail.TabIndex = 15;
            lblSelectTrail.Text = "Select Trail:";
            // 
            // lblSelectPark
            // 
            lblSelectPark.AutoSize = true;
            lblSelectPark.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectPark.Location = new Point(35, 168);
            lblSelectPark.Name = "lblSelectPark";
            lblSelectPark.Size = new Size(99, 21);
            lblSelectPark.TabIndex = 14;
            lblSelectPark.Text = "Select Park:";
            // 
            // cmbSelectPark
            // 
            cmbSelectPark.FormattingEnabled = true;
            cmbSelectPark.Location = new Point(159, 166);
            cmbSelectPark.Name = "cmbSelectPark";
            cmbSelectPark.Size = new Size(229, 23);
            cmbSelectPark.TabIndex = 13;
            cmbSelectPark.SelectedIndexChanged += cmbSelectPark_SelectedIndexChanged;
            // 
            // pnlAddParticipants
            // 
            pnlAddParticipants.BackColor = Color.White;
            pnlAddParticipants.Controls.Add(btnReloadAll);
            pnlAddParticipants.Controls.Add(label1);
            pnlAddParticipants.Controls.Add(dgvParticipants);
            pnlAddParticipants.Controls.Add(btnSearchParticipant);
            pnlAddParticipants.Controls.Add(txtSearchParticipant);
            pnlAddParticipants.Controls.Add(lblAddParticipantHeading);
            pnlAddParticipants.Location = new Point(13, 305);
            pnlAddParticipants.Name = "pnlAddParticipants";
            pnlAddParticipants.Size = new Size(953, 374);
            pnlAddParticipants.TabIndex = 21;
            // 
            // btnReloadAll
            // 
            btnReloadAll.BackColor = Color.Transparent;
            btnReloadAll.BaseColor = Color.LightGray;
            btnReloadAll.Font = new Font("Segoe UI", 12F);
            btnReloadAll.Location = new Point(805, 80);
            btnReloadAll.Name = "btnReloadAll";
            btnReloadAll.RightToLeft = RightToLeft.No;
            btnReloadAll.Rounded = false;
            btnReloadAll.Size = new Size(119, 29);
            btnReloadAll.TabIndex = 16;
            btnReloadAll.Text = "Reload All";
            btnReloadAll.TextColor = Color.Black;
            btnReloadAll.Click += btnReloadAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 48);
            label1.Name = "label1";
            label1.Size = new Size(482, 15);
            label1.TabIndex = 14;
            label1.Text = "Please Note: You should first register a participant (hiker) before you can add to the permit\r\n";
            // 
            // dgvParticipants
            // 
            dgvParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipants.Location = new Point(18, 115);
            dgvParticipants.Name = "dgvParticipants";
            dgvParticipants.Size = new Size(906, 187);
            dgvParticipants.TabIndex = 14;
            dgvParticipants.CellContentClick += dgvParticipants_CellContentClick;
            // 
            // btnSearchParticipant
            // 
            btnSearchParticipant.BackColor = Color.Transparent;
            btnSearchParticipant.BaseColor = Color.FromArgb(44, 123, 102);
            btnSearchParticipant.Font = new Font("Segoe UI", 12F);
            btnSearchParticipant.Location = new Point(805, 25);
            btnSearchParticipant.Name = "btnSearchParticipant";
            btnSearchParticipant.Rounded = false;
            btnSearchParticipant.Size = new Size(119, 29);
            btnSearchParticipant.TabIndex = 11;
            btnSearchParticipant.Text = "Search";
            btnSearchParticipant.TextColor = Color.FromArgb(243, 243, 243);
            btnSearchParticipant.Click += btnSearchParticipant_Click;
            // 
            // txtSearchParticipant
            // 
            txtSearchParticipant.BackColor = SystemColors.ScrollBar;
            txtSearchParticipant.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchParticipant.Location = new Point(556, 25);
            txtSearchParticipant.Name = "txtSearchParticipant";
            txtSearchParticipant.Size = new Size(230, 27);
            txtSearchParticipant.TabIndex = 10;
            // 
            // lblAddParticipantHeading
            // 
            lblAddParticipantHeading.AutoSize = true;
            lblAddParticipantHeading.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddParticipantHeading.Location = new Point(18, 14);
            lblAddParticipantHeading.Name = "lblAddParticipantHeading";
            lblAddParticipantHeading.Size = new Size(162, 25);
            lblAddParticipantHeading.TabIndex = 9;
            lblAddParticipantHeading.Text = "Add Participant: ";
            // 
            // btnUpdatePermit
            // 
            btnUpdatePermit.BackColor = Color.Transparent;
            btnUpdatePermit.BaseColor = Color.FromArgb(44, 123, 102);
            btnUpdatePermit.Font = new Font("Segoe UI", 12F);
            btnUpdatePermit.Location = new Point(847, 707);
            btnUpdatePermit.Name = "btnUpdatePermit";
            btnUpdatePermit.Rounded = false;
            btnUpdatePermit.Size = new Size(119, 29);
            btnUpdatePermit.TabIndex = 22;
            btnUpdatePermit.Text = "Update Permit";
            btnUpdatePermit.TextColor = Color.FromArgb(243, 243, 243);
            btnUpdatePermit.Click += btnUpdatePermit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BaseColor = Color.LightGray;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(670, 707);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Rounded = false;
            btnCancel.Size = new Size(119, 29);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.Black;
            btnCancel.Click += btnCancel_Click;
            // 
            // editPermitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1004, 758);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdatePermit);
            Controls.Add(pnlAddParticipants);
            Controls.Add(dtpExpectedReturnTime);
            Controls.Add(dtpPermitDate);
            Controls.Add(cmbSelectTrail);
            Controls.Add(lblExpectedReturnTime);
            Controls.Add(lblSelectDate);
            Controls.Add(lblSelectTrail);
            Controls.Add(lblSelectPark);
            Controls.Add(cmbSelectPark);
            Controls.Add(lblEditPermitTitle);
            Controls.Add(pnlHeader);
            Name = "editPermitForm";
            Text = "editPermitForm";
            Load += editPermitForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlAddParticipants.ResumeLayout(false);
            pnlAddParticipants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Label lblEditPermitTitle;
        private DateTimePicker dtpExpectedReturnTime;
        private DateTimePicker dtpPermitDate;
        private ComboBox cmbSelectTrail;
        private Label lblExpectedReturnTime;
        private Label lblSelectDate;
        private Label lblSelectTrail;
        private Label lblSelectPark;
        private ComboBox cmbSelectPark;
        private Panel pnlAddParticipants;
        private ReaLTaiizor.Controls.ForeverButton btnReloadAll;
        private Label label1;
        private DataGridView dgvParticipants;
        private ReaLTaiizor.Controls.ForeverButton btnSearchParticipant;
        private TextBox txtSearchParticipant;
        private Label lblAddParticipantHeading;
        private ReaLTaiizor.Controls.ForeverButton btnUpdatePermit;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
    }
}