using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dorm_managment_system
{
    public partial class Accomodation_Request : Form
    {

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
