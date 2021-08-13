
namespace Dorm_managment_system
{
    partial class Terminate
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
            this.gbTerminate = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbTerminate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTerminate
            // 
            this.gbTerminate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.gbTerminate.Controls.Add(this.listView1);
            this.gbTerminate.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTerminate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbTerminate.Location = new System.Drawing.Point(41, 12);
            this.gbTerminate.Name = "gbTerminate";
            this.gbTerminate.Size = new System.Drawing.Size(715, 337);
            this.gbTerminate.TabIndex = 35;
            this.gbTerminate.TabStop = false;
            this.gbTerminate.Text = "Termination Requests :";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(683, 288);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInfo.Location = new System.Drawing.Point(71, 368);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(349, 22);
            this.lblInfo.TabIndex = 41;
            this.lblInfo.Text = "Upon completing the review please write :";
            // 
            // txtStudID
            // 
            this.txtStudID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStudID.Location = new System.Drawing.Point(238, 411);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(196, 25);
            this.txtStudID.TabIndex = 40;
            this.txtStudID.Text = "Insert TP number here...";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStudentID.Location = new System.Drawing.Point(109, 411);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(123, 22);
            this.lblStudentID.TabIndex = 39;
            this.lblStudentID.Text = "1. Student_ID";
            // 
            // btnTerminate
            // 
            this.btnTerminate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTerminate.Location = new System.Drawing.Point(482, 404);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(164, 37);
            this.btnTerminate.TabIndex = 47;
            this.btnTerminate.Text = "Terminate Contract";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(608, 510);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 37);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(466, 510);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 37);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Terminate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(781, 577);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.gbTerminate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Terminate";
            this.Text = "Terminate";
            this.Load += new System.EventHandler(this.Terminate_Load);
            this.gbTerminate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTerminate;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listView1;
    }
}