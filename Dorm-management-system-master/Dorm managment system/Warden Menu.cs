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
    }
}
