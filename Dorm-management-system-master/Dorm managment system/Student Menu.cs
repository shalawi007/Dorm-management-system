using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorm_managment_system
{
    public partial class Student_Menu : Form
    {
        public Student_Menu()
        {
            InitializeComponent();
            if (Instances.values.loggedInStudent != null)
            {
                label1.Text = Instances.values.loggedInStudent.Name;
            }
        }

        private void btnbookacc_Click(object sender, EventArgs e)
        {
            Hide();
            var menu = new Accomodation_Request();
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

        private void btnstuaccreq_Click(object sender, EventArgs e)
        {
            Hide();
            var menu = new Change_Room_Request();
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
