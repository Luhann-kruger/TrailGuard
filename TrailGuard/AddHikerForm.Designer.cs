namespace TrailGuard
{
    partial class AddHikerForm
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
            lblAddHikerTitle = new Label();
            pnlFormContent = new Panel();
            btnCancel = new ReaLTaiizor.Controls.ForeverButton();
            btnSave = new ReaLTaiizor.Controls.ForeverButton();
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
            // lblAddHikerTitle
            // 
            lblAddHikerTitle.AutoSize = true;
            lblAddHikerTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddHikerTitle.Location = new Point(60, 65);
            lblAddHikerTitle.Name = "lblAddHikerTitle";
            lblAddHikerTitle.Size = new Size(113, 30);
            lblAddHikerTitle.TabIndex = 1;
            lblAddHikerTitle.Text = "Add Hiker";
            // 
            // pnlFormContent
            // 
            pnlFormContent.BackColor = Color.White;
            pnlFormContent.Location = new Point(60, 105);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.Size = new Size(740, 400);
            pnlFormContent.TabIndex = 2;
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
            // AddHikerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(864, 581);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(pnlFormContent);
            Controls.Add(lblAddHikerTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddHikerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Hiker";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Label lblAddHikerTitle;
        private Panel pnlFormContent;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
        private ReaLTaiizor.Controls.ForeverButton btnSave;
    }
}