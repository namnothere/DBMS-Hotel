using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Hotel
{
    class MyDB
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DD46R4UJ;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Hotel");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}
