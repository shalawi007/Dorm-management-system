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
    public partial class Change_Room_Request : Form
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

        public Change_Room_Request()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Change_Room_Request_Load(object sender, EventArgs e)
        {
            rdoBlockB.Checked = false;
            rdoBlockA.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtRoomno.Text != "" && (rdoBlockA.Checked ^ rdoBlockB.Checked))
            {   
                
                String Rooms_no = txtRoomno.Text;

                if (rdoBlockA.Checked)
                {
                    //Submitting Change Room request to Block B
                    query = "UPDATE Booking SET [Changed Block] = 'Block A' WHERE Std_ID = ('" + Instances.values.loggedInStudent.ID + "') AND Room_ID = ('" + Rooms_no + "')";
                    dbConnection.setData(query);
                }
                else if (rdoBlockB.Checked)
                {
                    //Submitting Change Room request to Block B
                    query = "UPDATE Booking SET [Changed Block] = 'Block B' WHERE Std_ID = ('" + Instances.values.loggedInStudent.ID + "') AND Room_ID = ('"+Rooms_no+"')";
                    dbConnection.setData(query);
                   
                }
                





            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
