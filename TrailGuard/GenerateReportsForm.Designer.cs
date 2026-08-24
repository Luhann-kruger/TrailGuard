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
            lblPeakUsage = new Label();
            label7 = new Label();
            lblLeastUsedTrail = new Label();
            lblMostUsedTrail = new Label();
            label6 = new Label();
            label5 = new Label();
            tabReports = new TabControl();
            tabPageTrailUsage = new TabPage();
            dgvReport = new DataGridView();
            tabPageIncidents = new TabPage();
            dgvIncidents = new DataGridView();
            lblUnderusedNotice = new Label();
            pnlSignageNotice = new Panel();
            lblSignageNotice = new Label();
            pnlUnderusedNotice = new Panel();
            pnlHeader.SuspendLayout();
            panelTOP.SuspendLayout();
            panel1.SuspendLayout();
            tabReports.SuspendLayout();
            tabPageTrailUsage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            tabPageIncidents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIncidents).BeginInit();
            pnlSignageNotice.SuspendLayout();
            pnlUnderusedNotice.SuspendLayout();
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
            lblModeTitle.Location = new Point(830, 24);
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
            panelTOP.Location = new Point(32, 191);
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
            panel1.Controls.Add(lblPeakUsage);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblLeastUsedTrail);
            panel1.Controls.Add(lblMostUsedTrail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tabReports);
            panel1.Location = new Point(32, 358);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 276);
            panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BaseColor = Color.Green;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(799, 199);
            btnClose.Name = "btnClose";
            btnClose.Rounded = false;
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.TextColor = Color.FromArgb(243, 243, 243);
            btnClose.Click += btnClose_Click;
            // 
            // lblPeakUsage
            // 
            lblPeakUsage.AutoSize = true;
            lblPeakUsage.Location = new Point(180, 238);
            lblPeakUsage.Name = "lblPeakUsage";
            lblPeakUsage.Size = new Size(38, 15);
            lblPeakUsage.TabIndex = 6;
            lblPeakUsage.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 238);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 5;
            label7.Text = "Peak usage date";
            // 
            // lblLeastUsedTrail
            // 
            lblLeastUsedTrail.AutoSize = true;
            lblLeastUsedTrail.Location = new Point(180, 212);
            lblLeastUsedTrail.Name = "lblLeastUsedTrail";
            lblLeastUsedTrail.Size = new Size(38, 15);
            lblLeastUsedTrail.TabIndex = 4;
            lblLeastUsedTrail.Text = "label8";
            // 
            // lblMostUsedTrail
            // 
            lblMostUsedTrail.AutoSize = true;
            lblMostUsedTrail.Location = new Point(180, 188);
            lblMostUsedTrail.Name = "lblMostUsedTrail";
            lblMostUsedTrail.Size = new Size(38, 15);
            lblMostUsedTrail.TabIndex = 3;
            lblMostUsedTrail.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 212);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 2;
            label6.Text = "Least used trail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 188);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 1;
            label5.Text = "Most used trail";
            // 
            // tabReports
            // 
            tabReports.Controls.Add(tabPageTrailUsage);
            tabReports.Controls.Add(tabPageIncidents);
            tabReports.Location = new Point(21, 19);
            tabReports.Margin = new Padding(3, 2, 3, 2);
            tabReports.Name = "tabReports";
            tabReports.SelectedIndex = 0;
            tabReports.Size = new Size(898, 158);
            tabReports.TabIndex = 0;
            // 
            // tabPageTrailUsage
            // 
            tabPageTrailUsage.Controls.Add(dgvReport);
            tabPageTrailUsage.Location = new Point(4, 24);
            tabPageTrailUsage.Margin = new Padding(3, 2, 3, 2);
            tabPageTrailUsage.Name = "tabPageTrailUsage";
            tabPageTrailUsage.Padding = new Padding(3, 2, 3, 2);
            tabPageTrailUsage.Size = new Size(890, 130);
            tabPageTrailUsage.TabIndex = 0;
            tabPageTrailUsage.Text = "Trail Usage";
            tabPageTrailUsage.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(3, 2);
            dgvReport.Margin = new Padding(3, 2, 3, 2);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(884, 126);
            dgvReport.TabIndex = 0;
            // 
            // tabPageIncidents
            // 
            tabPageIncidents.Controls.Add(dgvIncidents);
            tabPageIncidents.Location = new Point(4, 24);
            tabPageIncidents.Margin = new Padding(3, 2, 3, 2);
            tabPageIncidents.Name = "tabPageIncidents";
            tabPageIncidents.Padding = new Padding(3, 2, 3, 2);
            tabPageIncidents.Size = new Size(890, 130);
            tabPageIncidents.TabIndex = 1;
            tabPageIncidents.Text = "Incident Summary";
            tabPageIncidents.UseVisualStyleBackColor = true;
            // 
            // dgvIncidents
            // 
            dgvIncidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncidents.Dock = DockStyle.Fill;
            dgvIncidents.Location = new Point(3, 2);
            dgvIncidents.Margin = new Padding(3, 2, 3, 2);
            dgvIncidents.Name = "dgvIncidents";
            dgvIncidents.RowHeadersWidth = 51;
            dgvIncidents.Size = new Size(884, 126);
            dgvIncidents.TabIndex = 0;
            // 
            // lblUnderusedNotice
            // 
            lblUnderusedNotice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnderusedNotice.Location = new Point(31, 13);
            lblUnderusedNotice.Name = "lblUnderusedNotice";
            lblUnderusedNotice.Size = new Size(113, 56);
            lblUnderusedNotice.TabIndex = 0;
            lblUnderusedNotice.Text = "0 trail(s) Underused";
            lblUnderusedNotice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSignageNotice
            // 
            pnlSignageNotice.BackColor = Color.Tomato;
            pnlSignageNotice.Controls.Add(lblSignageNotice);
            pnlSignageNotice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlSignageNotice.Location = new Point(323, 86);
            pnlSignageNotice.Margin = new Padding(3, 2, 3, 2);
            pnlSignageNotice.Name = "pnlSignageNotice";
            pnlSignageNotice.Size = new Size(170, 85);
            pnlSignageNotice.TabIndex = 6;
            // 
            // lblSignageNotice
            // 
            lblSignageNotice.Location = new Point(3, 13);
            lblSignageNotice.Name = "lblSignageNotice";
            lblSignageNotice.Size = new Size(164, 42);
            lblSignageNotice.TabIndex = 0;
            lblSignageNotice.Text = "0 trail(s) need Signage or Closure";
            lblSignageNotice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlUnderusedNotice
            // 
            pnlUnderusedNotice.BackColor = Color.Khaki;
            pnlUnderusedNotice.Controls.Add(lblUnderusedNotice);
            pnlUnderusedNotice.Location = new Point(551, 86);
            pnlUnderusedNotice.Margin = new Padding(3, 2, 3, 2);
            pnlUnderusedNotice.Name = "pnlUnderusedNotice";
            pnlUnderusedNotice.Size = new Size(165, 85);
            pnlUnderusedNotice.TabIndex = 5;
            // 
            // GenerateReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1004, 645);
            Controls.Add(pnlUnderusedNotice);
            Controls.Add(panel1);
            Controls.Add(pnlSignageNotice);
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
            tabReports.ResumeLayout(false);
            tabPageTrailUsage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            tabPageIncidents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIncidents).EndInit();
            pnlSignageNotice.ResumeLayout(false);
            pnlUnderusedNotice.ResumeLayout(false);
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
        private Label lblLeastUsedTrail;
        private Label lblMostUsedTrail;
        private Label label6;
        private Label label5;
        private Label lblPeakUsage;
        private Label label7;
        private TabControl tabReports;
        private TabPage tabPageTrailUsage;
        private DataGridView dgvReport;
        private TabPage tabPageIncidents;
        private DataGridView dgvIncidents;
        private Label lblUnderusedNotice;
        private Panel pnlSignageNotice;
        private Label lblSignageNotice;
        private Panel pnlUnderusedNotice;
        private ReaLTaiizor.Controls.ForeverButton btnClose;
    }
}