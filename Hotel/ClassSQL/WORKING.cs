using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    class WORKING
    {
        MyDB Mydb = new MyDB();

        public DataTable LogIn(string username, string password)
        {
            SqlCommand command = new SqlCommand("\tselect * from log_in inner join Employees on log_in.id=Employees.id where username= @username and password= @password", Mydb.getConnection);
            command.Parameters.Add("@username", SqlDbType.NChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.NChar).Value = password;
            Mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Mydb.closeConnection();
            return table;
        }

        public DataTable GetIdAssignment(int idE)
        {
            string sql = "select a.id from assignment a inner join shift s " +
                "on a.shift = s.shift where a.id_employee = @ide and a.date = CAST(GETDATE() as DATE)" +
                "and cast(getdate() as time)>= CAST(s.timeFrom as time) and cast(getdate() as time)< CAST(s.timeTo as time)";
            SqlCommand command = new SqlCommand(sql, Mydb.getConnection);
            command.Parameters.Add("@ide", SqlDbType.Int).Value = idE;
            Mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Mydb.closeConnection();
            return table;
        }

        public void ConfirmLogin(int idAssignment)
        {
            string sql = "update assignment set status=1,work=0 where id=@id";
            SqlCommand command = new SqlCommand(sql, Mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idAssignment;
            Mydb.openConnection();
            command.ExecuteNonQuery();
        }

        public void UpdateWorking(int idAssignment)
        {
            string sql = "update assignment set work+=0.05 where id=@id";//3 phút cập nhật 1 lần
            SqlCommand command = new SqlCommand(sql, Mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idAssignment;
            Mydb.openConnection();
            command.ExecuteNonQuery();
            Mydb.closeConnection();
        }


    }
}

