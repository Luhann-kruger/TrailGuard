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
            txtChangeDifficultyLevel = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtChangeTrailStatus = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtChangeTrailName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtChangeMaximumHikers = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            lblEditTrailTitle.Location = new Point(142, 97);
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
            btnCancel.Location = new Point(543, 495);
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
            btnSaveTrail.Location = new Point(742, 495);
            btnSaveTrail.Name = "btnSaveTrail";
            btnSaveTrail.Rounded = false;
            btnSaveTrail.Size = new Size(120, 40);
            btnSaveTrail.TabIndex = 6;
            btnSaveTrail.Text = "Save Trail";
            btnSaveTrail.TextColor = Color.FromArgb(243, 243, 243);
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
            comboBoxSelectPark.Location = new Point(142, 181);
            comboBoxSelectPark.Name = "comboBoxSelectPark";
            comboBoxSelectPark.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboBoxSelectPark.SelectedItemForeColor = Color.White;
            comboBoxSelectPark.Size = new Size(250, 26);
            comboBoxSelectPark.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            comboBoxSelectPark.StyleManager = null;
            comboBoxSelectPark.TabIndex = 11;
            comboBoxSelectPark.ThemeAuthor = "Taiizor";
            comboBoxSelectPark.ThemeName = "MetroLight";
            // 
            // txtChangeDifficultyLevel
            // 
            txtChangeDifficultyLevel.AllowPromptAsInput = true;
            txtChangeDifficultyLevel.AnimateReadOnly = false;
            txtChangeDifficultyLevel.AsciiOnly = false;
            txtChangeDifficultyLevel.BackgroundImageLayout = ImageLayout.None;
            txtChangeDifficultyLevel.BeepOnError = false;
            txtChangeDifficultyLevel.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtChangeDifficultyLevel.Depth = 0;
            txtChangeDifficultyLevel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtChangeDifficultyLevel.HidePromptOnLeave = false;
            txtChangeDifficultyLevel.HideSelection = true;
            txtChangeDifficultyLevel.InsertKeyMode = InsertKeyMode.Default;
            txtChangeDifficultyLevel.LeadingIcon = null;
            txtChangeDifficultyLevel.Location = new Point(142, 238);
            txtChangeDifficultyLevel.Mask = "";
            txtChangeDifficultyLevel.MaxLength = 32767;
            txtChangeDifficultyLevel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtChangeDifficultyLevel.Name = "txtChangeDifficultyLevel";
            txtChangeDifficultyLevel.PasswordChar = '\0';
            txtChangeDifficultyLevel.PrefixSuffixText = null;
            txtChangeDifficultyLevel.PromptChar = '_';
            txtChangeDifficultyLevel.ReadOnly = false;
            txtChangeDifficultyLevel.RejectInputOnFirstFailure = false;
            txtChangeDifficultyLevel.ResetOnPrompt = true;
            txtChangeDifficultyLevel.ResetOnSpace = true;
            txtChangeDifficultyLevel.RightToLeft = RightToLeft.No;
            txtChangeDifficultyLevel.SelectedText = "";
            txtChangeDifficultyLevel.SelectionLength = 0;
            txtChangeDifficultyLevel.SelectionStart = 0;
            txtChangeDifficultyLevel.ShortcutsEnabled = true;
            txtChangeDifficultyLevel.Size = new Size(250, 48);
            txtChangeDifficultyLevel.SkipLiterals = true;
            txtChangeDifficultyLevel.TabIndex = 17;
            txtChangeDifficultyLevel.TabStop = false;
            txtChangeDifficultyLevel.Text = "Change Difficulty Level";
            txtChangeDifficultyLevel.TextAlign = HorizontalAlignment.Left;
            txtChangeDifficultyLevel.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtChangeDifficultyLevel.TrailingIcon = null;
            txtChangeDifficultyLevel.UseSystemPasswordChar = false;
            txtChangeDifficultyLevel.ValidatingType = null;
            // 
            // txtChangeTrailStatus
            // 
            txtChangeTrailStatus.AllowPromptAsInput = true;
            txtChangeTrailStatus.AnimateReadOnly = false;
            txtChangeTrailStatus.AsciiOnly = false;
            txtChangeTrailStatus.BackgroundImageLayout = ImageLayout.None;
            txtChangeTrailStatus.BeepOnError = false;
            txtChangeTrailStatus.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtChangeTrailStatus.Depth = 0;
            txtChangeTrailStatus.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtChangeTrailStatus.HidePromptOnLeave = false;
            txtChangeTrailStatus.HideSelection = true;
            txtChangeTrailStatus.InsertKeyMode = InsertKeyMode.Default;
            txtChangeTrailStatus.LeadingIcon = null;
            txtChangeTrailStatus.Location = new Point(142, 324);
            txtChangeTrailStatus.Mask = "";
            txtChangeTrailStatus.MaxLength = 32767;
            txtChangeTrailStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtChangeTrailStatus.Name = "txtChangeTrailStatus";
            txtChangeTrailStatus.PasswordChar = '\0';
            txtChangeTrailStatus.PrefixSuffixText = null;
            txtChangeTrailStatus.PromptChar = '_';
            txtChangeTrailStatus.ReadOnly = false;
            txtChangeTrailStatus.RejectInputOnFirstFailure = false;
            txtChangeTrailStatus.ResetOnPrompt = true;
            txtChangeTrailStatus.ResetOnSpace = true;
            txtChangeTrailStatus.RightToLeft = RightToLeft.No;
            txtChangeTrailStatus.SelectedText = "";
            txtChangeTrailStatus.SelectionLength = 0;
            txtChangeTrailStatus.SelectionStart = 0;
            txtChangeTrailStatus.ShortcutsEnabled = true;
            txtChangeTrailStatus.Size = new Size(250, 48);
            txtChangeTrailStatus.SkipLiterals = true;
            txtChangeTrailStatus.TabIndex = 18;
            txtChangeTrailStatus.TabStop = false;
            txtChangeTrailStatus.Text = "Change Trail Status";
            txtChangeTrailStatus.TextAlign = HorizontalAlignment.Left;
            txtChangeTrailStatus.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtChangeTrailStatus.TrailingIcon = null;
            txtChangeTrailStatus.UseSystemPasswordChar = false;
            txtChangeTrailStatus.ValidatingType = null;
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
            txtChangeTrailName.Location = new Point(612, 238);
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
            txtChangeMaximumHikers.Location = new Point(612, 324);
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
            // EditTrailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1004, 557);
            Controls.Add(txtChangeMaximumHikers);
            Controls.Add(txtChangeTrailName);
            Controls.Add(txtChangeTrailStatus);
            Controls.Add(txtChangeDifficultyLevel);
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
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtChangeDifficultyLevel;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtChangeTrailStatus;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtChangeTrailName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtChangeMaximumHikers;
    }
}