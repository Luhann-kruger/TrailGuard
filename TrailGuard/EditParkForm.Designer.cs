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
            btnCancel.Location = new Point(649, 501);
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
            btnSavePark.Location = new Point(831, 501);
            btnSavePark.Name = "btnSavePark";
            btnSavePark.Rounded = false;
            btnSavePark.Size = new Size(120, 40);
            btnSavePark.TabIndex = 7;
            btnSavePark.Text = "Save Park";
            btnSavePark.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // EditParkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1003, 553);
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
    }
}