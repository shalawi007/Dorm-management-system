using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Dorm_managment_system
{
    public partial class Termination_of_Accomodation : Form
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
        Database dbconnection = new Database();
        String query;

        public Termination_of_Accomodation()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Termination_of_Accomodation_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBookID.Text  != "" && txtStudentID.Text  != "" && txtReason.Text  != "")
            {
                String Book_ID = txtBookID.Text;
                String Std_ID = txtStudentID.Text;
                String Term_Reason = txtReason.Text;

                query = "UPDATE Booking SET Term_Reason = ('" + Term_Reason + "') WHERE Std_ID = ('" + Std_ID + "') AND Book_ID = ('" + Book_ID + "')";

                dbconnection.setData(query);

                this.Hide();
                Student_Menu f = new Student_Menu();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill all fields correctly!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Menu f = new Student_Menu();
            f.ShowDialog();
            this.Close();
        }
    }
}
