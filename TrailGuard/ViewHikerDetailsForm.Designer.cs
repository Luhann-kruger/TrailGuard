namespace TrailGuard
{
    partial class ViewHikerDetailsForm
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
            lblViewHikerDetailsTitle = new Label();
            pnlFormContent = new Panel();
            btnBack = new ReaLTaiizor.Controls.ForeverButton();
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
            // lblViewHikerDetailsTitle
            // 
            lblViewHikerDetailsTitle.AutoSize = true;
            lblViewHikerDetailsTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewHikerDetailsTitle.Location = new Point(60, 65);
            lblViewHikerDetailsTitle.Name = "lblViewHikerDetailsTitle";
            lblViewHikerDetailsTitle.Size = new Size(192, 30);
            lblViewHikerDetailsTitle.TabIndex = 1;
            lblViewHikerDetailsTitle.Text = "View Hiker Details";
            // 
            // pnlFormContent
            // 
            pnlFormContent.BackColor = Color.White;
            pnlFormContent.Location = new Point(60, 105);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.Size = new Size(740, 400);
            pnlFormContent.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BaseColor = Color.FromArgb(84, 84, 84);
            btnBack.Font = new Font("Segoe UI", 12F);
            btnBack.Location = new Point(60, 525);
            btnBack.Name = "btnBack";
            btnBack.Rounded = false;
            btnBack.Size = new Size(101, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.TextColor = Color.FromArgb(243, 243, 243);
            btnBack.Click += btnBack_Click;
            // 
            // ViewHikerDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(864, 581);
            Controls.Add(btnBack);
            Controls.Add(pnlFormContent);
            Controls.Add(lblViewHikerDetailsTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewHikerDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View Hiker Details";
            Load += ViewHikerDetailsForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Label lblViewHikerDetailsTitle;
        private Panel pnlFormContent;
        private ReaLTaiizor.Controls.ForeverButton btnBack;
    }
}