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
            // lblEditTrailTitle
            // 
            lblEditTrailTitle.AutoSize = true;
            lblEditTrailTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditTrailTitle.Location = new Point(28, 98);
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
            btnCancel.Location = new Point(656, 495);
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
            btnSaveTrail.Location = new Point(837, 495);
            btnSaveTrail.Name = "btnSaveTrail";
            btnSaveTrail.Rounded = false;
            btnSaveTrail.Size = new Size(120, 40);
            btnSaveTrail.TabIndex = 6;
            btnSaveTrail.Text = "Save Trail";
            btnSaveTrail.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // EditTrailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1004, 557);
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
    }
}