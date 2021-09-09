using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Dorm_managment_system
{
    class Database
        
    {
        SqlConnection connection;
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\ProjectsV13;database=Dorm db;integrated security = True";
            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = connection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    public Database()
    {
        connection = getConnection();
    }
}
}
