
namespace Dorm_managment_system
{
    partial class Roomassign
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.StartdatePicker = new System.Windows.Forms.DateTimePicker();
            this.EnddatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboRooms = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbRequest = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.blUnitNo = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEnddate = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblfilter = new System.Windows.Forms.Label();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.lstUnits = new System.Windows.Forms.ListBox();
            this.gbRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStudentID.Location = new System.Drawing.Point(35, 48);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(103, 22);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student_ID";
            // 
            // txtStudID
            // 
            this.txtStudID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStudID.Location = new System.Drawing.Point(157, 46);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(196, 25);
            this.txtStudID.TabIndex = 3;
            this.txtStudID.Text = "Insert TP number here...";
            // 
            // StartdatePicker
            // 
            this.StartdatePicker.Location = new System.Drawing.Point(570, 40);
            this.StartdatePicker.Name = "StartdatePicker";
            this.StartdatePicker.Size = new System.Drawing.Size(275, 29);
            this.StartdatePicker.TabIndex = 5;
            // 
            // EnddatePicker
            // 
            this.EnddatePicker.Location = new System.Drawing.Point(570, 88);
            this.EnddatePicker.Name = "EnddatePicker";
            this.EnddatePicker.Size = new System.Drawing.Size(275, 29);
            this.EnddatePicker.TabIndex = 8;
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAssign.Location = new System.Drawing.Point(754, 152);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(108, 34);
            this.btnAssign.TabIndex = 9;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(633, 151);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cboRooms
            // 
            this.cboRooms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRooms.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboRooms.FormattingEnabled = true;
            this.cboRooms.Location = new System.Drawing.Point(156, 101);
            this.cboRooms.Name = "cboRooms";
            this.cboRooms.Size = new System.Drawing.Size(196, 25);
            this.cboRooms.TabIndex = 11;
            this.cboRooms.Text = "Pick an avaliable Unit...";
            this.cboRooms.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(658, 509);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 37);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(818, 509);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 37);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Location = new System.Drawing.Point(480, 529);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(125, 36);
            this.btnShow.TabIndex = 19;
            this.btnShow.Text = "Show requests";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gbRequest
            // 
            this.gbRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.gbRequest.Controls.Add(this.listView1);
            this.gbRequest.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbRequest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbRequest.Location = new System.Drawing.Point(12, 152);
            this.gbRequest.Name = "gbRequest";
            this.gbRequest.Size = new System.Drawing.Size(593, 371);
            this.gbRequest.TabIndex = 20;
            this.gbRequest.TabStop = false;
            this.gbRequest.Text = "Students Requests:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(581, 307);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // blUnitNo
            // 
            this.blUnitNo.AutoSize = true;
            this.blUnitNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blUnitNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.blUnitNo.Location = new System.Drawing.Point(35, 101);
            this.blUnitNo.Name = "blUnitNo";
            this.blUnitNo.Size = new System.Drawing.Size(115, 22);
            this.blUnitNo.TabIndex = 21;
            this.blUnitNo.Text = "Unit Number";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStartDate.Location = new System.Drawing.Point(439, 46);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(105, 22);
            this.lblStartDate.TabIndex = 22;
            this.lblStartDate.Text = "Start Date :";
            // 
            // lblEnddate
            // 
            this.lblEnddate.AutoSize = true;
            this.lblEnddate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnddate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEnddate.Location = new System.Drawing.Point(439, 94);
            this.lblEnddate.Name = "lblEnddate";
            this.lblEnddate.Size = new System.Drawing.Size(97, 22);
            this.lblEnddate.TabIndex = 23;
            this.lblEnddate.Text = "End Date :";
            this.lblEnddate.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUnit.Location = new System.Drawing.Point(639, 212);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(142, 22);
            this.lblUnit.TabIndex = 24;
            this.lblUnit.Text = "Avaliable Units :";
            // 
            // lblfilter
            // 
            this.lblfilter.AutoSize = true;
            this.lblfilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblfilter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblfilter.Location = new System.Drawing.Point(633, 240);
            this.lblfilter.Name = "lblfilter";
            this.lblfilter.Size = new System.Drawing.Size(45, 19);
            this.lblfilter.TabIndex = 25;
            this.lblfilter.Text = "Filter";
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxA.Location = new System.Drawing.Point(711, 237);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(80, 25);
            this.checkBoxA.TabIndex = 26;
            this.checkBoxA.Text = "Block A";
            this.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxB.Location = new System.Drawing.Point(797, 237);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(79, 25);
            this.checkBoxB.TabIndex = 27;
            this.checkBoxB.Text = "Block B";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // lstUnits
            // 
            this.lstUnits.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstUnits.FormattingEnabled = true;
            this.lstUnits.ItemHeight = 19;
            this.lstUnits.Items.AddRange(new object[] {
            "A-01-01",
            "A-01-02",
            "A-02-03",
            "A-05-02",
            "B-01-02",
            "B-03-04",
            "B-04-02"});
            this.lstUnits.Location = new System.Drawing.Point(639, 268);
            this.lstUnits.Name = "lstUnits";
            this.lstUnits.Size = new System.Drawing.Size(243, 156);
            this.lstUnits.TabIndex = 28;
            // 
            // Roomassign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.lstUnits);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.checkBoxA);
            this.Controls.Add(this.lblfilter);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblEnddate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.blUnitNo);
            this.Controls.Add(this.gbRequest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cboRooms);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.EnddatePicker);
            this.Controls.Add(this.StartdatePicker);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.lblStudentID);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Roomassign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room assignment";
            this.Load += new System.EventHandler(this.Roomasign_Load);
            this.gbRequest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.DateTimePicker StartdatePicker;
        private System.Windows.Forms.DateTimePicker EnddatePicker;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cboRooms;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox gbRequest;
        private System.Windows.Forms.Label blUnitNo;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEnddate;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblfilter;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.ListBox lstUnits;
        private System.Windows.Forms.ListView listView1;
    }
}