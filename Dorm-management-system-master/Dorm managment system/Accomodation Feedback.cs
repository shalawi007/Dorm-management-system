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
    public partial class Accomodation_Feedback : Form
    {
        Database dbConnection = new Database();
        String query;
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

        public Accomodation_Feedback()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Accomodation_Feedback_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Menu f3 = new Student_Menu(); // Instantiate a Form object.
            f3.ShowDialog(); // Show Form and          
            this.Close(); // closes the current Form instance.
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "" && txtRoomno.Text != "" && txtFeedback.Text != "")
            {
                String Rooms_no = txtRoomno.Text;
                String Student_ID = txtStudentID.Text;
                String Feedback = txtFeedback.Text;

                query = "Insert Into Feedback (Room_ID, Student_ID,Feedback) Values ('"+Rooms_no+ "','" + Student_ID + "','" + Feedback + "');";
                dbConnection.setData(query);

                this.Hide();
                Student_Menu f = new Student_Menu();
                f.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
