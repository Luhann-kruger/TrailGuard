namespace TrailGuard
{
    partial class MaintainRescuesForm
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
            lblMaintainRescuesTitle = new Label();
            txtSearchRescue = new TextBox();
            pnlFormContent = new Panel();
            btnRefresh = new ReaLTaiizor.Controls.ForeverButton();
            lblFilterBy = new Label();
            dataGridViewRescues = new DataGridView();
            btnFilterClosedStatus = new ReaLTaiizor.Controls.ForeverButton();
            btnFilterInProgressStatus = new ReaLTaiizor.Controls.ForeverButton();
            btnFilterOpenStatus = new ReaLTaiizor.Controls.ForeverButton();
            btnSearch = new ReaLTaiizor.Controls.ForeverButton();
            cmsRescueActions = new ContextMenuStrip(components);
            pnlFormContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRescues).BeginInit();
            SuspendLayout();
            // 
            // lblMaintainRescuesTitle
            // 
            lblMaintainRescuesTitle.AutoSize = true;
            lblMaintainRescuesTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaintainRescuesTitle.Location = new Point(12, 23);
            lblMaintainRescuesTitle.Name = "lblMaintainRescuesTitle";
            lblMaintainRescuesTitle.Size = new Size(287, 40);
            lblMaintainRescuesTitle.TabIndex = 0;
            lblMaintainRescuesTitle.Text = "Maintain Rescues";
            // 
            // txtSearchRescue
            // 
            txtSearchRescue.BackColor = SystemColors.ScrollBar;
            txtSearchRescue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchRescue.Location = new Point(777, 100);
            txtSearchRescue.Name = "txtSearchRescue";
            txtSearchRescue.Size = new Size(230, 27);
            txtSearchRescue.TabIndex = 2;
            // 
            // pnlFormContent
            // 
            pnlFormContent.BackColor = Color.White;
            pnlFormContent.Controls.Add(btnRefresh);
            pnlFormContent.Controls.Add(lblFilterBy);
            pnlFormContent.Controls.Add(dataGridViewRescues);
            pnlFormContent.Controls.Add(btnFilterClosedStatus);
            pnlFormContent.Controls.Add(btnFilterInProgressStatus);
            pnlFormContent.Controls.Add(btnFilterOpenStatus);
            pnlFormContent.Controls.Add(btnSearch);
            pnlFormContent.Controls.Add(txtSearchRescue);
            pnlFormContent.Location = new Point(12, 88);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.Size = new Size(1191, 473);
            pnlFormContent.TabIndex = 3;
            pnlFormContent.Paint += pnlFormContent_Paint;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BaseColor = Color.Silver;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Location = new Point(38, 434);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Rounded = false;
            btnRefresh.Size = new Size(73, 29);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextColor = Color.Black;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.Location = new Point(38, 148);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(99, 30);
            lblFilterBy.TabIndex = 8;
            lblFilterBy.Text = "Filter By:";
            // 
            // dataGridViewRescues
            // 
            dataGridViewRescues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRescues.Location = new Point(38, 200);
            dataGridViewRescues.Name = "dataGridViewRescues";
            dataGridViewRescues.Size = new Size(1094, 205);
            dataGridViewRescues.TabIndex = 7;
            dataGridViewRescues.CellContentClick += dataGridViewRescues_CellContentClick;
            // 
            // btnFilterClosedStatus
            // 
            btnFilterClosedStatus.BackColor = Color.Transparent;
            btnFilterClosedStatus.BaseColor = Color.Silver;
            btnFilterClosedStatus.Font = new Font("Segoe UI", 12F);
            btnFilterClosedStatus.Location = new Point(353, 149);
            btnFilterClosedStatus.Name = "btnFilterClosedStatus";
            btnFilterClosedStatus.Rounded = false;
            btnFilterClosedStatus.Size = new Size(73, 29);
            btnFilterClosedStatus.TabIndex = 6;
            btnFilterClosedStatus.Text = "Closed";
            btnFilterClosedStatus.TextColor = Color.Black;
            btnFilterClosedStatus.Click += btnFilterClosedStatus_Click;
            // 
            // btnFilterInProgressStatus
            // 
            btnFilterInProgressStatus.BackColor = Color.Transparent;
            btnFilterInProgressStatus.BaseColor = Color.Silver;
            btnFilterInProgressStatus.Font = new Font("Segoe UI", 12F);
            btnFilterInProgressStatus.Location = new Point(243, 149);
            btnFilterInProgressStatus.Name = "btnFilterInProgressStatus";
            btnFilterInProgressStatus.Rounded = false;
            btnFilterInProgressStatus.Size = new Size(100, 29);
            btnFilterInProgressStatus.TabIndex = 5;
            btnFilterInProgressStatus.Text = "In Progress";
            btnFilterInProgressStatus.TextColor = Color.Black;
            btnFilterInProgressStatus.Click += btnFilterInProgressStatus_Click;
            // 
            // btnFilterOpenStatus
            // 
            btnFilterOpenStatus.BackColor = Color.Transparent;
            btnFilterOpenStatus.BaseColor = Color.Silver;
            btnFilterOpenStatus.Font = new Font("Segoe UI", 12F);
            btnFilterOpenStatus.Location = new Point(160, 149);
            btnFilterOpenStatus.Name = "btnFilterOpenStatus";
            btnFilterOpenStatus.Rounded = false;
            btnFilterOpenStatus.Size = new Size(73, 29);
            btnFilterOpenStatus.TabIndex = 4;
            btnFilterOpenStatus.Text = "Open";
            btnFilterOpenStatus.TextColor = Color.Black;
            btnFilterOpenStatus.Click += btnFilterOpenStatus_Click;
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
            // cmsRescueActions
            // 
            cmsRescueActions.MinimumSize = new Size(50, 0);
            cmsRescueActions.Name = "cmsRescueActions";
            cmsRescueActions.Size = new Size(61, 4);
            cmsRescueActions.ItemClicked += cmsRescueActions_ItemClicked;
            // 
            // MaintainRescuesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1215, 563);
            Controls.Add(pnlFormContent);
            Controls.Add(lblMaintainRescuesTitle);
            Name = "MaintainRescuesForm";
            Text = "MaintainRescuesForm";
            Load += MaintainRescuesForm_Load;
            pnlFormContent.ResumeLayout(false);
            pnlFormContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRescues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaintainRescuesTitle;
        private TextBox txtSearchRescue;
        private Panel pnlFormContent;
        private ReaLTaiizor.Controls.ForeverButton btnRefresh;
        private Label lblFilterBy;
        private DataGridView dataGridViewRescues;
        private ReaLTaiizor.Controls.ForeverButton btnFilterClosedStatus;
        private ReaLTaiizor.Controls.ForeverButton btnFilterInProgressStatus;
        private ReaLTaiizor.Controls.ForeverButton btnFilterOpenStatus;
        private ReaLTaiizor.Controls.ForeverButton btnSearch;
        private ContextMenuStrip cmsRescueActions;
    }
}