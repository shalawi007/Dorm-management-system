using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Dorm_managment_system
{
    class Database
        
    {
        SqlConnection connection;
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\C:\Users\Ghaarib\source\repos\Dorm-management-system\Dorm-management-system-master\Dorm managment system\Dorm db.mdf; Integrated Security = True; Connect Timeout = 30";
            return con;
        }
        public DataSet getData(String query) //get data from db
        {
            connection = getConnection();
            SqlConnection con = connection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query) //Insert + delete + update data 
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = query;
                int icount = cmd.ExecuteNonQuery();

                if (icount == 0)
                    MessageBox.Show("Unable to Update Record", "Record Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Record Update Successful", "Record Updated",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                con.Close();
            }
        }
    public Database()
    {
        connection = getConnection();

    }
}
}
