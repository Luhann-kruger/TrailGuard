namespace TrailGuard
{
    partial class MaintainHikersForm
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
            lblMaintainHikersTitle = new Label();
            pnlFormContent = new Panel();
            btnRefresh = new ReaLTaiizor.Controls.ForeverButton();
            dataGridViewHikers = new DataGridView();
            btnSearch = new ReaLTaiizor.Controls.ForeverButton();
            btnAddHiker = new ReaLTaiizor.Controls.ForeverButton();
            txtSearchHiker = new TextBox();
            cmsHikerActions = new ContextMenuStrip(components);
            pnlFormContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHikers).BeginInit();
            SuspendLayout();
            // 
            // lblMaintainHikersTitle
            // 
            lblMaintainHikersTitle.AutoSize = true;
            lblMaintainHikersTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaintainHikersTitle.Location = new Point(12, 23);
            lblMaintainHikersTitle.Name = "lblMaintainHikersTitle";
            lblMaintainHikersTitle.Size = new Size(240, 40);
            lblMaintainHikersTitle.TabIndex = 0;
            lblMaintainHikersTitle.Text = "Maintain Hikers";
            // 
            // pnlFormContent
            // 
            pnlFormContent.BackColor = Color.White;
            pnlFormContent.Controls.Add(btnRefresh);
            pnlFormContent.Controls.Add(dataGridViewHikers);
            pnlFormContent.Controls.Add(btnSearch);
            pnlFormContent.Controls.Add(btnAddHiker);
            pnlFormContent.Controls.Add(txtSearchHiker);
            pnlFormContent.Location = new Point(12, 79);
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
            btnRefresh.Location = new Point(38, 153);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Rounded = false;
            btnRefresh.Size = new Size(73, 29);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextColor = Color.Black;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridViewHikers
            // 
            dataGridViewHikers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHikers.Location = new Point(38, 200);
            dataGridViewHikers.Name = "dataGridViewHikers";
            dataGridViewHikers.Size = new Size(1094, 205);
            dataGridViewHikers.TabIndex = 6;
            dataGridViewHikers.CellContentClick += dataGridViewHikers_CellContentClick;
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
            // btnAddHiker
            // 
            btnAddHiker.BackColor = Color.Transparent;
            btnAddHiker.BaseColor = Color.FromArgb(44, 123, 102);
            btnAddHiker.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddHiker.Location = new Point(981, 20);
            btnAddHiker.Name = "btnAddHiker";
            btnAddHiker.Rounded = false;
            btnAddHiker.Size = new Size(151, 36);
            btnAddHiker.TabIndex = 1;
            btnAddHiker.Text = "+ Add Hiker";
            btnAddHiker.TextColor = Color.FromArgb(243, 243, 243);
            btnAddHiker.Click += btnAddHiker_Click;
            // 
            // txtSearchHiker
            // 
            txtSearchHiker.BackColor = SystemColors.ScrollBar;
            txtSearchHiker.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchHiker.Location = new Point(777, 100);
            txtSearchHiker.Name = "txtSearchHiker";
            txtSearchHiker.Size = new Size(230, 27);
            txtSearchHiker.TabIndex = 2;
            // 
            // cmsHikerActions
            // 
            cmsHikerActions.MinimumSize = new Size(50, 0);
            cmsHikerActions.Name = "cmsHikerActions";
            cmsHikerActions.Size = new Size(61, 4);
            cmsHikerActions.ItemClicked += cmsHikerActions_ItemClicked;
            // 
            // MaintainHikersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1215, 563);
            Controls.Add(pnlFormContent);
            Controls.Add(lblMaintainHikersTitle);
            Name = "MaintainHikersForm";
            Text = "MaintainHikersForm";
            Load += MaintainHikersForm_Load;
            pnlFormContent.ResumeLayout(false);
            pnlFormContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHikers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaintainHikersTitle;
        private Panel pnlFormContent;
        private ReaLTaiizor.Controls.ForeverButton btnRefresh;
        private DataGridView dataGridViewHikers;
        private ReaLTaiizor.Controls.ForeverButton btnSearch;
        private ReaLTaiizor.Controls.ForeverButton btnAddHiker;
        private TextBox txtSearchHiker;
        private ContextMenuStrip cmsHikerActions;
    }
}