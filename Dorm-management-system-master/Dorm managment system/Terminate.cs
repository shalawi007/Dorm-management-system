using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dorm_managment_system
{
    public partial class Terminate : Form
    {
        public Terminate()
        {
            InitializeComponent();
        }

        private void Terminate_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //Add column header
            listView1.Columns.Add("Student_ID", 100);
            listView1.Columns.Add("Student name", 100);
            listView1.Columns.Add("Present unit", 100);
            listView1.Columns.Add("Start Date", 100);
            listView1.Columns.Add("End Date", 100);
            listView1.Columns.Add("Reasons", 100);
            //Add items in the listview
            string[] arr = new string[6];
            ListViewItem itm;

            //Add first item
            arr[0] = "TP012345";
            arr[1] = "James Upper";
            arr[2] = "A-01-02";
            arr[3] = "1 Jul, 2021";
            arr[4] = "16 Dec, 2021";
            arr[5] = "Finical issues";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add second item
            arr[0] = "TP023466";
            arr[1] = "Reza Ali";
            arr[2] = "B-02-02";
            arr[3] = "20 Aug, 2021";
            arr[4] = "2 Jan, 2022";
            arr[5] = "Visa Overstay";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    string Student_ID = listView1.SelectedItems[0].SubItems[0].Text;
                    string Student_Name = listView1.SelectedItems[0].SubItems[1].Text;
                    string Presunit = listView1.SelectedItems[0].SubItems[2].Text;
                    MessageBox.Show(Student_ID + " , " + Student_Name + " , " + Presunit + "Terminated");
                    listView1.Items[i].Remove();
                    i--;
                }
                else
                {
                    MessageBox.Show("Retry again");

                }

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
    }
}
