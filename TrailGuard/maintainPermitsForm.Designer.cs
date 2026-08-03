namespace TrailGuard
{
    partial class maintainPermitsForm
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
            lblMaintainPermitsTitle = new Label();
            pnlFormContent = new Panel();
            btnRefresh = new ReaLTaiizor.Controls.ForeverButton();
            dgvPermits = new DataGridView();
            btnSearch = new ReaLTaiizor.Controls.ForeverButton();
            btnCreatePermit = new ReaLTaiizor.Controls.ForeverButton();
            txtSearchPark = new TextBox();
            btnRegistered = new ReaLTaiizor.Controls.ForeverButton();
            btnCancelled = new ReaLTaiizor.Controls.ForeverButton();
            btnCheckedIn = new ReaLTaiizor.Controls.ForeverButton();
            btnCompleted = new ReaLTaiizor.Controls.ForeverButton();
            btnOverdue = new ReaLTaiizor.Controls.ForeverButton();
            btnRescued = new ReaLTaiizor.Controls.ForeverButton();
            pnlFormContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermits).BeginInit();
            SuspendLayout();
            // 
            // lblMaintainPermitsTitle
            // 
            lblMaintainPermitsTitle.AutoSize = true;
            lblMaintainPermitsTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaintainPermitsTitle.Location = new Point(22, 22);
            lblMaintainPermitsTitle.Name = "lblMaintainPermitsTitle";
            lblMaintainPermitsTitle.Size = new Size(252, 40);
            lblMaintainPermitsTitle.TabIndex = 2;
            lblMaintainPermitsTitle.Text = "Maintain Permits";
            // 
            // pnlFormContent
            // 
            pnlFormContent.BackColor = Color.White;
            pnlFormContent.Controls.Add(btnRescued);
            pnlFormContent.Controls.Add(btnOverdue);
            pnlFormContent.Controls.Add(btnCompleted);
            pnlFormContent.Controls.Add(btnCheckedIn);
            pnlFormContent.Controls.Add(btnCancelled);
            pnlFormContent.Controls.Add(btnRegistered);
            pnlFormContent.Controls.Add(btnRefresh);
            pnlFormContent.Controls.Add(dgvPermits);
            pnlFormContent.Controls.Add(btnSearch);
            pnlFormContent.Controls.Add(btnCreatePermit);
            pnlFormContent.Controls.Add(txtSearchPark);
            pnlFormContent.Location = new Point(12, 78);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.Size = new Size(1191, 473);
            pnlFormContent.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BaseColor = Color.Silver;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Location = new Point(38, 426);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Rounded = false;
            btnRefresh.Size = new Size(73, 29);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextColor = Color.Black;
            // 
            // dgvPermits
            // 
            dgvPermits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermits.Location = new Point(38, 200);
            dgvPermits.Name = "dgvPermits";
            dgvPermits.Size = new Size(1094, 205);
            dgvPermits.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BaseColor = Color.FromArgb(44, 123, 102);
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(1013, 98);
            btnSearch.Name = "btnSearch";
            btnSearch.Rounded = false;
            btnSearch.Size = new Size(119, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // btnCreatePermit
            // 
            btnCreatePermit.BackColor = Color.Transparent;
            btnCreatePermit.BaseColor = Color.FromArgb(44, 123, 102);
            btnCreatePermit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreatePermit.Location = new Point(954, 17);
            btnCreatePermit.Name = "btnCreatePermit";
            btnCreatePermit.Rounded = false;
            btnCreatePermit.Size = new Size(178, 39);
            btnCreatePermit.TabIndex = 1;
            btnCreatePermit.Text = "+ Create Permit";
            btnCreatePermit.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // txtSearchPark
            // 
            txtSearchPark.BackColor = SystemColors.ScrollBar;
            txtSearchPark.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchPark.Location = new Point(777, 100);
            txtSearchPark.Name = "txtSearchPark";
            txtSearchPark.Size = new Size(230, 27);
            txtSearchPark.TabIndex = 2;
            // 
            // btnRegistered
            // 
            btnRegistered.BackColor = Color.Transparent;
            btnRegistered.BaseColor = Color.Silver;
            btnRegistered.Font = new Font("Segoe UI", 12F);
            btnRegistered.Location = new Point(219, 156);
            btnRegistered.Name = "btnRegistered";
            btnRegistered.Rounded = false;
            btnRegistered.Size = new Size(122, 29);
            btnRegistered.TabIndex = 9;
            btnRegistered.Text = "Registered";
            btnRegistered.TextColor = Color.Black;
            // 
            // btnCancelled
            // 
            btnCancelled.BackColor = Color.Transparent;
            btnCancelled.BaseColor = Color.Silver;
            btnCancelled.Font = new Font("Segoe UI", 12F);
            btnCancelled.Location = new Point(361, 156);
            btnCancelled.Name = "btnCancelled";
            btnCancelled.Rounded = false;
            btnCancelled.Size = new Size(122, 29);
            btnCancelled.TabIndex = 10;
            btnCancelled.Text = "Cancelled";
            btnCancelled.TextColor = Color.Black;
            // 
            // btnCheckedIn
            // 
            btnCheckedIn.BackColor = Color.Transparent;
            btnCheckedIn.BaseColor = Color.Silver;
            btnCheckedIn.Font = new Font("Segoe UI", 12F);
            btnCheckedIn.Location = new Point(508, 156);
            btnCheckedIn.Name = "btnCheckedIn";
            btnCheckedIn.Rounded = false;
            btnCheckedIn.Size = new Size(122, 29);
            btnCheckedIn.TabIndex = 11;
            btnCheckedIn.Text = "Checked-In";
            btnCheckedIn.TextColor = Color.Black;
            // 
            // btnCompleted
            // 
            btnCompleted.BackColor = Color.Transparent;
            btnCompleted.BaseColor = Color.Silver;
            btnCompleted.Font = new Font("Segoe UI", 12F);
            btnCompleted.Location = new Point(655, 156);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Rounded = false;
            btnCompleted.Size = new Size(122, 29);
            btnCompleted.TabIndex = 12;
            btnCompleted.Text = "Completed";
            btnCompleted.TextColor = Color.Black;
            // 
            // btnOverdue
            // 
            btnOverdue.BackColor = Color.Transparent;
            btnOverdue.BaseColor = Color.Silver;
            btnOverdue.Font = new Font("Segoe UI", 12F);
            btnOverdue.Location = new Point(801, 156);
            btnOverdue.Name = "btnOverdue";
            btnOverdue.Rounded = false;
            btnOverdue.Size = new Size(122, 29);
            btnOverdue.TabIndex = 13;
            btnOverdue.Text = "Overdue";
            btnOverdue.TextColor = Color.Black;
            // 
            // btnRescued
            // 
            btnRescued.BackColor = Color.Transparent;
            btnRescued.BaseColor = Color.Silver;
            btnRescued.Font = new Font("Segoe UI", 12F);
            btnRescued.Location = new Point(950, 156);
            btnRescued.Name = "btnRescued";
            btnRescued.Rounded = false;
            btnRescued.Size = new Size(122, 29);
            btnRescued.TabIndex = 14;
            btnRescued.Text = "Rescued";
            btnRescued.TextColor = Color.Black;
            // 
            // maintainPermitsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1215, 563);
            Controls.Add(pnlFormContent);
            Controls.Add(lblMaintainPermitsTitle);
            Name = "maintainPermitsForm";
            Text = "maintainPermitsForm";
            pnlFormContent.ResumeLayout(false);
            pnlFormContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaintainPermitsTitle;
        private Panel pnlFormContent;
        private ReaLTaiizor.Controls.ForeverButton btnRefresh;
        private DataGridView dgvPermits;
        private ReaLTaiizor.Controls.ForeverButton btnSearch;
        private ReaLTaiizor.Controls.ForeverButton btnCreatePermit;
        private TextBox txtSearchPark;
        private ReaLTaiizor.Controls.ForeverButton btnCancelled;
        private ReaLTaiizor.Controls.ForeverButton btnRegistered;
        private ReaLTaiizor.Controls.ForeverButton btnCheckedIn;
        private ReaLTaiizor.Controls.ForeverButton btnCompleted;
        private ReaLTaiizor.Controls.ForeverButton btnOverdue;
        private ReaLTaiizor.Controls.ForeverButton btnRescued;
    }
}