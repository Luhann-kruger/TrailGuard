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
            btnCancel.Location = new Point(615, 524);
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
            btnCreatePark.Location = new Point(799, 524);
            btnCreatePark.Name = "btnCreatePark";
            btnCreatePark.Rounded = false;
            btnCreatePark.Size = new Size(120, 40);
            btnCreatePark.TabIndex = 6;
            btnCreatePark.Text = "Create Park";
            btnCreatePark.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // CreateParkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1003, 576);
            Controls.Add(btnCreatePark);
            Controls.Add(btnCancel);
            Controls.Add(lblCreateParkTitle);
            Controls.Add(pnlHeader);
            Name = "CreateParkForm";
            Text = "CreateParkForm";
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
    }
}