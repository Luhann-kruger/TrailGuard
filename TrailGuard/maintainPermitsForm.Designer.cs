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
            components = new System.ComponentModel.Container();
            lblMaintainPermitsTitle = new Label();
            pnlFormContent = new Panel();
            lblFilterBy = new Label();
            btnRescued = new ReaLTaiizor.Controls.ForeverButton();
            btnOverdue = new ReaLTaiizor.Controls.ForeverButton();
            btnCompleted = new ReaLTaiizor.Controls.ForeverButton();
            btnActive = new ReaLTaiizor.Controls.ForeverButton();
            btnCancelled = new ReaLTaiizor.Controls.ForeverButton();
            btnRegistered = new ReaLTaiizor.Controls.ForeverButton();
            btnRefresh = new ReaLTaiizor.Controls.ForeverButton();
            dgvPermits = new DataGridView();
            btnSearch = new ReaLTaiizor.Controls.ForeverButton();
            btnCreatePermit = new ReaLTaiizor.Controls.ForeverButton();
            txtSearchPermit = new TextBox();
            cmsPermitActions = new ContextMenuStrip(components);
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
            pnlFormContent.Controls.Add(lblFilterBy);
            pnlFormContent.Controls.Add(btnRescued);
            pnlFormContent.Controls.Add(btnOverdue);
            pnlFormContent.Controls.Add(btnCompleted);
            pnlFormContent.Controls.Add(btnActive);
            pnlFormContent.Controls.Add(btnCancelled);
            pnlFormContent.Controls.Add(btnRegistered);
            pnlFormContent.Controls.Add(btnRefresh);
            pnlFormContent.Controls.Add(dgvPermits);
            pnlFormContent.Controls.Add(btnSearch);
            pnlFormContent.Controls.Add(btnCreatePermit);
            pnlFormContent.Controls.Add(txtSearchPermit);
            pnlFormContent.Location = new Point(12, 78);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.Size = new Size(1191, 473);
            pnlFormContent.TabIndex = 5;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.Location = new Point(38, 160);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(149, 25);
            lblFilterBy.TabIndex = 6;
            lblFilterBy.Text = "Filter By Status:";
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
            btnRescued.Click += btnRescued_Click;
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
            btnOverdue.Click += btnOverdue_Click;
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
            btnCompleted.Click += btnCompleted_Click;
            // 
            // btnActive
            // 
            btnActive.BackColor = Color.Transparent;
            btnActive.BaseColor = Color.Silver;
            btnActive.Font = new Font("Segoe UI", 12F);
            btnActive.Location = new Point(508, 156);
            btnActive.Name = "btnActive";
            btnActive.Rounded = false;
            btnActive.Size = new Size(122, 29);
            btnActive.TabIndex = 11;
            btnActive.Text = "Active";
            btnActive.TextColor = Color.Black;
            btnActive.Click += btnActive_Click;
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
            btnCancelled.Click += btnCancelled_Click;
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
            btnRegistered.Click += btnRegistered_Click;
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
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvPermits
            // 
            dgvPermits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermits.Location = new Point(38, 200);
            dgvPermits.Name = "dgvPermits";
            dgvPermits.Size = new Size(1094, 205);
            dgvPermits.TabIndex = 6;
            dgvPermits.CellContentClick += dgvPermits_CellContentClick;
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
            btnSearch.Click += btnSearch_Click;
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
            btnCreatePermit.Click += btnCreatePermit_Click;
            // 
            // txtSearchPermit
            // 
            txtSearchPermit.BackColor = SystemColors.ScrollBar;
            txtSearchPermit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchPermit.Location = new Point(777, 100);
            txtSearchPermit.Name = "txtSearchPermit";
            txtSearchPermit.Size = new Size(230, 27);
            txtSearchPermit.TabIndex = 2;
            // 
            // cmsPermitActions
            // 
            cmsPermitActions.Name = "cmsPermitActions";
            cmsPermitActions.Size = new Size(61, 4);
            cmsPermitActions.ItemClicked += cmsPermitActions_ItemClicked;
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
            Load += maintainPermitsForm_Load;
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
        private TextBox txtSearchPermit;
        private ReaLTaiizor.Controls.ForeverButton btnCancelled;
        private ReaLTaiizor.Controls.ForeverButton btnRegistered;
        private ReaLTaiizor.Controls.ForeverButton btnActive;
        private ReaLTaiizor.Controls.ForeverButton btnCompleted;
        private ReaLTaiizor.Controls.ForeverButton btnOverdue;
        private ReaLTaiizor.Controls.ForeverButton btnRescued;
        private Label lblFilterBy;
        private ContextMenuStrip cmsPermitActions;
    }
}