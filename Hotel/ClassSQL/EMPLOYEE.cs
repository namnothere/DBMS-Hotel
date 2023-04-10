using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    class EMPLOYEES
    {
        MyDB Mydb = new MyDB();
        public DataTable GetEmployee(DateTime date)
        {
            string query;
            Mydb.openConnection();
            SqlCommand command;
            DataTable data = new DataTable();
            try
            {
                query = "select E.id as id_employee ,E.name,T.name as type from employees as E inner join" +
                    " type_employee as T on E.type=T.id " +
                    " where not exists (select A.id_employee from assignment as A where  CAST(A.checkin as DATE)=@date and E.id=A.id_employee)";

                command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);

                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assignment SQL");
                Mydb.closeConnection();
                return data;
            }
        }
        public bool InsertEmployees(int ID, string name, string gender, string CMND, DateTime bdate, string phone, string address, int type, MemoryStream picture, int stt)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Employees (id, name, gender,cmnd ,bdate, phone, address, type, stt, picture)" + "VALUES (@id,@name,@gdr,@cm,@bdt,@phn,@adrs,@type, @stt, @pic)", Mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cm", SqlDbType.VarChar).Value = CMND;
            command.Parameters.Add("@bdt", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@type", SqlDbType.Int).Value = type;
            command.Parameters.Add("@stt", SqlDbType.Int).Value = stt;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            Mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                Mydb.closeConnection();
                return true;
            }
            else
            {
                Mydb.closeConnection();
                return false;
            }
        }
        public bool UpdateEmployeesByID(int ID, string name, string gender, string CMND, DateTime bdate, string phone, string address, int type, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("update Employees set name=@oname, gender=@ogender, cmnd = @ocmnd, bdate=@obdate, phone=@ophone, address=@oaddress, type=@otype, picture=@pic where id = @oid", Mydb.getConnection);
        //  SqlCommand command = new SqlCommand("Update Employees set name=@oname, gender=@ogender, cmnd=@ocmnd, bdate=@obdate, phone=@ophone, address=@oaddress, type=@otype, picture = @pic Where id = @oid", Mydb.getConnection);
            
            command.Parameters.Add("@oid", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@oname", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@ogender", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@ocmnd", SqlDbType.VarChar).Value = CMND;
            command.Parameters.Add("@obdate", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@ophone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@oaddress", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@otype", SqlDbType.Int).Value = type;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            
            Mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                Mydb.closeConnection();
                return true;
            }
            else
            {
                Mydb.closeConnection();
                return false;
            }
        }
        public bool DeleteEmployees(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Employees where id = @oid", Mydb.getConnection);
            command.Parameters.Add("@oid", SqlDbType.Int).Value = id;
            Mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                Mydb.closeConnection();
                return true;
            }
            else
            {
                Mydb.closeConnection();
                return false;
            }

        }
        public DataTable getEmployeeByID(int id)
        {
            SqlCommand command = new SqlCommand("Select * from employees where id = @oid", Mydb.getConnection);
            command.Parameters.Add("oid", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable data = new DataTable();
            Mydb.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(data);
            return data;
        }
        public bool CMNDExist(string cmnd)
        {
            SqlCommand command = new SqlCommand("select * FROM employees WHERE cmnd=@ocmnd", Mydb.getConnection);
            command.Parameters.Add("@ocmnd", SqlDbType.VarChar).Value = cmnd;
            Mydb.openConnection();
            SqlDataAdapter Adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            Adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Mydb.closeConnection();
                return true;
            }
            else
            {
                Mydb.closeConnection();
                return false;
            }
        }

        public DataTable GetAllEmployee(int check)
        {
            string query;
            Mydb.openConnection();
            SqlCommand command;
            DataTable data = new DataTable();
            try
            {
                if (check == 1)
                {
                    query = "select E.id as id ,E.name,T.name as type ,bdate,gender,cmnd,phone,address,picture from employees as E inner join" +
                        " type_employee as T on E.type=T.id order by id";
                }
                else
                {
                    if (check == 3)
                    {
                        query = "select E.id as id ,E.name,T.name as type ,bdate,gender,cmnd,phone,address,picture from employees as E inner join" +
                            " type_employee as T on E.type=T.id order by type";
                    }
                    else
                    {
                        query = "select E.id as id ,E.name,T.name as type ,bdate,gender,cmnd,phone,address,picture from employees as E inner join" +
                            " type_employee as T on E.type=T.id order by E.name";
                    }    
                }

                command = new SqlCommand(query, Mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);

                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assignment SQL");
                Mydb.closeConnection();
                return data;
            }
        }

        public bool InsertLogin(int ID, string user, string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Login (id, username, password)" + "VALUES (@id,@username,@password)", Mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = user;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = pass;

            Mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                Mydb.closeConnection();
                return true;
            }
            else
            {
                Mydb.closeConnection();
                return false;
            }
        }

        public bool ExistID(int ID)
        {
            Mydb.openConnection();
            SqlCommand command = new SqlCommand("select id from login where id=@id", Mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            DataTable dt = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter(command);
            Adapter.Fill(dt);
            Mydb.closeConnection();
            if ((dt.Rows.Count>0))
            {
                Mydb.closeConnection();
                return true;
            }
            else
            {
                Mydb.closeConnection();
                return false;
            }
        }
        public bool ExistUser(string user)
        {
            Mydb.openConnection();
            SqlCommand command = new SqlCommand("select user from login where user=@user", Mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
            DataTable dt = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter(command);
            Adapter.Fill(dt);
            Mydb.closeConnection();
            if ((dt.Rows.Count > 0))
            {
                Mydb.closeConnection();
                return true;
            }
            else
            {
                Mydb.closeConnection();
                return false;
            }
        }
    }
}
