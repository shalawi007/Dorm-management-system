using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dorm_managment_system
{
    public partial class Roomassign : Form
    {
        Database dbConnection = new Database();
        String query;

        public Roomassign()
        {
            InitializeComponent();
        }

        private void Roomasign_Load(object sender, EventArgs e)
        {

            query = "Select Book_ID,Std_ID,Start_Date,End_Date,Req_Block From Booking where Room_ID IS Null";
            DataSet ds = dbConnection.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

            ///query = "Select ID From Rooms where Status = 'Vacant'";
            ///DataSet ds = dbConnection.getData(query);
            ///cboRooms.DataSource = ds;



            /// listView1.View = View.Details;
            ///listView1.GridLines = true;
            /// listView1.FullRowSelect = true;
            //Add column header
            /// listView1.Columns.Add("Student_ID", 100);
            ///  listView1.Columns.Add("Student name", 70);
            ///  listView1.Columns.Add("Requested Block", 70);
            /// listView1.Columns.Add("Start Date", 100);
            ///listView1.Columns.Add("End Date", 100);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            

            //Add items in the listview
            //string[] arr = new string[5];
            ///ListViewItem itm;

            

            

            ////foreach (var row in ds.Tables[0].Rows)
            {
                //Add first item

                //arr[0] = "TP012345";
                //arr[1] = "James Upper";
                //arr[2] = "A";
                //arr[3] = "1 Jul, 2021";
                //arr[4] = "16 Dec, 2021";
                //itm = new ListViewItem(arr);
                //listView1.Items.Add(itm);
            }

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

        private void lstUnits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if(txtBookID.Text != "" && txtStudID.Text != "" && cboRooms.Text != "")
            {
                String Book_ID = txtBookID.Text;
                String Rooms_no = cboRooms.Text;
                
                //Assign the room 
                query = "UPDATE Booking SET Room_ID = ('" + Rooms_no + "') WHERE Book_ID = ('" + Book_ID + "')";
                dbConnection.setData(query);
                ///Updating Room to occupied
                query = "UPDATE Rooms SET Status = ('Occupied') WHERE ID = ('" + Rooms_no + "')";
                dbConnection.setData(query);
                Roomasign_Load(this, null);
                
                    
                  
          

            }                                 
            else                             
            {
                MessageBox.Show("Fill All Fields", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboRooms_Click(object sender, EventArgs e)
        { 
            query = "Select * From Rooms Where Status = 'Vacant'";
            DataSet ds = dbConnection.getData(query);
            cboRooms.DataSource = ds.Tables[0];
            cboRooms.DisplayMember = "ID";
            cboRooms.ValueMember = "Status";
        }

        private void txtStudID_Click(object sender, EventArgs e)
        {
            txtStudID.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudID.Clear();
            txtBookID.Clear();
            cboRooms.SelectedIndex = -1;
        }
    }
}
