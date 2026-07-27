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
            // 
            // CreateTrailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1004, 590);
            Controls.Add(btnCreateTrail);
            Controls.Add(btnCancel);
            Controls.Add(lblCreateTrailTitle);
            Controls.Add(pnlHeader);
            Name = "CreateTrailForm";
            Text = "CreateTrailForm";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
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
    }
}