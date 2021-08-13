using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dorm_managment_system
{
    public partial class ChangeRoom : Form
    {
        private GroupBox gbChroom;
        private TextBox txtStudID;
        private Label lblStudentID;
        private Label lblAproval;
        private Label blUnitNo;
        private ComboBox cboRooms;
        private Button btnExit;
        private Button btnBack;
        private Button btnApprove;
        private Button btnDecline;
        private ListView listView1;
        private Button btnShow;

        public ChangeRoom()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.gbChroom = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblAproval = new System.Windows.Forms.Label();
            this.blUnitNo = new System.Windows.Forms.Label();
            this.cboRooms = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbChroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChroom
            // 
            this.gbChroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.gbChroom.Controls.Add(this.listView1);
            this.gbChroom.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbChroom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbChroom.Location = new System.Drawing.Point(32, 21);
            this.gbChroom.Name = "gbChroom";
            this.gbChroom.Size = new System.Drawing.Size(846, 305);
            this.gbChroom.TabIndex = 34;
            this.gbChroom.TabStop = false;
            this.gbChroom.Text = "Change Room Requests :";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(830, 271);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtStudID
            // 
            this.txtStudID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStudID.Location = new System.Drawing.Point(208, 373);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(196, 25);
            this.txtStudID.TabIndex = 37;
            this.txtStudID.Text = "Insert TP number here...";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStudentID.Location = new System.Drawing.Point(56, 373);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(103, 22);
            this.lblStudentID.TabIndex = 36;
            this.lblStudentID.Text = "Student_ID";
            // 
            // lblAproval
            // 
            this.lblAproval.AutoSize = true;
            this.lblAproval.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAproval.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAproval.Location = new System.Drawing.Point(56, 413);
            this.lblAproval.Name = "lblAproval";
            this.lblAproval.Size = new System.Drawing.Size(268, 22);
            this.lblAproval.TabIndex = 38;
            this.lblAproval.Text = "If approved pick a room please:";
            // 
            // blUnitNo
            // 
            this.blUnitNo.AutoSize = true;
            this.blUnitNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blUnitNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.blUnitNo.Location = new System.Drawing.Point(56, 470);
            this.blUnitNo.Name = "blUnitNo";
            this.blUnitNo.Size = new System.Drawing.Size(115, 22);
            this.blUnitNo.TabIndex = 40;
            this.blUnitNo.Text = "Unit Number";
            // 
            // cboRooms
            // 
            this.cboRooms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRooms.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboRooms.FormattingEnabled = true;
            this.cboRooms.Location = new System.Drawing.Point(208, 467);
            this.cboRooms.Name = "cboRooms";
            this.cboRooms.Size = new System.Drawing.Size(196, 25);
            this.cboRooms.TabIndex = 39;
            this.cboRooms.Text = "Pick an avaliable Unit...";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(792, 579);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 37);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(654, 579);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 37);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApprove.Location = new System.Drawing.Point(258, 529);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(111, 37);
            this.btnApprove.TabIndex = 44;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnDecline
            // 
            this.btnDecline.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecline.Location = new System.Drawing.Point(97, 529);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(123, 37);
            this.btnDecline.TabIndex = 43;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Location = new System.Drawing.Point(747, 332);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(125, 36);
            this.btnShow.TabIndex = 45;
            this.btnShow.Text = "Show requests";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ChangeRoom
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(932, 650);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.blUnitNo);
            this.Controls.Add(this.cboRooms);
            this.Controls.Add(this.lblAproval);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.gbChroom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChangeRoom_Load);
            this.gbChroom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ChangeRoom_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //Add column header
            listView1.Columns.Add("Student_ID", 100);
            listView1.Columns.Add("Student name", 100);
            listView1.Columns.Add("Requested Block", 100);
            listView1.Columns.Add("Present Unit", 100);
            listView1.Columns.Add("Start Date", 100);
            listView1.Columns.Add("End Date", 100);
            //Add items in the listview
            string[] arr = new string[6];
            ListViewItem itm;

            //Add first item
            arr[0] = "TP012345";
            arr[1] = "James Upper";
            arr[2] = "A";
            arr[3] = "A-01-01";
            arr[4] = "1 Jul, 2021";
            arr[5] = "16 Dec, 2021";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add second item
            arr[0] = "TP023466";
            arr[1] = "Reza Ali";
            arr[2] = "B";
            arr[3] = "B-02-02";
            arr[4] = "20 Aug, 2021";
            arr[5] = "2 Jan, 2022";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string Student_ID = null;
            string Student_Name = null;
            string ReqBlock = null;
            string Presunit = null;        
            string StartD = null;
            string EndD = null ;

            Student_ID = listView1.SelectedItems[0].SubItems[0].Text;
            Student_Name = listView1.SelectedItems[0].SubItems[1].Text;
            ReqBlock = listView1.SelectedItems[0].SubItems[2].Text;
            Presunit = listView1.SelectedItems[0].SubItems[3].Text;
            StartD = listView1.SelectedItems[0].SubItems[4].Text;
            EndD =  listView1.SelectedItems[0].SubItems[5].Text;
            MessageBox.Show(Student_ID + " , " + Student_Name + " , " + ReqBlock);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Warden_Menu f3 = new Warden_Menu(); // Instantiate a Form object.
            f3.ShowDialog(); // Show Form and          
            this.Close(); // closes the current Form instance.
        }
    }
}
