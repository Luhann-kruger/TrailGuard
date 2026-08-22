namespace TrailGuard
{
    partial class GenerateReportsForm
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
            lblGenerateReportsTitle = new Label();
            panelTOP = new Panel();
            btnGenerateReport = new Button();
            cmbTrails = new ComboBox();
            dateTimePickerENDDATE = new DateTimePicker();
            dateTimePickerSTARTDATE = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnClose = new ReaLTaiizor.Controls.ForeverButton();
            pnlAttention = new Panel();
            lblAttentionCount = new Label();
            pnlUnderused = new Panel();
            lblUnderusedCount = new Label();
            lblPeakUsage = new Label();
            label7 = new Label();
            dgvReport = new DataGridView();
            pnlHeader.SuspendLayout();
            panelTOP.SuspendLayout();
            panel1.SuspendLayout();
            pnlAttention.SuspendLayout();
            pnlUnderused.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
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
            pnlHeader.TabIndex = 1;
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
            // lblGenerateReportsTitle
            // 
            lblGenerateReportsTitle.AutoSize = true;
            lblGenerateReportsTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReportsTitle.Location = new Point(10, 75);
            lblGenerateReportsTitle.Name = "lblGenerateReportsTitle";
            lblGenerateReportsTitle.Size = new Size(258, 40);
            lblGenerateReportsTitle.TabIndex = 2;
            lblGenerateReportsTitle.Text = "Generate Reports";
            // 
            // panelTOP
            // 
            panelTOP.Controls.Add(btnGenerateReport);
            panelTOP.Controls.Add(cmbTrails);
            panelTOP.Controls.Add(dateTimePickerENDDATE);
            panelTOP.Controls.Add(dateTimePickerSTARTDATE);
            panelTOP.Controls.Add(label4);
            panelTOP.Controls.Add(label3);
            panelTOP.Controls.Add(label2);
            panelTOP.Controls.Add(label1);
            panelTOP.Location = new Point(32, 123);
            panelTOP.Margin = new Padding(3, 2, 3, 2);
            panelTOP.Name = "panelTOP";
            panelTOP.Size = new Size(941, 147);
            panelTOP.TabIndex = 3;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(643, 63);
            btnGenerateReport.Margin = new Padding(3, 2, 3, 2);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(142, 32);
            btnGenerateReport.TabIndex = 7;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += button1_Click;
            // 
            // cmbTrails
            // 
            cmbTrails.FormattingEnabled = true;
            cmbTrails.Items.AddRange(new object[] { "All" });
            cmbTrails.Location = new Point(21, 107);
            cmbTrails.Margin = new Padding(3, 2, 3, 2);
            cmbTrails.Name = "cmbTrails";
            cmbTrails.Size = new Size(515, 23);
            cmbTrails.TabIndex = 6;
            cmbTrails.Text = "<Select trail name>";
            cmbTrails.SelectedIndexChanged += cmbTrails_SelectedIndexChanged;
            // 
            // dateTimePickerENDDATE
            // 
            dateTimePickerENDDATE.Location = new Point(304, 56);
            dateTimePickerENDDATE.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerENDDATE.Name = "dateTimePickerENDDATE";
            dateTimePickerENDDATE.Size = new Size(219, 23);
            dateTimePickerENDDATE.TabIndex = 5;
            // 
            // dateTimePickerSTARTDATE
            // 
            dateTimePickerSTARTDATE.Location = new Point(21, 56);
            dateTimePickerSTARTDATE.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerSTARTDATE.Name = "dateTimePickerSTARTDATE";
            dateTimePickerSTARTDATE.Size = new Size(219, 23);
            dateTimePickerSTARTDATE.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 90);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Trail filter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 39);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "End date";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 39);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Start date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 12);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Report period";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(pnlAttention);
            panel1.Controls.Add(pnlUnderused);
            panel1.Controls.Add(lblPeakUsage);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dgvReport);
            panel1.Location = new Point(32, 274);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 298);
            panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BaseColor = Color.FromArgb(35, 168, 109);
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(799, 245);
            btnClose.Name = "btnClose";
            btnClose.Rounded = false;
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.TextColor = Color.FromArgb(243, 243, 243);
            btnClose.Click += btnClose_Click;
            // 
            // pnlAttention
            // 
            pnlAttention.BackColor = Color.Tomato;
            pnlAttention.Controls.Add(lblAttentionCount);
            pnlAttention.Location = new Point(247, 193);
            pnlAttention.Name = "pnlAttention";
            pnlAttention.Size = new Size(179, 83);
            pnlAttention.TabIndex = 8;
            // 
            // lblAttentionCount
            // 
            lblAttentionCount.Dock = DockStyle.Fill;
            lblAttentionCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAttentionCount.Location = new Point(0, 0);
            lblAttentionCount.Name = "lblAttentionCount";
            lblAttentionCount.Size = new Size(179, 83);
            lblAttentionCount.TabIndex = 10;
            lblAttentionCount.Text = "-";
            // 
            // pnlUnderused
            // 
            pnlUnderused.BackColor = Color.PaleGoldenrod;
            pnlUnderused.Controls.Add(lblUnderusedCount);
            pnlUnderused.Location = new Point(21, 193);
            pnlUnderused.Name = "pnlUnderused";
            pnlUnderused.Size = new Size(179, 83);
            pnlUnderused.TabIndex = 7;
            // 
            // lblUnderusedCount
            // 
            lblUnderusedCount.Dock = DockStyle.Fill;
            lblUnderusedCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnderusedCount.Location = new Point(0, 0);
            lblUnderusedCount.Name = "lblUnderusedCount";
            lblUnderusedCount.Size = new Size(179, 83);
            lblUnderusedCount.TabIndex = 9;
            lblUnderusedCount.Text = "-";
            // 
            // lblPeakUsage
            // 
            lblPeakUsage.AutoSize = true;
            lblPeakUsage.Location = new Point(601, 212);
            lblPeakUsage.Name = "lblPeakUsage";
            lblPeakUsage.Size = new Size(12, 15);
            lblPeakUsage.TabIndex = 6;
            lblPeakUsage.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(525, 212);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 5;
            label7.Text = "Peak Day";
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(21, 19);
            dgvReport.Margin = new Padding(3, 2, 3, 2);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(898, 152);
            dgvReport.TabIndex = 0;
            dgvReport.DataBindingComplete += dgvReport_DataBindingComplete;
            // 
            // GenerateReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1004, 583);
            Controls.Add(panel1);
            Controls.Add(panelTOP);
            Controls.Add(lblGenerateReportsTitle);
            Controls.Add(pnlHeader);
            Name = "GenerateReportsForm";
            Text = "GenerateReportsForm";
            Load += GenerateReportsForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panelTOP.ResumeLayout(false);
            panelTOP.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlAttention.ResumeLayout(false);
            pnlUnderused.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblModeTitle;
        private Label lblTitle;
        private Label lblGenerateReportsTitle;
        private Panel panelTOP;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerENDDATE;
        private DateTimePicker dateTimePickerSTARTDATE;
        private ComboBox cmbTrails;
        private Button btnGenerateReport;
        private DataGridView dgvReport;
        private Label lblPeakUsage;
        private Label label7;
        private Panel pnlAttention;
        private Label lblAttentionCount;
        private Panel pnlUnderused;
        private Label lblUnderusedCount;
        private ReaLTaiizor.Controls.ForeverButton btnClose;
    }
}