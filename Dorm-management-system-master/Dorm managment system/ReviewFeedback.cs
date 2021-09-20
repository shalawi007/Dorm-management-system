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
        }

        private void lblstu_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ReviewFeedback_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            query = "Select Feedback_ID, Description, Student_ID, Room_ID, where Req_Status IS Null";
            DataSet ds = dbConnection.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    
}
