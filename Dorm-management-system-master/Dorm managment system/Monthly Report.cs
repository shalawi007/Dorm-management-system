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
            
           
        }

        private void btnShreportA_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShreportB_Click(object sender, EventArgs e)
        {
            
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
    }
    
}
