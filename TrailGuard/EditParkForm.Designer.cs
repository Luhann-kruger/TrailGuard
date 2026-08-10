namespace TrailGuard
{
    partial class EditParkForm
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
            lblEditParkTitle = new Label();
            btnCancel = new ReaLTaiizor.Controls.ForeverButton();
            btnSavePark = new ReaLTaiizor.Controls.ForeverButton();
            comboBoxEditSelectProvince = new ReaLTaiizor.Controls.MetroComboBox();
            lblEditSelectProvince = new ReaLTaiizor.Controls.DungeonLabel();
            lblEditOfficeNumber = new ReaLTaiizor.Controls.DungeonLabel();
            lblEditParkName = new ReaLTaiizor.Controls.DungeonLabel();
            txtEditEnterOfficeNumber = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtEditParkName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            pnlHeader.TabIndex = 4;
            // 
            // lblModeTitle
            // 
            lblModeTitle.AutoSize = true;
            lblModeTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeTitle.ForeColor = Color.White;
            lblModeTitle.Location = new Point(504, 24);
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
            // lblEditParkTitle
            // 
            lblEditParkTitle.AutoSize = true;
            lblEditParkTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditParkTitle.Location = new Point(44, 104);
            lblEditParkTitle.Name = "lblEditParkTitle";
            lblEditParkTitle.Size = new Size(138, 40);
            lblEditParkTitle.TabIndex = 5;
            lblEditParkTitle.Text = "Edit Park";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BaseColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(345, 501);
            btnCancel.Name = "btnCancel";
            btnCancel.Rounded = false;
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.Black;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSavePark
            // 
            btnSavePark.BackColor = Color.Transparent;
            btnSavePark.BaseColor = Color.FromArgb(44, 123, 102);
            btnSavePark.Font = new Font("Segoe UI", 12F);
            btnSavePark.Location = new Point(527, 501);
            btnSavePark.Name = "btnSavePark";
            btnSavePark.Rounded = false;
            btnSavePark.Size = new Size(120, 40);
            btnSavePark.TabIndex = 7;
            btnSavePark.Text = "Save Park";
            btnSavePark.TextColor = Color.FromArgb(243, 243, 243);
            btnSavePark.Click += btnSavePark_Click;
            // 
            // comboBoxEditSelectProvince
            // 
            comboBoxEditSelectProvince.AllowDrop = true;
            comboBoxEditSelectProvince.ArrowColor = Color.FromArgb(150, 150, 150);
            comboBoxEditSelectProvince.BackColor = Color.Transparent;
            comboBoxEditSelectProvince.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboBoxEditSelectProvince.BorderColor = Color.FromArgb(150, 150, 150);
            comboBoxEditSelectProvince.CausesValidation = false;
            comboBoxEditSelectProvince.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboBoxEditSelectProvince.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboBoxEditSelectProvince.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboBoxEditSelectProvince.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxEditSelectProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEditSelectProvince.Font = new Font("Microsoft Sans Serif", 11F);
            comboBoxEditSelectProvince.FormattingEnabled = true;
            comboBoxEditSelectProvince.IsDerivedStyle = true;
            comboBoxEditSelectProvince.ItemHeight = 20;
            comboBoxEditSelectProvince.Location = new Point(44, 309);
            comboBoxEditSelectProvince.Name = "comboBoxEditSelectProvince";
            comboBoxEditSelectProvince.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboBoxEditSelectProvince.SelectedItemForeColor = Color.White;
            comboBoxEditSelectProvince.Size = new Size(250, 26);
            comboBoxEditSelectProvince.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            comboBoxEditSelectProvince.StyleManager = null;
            comboBoxEditSelectProvince.TabIndex = 55;
            comboBoxEditSelectProvince.ThemeAuthor = "Taiizor";
            comboBoxEditSelectProvince.ThemeName = "MetroLight";
            // 
            // lblEditSelectProvince
            // 
            lblEditSelectProvince.AutoSize = true;
            lblEditSelectProvince.BackColor = Color.Transparent;
            lblEditSelectProvince.Font = new Font("Segoe UI", 11F);
            lblEditSelectProvince.ForeColor = Color.FromArgb(76, 76, 77);
            lblEditSelectProvince.Location = new Point(44, 277);
            lblEditSelectProvince.Name = "lblEditSelectProvince";
            lblEditSelectProvince.Size = new Size(109, 20);
            lblEditSelectProvince.TabIndex = 54;
            lblEditSelectProvince.Text = "Select Province";
            // 
            // lblEditOfficeNumber
            // 
            lblEditOfficeNumber.AutoSize = true;
            lblEditOfficeNumber.BackColor = Color.Transparent;
            lblEditOfficeNumber.Font = new Font("Segoe UI", 11F);
            lblEditOfficeNumber.ForeColor = Color.FromArgb(76, 76, 77);
            lblEditOfficeNumber.Location = new Point(44, 382);
            lblEditOfficeNumber.Name = "lblEditOfficeNumber";
            lblEditOfficeNumber.Size = new Size(137, 20);
            lblEditOfficeNumber.TabIndex = 53;
            lblEditOfficeNumber.Text = "Edit Office Number";
            // 
            // lblEditParkName
            // 
            lblEditParkName.AutoSize = true;
            lblEditParkName.BackColor = Color.Transparent;
            lblEditParkName.Font = new Font("Segoe UI", 11F);
            lblEditParkName.ForeColor = Color.FromArgb(76, 76, 77);
            lblEditParkName.Location = new Point(44, 169);
            lblEditParkName.Name = "lblEditParkName";
            lblEditParkName.Size = new Size(110, 20);
            lblEditParkName.TabIndex = 52;
            lblEditParkName.Text = "Edit Park Name";
            // 
            // txtEditEnterOfficeNumber
            // 
            txtEditEnterOfficeNumber.AllowPromptAsInput = true;
            txtEditEnterOfficeNumber.AnimateReadOnly = false;
            txtEditEnterOfficeNumber.AsciiOnly = false;
            txtEditEnterOfficeNumber.BackgroundImageLayout = ImageLayout.None;
            txtEditEnterOfficeNumber.BeepOnError = false;
            txtEditEnterOfficeNumber.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtEditEnterOfficeNumber.Depth = 0;
            txtEditEnterOfficeNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEditEnterOfficeNumber.HidePromptOnLeave = false;
            txtEditEnterOfficeNumber.HideSelection = true;
            txtEditEnterOfficeNumber.InsertKeyMode = InsertKeyMode.Default;
            txtEditEnterOfficeNumber.LeadingIcon = null;
            txtEditEnterOfficeNumber.Location = new Point(44, 415);
            txtEditEnterOfficeNumber.Mask = "";
            txtEditEnterOfficeNumber.MaxLength = 32767;
            txtEditEnterOfficeNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEditEnterOfficeNumber.Name = "txtEditEnterOfficeNumber";
            txtEditEnterOfficeNumber.PasswordChar = '\0';
            txtEditEnterOfficeNumber.PrefixSuffixText = null;
            txtEditEnterOfficeNumber.PromptChar = '_';
            txtEditEnterOfficeNumber.ReadOnly = false;
            txtEditEnterOfficeNumber.RejectInputOnFirstFailure = false;
            txtEditEnterOfficeNumber.ResetOnPrompt = true;
            txtEditEnterOfficeNumber.ResetOnSpace = true;
            txtEditEnterOfficeNumber.RightToLeft = RightToLeft.No;
            txtEditEnterOfficeNumber.SelectedText = "";
            txtEditEnterOfficeNumber.SelectionLength = 0;
            txtEditEnterOfficeNumber.SelectionStart = 0;
            txtEditEnterOfficeNumber.ShortcutsEnabled = true;
            txtEditEnterOfficeNumber.Size = new Size(250, 48);
            txtEditEnterOfficeNumber.SkipLiterals = true;
            txtEditEnterOfficeNumber.TabIndex = 51;
            txtEditEnterOfficeNumber.TabStop = false;
            txtEditEnterOfficeNumber.Text = "Current Office Number";
            txtEditEnterOfficeNumber.TextAlign = HorizontalAlignment.Left;
            txtEditEnterOfficeNumber.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEditEnterOfficeNumber.TrailingIcon = null;
            txtEditEnterOfficeNumber.UseSystemPasswordChar = false;
            txtEditEnterOfficeNumber.ValidatingType = null;
            // 
            // txtEditParkName
            // 
            txtEditParkName.AllowPromptAsInput = true;
            txtEditParkName.AnimateReadOnly = false;
            txtEditParkName.AsciiOnly = false;
            txtEditParkName.BackgroundImageLayout = ImageLayout.None;
            txtEditParkName.BeepOnError = false;
            txtEditParkName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtEditParkName.Depth = 0;
            txtEditParkName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEditParkName.HidePromptOnLeave = false;
            txtEditParkName.HideSelection = true;
            txtEditParkName.InsertKeyMode = InsertKeyMode.Default;
            txtEditParkName.LeadingIcon = null;
            txtEditParkName.Location = new Point(44, 201);
            txtEditParkName.Mask = "";
            txtEditParkName.MaxLength = 32767;
            txtEditParkName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEditParkName.Name = "txtEditParkName";
            txtEditParkName.PasswordChar = '\0';
            txtEditParkName.PrefixSuffixText = null;
            txtEditParkName.PromptChar = '_';
            txtEditParkName.ReadOnly = false;
            txtEditParkName.RejectInputOnFirstFailure = false;
            txtEditParkName.ResetOnPrompt = true;
            txtEditParkName.ResetOnSpace = true;
            txtEditParkName.RightToLeft = RightToLeft.No;
            txtEditParkName.SelectedText = "";
            txtEditParkName.SelectionLength = 0;
            txtEditParkName.SelectionStart = 0;
            txtEditParkName.ShortcutsEnabled = true;
            txtEditParkName.Size = new Size(250, 48);
            txtEditParkName.SkipLiterals = true;
            txtEditParkName.TabIndex = 50;
            txtEditParkName.TabStop = false;
            txtEditParkName.Text = "Current Park Name";
            txtEditParkName.TextAlign = HorizontalAlignment.Left;
            txtEditParkName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEditParkName.TrailingIcon = null;
            txtEditParkName.UseSystemPasswordChar = false;
            txtEditParkName.ValidatingType = null;
            // 
            // EditParkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(659, 553);
            Controls.Add(comboBoxEditSelectProvince);
            Controls.Add(lblEditSelectProvince);
            Controls.Add(lblEditOfficeNumber);
            Controls.Add(lblEditParkName);
            Controls.Add(txtEditEnterOfficeNumber);
            Controls.Add(txtEditParkName);
            Controls.Add(btnSavePark);
            Controls.Add(btnCancel);
            Controls.Add(lblEditParkTitle);
            Controls.Add(pnlHeader);
            Name = "EditParkForm";
            Text = "EditParkForm";
            Load += EditParkForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Label lblEditParkTitle;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
        private ReaLTaiizor.Controls.ForeverButton btnSavePark;
        private ReaLTaiizor.Controls.MetroComboBox comboBoxEditSelectProvince;
        private ReaLTaiizor.Controls.DungeonLabel lblEditSelectProvince;
        private ReaLTaiizor.Controls.DungeonLabel lblEditOfficeNumber;
        private ReaLTaiizor.Controls.DungeonLabel lblEditParkName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEditEnterOfficeNumber;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEditParkName;
    }
}