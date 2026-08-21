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
            lblPeakUsage = new Label();
            label7 = new Label();
            lblLeastUsedTrail = new Label();
            lblMostUsedTrail = new Label();
            label6 = new Label();
            label5 = new Label();
            dgvReport = new DataGridView();
            pnlHeader.SuspendLayout();
            panelTOP.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(56, 146, 89);
            pnlHeader.Controls.Add(lblModeTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(1, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1147, 96);
            pnlHeader.TabIndex = 1;
            // 
            // lblModeTitle
            // 
            lblModeTitle.AutoSize = true;
            lblModeTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeTitle.ForeColor = Color.White;
            lblModeTitle.Location = new Point(665, 32);
            lblModeTitle.Name = "lblModeTitle";
            lblModeTitle.Size = new Size(184, 37);
            lblModeTitle.TabIndex = 3;
            lblModeTitle.Text = "Admin Mode";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(14, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(187, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "TrailGuard";
            // 
            // lblGenerateReportsTitle
            // 
            lblGenerateReportsTitle.AutoSize = true;
            lblGenerateReportsTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReportsTitle.Location = new Point(12, 100);
            lblGenerateReportsTitle.Name = "lblGenerateReportsTitle";
            lblGenerateReportsTitle.Size = new Size(324, 50);
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
            panelTOP.Location = new Point(36, 164);
            panelTOP.Name = "panelTOP";
            panelTOP.Size = new Size(1075, 196);
            panelTOP.TabIndex = 3;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(735, 84);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(162, 43);
            btnGenerateReport.TabIndex = 7;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += button1_Click;
            // 
            // cmbTrails
            // 
            cmbTrails.FormattingEnabled = true;
            cmbTrails.Items.AddRange(new object[] { "All" });
            cmbTrails.Location = new Point(24, 143);
            cmbTrails.Name = "cmbTrails";
            cmbTrails.Size = new Size(588, 28);
            cmbTrails.TabIndex = 6;
            cmbTrails.Text = "<Select trail name>";
            cmbTrails.SelectedIndexChanged += cmbTrails_SelectedIndexChanged;
            // 
            // dateTimePickerENDDATE
            // 
            dateTimePickerENDDATE.Location = new Point(348, 75);
            dateTimePickerENDDATE.Name = "dateTimePickerENDDATE";
            dateTimePickerENDDATE.Size = new Size(250, 27);
            dateTimePickerENDDATE.TabIndex = 5;
            // 
            // dateTimePickerSTARTDATE
            // 
            dateTimePickerSTARTDATE.Location = new Point(24, 75);
            dateTimePickerSTARTDATE.Name = "dateTimePickerSTARTDATE";
            dateTimePickerSTARTDATE.Size = new Size(250, 27);
            dateTimePickerSTARTDATE.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 120);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Trail filter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 52);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "End date";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 52);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Start date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Report period";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPeakUsage);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblLeastUsedTrail);
            panel1.Controls.Add(lblMostUsedTrail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dgvReport);
            panel1.Location = new Point(36, 366);
            panel1.Name = "panel1";
            panel1.Size = new Size(1075, 368);
            panel1.TabIndex = 4;
            // 
            // lblPeakUsage
            // 
            lblPeakUsage.AutoSize = true;
            lblPeakUsage.Location = new Point(206, 317);
            lblPeakUsage.Name = "lblPeakUsage";
            lblPeakUsage.Size = new Size(50, 20);
            lblPeakUsage.TabIndex = 6;
            lblPeakUsage.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 317);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 5;
            label7.Text = "Peak usage date";
            // 
            // lblLeastUsedTrail
            // 
            lblLeastUsedTrail.AutoSize = true;
            lblLeastUsedTrail.Location = new Point(206, 283);
            lblLeastUsedTrail.Name = "lblLeastUsedTrail";
            lblLeastUsedTrail.Size = new Size(50, 20);
            lblLeastUsedTrail.TabIndex = 4;
            lblLeastUsedTrail.Text = "label8";
            // 
            // lblMostUsedTrail
            // 
            lblMostUsedTrail.AutoSize = true;
            lblMostUsedTrail.Location = new Point(206, 251);
            lblMostUsedTrail.Name = "lblMostUsedTrail";
            lblMostUsedTrail.Size = new Size(50, 20);
            lblMostUsedTrail.TabIndex = 3;
            lblMostUsedTrail.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 283);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 2;
            label6.Text = "Least used trail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 251);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 1;
            label5.Text = "Most used trail";
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(24, 25);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(1026, 203);
            dgvReport.TabIndex = 0;
            // 
            // GenerateReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1147, 777);
            Controls.Add(panel1);
            Controls.Add(panelTOP);
            Controls.Add(lblGenerateReportsTitle);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GenerateReportsForm";
            Text = "GenerateReportsForm";
            Load += GenerateReportsForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panelTOP.ResumeLayout(false);
            panelTOP.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label lblLeastUsedTrail;
        private Label lblMostUsedTrail;
        private Label label6;
        private Label label5;
        private Label lblPeakUsage;
        private Label label7;
    }
}