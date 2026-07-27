namespace TrailGuard
{
    partial class maintainParksForm
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
            lblMaintainParksTitle = new Label();
            pnlFormContent = new Panel();
            btnRefresh = new ReaLTaiizor.Controls.ForeverButton();
            dgvParks = new DataGridView();
            btnSearch = new ReaLTaiizor.Controls.ForeverButton();
            btnCreatePark = new ReaLTaiizor.Controls.ForeverButton();
            txtSearchPark = new TextBox();
            pnlFormContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParks).BeginInit();
            SuspendLayout();
            // 
            // lblMaintainParksTitle
            // 
            lblMaintainParksTitle.AutoSize = true;
            lblMaintainParksTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaintainParksTitle.Location = new Point(12, 18);
            lblMaintainParksTitle.Name = "lblMaintainParksTitle";
            lblMaintainParksTitle.Size = new Size(222, 40);
            lblMaintainParksTitle.TabIndex = 1;
            lblMaintainParksTitle.Text = "Maintain Parks";
            // 
            // pnlFormContent
            // 
            pnlFormContent.BackColor = Color.White;
            pnlFormContent.Controls.Add(btnRefresh);
            pnlFormContent.Controls.Add(dgvParks);
            pnlFormContent.Controls.Add(btnSearch);
            pnlFormContent.Controls.Add(btnCreatePark);
            pnlFormContent.Controls.Add(txtSearchPark);
            pnlFormContent.Location = new Point(12, 79);
            pnlFormContent.Name = "pnlFormContent";
            pnlFormContent.Size = new Size(1191, 473);
            pnlFormContent.TabIndex = 4;
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
            // 
            // dgvParks
            // 
            dgvParks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParks.Location = new Point(38, 200);
            dgvParks.Name = "dgvParks";
            dgvParks.Size = new Size(1094, 205);
            dgvParks.TabIndex = 6;
            dgvParks.CellContentClick += dgvParks_CellContentClick;
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
            // btnCreatePark
            // 
            btnCreatePark.BackColor = Color.Transparent;
            btnCreatePark.BaseColor = Color.FromArgb(44, 123, 102);
            btnCreatePark.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreatePark.Location = new Point(981, 20);
            btnCreatePark.Name = "btnCreatePark";
            btnCreatePark.Rounded = false;
            btnCreatePark.Size = new Size(151, 36);
            btnCreatePark.TabIndex = 1;
            btnCreatePark.Text = "+ Create Park";
            btnCreatePark.TextColor = Color.FromArgb(243, 243, 243);
            btnCreatePark.Click += btnCreatePark_Click;
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
            // maintainParksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1215, 563);
            Controls.Add(pnlFormContent);
            Controls.Add(lblMaintainParksTitle);
            Name = "maintainParksForm";
            Text = "maintainParksForm";
            Load += maintainParksForm_Load;
            pnlFormContent.ResumeLayout(false);
            pnlFormContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaintainParksTitle;
        private Panel pnlFormContent;
        private ReaLTaiizor.Controls.ForeverButton btnRefresh;
        private DataGridView dgvParks;
        private ReaLTaiizor.Controls.ForeverButton btnSearch;
        private ReaLTaiizor.Controls.ForeverButton btnCreatePark;
        private TextBox txtSearchPark;
    }
}