using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dorm_managment_system
{
    public partial class Student_Menu : Form
    {
        public Student_Menu()
        {
            InitializeComponent();
            if (Instances.values.loggedInStudent != null) {
                label1.Text = Instances.values.loggedInStudent.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var menu = new Accomodation_Request();
            menu.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblstu_Click(object sender, EventArgs e)
        {

        }

        private void Student_Menu_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
              
        private void btnstuaccreq_Click(object sender, EventArgs e)
        {
            Hide();
            var menu = new Change_Room_Request();
            menu.ShowDialog();
            Close();
        }

        private void btnstutermacc_Click(object sender, EventArgs e)
        {
            Hide();
            var menu = new Termination_of_Accomodation();
            menu.ShowDialog();
            Close();
        }

        private void btnstufeed_Click(object sender, EventArgs e)
        {
            Hide();
            var menu = new Accomodation_Feedback();
            menu.ShowDialog();
            Close();
        }
    }
}
