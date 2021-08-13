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
    }
    
}
