
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
            this.lblStudID = new System.Windows.Forms.Label();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboRooms = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbRequest = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.blUnitNo = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.gbRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudID
            // 
            this.lblStudID.AutoSize = true;
            this.lblStudID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStudID.Location = new System.Drawing.Point(35, 436);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(113, 22);
            this.lblStudID.TabIndex = 1;
            this.lblStudID.Text = "Student_ID :";
            // 
            // txtStudID
            // 
            this.txtStudID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStudID.Location = new System.Drawing.Point(175, 433);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(196, 25);
            this.txtStudID.TabIndex = 3;
            this.txtStudID.Text = "Insert TP number here...";
            this.txtStudID.Click += new System.EventHandler(this.txtStudID_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAssign.Location = new System.Drawing.Point(656, 456);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(108, 34);
            this.btnAssign.TabIndex = 9;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(546, 455);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboRooms
            // 
            this.cboRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRooms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRooms.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboRooms.FormattingEnabled = true;
            this.cboRooms.Location = new System.Drawing.Point(546, 379);
            this.cboRooms.Name = "cboRooms";
            this.cboRooms.Size = new System.Drawing.Size(196, 25);
            this.cboRooms.TabIndex = 11;
            this.cboRooms.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cboRooms.Click += new System.EventHandler(this.cboRooms_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(162, 516);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 37);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(25, 516);
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
            this.btnShow.Location = new System.Drawing.Point(639, 516);
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
            this.gbRequest.Controls.Add(this.dataGridView1);
            this.gbRequest.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbRequest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbRequest.Location = new System.Drawing.Point(25, 12);
            this.gbRequest.Name = "gbRequest";
            this.gbRequest.Size = new System.Drawing.Size(750, 333);
            this.gbRequest.TabIndex = 20;
            this.gbRequest.TabStop = false;
            this.gbRequest.Text = "Students Requests:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(726, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // blUnitNo
            // 
            this.blUnitNo.AutoSize = true;
            this.blUnitNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blUnitNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.blUnitNo.Location = new System.Drawing.Point(398, 379);
            this.blUnitNo.Name = "blUnitNo";
            this.blUnitNo.Size = new System.Drawing.Size(142, 22);
            this.blUnitNo.TabIndex = 21;
            this.blUnitNo.Text = "Avaliable Units :";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBookID.Location = new System.Drawing.Point(35, 382);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(115, 22);
            this.lblBookID.TabIndex = 22;
            this.lblBookID.Text = "Booking ID :";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(175, 379);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(196, 29);
            this.txtBookID.TabIndex = 24;
            // 
            // Roomassign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(793, 577);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.blUnitNo);
            this.Controls.Add(this.gbRequest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cboRooms);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.lblStudID);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Roomassign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room assignment";
            this.Load += new System.EventHandler(this.Roomasign_Load);
            this.gbRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStudID;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cboRooms;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox gbRequest;
        private System.Windows.Forms.Label blUnitNo;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBookID;
    }
}