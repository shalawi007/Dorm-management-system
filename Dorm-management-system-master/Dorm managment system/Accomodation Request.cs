using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dorm_managment_system.Models;

namespace Dorm_managment_system
{
    public partial class Accomodation_Request : Form
    {

        String pickedBlock = "";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
         );

        public Accomodation_Request()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Accomodation_Request_Load(object sender, EventArgs e)
        {
            lstFacilities.Items.Clear();
            rdoBlockB.Checked = false;
            rdoBlockA.Checked = false;
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            EndDatePicker.Value = StartDatePicker.Value.AddDays(119);
        }

        private void rdoBlockA_CheckedChanged(object sender, EventArgs e)
        {
            radioPicked();
        }

        private void rdoBlockB_CheckedChanged(object sender, EventArgs e)
        {
            radioPicked();
        }

        private void radioPicked()
        {
            lstFacilities.Items.Clear();

            if (rdoBlockA.Checked)
            {
                pickedBlock = "Block A";
                lstFacilities.Items.Add("Swimming pool");
                lstFacilities.Items.Add("Gym");
            }
            else if (rdoBlockB.Checked)
            {
                pickedBlock = "Block B";
                lstFacilities.Items.Add("Walking Area");
                lstFacilities.Items.Add("Big dorms");
                lstFacilities.Items.Add("Mainenence");

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Booking.requestBooking(
                 StartDatePicker.Value.ToString("yyyy-MM-dd"),
                 EndDatePicker.Value.ToString("yyyy-MM-dd"),
                 pickedBlock
                );
        }

        private void btnFacilities_Click(object sender, EventArgs e)
        {
            if (rdoBlockA.Checked)
            {
                lstFacilities.Items.Clear();
                lstFacilities.Items.Add("Wifi");
                lstFacilities.Items.Add("Cafeteria");
                lstFacilities.Items.Add("Gym");
                lstFacilities.Items.Add("Common area");
                lstFacilities.Items.Add("Swimming pool");
                lstFacilities.Items.Add("Kitchen");
                lstFacilities.Items.Add("Laundry room");
                lstFacilities.Items.Add("Showers");
                lstFacilities.Items.Add("Air-conditioned rooms");
            }
            else
            {
                lstFacilities.Items.Clear();
                lstFacilities.Items.Add("Air-conditioned rooms");
                lstFacilities.Items.Add("Cafeteria");
                lstFacilities.Items.Add("Gym");
                lstFacilities.Items.Add("Common area");
                lstFacilities.Items.Add("Kitchen");
                lstFacilities.Items.Add("Laundry room");
                lstFacilities.Items.Add("Showers");
                lstFacilities.Items.Add("Wifi");
            }

        }
    }
}
