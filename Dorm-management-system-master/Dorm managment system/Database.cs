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
            con.ConnectionString = "data source = (localdb)\\C:\\IOOP db;database=Dorm db;integrated security = True";
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
        public void setData(String query, String message) //Insert + delete + update data 
        {
            SqlConnection con = connection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(message + "Success");

        }
    public Database()
    {
        connection = getConnection();
    }
}
}
