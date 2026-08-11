namespace TrailGuard
{
    partial class mantainTrailsForm
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
            lblMaintainTrailsTitle = new Label();
            btnCreateTrail = new ReaLTaiizor.Controls.ForeverButton();
            txtSearchTrail = new TextBox();
            pnlFormContent = new Panel();
            btnRefresh = new ReaLTaiizor.Controls.ForeverButton();
            lblFilterBy = new Label();
            dgvTrails = new DataGridView();
            btnFilterCloseStatus = new ReaLTaiizor.Controls.ForeverButton();
            btnFilterOpenStatus = new ReaLTaiizor.Controls.ForeverButton();
            btnSearch = new ReaLTaiizor.Controls.ForeverButton();
            cmsTrailActions = new ContextMenuStrip(components);
            pnlFormContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrails).BeginInit();
            SuspendLayout();
            // 
            // lblMaintainTrailsTitle
            // 
            lblMaintainTrailsTitle.AutoSize = true;
            lblMaintainTrailsTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaintainTrailsTitle.Location = new Point(12, 23);
            lblMaintainTrailsTitle.Name = "lblMaintainTrailsTitle";
            lblMaintainTrailsTitle.Size = new Size(220, 40);
            lblMaintainTrailsTitle.TabIndex = 0;
            lblMaintainTrailsTitle.Text = "Maintain Trails";
            // 
            // btnCreateTrail
            // 
            btnCreateTrail.BackColor = Color.Transparent;
            btnCreateTrail.BaseColor = Color.FromArgb(44, 123, 102);
            btnCreateTrail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateTrail.Location = new Point(981, 20);
            btnCreateTrail.Name = "btnCreateTrail";
            btnCreateTrail.Rounded = false;
            btnCreateTrail.Size = new Size(151, 36);
            btnCreateTrail.TabIndex = 1;
            btnCreateTrail.Text = "+ Create Trail";
            btnCreateTrail.TextColor = Color.FromArgb(243, 243, 243);
            btnCreateTrail.Click += btnCreateTrail_Click;
            // 
            // txtSearchTrail
            // 
            txtSearchTrail.BackColor = SystemColors.ScrollBar;
            txtSearchTrail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchTrail.Location = new Point(777, 100);
            txtSearchTrail.Name = "txtSearchTrail";
            txtSearchTrail.Size = new Size(230, 27);
            txtSearchTrail.TabIndex = 2;
            // 
            // pnlFormContent
            // 
            pnlFormContent.BackColor = Color.White;
            pnlFormContent.Controls.Add(btnRefresh);
            pnlFormContent.Controls.Add(lblFilterBy);
            pnlFormContent.Controls.Add(dgvTrails);
            pnlFormContent.Controls.Add(btnFilterCloseStatus);
            pnlFormContent.Controls.Add(btnFilterOpenStatus);
            pnlFormContent.Controls.Add(btnSearch);
            pnlFormContent.Controls.Add(btnCreateTrail);
            pnlFormContent.Controls.Add(txtSearchTrail);
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
            btnRefresh.TabIndex = 8;
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
            lblFilterBy.TabIndex = 7;
            lblFilterBy.Text = "Filter By:";
            // 
            // dgvTrails
            // 
            dgvTrails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrails.Location = new Point(38, 200);
            dgvTrails.Name = "dgvTrails";
            dgvTrails.Size = new Size(1094, 205);
            dgvTrails.TabIndex = 6;
            dgvTrails.CellContentClick += dgvTrails_CellContentClick_1;
            // 
            // btnFilterCloseStatus
            // 
            btnFilterCloseStatus.BackColor = Color.Transparent;
            btnFilterCloseStatus.BaseColor = Color.Silver;
            btnFilterCloseStatus.Font = new Font("Segoe UI", 12F);
            btnFilterCloseStatus.Location = new Point(250, 149);
            btnFilterCloseStatus.Name = "btnFilterCloseStatus";
            btnFilterCloseStatus.Rounded = false;
            btnFilterCloseStatus.Size = new Size(73, 29);
            btnFilterCloseStatus.TabIndex = 5;
            btnFilterCloseStatus.Text = "Close";
            btnFilterCloseStatus.TextColor = Color.Black;
            btnFilterCloseStatus.Click += btnFilterCloseStatus_Click;
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
            // cmsTrailActions
            // 
            cmsTrailActions.MinimumSize = new Size(50, 0);
            cmsTrailActions.Name = "cmsTrailActions";
            cmsTrailActions.Size = new Size(61, 4);
            cmsTrailActions.ItemClicked += cmsTrailActions_ItemClicked;
            // 
            // mantainTrailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1215, 563);
            Controls.Add(pnlFormContent);
            Controls.Add(lblMaintainTrailsTitle);
            Name = "mantainTrailsForm";
            Text = "mantainTrails";
            Load += mantainTrails_Load;
            pnlFormContent.ResumeLayout(false);
            pnlFormContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaintainTrailsTitle;
        private ReaLTaiizor.Controls.ForeverButton btnCreateTrail;
        private TextBox txtSearchTrail;
        private Panel pnlFormContent;
        private ReaLTaiizor.Controls.ForeverButton btnFilterCloseStatus;
        private ReaLTaiizor.Controls.ForeverButton btnFilterOpenStatus;
        private ReaLTaiizor.Controls.ForeverButton btnSearch;
        private DataGridView dgvTrails;
        private ReaLTaiizor.Controls.ForeverButton btnRefresh;
        private Label lblFilterBy;
        private ContextMenuStrip cmsTrailActions;
    }
}