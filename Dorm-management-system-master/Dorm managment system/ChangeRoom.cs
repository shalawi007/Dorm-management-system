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
        Database dbConnection = new Database();
        String query;

        private GroupBox gbChroom;
        private TextBox txtBookID;
        private Label lblBookID;
        private Label lblAproval;
        private Label blUnitNo;
        private ComboBox cboRooms;
        private Button btnBack;
        private Button btnApprove;
        private DataGridView dataGridView1;
        private TextBox txtCurrentRoom;
        private Label lblcurroom;
        private Button button2;
        private Button btnDecline;

        public ChangeRoom()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.gbChroom = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblAproval = new System.Windows.Forms.Label();
            this.blUnitNo = new System.Windows.Forms.Label();
            this.cboRooms = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.txtCurrentRoom = new System.Windows.Forms.TextBox();
            this.lblcurroom = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gbChroom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbChroom
            // 
            this.gbChroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.gbChroom.Controls.Add(this.dataGridView1);
            this.gbChroom.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.gbChroom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbChroom.Location = new System.Drawing.Point(32, 29);
            this.gbChroom.Name = "gbChroom";
            this.gbChroom.Size = new System.Drawing.Size(682, 305);
            this.gbChroom.TabIndex = 7;
            this.gbChroom.TabStop = false;
            this.gbChroom.Text = "Change Room Requests :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(670, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBookID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBookID.Location = new System.Drawing.Point(268, 354);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(196, 25);
            this.txtBookID.TabIndex = 0;
            this.txtBookID.Text = "Insert Booking ID here...";
            this.txtBookID.Click += new System.EventHandler(this.txtBookID_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBookID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBookID.Location = new System.Drawing.Point(56, 357);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(115, 22);
            this.lblBookID.TabIndex = 8;
            this.lblBookID.Text = "Booking ID :";
            // 
            // lblAproval
            // 
            this.lblAproval.AutoSize = true;
            this.lblAproval.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAproval.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAproval.Location = new System.Drawing.Point(56, 394);
            this.lblAproval.Name = "lblAproval";
            this.lblAproval.Size = new System.Drawing.Size(272, 22);
            this.lblAproval.TabIndex = 9;
            this.lblAproval.Text = "If approved fill required details :";
            // 
            // blUnitNo
            // 
            this.blUnitNo.AutoSize = true;
            this.blUnitNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.blUnitNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.blUnitNo.Location = new System.Drawing.Point(56, 480);
            this.blUnitNo.Name = "blUnitNo";
            this.blUnitNo.Size = new System.Drawing.Size(120, 22);
            this.blUnitNo.TabIndex = 11;
            this.blUnitNo.Text = "Unit Number:";
            // 
            // cboRooms
            // 
            this.cboRooms.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboRooms.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboRooms.FormattingEnabled = true;
            this.cboRooms.Location = new System.Drawing.Point(268, 477);
            this.cboRooms.Name = "cboRooms";
            this.cboRooms.Size = new System.Drawing.Size(196, 25);
            this.cboRooms.TabIndex = 2;
            this.cboRooms.Text = "Pick an avaliable Unit...";
            this.cboRooms.SelectedIndexChanged += new System.EventHandler(this.cboRooms_SelectedIndexChanged);
            this.cboRooms.Click += new System.EventHandler(this.cboRooms_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnBack.Location = new System.Drawing.Point(32, 589);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnApprove.Location = new System.Drawing.Point(617, 555);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(97, 37);
            this.btnApprove.TabIndex = 3;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDecline.Location = new System.Drawing.Point(479, 555);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(97, 37);
            this.btnDecline.TabIndex = 4;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // txtCurrentRoom
            // 
            this.txtCurrentRoom.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCurrentRoom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCurrentRoom.Location = new System.Drawing.Point(268, 428);
            this.txtCurrentRoom.Name = "txtCurrentRoom";
            this.txtCurrentRoom.Size = new System.Drawing.Size(196, 25);
            this.txtCurrentRoom.TabIndex = 1;
            this.txtCurrentRoom.Text = "Insert Room Number here...";
            this.txtCurrentRoom.Enter += new System.EventHandler(this.txtCurrentRoom_Enter);
            // 
            // lblcurroom
            // 
            this.lblcurroom.AutoSize = true;
            this.lblcurroom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblcurroom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblcurroom.Location = new System.Drawing.Point(56, 428);
            this.lblcurroom.Name = "lblcurroom";
            this.lblcurroom.Size = new System.Drawing.Size(173, 22);
            this.lblcurroom.TabIndex = 10;
            this.lblcurroom.Text = "Current Room No. :";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(720, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangeRoom
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(750, 650);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblcurroom);
            this.Controls.Add(this.txtCurrentRoom);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.blUnitNo);
            this.Controls.Add(this.cboRooms);
            this.Controls.Add(this.lblAproval);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.gbChroom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChangeRoom_Load);
            this.gbChroom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ChangeRoom_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            query = "SELECT Book_ID, Std_ID AS 'Student ID',Room_ID AS 'Current Room',[Changed Block] AS 'Requested Block'FROM Booking WHERE Booking.[Changed Block] IS NOT NULL";
            DataSet ds = dbConnection.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void StyleDatagridview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
                        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Warden_Menu f3 = new Warden_Menu(); // Instantiate a Form object.
            f3.ShowDialog(); // Show Form and          
            this.Close(); // closes the current Form instance.
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            String Book_ID = txtBookID.Text;
            String CurrentRoom = txtCurrentRoom.Text;
            String Rooms_no = cboRooms.Text;

            if (txtBookID.Text != "" && txtCurrentRoom.Text != "" && cboRooms.Text != "")
            {   
                ///Updating Room to occupied and Vacant
                query = "UPDATE Rooms SET Status = ('Occupied') WHERE ID = ('" + Rooms_no + "')";
                dbConnection.setData(query);

                query = "UPDATE Rooms SET Status = ('Vacant') WHERE ID = ('" + CurrentRoom + "')";
                dbConnection.setData(query);

                //Assign the room 
                query = "UPDATE Booking SET Room_ID = ('" + CurrentRoom + "') WHERE Book_ID = ('" + Book_ID + "')";
                dbConnection.setData(query);
                //Updating the Student's Block
                query = "UPDATE Booking SET Req_Block = [Changed Block]  WHERE Book_ID = ('" + Book_ID + "')";
                dbConnection.setData(query);
                //deleting Changed Block Value
                query = "UPDATE Booking SET [Changed Block] = NULL WHERE Book_ID = ('" + Book_ID + "')";
                dbConnection.setData(query);

                ChangeRoom_Load(this, null);

            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            String Book_ID = txtBookID.Text;
            
            if (txtBookID.Text != "")
            {               
                //deleting Changed Block Value
                query = "UPDATE Booking SET [Changed Block] = NUll  WHERE Book_ID = ('" + Book_ID + "')";
                dbConnection.setData(query);

                ChangeRoom_Load(this, null);

            }
            else
            {
                MessageBox.Show("Fill required Fields", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void cboRooms_Click(object sender, EventArgs e)
        {
            query = "Select * From Rooms Where Status = 'Vacant'";
            DataSet ds = dbConnection.getData(query);
            cboRooms.DataSource = ds.Tables[0];
            cboRooms.DisplayMember = "ID";
            cboRooms.ValueMember = "Status";
        }

        private void txtBookID_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
        }

        private void txtCurrentRoom_Enter(object sender, EventArgs e)
        {
            txtCurrentRoom.Clear();
        }

        private void txtBookID_Enter(object sender, EventArgs e)
        {
            txtBookID.Clear();
        }
    }
}
