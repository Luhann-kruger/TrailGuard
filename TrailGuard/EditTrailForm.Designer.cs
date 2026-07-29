namespace TrailGuard
{
    partial class EditTrailForm
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
            lblEditTrailTitle = new Label();
            btnCancel = new ReaLTaiizor.Controls.ForeverButton();
            btnSaveTrail = new ReaLTaiizor.Controls.ForeverButton();
            comboBoxSelectPark = new ReaLTaiizor.Controls.MetroComboBox();
            txtChangeTrailName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtChangeMaximumHikers = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            comboBoxSelectDificultyLevel = new ReaLTaiizor.Controls.MetroComboBox();
            comboBoxChangeStatus = new ReaLTaiizor.Controls.MetroComboBox();
            lblSelectPark = new ReaLTaiizor.Controls.DungeonLabel();
            lblChangeDifficulty = new ReaLTaiizor.Controls.DungeonLabel();
            lblChangeTrailStatus = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            lblSelectTrail = new ReaLTaiizor.Controls.DungeonLabel();
            comboBoxSelectTrail = new ReaLTaiizor.Controls.MetroComboBox();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(56, 146, 89);
            pnlHeader.Controls.Add(lblModeTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(1, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1004, 72);
            pnlHeader.TabIndex = 3;
            // 
            // lblModeTitle
            // 
            lblModeTitle.AutoSize = true;
            lblModeTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeTitle.ForeColor = Color.White;
            lblModeTitle.Location = new Point(719, 18);
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
            // lblEditTrailTitle
            // 
            lblEditTrailTitle.AutoSize = true;
            lblEditTrailTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditTrailTitle.Location = new Point(28, 95);
            lblEditTrailTitle.Name = "lblEditTrailTitle";
            lblEditTrailTitle.Size = new Size(136, 40);
            lblEditTrailTitle.TabIndex = 4;
            lblEditTrailTitle.Text = "Edit Trail";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BaseColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(635, 486);
            btnCancel.Name = "btnCancel";
            btnCancel.Rounded = false;
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.Black;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveTrail
            // 
            btnSaveTrail.BackColor = Color.Transparent;
            btnSaveTrail.BaseColor = Color.FromArgb(44, 123, 102);
            btnSaveTrail.Font = new Font("Segoe UI", 12F);
            btnSaveTrail.Location = new Point(829, 486);
            btnSaveTrail.Name = "btnSaveTrail";
            btnSaveTrail.Rounded = false;
            btnSaveTrail.Size = new Size(120, 40);
            btnSaveTrail.TabIndex = 6;
            btnSaveTrail.Text = "Save Trail";
            btnSaveTrail.TextColor = Color.FromArgb(243, 243, 243);
            btnSaveTrail.Click += btnSaveTrail_Click;
            // 
            // comboBoxSelectPark
            // 
            comboBoxSelectPark.AllowDrop = true;
            comboBoxSelectPark.ArrowColor = Color.FromArgb(150, 150, 150);
            comboBoxSelectPark.BackColor = Color.Transparent;
            comboBoxSelectPark.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboBoxSelectPark.BorderColor = Color.FromArgb(150, 150, 150);
            comboBoxSelectPark.CausesValidation = false;
            comboBoxSelectPark.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboBoxSelectPark.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboBoxSelectPark.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboBoxSelectPark.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxSelectPark.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectPark.Font = new Font("Microsoft Sans Serif", 11F);
            comboBoxSelectPark.FormattingEnabled = true;
            comboBoxSelectPark.IsDerivedStyle = true;
            comboBoxSelectPark.ItemHeight = 20;
            comboBoxSelectPark.Location = new Point(39, 181);
            comboBoxSelectPark.Name = "comboBoxSelectPark";
            comboBoxSelectPark.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboBoxSelectPark.SelectedItemForeColor = Color.White;
            comboBoxSelectPark.Size = new Size(250, 26);
            comboBoxSelectPark.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            comboBoxSelectPark.StyleManager = null;
            comboBoxSelectPark.TabIndex = 11;
            comboBoxSelectPark.ThemeAuthor = "Taiizor";
            comboBoxSelectPark.ThemeName = "MetroLight";
            comboBoxSelectPark.SelectedIndexChanged += comboBoxSelectPark_SelectedIndexChanged;
            // 
            // txtChangeTrailName
            // 
            txtChangeTrailName.AllowPromptAsInput = true;
            txtChangeTrailName.AnimateReadOnly = false;
            txtChangeTrailName.AsciiOnly = false;
            txtChangeTrailName.BackgroundImageLayout = ImageLayout.None;
            txtChangeTrailName.BeepOnError = false;
            txtChangeTrailName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtChangeTrailName.Depth = 0;
            txtChangeTrailName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtChangeTrailName.HidePromptOnLeave = false;
            txtChangeTrailName.HideSelection = true;
            txtChangeTrailName.InsertKeyMode = InsertKeyMode.Default;
            txtChangeTrailName.LeadingIcon = null;
            txtChangeTrailName.Location = new Point(699, 181);
            txtChangeTrailName.Mask = "";
            txtChangeTrailName.MaxLength = 32767;
            txtChangeTrailName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtChangeTrailName.Name = "txtChangeTrailName";
            txtChangeTrailName.PasswordChar = '\0';
            txtChangeTrailName.PrefixSuffixText = null;
            txtChangeTrailName.PromptChar = '_';
            txtChangeTrailName.ReadOnly = false;
            txtChangeTrailName.RejectInputOnFirstFailure = false;
            txtChangeTrailName.ResetOnPrompt = true;
            txtChangeTrailName.ResetOnSpace = true;
            txtChangeTrailName.RightToLeft = RightToLeft.No;
            txtChangeTrailName.SelectedText = "";
            txtChangeTrailName.SelectionLength = 0;
            txtChangeTrailName.SelectionStart = 0;
            txtChangeTrailName.ShortcutsEnabled = true;
            txtChangeTrailName.Size = new Size(250, 48);
            txtChangeTrailName.SkipLiterals = true;
            txtChangeTrailName.TabIndex = 20;
            txtChangeTrailName.TabStop = false;
            txtChangeTrailName.Text = "Change Trail Name";
            txtChangeTrailName.TextAlign = HorizontalAlignment.Left;
            txtChangeTrailName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtChangeTrailName.TrailingIcon = null;
            txtChangeTrailName.UseSystemPasswordChar = false;
            txtChangeTrailName.ValidatingType = null;
            // 
            // txtChangeMaximumHikers
            // 
            txtChangeMaximumHikers.AllowPromptAsInput = true;
            txtChangeMaximumHikers.AnimateReadOnly = false;
            txtChangeMaximumHikers.AsciiOnly = false;
            txtChangeMaximumHikers.BackgroundImageLayout = ImageLayout.None;
            txtChangeMaximumHikers.BeepOnError = false;
            txtChangeMaximumHikers.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtChangeMaximumHikers.Depth = 0;
            txtChangeMaximumHikers.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtChangeMaximumHikers.HidePromptOnLeave = false;
            txtChangeMaximumHikers.HideSelection = true;
            txtChangeMaximumHikers.InsertKeyMode = InsertKeyMode.Default;
            txtChangeMaximumHikers.LeadingIcon = null;
            txtChangeMaximumHikers.Location = new Point(699, 287);
            txtChangeMaximumHikers.Mask = "";
            txtChangeMaximumHikers.MaxLength = 32767;
            txtChangeMaximumHikers.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtChangeMaximumHikers.Name = "txtChangeMaximumHikers";
            txtChangeMaximumHikers.PasswordChar = '\0';
            txtChangeMaximumHikers.PrefixSuffixText = null;
            txtChangeMaximumHikers.PromptChar = '_';
            txtChangeMaximumHikers.ReadOnly = false;
            txtChangeMaximumHikers.RejectInputOnFirstFailure = false;
            txtChangeMaximumHikers.ResetOnPrompt = true;
            txtChangeMaximumHikers.ResetOnSpace = true;
            txtChangeMaximumHikers.RightToLeft = RightToLeft.No;
            txtChangeMaximumHikers.SelectedText = "";
            txtChangeMaximumHikers.SelectionLength = 0;
            txtChangeMaximumHikers.SelectionStart = 0;
            txtChangeMaximumHikers.ShortcutsEnabled = true;
            txtChangeMaximumHikers.Size = new Size(250, 48);
            txtChangeMaximumHikers.SkipLiterals = true;
            txtChangeMaximumHikers.TabIndex = 21;
            txtChangeMaximumHikers.TabStop = false;
            txtChangeMaximumHikers.Text = "Change Maximum Hikers";
            txtChangeMaximumHikers.TextAlign = HorizontalAlignment.Left;
            txtChangeMaximumHikers.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtChangeMaximumHikers.TrailingIcon = null;
            txtChangeMaximumHikers.UseSystemPasswordChar = false;
            txtChangeMaximumHikers.ValidatingType = null;
            // 
            // comboBoxSelectDificultyLevel
            // 
            comboBoxSelectDificultyLevel.AllowDrop = true;
            comboBoxSelectDificultyLevel.ArrowColor = Color.FromArgb(150, 150, 150);
            comboBoxSelectDificultyLevel.BackColor = Color.Transparent;
            comboBoxSelectDificultyLevel.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboBoxSelectDificultyLevel.BorderColor = Color.FromArgb(150, 150, 150);
            comboBoxSelectDificultyLevel.CausesValidation = false;
            comboBoxSelectDificultyLevel.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboBoxSelectDificultyLevel.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboBoxSelectDificultyLevel.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboBoxSelectDificultyLevel.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxSelectDificultyLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectDificultyLevel.Font = new Font("Microsoft Sans Serif", 11F);
            comboBoxSelectDificultyLevel.FormattingEnabled = true;
            comboBoxSelectDificultyLevel.IsDerivedStyle = true;
            comboBoxSelectDificultyLevel.ItemHeight = 20;
            comboBoxSelectDificultyLevel.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxSelectDificultyLevel.Location = new Point(363, 287);
            comboBoxSelectDificultyLevel.Name = "comboBoxSelectDificultyLevel";
            comboBoxSelectDificultyLevel.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboBoxSelectDificultyLevel.SelectedItemForeColor = Color.White;
            comboBoxSelectDificultyLevel.Size = new Size(250, 26);
            comboBoxSelectDificultyLevel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            comboBoxSelectDificultyLevel.StyleManager = null;
            comboBoxSelectDificultyLevel.TabIndex = 22;
            comboBoxSelectDificultyLevel.ThemeAuthor = "Taiizor";
            comboBoxSelectDificultyLevel.ThemeName = "MetroLight";
            // 
            // comboBoxChangeStatus
            // 
            comboBoxChangeStatus.AllowDrop = true;
            comboBoxChangeStatus.ArrowColor = Color.FromArgb(150, 150, 150);
            comboBoxChangeStatus.BackColor = Color.Transparent;
            comboBoxChangeStatus.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboBoxChangeStatus.BorderColor = Color.FromArgb(150, 150, 150);
            comboBoxChangeStatus.CausesValidation = false;
            comboBoxChangeStatus.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboBoxChangeStatus.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboBoxChangeStatus.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboBoxChangeStatus.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxChangeStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChangeStatus.Font = new Font("Microsoft Sans Serif", 11F);
            comboBoxChangeStatus.FormattingEnabled = true;
            comboBoxChangeStatus.IsDerivedStyle = true;
            comboBoxChangeStatus.ItemHeight = 20;
            comboBoxChangeStatus.Items.AddRange(new object[] { "Open", "Closed" });
            comboBoxChangeStatus.Location = new Point(363, 181);
            comboBoxChangeStatus.Name = "comboBoxChangeStatus";
            comboBoxChangeStatus.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboBoxChangeStatus.SelectedItemForeColor = Color.White;
            comboBoxChangeStatus.Size = new Size(250, 26);
            comboBoxChangeStatus.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            comboBoxChangeStatus.StyleManager = null;
            comboBoxChangeStatus.TabIndex = 23;
            comboBoxChangeStatus.ThemeAuthor = "Taiizor";
            comboBoxChangeStatus.ThemeName = "MetroLight";
            // 
            // lblSelectPark
            // 
            lblSelectPark.AutoSize = true;
            lblSelectPark.BackColor = Color.Transparent;
            lblSelectPark.Font = new Font("Segoe UI", 11F);
            lblSelectPark.ForeColor = Color.FromArgb(76, 76, 77);
            lblSelectPark.Location = new Point(39, 147);
            lblSelectPark.Name = "lblSelectPark";
            lblSelectPark.Size = new Size(80, 20);
            lblSelectPark.TabIndex = 31;
            lblSelectPark.Text = "Select Park";
            // 
            // lblChangeDifficulty
            // 
            lblChangeDifficulty.AutoSize = true;
            lblChangeDifficulty.BackColor = Color.Transparent;
            lblChangeDifficulty.Font = new Font("Segoe UI", 11F);
            lblChangeDifficulty.ForeColor = Color.FromArgb(76, 76, 77);
            lblChangeDifficulty.Location = new Point(363, 255);
            lblChangeDifficulty.Name = "lblChangeDifficulty";
            lblChangeDifficulty.Size = new Size(161, 20);
            lblChangeDifficulty.TabIndex = 32;
            lblChangeDifficulty.Text = "Change Difficulty Level";
            // 
            // lblChangeTrailStatus
            // 
            lblChangeTrailStatus.AutoSize = true;
            lblChangeTrailStatus.BackColor = Color.Transparent;
            lblChangeTrailStatus.Font = new Font("Segoe UI", 11F);
            lblChangeTrailStatus.ForeColor = Color.FromArgb(76, 76, 77);
            lblChangeTrailStatus.Location = new Point(363, 147);
            lblChangeTrailStatus.Name = "lblChangeTrailStatus";
            lblChangeTrailStatus.Size = new Size(135, 20);
            lblChangeTrailStatus.TabIndex = 33;
            lblChangeTrailStatus.Text = "Change Trail Status";
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 11F);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(699, 147);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(135, 20);
            dungeonLabel1.TabIndex = 34;
            dungeonLabel1.Text = "Change Trail Name";
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 11F);
            dungeonLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel2.Location = new Point(699, 255);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(174, 20);
            dungeonLabel2.TabIndex = 35;
            dungeonLabel2.Text = "Change Maximum Hikers";
            // 
            // lblSelectTrail
            // 
            lblSelectTrail.AutoSize = true;
            lblSelectTrail.BackColor = Color.Transparent;
            lblSelectTrail.Font = new Font("Segoe UI", 11F);
            lblSelectTrail.ForeColor = Color.FromArgb(76, 76, 77);
            lblSelectTrail.Location = new Point(39, 255);
            lblSelectTrail.Name = "lblSelectTrail";
            lblSelectTrail.Size = new Size(81, 20);
            lblSelectTrail.TabIndex = 36;
            lblSelectTrail.Text = "Select Trail";
            // 
            // comboBoxSelectTrail
            // 
            comboBoxSelectTrail.AllowDrop = true;
            comboBoxSelectTrail.ArrowColor = Color.FromArgb(150, 150, 150);
            comboBoxSelectTrail.BackColor = Color.Transparent;
            comboBoxSelectTrail.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboBoxSelectTrail.BorderColor = Color.FromArgb(150, 150, 150);
            comboBoxSelectTrail.CausesValidation = false;
            comboBoxSelectTrail.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboBoxSelectTrail.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboBoxSelectTrail.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboBoxSelectTrail.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxSelectTrail.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectTrail.Font = new Font("Microsoft Sans Serif", 11F);
            comboBoxSelectTrail.FormattingEnabled = true;
            comboBoxSelectTrail.IsDerivedStyle = true;
            comboBoxSelectTrail.ItemHeight = 20;
            comboBoxSelectTrail.Location = new Point(39, 287);
            comboBoxSelectTrail.Name = "comboBoxSelectTrail";
            comboBoxSelectTrail.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboBoxSelectTrail.SelectedItemForeColor = Color.White;
            comboBoxSelectTrail.Size = new Size(250, 26);
            comboBoxSelectTrail.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            comboBoxSelectTrail.StyleManager = null;
            comboBoxSelectTrail.TabIndex = 37;
            comboBoxSelectTrail.ThemeAuthor = "Taiizor";
            comboBoxSelectTrail.ThemeName = "MetroLight";
            comboBoxSelectTrail.SelectedIndexChanged += comboBoxSelectTrail_SelectedIndexChanged;
            // 
            // EditTrailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1004, 557);
            Controls.Add(comboBoxSelectTrail);
            Controls.Add(lblSelectTrail);
            Controls.Add(dungeonLabel2);
            Controls.Add(dungeonLabel1);
            Controls.Add(lblChangeTrailStatus);
            Controls.Add(lblChangeDifficulty);
            Controls.Add(lblSelectPark);
            Controls.Add(comboBoxChangeStatus);
            Controls.Add(comboBoxSelectDificultyLevel);
            Controls.Add(txtChangeMaximumHikers);
            Controls.Add(txtChangeTrailName);
            Controls.Add(comboBoxSelectPark);
            Controls.Add(btnSaveTrail);
            Controls.Add(btnCancel);
            Controls.Add(lblEditTrailTitle);
            Controls.Add(pnlHeader);
            Name = "EditTrailForm";
            Text = "EditTrailForm";
            Load += EditTrailForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Label lblEditTrailTitle;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
        private ReaLTaiizor.Controls.ForeverButton btnSaveTrail;
        private ReaLTaiizor.Controls.MetroComboBox comboBoxSelectPark;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtChangeTrailName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtChangeMaximumHikers;
        private ReaLTaiizor.Controls.MetroComboBox comboBoxSelectDificultyLevel;
        private ReaLTaiizor.Controls.MetroComboBox comboBoxChangeStatus;
        private ReaLTaiizor.Controls.DungeonLabel lblSelectPark;
        private ReaLTaiizor.Controls.DungeonLabel lblChangeDifficulty;
        private ReaLTaiizor.Controls.DungeonLabel lblChangeTrailStatus;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonLabel lblSelectTrail;
        private ReaLTaiizor.Controls.MetroComboBox comboBoxSelectTrail;
    }
}