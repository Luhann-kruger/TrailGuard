namespace TrailGuard
{
    partial class CreateTrailForm
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
            lblCreateTrailTitle = new Label();
            btnCancel = new ReaLTaiizor.Controls.ForeverButton();
            btnCreateTrail = new ReaLTaiizor.Controls.ForeverButton();
            cmbSelectPark = new ComboBox();
            txtTrailName = new TextBox();
            numDifficultyLevel = new NumericUpDown();
            numMaxHikers = new NumericUpDown();
            lblSelectPark = new Label();
            lblTrailName = new Label();
            lblDifficulty = new Label();
            lblMaxHikers = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDifficultyLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxHikers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(56, 146, 89);
            pnlHeader.Controls.Add(lblModeTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1004, 72);
            pnlHeader.TabIndex = 2;
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
            // lblCreateTrailTitle
            // 
            lblCreateTrailTitle.AutoSize = true;
            lblCreateTrailTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateTrailTitle.Location = new Point(36, 107);
            lblCreateTrailTitle.Name = "lblCreateTrailTitle";
            lblCreateTrailTitle.Size = new Size(173, 40);
            lblCreateTrailTitle.TabIndex = 3;
            lblCreateTrailTitle.Text = "Create Trail";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BaseColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(582, 538);
            btnCancel.Name = "btnCancel";
            btnCancel.Rounded = false;
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.Black;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreateTrail
            // 
            btnCreateTrail.BackColor = Color.Transparent;
            btnCreateTrail.BaseColor = Color.FromArgb(44, 123, 102);
            btnCreateTrail.Font = new Font("Segoe UI", 12F);
            btnCreateTrail.Location = new Point(806, 538);
            btnCreateTrail.Name = "btnCreateTrail";
            btnCreateTrail.Rounded = false;
            btnCreateTrail.Size = new Size(120, 40);
            btnCreateTrail.TabIndex = 5;
            btnCreateTrail.Text = "Create Trail";
            btnCreateTrail.TextColor = Color.FromArgb(243, 243, 243);
            btnCreateTrail.Click += btnCreateTrail_Click;
            // 
            // cmbSelectPark
            // 
            cmbSelectPark.FormattingEnabled = true;
            cmbSelectPark.Location = new Point(201, 196);
            cmbSelectPark.Name = "cmbSelectPark";
            cmbSelectPark.Size = new Size(186, 23);
            cmbSelectPark.TabIndex = 6;
            // 
            // txtTrailName
            // 
            txtTrailName.Location = new Point(582, 196);
            txtTrailName.Name = "txtTrailName";
            txtTrailName.Size = new Size(199, 23);
            txtTrailName.TabIndex = 7;
            // 
            // numDifficultyLevel
            // 
            numDifficultyLevel.Location = new Point(275, 271);
            numDifficultyLevel.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numDifficultyLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDifficultyLevel.Name = "numDifficultyLevel";
            numDifficultyLevel.Size = new Size(136, 23);
            numDifficultyLevel.TabIndex = 8;
            numDifficultyLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numMaxHikers
            // 
            numMaxHikers.Location = new Point(645, 269);
            numMaxHikers.Name = "numMaxHikers";
            numMaxHikers.Size = new Size(136, 23);
            numMaxHikers.TabIndex = 9;
            // 
            // lblSelectPark
            // 
            lblSelectPark.AutoSize = true;
            lblSelectPark.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectPark.Location = new Point(65, 194);
            lblSelectPark.Name = "lblSelectPark";
            lblSelectPark.Size = new Size(111, 25);
            lblSelectPark.TabIndex = 10;
            lblSelectPark.Text = "Select Park:";
            // 
            // lblTrailName
            // 
            lblTrailName.AutoSize = true;
            lblTrailName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrailName.Location = new Point(452, 194);
            lblTrailName.Name = "lblTrailName";
            lblTrailName.Size = new Size(109, 25);
            lblTrailName.TabIndex = 11;
            lblTrailName.Text = "Trail Name:";
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDifficulty.Location = new Point(65, 269);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(202, 25);
            lblDifficulty.TabIndex = 12;
            lblDifficulty.Text = "Difficulty Rating (1-5):";
            lblDifficulty.Click += lblDifficulty_Click;
            // 
            // lblMaxHikers
            // 
            lblMaxHikers.AutoSize = true;
            lblMaxHikers.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaxHikers.Location = new Point(452, 263);
            lblMaxHikers.Name = "lblMaxHikers";
            lblMaxHikers.Size = new Size(114, 25);
            lblMaxHikers.TabIndex = 13;
            lblMaxHikers.Text = "Max Hikers:";
            // 
            // CreateTrailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1004, 590);
            Controls.Add(lblMaxHikers);
            Controls.Add(lblDifficulty);
            Controls.Add(lblTrailName);
            Controls.Add(lblSelectPark);
            Controls.Add(numMaxHikers);
            Controls.Add(numDifficultyLevel);
            Controls.Add(txtTrailName);
            Controls.Add(cmbSelectPark);
            Controls.Add(btnCreateTrail);
            Controls.Add(btnCancel);
            Controls.Add(lblCreateTrailTitle);
            Controls.Add(pnlHeader);
            Name = "CreateTrailForm";
            Text = "CreateTrailForm";
            Load += CreateTrailForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDifficultyLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxHikers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Label lblCreateTrailTitle;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
        private ReaLTaiizor.Controls.ForeverButton btnCreateTrail;
        private ComboBox cmbSelectPark;
        private TextBox txtTrailName;
        private NumericUpDown numDifficultyLevel;
        private NumericUpDown numMaxHikers;
        private Label lblSelectPark;
        private Label lblTrailName;
        private Label lblDifficulty;
        private Label lblMaxHikers;
    }
}