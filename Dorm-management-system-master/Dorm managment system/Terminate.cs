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
    public partial class Terminate : Form
    {
      
        Database dbconnection = new Database();
        String query;
        public Terminate()
        {
            InitializeComponent();
        }

        private void Terminate_Load(object sender, EventArgs e)
        {

            query = "SELECT Book_ID, Std_ID, Term_Reason FROM Booking WHERE Term_Reason IS NOT NULL";
            DataSet ds = dbconnection.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

            
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            if(txtBookID .Text != "")
            {
                String Book_ID = txtBookID.Text;

                query = "UPDATE Booking SET Term_Reason = NULL WHERE Book_ID = ('" + Book_ID + "')";
                dbconnection.setData(query);
            }
            else
            {
                MessageBox.Show("Fill all fields correctly!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtStudID_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
