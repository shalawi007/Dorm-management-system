﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dorm_managment_system
{
    public partial class Roomassign : Form
    {
        public Roomassign()
        {
            InitializeComponent();
        }

        private void Roomasign_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //Add column header
            listView1.Columns.Add("Student_ID", 100);
            listView1.Columns.Add("Student name", 70);
            listView1.Columns.Add("Requested Block", 70);
            listView1.Columns.Add("Start Date", 100);
            listView1.Columns.Add("End Date", 100);
            //Add items in the listview
            string[] arr = new string[5];
            ListViewItem itm;

            //Add first item
            arr[0] = "TP012345";
            arr[1] = "James Upper";
            arr[2] = "A";
            arr[3] = "1 Jul, 2021";
            arr[4] = "16 Dec, 2021";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add second item
            arr[0] = "TP023466";
            arr[1] = "Reza Ali";
            arr[2] = "B";
            arr[3] = "20 Aug, 2021";
            arr[4] = "2 Jan, 2022";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
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
            string Student_ID = listView1.SelectedItems[0].SubItems[0].Text;
            string Student_Name = listView1.SelectedItems[0].SubItems[1].Text;
            string ReqBlock = listView1.SelectedItems[0].SubItems[2].Text;
            MessageBox.Show(Student_ID + " , " + Student_Name + " , " + ReqBlock);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}