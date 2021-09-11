using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dorm_managment_system
{
    public class Student
    {
        public String ID { get; set; }
        public String Pass { get; set; }
        public String Name { get; set; }
        public String Contact { get; set; }
        public String Email { get; set; }
        public String Birth_Date { get; set; }

        

        public Student(String id)
        {
            Database dbConnection = new Database();
            DataSet ds = dbConnection.getData("SELECT * from Student where ID = '" + id + "'");

            //  for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //    txtCustomerID.Text = ds.Tables[0].Rows[i]["ID"].ToString();

            DataRow firstRow = ds.Tables[0].Rows[0];
            if (ds.Tables[0].Rows[0] != null)
            {
                this.ID = firstRow["ID"].ToString();
                this.Pass = firstRow["Pass"].ToString();
                this.Name = firstRow["Name"].ToString();
                this.Contact = firstRow["Contact"].ToString();
                this.Email = firstRow["Email"].ToString();
                this.Birth_Date = firstRow["Birth_Date"].ToString();


            }
        }
        public static List<Student> getAllStudents() {
            List<Student> studentList = new List<Student>();

            Database dbConnection = new Database();
            DataSet ds = dbConnection.getData("SELECT * from Student");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                studentList.Add(new Student(
                    row["ID"].ToString(),
                    row["Pass"].ToString(),
                    row["Name"].ToString(),
                    row["Contact"].ToString(),
                    row["Email"].ToString(),
                    row["Birth_Date"].ToString()
                    ));
            }

            return studentList;
        }

        public Student(
        String ID,
        String Pass,
        String Name,
        String Contact,
        String Email,
        String Birth_Date
            )
        {

            this.ID = ID;
            this.Pass = Pass;
            this.Name = Name;
            this.Contact = Contact;
            this.Email = Email;
            this.Birth_Date = Birth_Date;
        }
    }
}
