using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dorm_managment_system
{
    public partial class Monthly_Report : Form
    {
        public Monthly_Report()
        {
            InitializeComponent();
        }

        private void Monthly_Report_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        private void btnShreportA_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            //Add column header
            listView1.Columns.Add("Unit Number", 100);
            listView1.Columns.Add("Student_ID", 100);
            listView1.Columns.Add("Student Name", 100);
            listView1.Columns.Add("Start Date", 100);
            listView1.Columns.Add("End Date", 100);
            listView1.Columns.Add("Room status", 100);
            //Add items in the listview
            string[] arr = new string[6];
            ListViewItem itm;

            //Add first item
            arr[0] = "A-01-01";
            arr[1] = "TP012345";
            arr[2] = "James Upper";
            arr[3] = "1 Jul, 2021";
            arr[4] = "16 Dec, 2021";
            arr[5] = "Occupied";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add second item
            arr[0] = "A-01-02";
            arr[1] = "TP023466";
            arr[2] = "Cena John";
            arr[3] = "20 Mar, 2021";
            arr[4] = "2 Jul, 2021";
            arr[5] = "Vacant";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }

        private void btnShreportB_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            //Add column header
            listView1.Columns.Add("Unit Number", 100);
            listView1.Columns.Add("Student_ID", 100);
            listView1.Columns.Add("Student Name", 100);
            listView1.Columns.Add("Start Date", 100);
            listView1.Columns.Add("End Date", 100);
            listView1.Columns.Add("Room status", 100);
            //Add items in the listview
            string[] arr = new string[6];
            ListViewItem itm;

            //Add first item
            arr[0] = "B-04-01";
            arr[1] = "TP023456";
            arr[2] = "Max Schuhmacher";
            arr[3] = "1 Jul, 2021";
            arr[4] = "16 Dec, 2021";
            arr[5] = "Occupied";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add second item
            arr[0] = "B-01-02";
            arr[1] = "TP023466";
            arr[2] = "Peter Neuer";
            arr[3] = "20 Mar, 2021";
            arr[4] = "2 Jul, 2021";
            arr[5] = "Vacant";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
    
}
