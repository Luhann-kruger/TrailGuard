namespace TrailGuard
{
    partial class OverduePermitsForm
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
            lblOverduePermitsTitle = new Label();
            pnlFormContent = new Panel();
            btnRefresh = new ReaLTaiizor.Controls.ForeverButton();
            dataGridViewOverduePermits = new DataGridView();
            btnSearch = new ReaLTaiizor.Controls.ForeverButton();
            txtSearchPermit = new TextBox();
            pnlFormContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverduePermits).BeginInit();
            SuspendLayout();
            // 
            // lblOverduePermitsTitle
            // 
            lblOverduePermitsTitle.AutoSize = true;
            lblOverduePermitsTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverduePermitsTitle.Location = new Point(12, 23);
            lblOverduePermitsTitle.Name = "lblOverduePermitsTitle";
            lblOverduePermitsTitle.Size = new Size(268, 40);
            lblOverduePermitsTitle.TabIndex = 0;
            lblOverduePermitsTitle.Text = "Overdue Permits";
            // 
            // pnlFormContent
            // 
            pnlFormContent.BackColor = Color.White;
            pnlFormContent.Controls.Add(btnRefresh);
            pnlFormContent.Controls.Add(dataGridViewOverduePermits);
            pnlFormContent.Controls.Add(btnSearch);
            pnlFormContent.Controls.Add(txtSearchPermit);
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
            btnRefresh.Location = new Point(38, 153);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Rounded = false;
            btnRefresh.Size = new Size(73, 29);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextColor = Color.Black;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridViewOverduePermits
            // 
            dataGridViewOverduePermits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOverduePermits.Location = new Point(38, 200);
            dataGridViewOverduePermits.Name = "dataGridViewOverduePermits";
            dataGridViewOverduePermits.Size = new Size(1094, 205);
            dataGridViewOverduePermits.TabIndex = 6;
            dataGridViewOverduePermits.CellContentClick += dataGridViewOverduePermits_CellContentClick;
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
            // txtSearchPermit
            // 
            txtSearchPermit.BackColor = SystemColors.ScrollBar;
            txtSearchPermit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchPermit.Location = new Point(777, 100);
            txtSearchPermit.Name = "txtSearchPermit";
            txtSearchPermit.Size = new Size(230, 27);
            txtSearchPermit.TabIndex = 2;
            // 
            // OverduePermitsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1215, 563);
            Controls.Add(pnlFormContent);
            Controls.Add(lblOverduePermitsTitle);
            Name = "OverduePermitsForm";
            Text = "OverduePermitsForm";
            Load += OverduePermitsForm_Load;
            pnlFormContent.ResumeLayout(false);
            pnlFormContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverduePermits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOverduePermitsTitle;
        private Panel pnlFormContent;
        private ReaLTaiizor.Controls.ForeverButton btnRefresh;
        private DataGridView dataGridViewOverduePermits;
        private ReaLTaiizor.Controls.ForeverButton btnSearch;
        private TextBox txtSearchPermit;
    }
}