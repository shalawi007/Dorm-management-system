
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblReportA = new System.Windows.Forms.Label();
            this.lblReportB = new System.Windows.Forms.Label();
            this.btnShreportA = new System.Windows.Forms.Button();
            this.btnShreportB = new System.Windows.Forms.Button();
            this.chVacant = new System.Windows.Forms.CheckBox();
            this.chOccupied = new System.Windows.Forms.CheckBox();
            this.lblfilter = new System.Windows.Forms.Label();
            this.gbReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(688, 528);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 37);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(545, 528);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 37);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // gbReport
            // 
            this.gbReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.gbReport.Controls.Add(this.listView1);
            this.gbReport.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbReport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbReport.Location = new System.Drawing.Point(48, 170);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(751, 337);
            this.gbReport.TabIndex = 49;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Monthly Report :";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(718, 294);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblReportA
            // 
            this.lblReportA.AutoSize = true;
            this.lblReportA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReportA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReportA.Location = new System.Drawing.Point(61, 34);
            this.lblReportA.Name = "lblReportA";
            this.lblReportA.Size = new System.Drawing.Size(239, 22);
            this.lblReportA.TabIndex = 50;
            this.lblReportA.Text = "1. Block A Monthly Report :";
            // 
            // lblReportB
            // 
            this.lblReportB.AutoSize = true;
            this.lblReportB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReportB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReportB.Location = new System.Drawing.Point(61, 93);
            this.lblReportB.Name = "lblReportB";
            this.lblReportB.Size = new System.Drawing.Size(241, 22);
            this.lblReportB.TabIndex = 51;
            this.lblReportB.Text = "2. Block B Monthly Report :";
            // 
            // btnShreportA
            // 
            this.btnShreportA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShreportA.Location = new System.Drawing.Point(357, 27);
            this.btnShreportA.Name = "btnShreportA";
            this.btnShreportA.Size = new System.Drawing.Size(166, 37);
            this.btnShreportA.TabIndex = 52;
            this.btnShreportA.Text = "Generate ";
            this.btnShreportA.UseVisualStyleBackColor = true;
            this.btnShreportA.Click += new System.EventHandler(this.btnShreportA_Click);
            // 
            // btnShreportB
            // 
            this.btnShreportB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShreportB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShreportB.Location = new System.Drawing.Point(357, 86);
            this.btnShreportB.Name = "btnShreportB";
            this.btnShreportB.Size = new System.Drawing.Size(166, 37);
            this.btnShreportB.TabIndex = 53;
            this.btnShreportB.Text = "Generate";
            this.btnShreportB.UseVisualStyleBackColor = true;
            this.btnShreportB.Click += new System.EventHandler(this.btnShreportB_Click);
            // 
            // chVacant
            // 
            this.chVacant.AutoSize = true;
            this.chVacant.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chVacant.Location = new System.Drawing.Point(731, 145);
            this.chVacant.Name = "chVacant";
            this.chVacant.Size = new System.Drawing.Size(61, 19);
            this.chVacant.TabIndex = 56;
            this.chVacant.Text = "Vacant";
            this.chVacant.UseVisualStyleBackColor = true;
            // 
            // chOccupied
            // 
            this.chOccupied.AutoSize = true;
            this.chOccupied.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chOccupied.Location = new System.Drawing.Point(645, 145);
            this.chOccupied.Name = "chOccupied";
            this.chOccupied.Size = new System.Drawing.Size(77, 19);
            this.chOccupied.TabIndex = 55;
            this.chOccupied.Text = "Occupied";
            this.chOccupied.UseVisualStyleBackColor = true;
            // 
            // lblfilter
            // 
            this.lblfilter.AutoSize = true;
            this.lblfilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblfilter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblfilter.Location = new System.Drawing.Point(585, 143);
            this.lblfilter.Name = "lblfilter";
            this.lblfilter.Size = new System.Drawing.Size(45, 19);
            this.lblfilter.TabIndex = 54;
            this.lblfilter.Text = "Filter";
            // 
            // Monthly_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(830, 577);
            this.Controls.Add(this.chVacant);
            this.Controls.Add(this.chOccupied);
            this.Controls.Add(this.lblfilter);
            this.Controls.Add(this.btnShreportB);
            this.Controls.Add(this.btnShreportA);
            this.Controls.Add(this.lblReportB);
            this.Controls.Add(this.lblReportA);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monthly_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly_Report";
            this.Load += new System.EventHandler(this.Monthly_Report_Load);
            this.gbReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.Label lblReportA;
        private System.Windows.Forms.Label lblReportB;
        private System.Windows.Forms.Button btnShreportA;
        private System.Windows.Forms.Button btnShreportB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox chVacant;
        private System.Windows.Forms.CheckBox chOccupied;
        private System.Windows.Forms.Label lblfilter;
    }
}