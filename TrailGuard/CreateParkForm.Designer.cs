namespace TrailGuard
{
    partial class CreateParkForm
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
            lblCreateParkTitle = new Label();
            btnCancel = new ReaLTaiizor.Controls.ForeverButton();
            btnCreatePark = new ReaLTaiizor.Controls.ForeverButton();
            comboBoxSelectProvince = new ReaLTaiizor.Controls.MetroComboBox();
            lblSelectProvince = new ReaLTaiizor.Controls.DungeonLabel();
            lblEnterOfficeNumber = new ReaLTaiizor.Controls.DungeonLabel();
            lblEnterParkName = new ReaLTaiizor.Controls.DungeonLabel();
            txtEnterOfficeNumber = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtEnterParkName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            pnlHeader.SuspendLayout();
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
            pnlHeader.TabIndex = 3;
            // 
            // lblModeTitle
            // 
            lblModeTitle.AutoSize = true;
            lblModeTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeTitle.ForeColor = Color.White;
            lblModeTitle.Location = new Point(464, 25);
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
            // lblCreateParkTitle
            // 
            lblCreateParkTitle.AutoSize = true;
            lblCreateParkTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateParkTitle.Location = new Point(35, 110);
            lblCreateParkTitle.Name = "lblCreateParkTitle";
            lblCreateParkTitle.Size = new Size(175, 40);
            lblCreateParkTitle.TabIndex = 4;
            lblCreateParkTitle.Text = "Create Park";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BaseColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(304, 498);
            btnCancel.Name = "btnCancel";
            btnCancel.Rounded = false;
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.Black;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreatePark
            // 
            btnCreatePark.BackColor = Color.Transparent;
            btnCreatePark.BaseColor = Color.FromArgb(44, 123, 102);
            btnCreatePark.Font = new Font("Segoe UI", 12F);
            btnCreatePark.Location = new Point(486, 498);
            btnCreatePark.Name = "btnCreatePark";
            btnCreatePark.Rounded = false;
            btnCreatePark.Size = new Size(120, 40);
            btnCreatePark.TabIndex = 6;
            btnCreatePark.Text = "Create Park";
            btnCreatePark.TextColor = Color.FromArgb(243, 243, 243);
            btnCreatePark.Click += btnCreatePark_Click;
            // 
            // comboBoxSelectProvince
            // 
            comboBoxSelectProvince.AllowDrop = true;
            comboBoxSelectProvince.ArrowColor = Color.FromArgb(150, 150, 150);
            comboBoxSelectProvince.BackColor = Color.Transparent;
            comboBoxSelectProvince.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboBoxSelectProvince.BorderColor = Color.FromArgb(150, 150, 150);
            comboBoxSelectProvince.CausesValidation = false;
            comboBoxSelectProvince.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboBoxSelectProvince.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboBoxSelectProvince.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboBoxSelectProvince.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxSelectProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectProvince.Font = new Font("Microsoft Sans Serif", 11F);
            comboBoxSelectProvince.FormattingEnabled = true;
            comboBoxSelectProvince.IsDerivedStyle = true;
            comboBoxSelectProvince.ItemHeight = 20;
            comboBoxSelectProvince.Location = new Point(35, 313);
            comboBoxSelectProvince.Name = "comboBoxSelectProvince";
            comboBoxSelectProvince.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboBoxSelectProvince.SelectedItemForeColor = Color.White;
            comboBoxSelectProvince.Size = new Size(250, 26);
            comboBoxSelectProvince.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            comboBoxSelectProvince.StyleManager = null;
            comboBoxSelectProvince.TabIndex = 49;
            comboBoxSelectProvince.ThemeAuthor = "Taiizor";
            comboBoxSelectProvince.ThemeName = "MetroLight";
            // 
            // lblSelectProvince
            // 
            lblSelectProvince.AutoSize = true;
            lblSelectProvince.BackColor = Color.Transparent;
            lblSelectProvince.Font = new Font("Segoe UI", 11F);
            lblSelectProvince.ForeColor = Color.FromArgb(76, 76, 77);
            lblSelectProvince.Location = new Point(35, 281);
            lblSelectProvince.Name = "lblSelectProvince";
            lblSelectProvince.Size = new Size(109, 20);
            lblSelectProvince.TabIndex = 48;
            lblSelectProvince.Text = "Select Province";
            // 
            // lblEnterOfficeNumber
            // 
            lblEnterOfficeNumber.AutoSize = true;
            lblEnterOfficeNumber.BackColor = Color.Transparent;
            lblEnterOfficeNumber.Font = new Font("Segoe UI", 11F);
            lblEnterOfficeNumber.ForeColor = Color.FromArgb(76, 76, 77);
            lblEnterOfficeNumber.Location = new Point(35, 386);
            lblEnterOfficeNumber.Name = "lblEnterOfficeNumber";
            lblEnterOfficeNumber.Size = new Size(145, 20);
            lblEnterOfficeNumber.TabIndex = 45;
            lblEnterOfficeNumber.Text = "Enter Office Number";
            // 
            // lblEnterParkName
            // 
            lblEnterParkName.AutoSize = true;
            lblEnterParkName.BackColor = Color.Transparent;
            lblEnterParkName.Font = new Font("Segoe UI", 11F);
            lblEnterParkName.ForeColor = Color.FromArgb(76, 76, 77);
            lblEnterParkName.Location = new Point(35, 173);
            lblEnterParkName.Name = "lblEnterParkName";
            lblEnterParkName.Size = new Size(118, 20);
            lblEnterParkName.TabIndex = 43;
            lblEnterParkName.Text = "Enter Park Name";
            lblEnterParkName.Click += lblSelectPark_Click;
            // 
            // txtEnterOfficeNumber
            // 
            txtEnterOfficeNumber.AllowPromptAsInput = true;
            txtEnterOfficeNumber.AnimateReadOnly = false;
            txtEnterOfficeNumber.AsciiOnly = false;
            txtEnterOfficeNumber.BackgroundImageLayout = ImageLayout.None;
            txtEnterOfficeNumber.BeepOnError = false;
            txtEnterOfficeNumber.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtEnterOfficeNumber.Depth = 0;
            txtEnterOfficeNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEnterOfficeNumber.HidePromptOnLeave = false;
            txtEnterOfficeNumber.HideSelection = true;
            txtEnterOfficeNumber.InsertKeyMode = InsertKeyMode.Default;
            txtEnterOfficeNumber.LeadingIcon = null;
            txtEnterOfficeNumber.Location = new Point(35, 419);
            txtEnterOfficeNumber.Mask = "";
            txtEnterOfficeNumber.MaxLength = 32767;
            txtEnterOfficeNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEnterOfficeNumber.Name = "txtEnterOfficeNumber";
            txtEnterOfficeNumber.PasswordChar = '\0';
            txtEnterOfficeNumber.PrefixSuffixText = null;
            txtEnterOfficeNumber.PromptChar = '_';
            txtEnterOfficeNumber.ReadOnly = false;
            txtEnterOfficeNumber.RejectInputOnFirstFailure = false;
            txtEnterOfficeNumber.ResetOnPrompt = true;
            txtEnterOfficeNumber.ResetOnSpace = true;
            txtEnterOfficeNumber.RightToLeft = RightToLeft.No;
            txtEnterOfficeNumber.SelectedText = "";
            txtEnterOfficeNumber.SelectionLength = 0;
            txtEnterOfficeNumber.SelectionStart = 0;
            txtEnterOfficeNumber.ShortcutsEnabled = true;
            txtEnterOfficeNumber.Size = new Size(250, 48);
            txtEnterOfficeNumber.SkipLiterals = true;
            txtEnterOfficeNumber.TabIndex = 40;
            txtEnterOfficeNumber.TabStop = false;
            txtEnterOfficeNumber.Text = "Enter Office Number";
            txtEnterOfficeNumber.TextAlign = HorizontalAlignment.Left;
            txtEnterOfficeNumber.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEnterOfficeNumber.TrailingIcon = null;
            txtEnterOfficeNumber.UseSystemPasswordChar = false;
            txtEnterOfficeNumber.ValidatingType = null;
            txtEnterOfficeNumber.Click += txtEnterOfficeNumber_Click;
            // 
            // txtEnterParkName
            // 
            txtEnterParkName.AllowPromptAsInput = true;
            txtEnterParkName.AnimateReadOnly = false;
            txtEnterParkName.AsciiOnly = false;
            txtEnterParkName.BackgroundImageLayout = ImageLayout.None;
            txtEnterParkName.BeepOnError = false;
            txtEnterParkName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtEnterParkName.Depth = 0;
            txtEnterParkName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEnterParkName.HidePromptOnLeave = false;
            txtEnterParkName.HideSelection = true;
            txtEnterParkName.InsertKeyMode = InsertKeyMode.Default;
            txtEnterParkName.LeadingIcon = null;
            txtEnterParkName.Location = new Point(35, 205);
            txtEnterParkName.Mask = "";
            txtEnterParkName.MaxLength = 32767;
            txtEnterParkName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEnterParkName.Name = "txtEnterParkName";
            txtEnterParkName.PasswordChar = '\0';
            txtEnterParkName.PrefixSuffixText = null;
            txtEnterParkName.PromptChar = '_';
            txtEnterParkName.ReadOnly = false;
            txtEnterParkName.RejectInputOnFirstFailure = false;
            txtEnterParkName.ResetOnPrompt = true;
            txtEnterParkName.ResetOnSpace = true;
            txtEnterParkName.RightToLeft = RightToLeft.No;
            txtEnterParkName.SelectedText = "";
            txtEnterParkName.SelectionLength = 0;
            txtEnterParkName.SelectionStart = 0;
            txtEnterParkName.ShortcutsEnabled = true;
            txtEnterParkName.Size = new Size(250, 48);
            txtEnterParkName.SkipLiterals = true;
            txtEnterParkName.TabIndex = 39;
            txtEnterParkName.TabStop = false;
            txtEnterParkName.Text = "Enter Park Name";
            txtEnterParkName.TextAlign = HorizontalAlignment.Left;
            txtEnterParkName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEnterParkName.TrailingIcon = null;
            txtEnterParkName.UseSystemPasswordChar = false;
            txtEnterParkName.ValidatingType = null;
            // 
            // CreateParkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(618, 552);
            Controls.Add(comboBoxSelectProvince);
            Controls.Add(lblSelectProvince);
            Controls.Add(lblEnterOfficeNumber);
            Controls.Add(lblEnterParkName);
            Controls.Add(txtEnterOfficeNumber);
            Controls.Add(txtEnterParkName);
            Controls.Add(btnCreatePark);
            Controls.Add(btnCancel);
            Controls.Add(lblCreateParkTitle);
            Controls.Add(pnlHeader);
            Name = "CreateParkForm";
            Text = "CreateParkForm";
            Load += CreateParkForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Label lblCreateParkTitle;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
        private ReaLTaiizor.Controls.ForeverButton btnCreatePark;
        private ReaLTaiizor.Controls.MetroComboBox comboBoxSelectProvince;
        private ReaLTaiizor.Controls.DungeonLabel lblSelectProvince;
        private ReaLTaiizor.Controls.DungeonLabel lblEnterOfficeNumber;
        private ReaLTaiizor.Controls.DungeonLabel lblEnterParkName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEnterOfficeNumber;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEnterParkName;
    }
}