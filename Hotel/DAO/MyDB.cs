using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel
{
    class MyDB
    {
        //SqlConnection con = new SqlConnection(@"Data Source=NEM\DBMS_FINAL;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Hotel");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        
        public MyDB()
        { 
            if (GlobalVar._username != null)
            {
                String connectionStr = @"Data Source=NEM\DBMS_FINAL;Initial Catalog=Hotel;Trusted_Connection=True;User Id=" + GlobalVar._username + ";Password=" + GlobalVar._password;
                con = new SqlConnection(connectionStr);
            }
        }

        public MyDB(string username, string password)
        {
            try
            {
                con = new SqlConnection();
                String connectionStr = @"Data Source=NEM\DBMS_FINAL;Initial Catalog=Hotel;Trusted_Connection=True;User Id=" + username + ";Password=" + password;
                con = new SqlConnection(connectionStr);
                GlobalVar._username = username;
                GlobalVar._password = password;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
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
