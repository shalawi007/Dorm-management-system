using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dorm_managment_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //foreach (var student in Student.getAllStudents())
            //{
            //    MessageBox.Show(student.Name);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usernameText = textBox1.Text;
            var passwordText = textBox2.Text;

            Database dbConnection = new Database();

            DataSet ds = dbConnection.getData($"SELECT * from Student where Name = '{usernameText}' and Pass = '{passwordText}'");

            var wardens = Warden.getAllWardens();

            Warden wardenFound = null;

            foreach (var warden in wardens)
            {
                if (warden.Name == usernameText && warden.Pass == passwordText)
                {
                    wardenFound = warden;
                }
            }

            //DataSet ds = dbConnection.getData($"SELECT * from warden where Name = '{textBox1.Text}' and Pass = '{textBox2.Text}'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow firstRow = ds.Tables[0].Rows[0];
                Student loggedInStudent = new Student(
                    firstRow["ID"].ToString(),
                    firstRow["Pass"].ToString(),
                    firstRow["Name"].ToString(),
                    firstRow["Contact"].ToString(),
                    firstRow["Email"].ToString(),
                    firstRow["Birth_Date"].ToString()
                    );

                Instances.values.loggedInStudent = loggedInStudent;

                Hide();
                Student_Menu menu = new Student_Menu();
                menu.ShowDialog();
                Close();
            }
            else if (wardenFound != null)
            {
                Instances.values.loggedInWarden = wardenFound;
                Hide();
                Warden_Menu wardenMenu = new Warden_Menu();
                wardenMenu.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.UseSystemPasswordChar = true;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
