using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dorm_managment_system
{
    public partial class Review_Feedback : Form
    {
        Database dbConnection = new Database();
        String query;
        public Review_Feedback()
        {
            InitializeComponent();
            combostatus.Items.Add("In Process");
            combostatus.Items.Add("Completed");
        }

        private void lblstu_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Warden_Menu Check = new Warden_Menu();
            Check.Show();

        }
        
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Review_Feedback_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            query = "Select Feedback_ID,Student_ID, Room_ID,Feedback,Description,Req_Status AS [Status] FROM Feedback ";
            DataSet ds = dbConnection.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Warden_Menu f3 = new Warden_Menu(); // Instantiate a Form object.
            f3.ShowDialog(); // Show Form and          
            this.Close(); // closes the current Form instance.
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtstudentid.Text != "" && txtfeedbackid.Text != "" && combostatus.Text != "" && txtdescrp.Text != "" )
            {
                String Student_ID = txtstudentid.Text;
                String Feedback = txtfeedbackid.Text;
                String Desc = txtdescrp.Text;
                String Status  = combostatus.Text;

                //Inserting data about the Feedback  
                query = "UPDATE Feedback SET Description = ('" + Desc + "'), Req_Status = ('" + Status + "') WHERE Feedback_ID = ('" + Feedback + "') AND Student_ID = ('" + Student_ID + "')";
                dbConnection.setData(query);
               
                Review_Feedback_Load(this, null);





            }
            else
            {
                MessageBox.Show("Please enter correct information. ", " Error! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {

        }

        private void combostatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdescrp_Enter(object sender, EventArgs e)
        {
            txtdescrp.Clear();
        }
    }
    
}
