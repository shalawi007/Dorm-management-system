using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            cboBlock.Items.Add("Block A");
            cboBlock.Items.Add("Block B");
        }

        private void Monthly_Report_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'DataSetReport.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.Fill(this.DataSetReport.DataTable1);
            //this.reportViewer1.RefreshReport();
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

        private void btnreportA_Click(object sender, EventArgs e)
        {
            if (cboBlock.Text == "Block A")
            {
                this.DataTable1TableAdapter.FillByA(this.DataSetReport.DataTable1);
                this.reportViewer1.RefreshReport();
                if (chOccupied.Checked)
                {
                    this.DataTable1TableAdapter.FillByAO(this.DataSetReport.DataTable1);
                    this.reportViewer1.RefreshReport();
                }
                else if (chVacant.Checked)
                {
                    this.DataTable1TableAdapter.FillByAV(this.DataSetReport.DataTable1);
                    this.reportViewer1.RefreshReport();
                }
            }
            else if (cboBlock.Text == "Block B")
            {
                this.DataTable1TableAdapter.FillByB(this.DataSetReport.DataTable1);
                this.reportViewer1.RefreshReport();
                if (chOccupied.Checked)
                {
                    this.DataTable1TableAdapter.FillByBO(this.DataSetReport.DataTable1);
                    this.reportViewer1.RefreshReport();
                }
                else if (chVacant.Checked)
                {
                    this.DataTable1TableAdapter.FillByBV(this.DataSetReport.DataTable1);
                    this.reportViewer1.RefreshReport();
                }
            }
            

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Warden_Menu f3 = new Warden_Menu(); // Instantiate a Form object.
            f3.ShowDialog(); // Show Form and          
            this.Close(); // closes the current Form instance.
        }
    }

    
    
    
}
