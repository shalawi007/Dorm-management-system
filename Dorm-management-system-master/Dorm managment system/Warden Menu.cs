using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dorm_managment_system
{
    public partial class Warden_Menu : Form
    {
        public Warden_Menu()
        {
            InitializeComponent();
            if (Instances.values.loggedInWarden != null) {
                label1.Text = Instances.values.loggedInWarden.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Warden_Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblstu_Click(object sender, EventArgs e)
        {

        }

        private void btnssignacc_Click(object sender, EventArgs e)
        {
            Hide();
            var menu = new Roomassign();
            menu.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnwarroomreq_Click(object sender, EventArgs e)
        {
            Hide();
            var menu = new ChangeRoom();
            menu.ShowDialog();
            Close();
        }

        private void btnwartermacc_Click(object sender, EventArgs e)
        {
            Hide();
            var menu = new Terminate();
            menu.ShowDialog();
            Close();
        }

        private void btnwarfeed_Click(object sender, EventArgs e)
        {

        }

        private void btnaccreport_Click(object sender, EventArgs e)
        {
            Hide();
            var menu = new Monthly_Report();
            menu.ShowDialog();
            Close();
        }
    }
}
