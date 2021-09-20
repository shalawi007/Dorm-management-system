
namespace Dorm_managment_system
{
    partial class Monthly_Report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReport = new Dorm_managment_system.DataSetReport();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblReport = new System.Windows.Forms.Label();
            this.btnreportA = new System.Windows.Forms.Button();
            this.chVacant = new System.Windows.Forms.CheckBox();
            this.chOccupied = new System.Windows.Forms.CheckBox();
            this.lblfilter = new System.Windows.Forms.Label();
            this.DataTable1TableAdapter = new Dorm_managment_system.DataSetReportTableAdapters.DataTable1TableAdapter();
            this.cboBlock = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).BeginInit();
            this.gbReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSetReport;
            // 
            // DataSetReport
            // 
            this.DataSetReport.DataSetName = "DataSetReport";
            this.DataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbReport
            // 
            this.gbReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.gbReport.Controls.Add(this.reportViewer1);
            this.gbReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbReport.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.gbReport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbReport.Location = new System.Drawing.Point(0, 92);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(711, 408);
            this.gbReport.TabIndex = 49;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Accomdation Report :";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.DataTable1BindingSource;
            reportDataSource6.Name = "DataSet2";
            reportDataSource6.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dorm_managment_system.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(705, 380);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblReport.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReport.Location = new System.Drawing.Point(12, 42);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(98, 22);
            this.lblReport.TabIndex = 50;
            this.lblReport.Text = "Report of :";
            // 
            // btnreportA
            // 
            this.btnreportA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnreportA.FlatAppearance.BorderSize = 0;
            this.btnreportA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnreportA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportA.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnreportA.Location = new System.Drawing.Point(549, 37);
            this.btnreportA.Name = "btnreportA";
            this.btnreportA.Size = new System.Drawing.Size(101, 32);
            this.btnreportA.TabIndex = 52;
            this.btnreportA.Text = "Generate ";
            this.btnreportA.UseVisualStyleBackColor = false;
            this.btnreportA.Click += new System.EventHandler(this.btnreportA_Click);
            // 
            // chVacant
            // 
            this.chVacant.AutoSize = true;
            this.chVacant.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chVacant.Location = new System.Drawing.Point(462, 47);
            this.chVacant.Name = "chVacant";
            this.chVacant.Size = new System.Drawing.Size(60, 17);
            this.chVacant.TabIndex = 56;
            this.chVacant.Text = "Vacant";
            this.chVacant.UseVisualStyleBackColor = true;
            // 
            // chOccupied
            // 
            this.chOccupied.AutoSize = true;
            this.chOccupied.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chOccupied.Location = new System.Drawing.Point(384, 47);
            this.chOccupied.Name = "chOccupied";
            this.chOccupied.Size = new System.Drawing.Size(72, 17);
            this.chOccupied.TabIndex = 55;
            this.chOccupied.Text = "Occupied";
            this.chOccupied.UseVisualStyleBackColor = true;
            // 
            // lblfilter
            // 
            this.lblfilter.AutoSize = true;
            this.lblfilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblfilter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblfilter.Location = new System.Drawing.Point(319, 43);
            this.lblfilter.Name = "lblfilter";
            this.lblfilter.Size = new System.Drawing.Size(45, 19);
            this.lblfilter.TabIndex = 54;
            this.lblfilter.Text = "Filter";
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // cboBlock
            // 
            this.cboBlock.FormattingEnabled = true;
            this.cboBlock.Location = new System.Drawing.Point(168, 43);
            this.cboBlock.Name = "cboBlock";
            this.cboBlock.Size = new System.Drawing.Size(121, 21);
            this.cboBlock.TabIndex = 57;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(677, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 26);
            this.btnExit.TabIndex = 58;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dorm_managment_system.Properties.Resources.back_icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Monthly_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(711, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboBlock);
            this.Controls.Add(this.chVacant);
            this.Controls.Add(this.chOccupied);
            this.Controls.Add(this.lblfilter);
            this.Controls.Add(this.btnreportA);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.gbReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monthly_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly_Report";
            this.Load += new System.EventHandler(this.Monthly_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).EndInit();
            this.gbReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Button btnreportA;
        private System.Windows.Forms.CheckBox chVacant;
        private System.Windows.Forms.CheckBox chOccupied;
        private System.Windows.Forms.Label lblfilter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetReport DataSetReport;
        private DataSetReportTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.ComboBox cboBlock;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}