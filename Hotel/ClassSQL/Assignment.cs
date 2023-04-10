using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    class Assignment
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
                    " where not exists (select A.id_employee from assignment as A where  CAST(A.date as DATE)=@date and E.id=A.id_employee)";
                
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

        public DataTable CountWorkingEmployee(DateTime from,DateTime to)//đếm số buổi làm việc của mỗi nhân viên
        {
            string query;
            Mydb.openConnection();
            SqlCommand command;
            DataTable data = new DataTable();
            try
            {
                query = "select id_employee,count(date) as count from assignment where CAST(checkin as DATE)>=@from and CAST(date as DATE)<=@to group by id_employee";

                command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@from", SqlDbType.Date).Value = from;
                command.Parameters.Add("@to", SqlDbType.Date).Value = to;
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
        public DataTable GetEmployeeWorking()
        {
            string query;
            Mydb.openConnection();
            SqlCommand command;
            DataTable data = new DataTable();
            try
            {
                query = "select stt,id from employees where stt <> 0 and stt is not null";

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
        public DataTable CountEmployeeEachShiftAndType(int shift)//đếm số lượng nhân viên mỗi ca
        {
            string query;
            Mydb.openConnection();
            SqlCommand command;
            DataTable data = new DataTable();
            try
            {
                query = "select type0,type1,type2 from shift where shift=@shift";

                command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@shift", SqlDbType.Int).Value = shift;
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

        public DataTable GetFirstEmployee(DateTime date)
        {
            string query;
            Mydb.openConnection();
            SqlCommand command;
            DataTable data = new DataTable();
            try
            {
                query = "select min(stt) as stt from employees as E " +
                    " where exists (select A.id_employee from assignment as A where CAST(A.date as DATE)=@date and E.id=A.id_employee)" +
                    " group by type order by type";

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

        public DataTable GetShift()
        {
            string query;
            Mydb.openConnection();
            SqlCommand command;
            DataTable data = new DataTable();
            try
            {
                query = "select * from shift order by shift";
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

        public DataTable GetShift(int shift)
        {
            string query;
            Mydb.openConnection();
            SqlCommand command;
            DataTable data = new DataTable();
            try
            {
                query = "select * from shift where shift=@shift";
                command = new SqlCommand(query, Mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                command.Parameters.Add("@shift", SqlDbType.Int).Value = shift;
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

        public DataTable GetEmployeeInDateAndShift(int shift, DateTime date)
        {
            string query;
            DataTable data = new DataTable();
            SqlCommand command;
            try
            {
                query = "select id_employee,E.name,T.name as type from employees as E inner join assignment as A" +
                " on E.id=A.id_employee inner join type_employee as T on E.type=T.id  where CAST(A.date as DATE)=@date and A.shift=@shift" +
                " order by E.stt";
                command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                command.Parameters.Add("@shift", SqlDbType.Int).Value = shift;
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

        public bool CheckExistDate(DateTime date)
        {
            string query;
            DataTable data = new DataTable();
            SqlCommand command;
            try
            {
                query = "select * from Assignment where CAST(Assignment.date as DATE)=@date";
                command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                Mydb.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                if(data.Rows.Count > 0)
                {
                    Mydb.closeConnection();
                    return true;
                }
                Mydb.closeConnection();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assignment SQL");
                Mydb.closeConnection();
                return false ;
            }
        }

        public DataTable GetEmployeeInType(int type)
        {
            string query;
            DataTable data = new DataTable();
            SqlCommand command;
            try
            {
                query = "select stt,id from employees where type=@type and stt <>0 and stt is not null order by stt";
                command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@type", SqlDbType.Int).Value = type;
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

        public DataTable GetAllEmployeeInType(int type)
        {
            string query;
            DataTable data = new DataTable();
            SqlCommand command;
            try
            {
                query = "select id from employees where type=@type";
                command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@type", SqlDbType.Int).Value = type;
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
        public DataTable GetTimeInShift(int shift)
        {
            string query;
            DataTable data = new DataTable();
            SqlCommand command;
            try
            {
                query = "select timeFrom,timeTo from shift where shift=@shift";
                command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@shift", SqlDbType.Int).Value = shift;
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

        public DataTable GetTimeFromAllShift()
        {
            string query;
            DataTable data = new DataTable();
            SqlCommand command;
            try
            {
                query = "select shift,timeFrom,timeTo from shift order by shift";
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

        public DataTable GetDateByID(int id)
        {
            string query;
            DataTable data = new DataTable();
            SqlCommand command;
            try
            {
                query = "select shift,checkin,checkout from assignment where id=@id";
                command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public bool SetZeroSTTOfEmployee()
        {
            string query = "update Employees set stt=0 where stt<>0";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                
                if (command.ExecuteNonQuery() > 0)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assignment SQL");
                Mydb.closeConnection();
                return false;
            }
        }
        public bool DeleteEmployeesInShiftAndDate(int shift,DateTime date)
        {
            string query = "delete from assignment where shift=@shift and CAST(date as DATE)=@date";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@shift", SqlDbType.Int).Value = shift;
                command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                Mydb.openConnection();
                if (command.ExecuteNonQuery() > 0)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assignment SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public bool DeleteEmployeesAfterDate( DateTime date)
        {

            string query = "select * from assignment where CAST(date as DATE)>@date";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                    return true;
                query = "delete from assignment where CAST(date as DATE)>@date";
                command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                if (command.ExecuteNonQuery() > 0)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assignment SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public bool DeleteEmployeesBetweenDate(DateTime from,DateTime to)
        {

            string query = "delete from assignment where CAST(date as DATE)>=@from and CAST(chekin as DATE)<=@to";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@from", SqlDbType.Date).Value = from;
                
                command.Parameters.Add("@to", SqlDbType.Date).Value = to;
                if (command.ExecuteNonQuery() > 0)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assignment SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public bool AddEmployeesInShiftAndDate(int id_employee,int shift,DateTime date,float work,int status)
        {
            string query = "insert into assignment(id_employee,shift,date,work,status) values(@id_employee,@shift,@date,@work,@status)";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_employee", SqlDbType.Int).Value = id_employee;
                command.Parameters.Add("@shift", SqlDbType.Int).Value = shift;
                command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                command.Parameters.Add("@work", SqlDbType.Float).Value = work;
                command.Parameters.Add("@status", SqlDbType.Int).Value = status;

                if (command.ExecuteNonQuery() > 0)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assignment SQL");
                Mydb.closeConnection();
                return false;
            }
        }


        
        public bool AddShift(int shift, DateTime from, DateTime to,int type0,int type1,int type2)
        {
            string query = "insert into Shift(shift,timeFrom,timeTo,type0,type1,type2) values(@shift,@timeFrom,@timeTo,@type0,@type1,@type2)";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@shift", SqlDbType.Int).Value = shift;
                command.Parameters.Add("@timeFrom", SqlDbType.DateTime).Value = from;
                command.Parameters.Add("@timeTo", SqlDbType.DateTime).Value = to;
                command.Parameters.Add("@type0", SqlDbType.Int).Value = type1;
                command.Parameters.Add("@type1", SqlDbType.Int).Value = type1;
                command.Parameters.Add("@type2", SqlDbType.Int).Value = type2;
                if (command.ExecuteNonQuery() > 0)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assignment SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public bool EditSTT(int id, int stt)
        {
            string query = "update employees set stt=@stt " +
                            "where id= @id";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@stt", SqlDbType.Int).Value = stt;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                if (command.ExecuteNonQuery() > 0)
                {
                    Mydb.closeConnection();
                    return true;
                }
                Mydb.closeConnection();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Customer SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public DataTable checkID(int id,DateTime date)//lấy id của bảng phân công
        {
            string query = "select id from assignment where id_employee=@id_employee and CAST(date as DATE)=@date";
            Mydb.openConnection();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_employee", SqlDbType.Int).Value = id;
                command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                SqlDataAdapter adapter = new SqlDataAdapter();
                
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                Mydb.closeConnection();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assignment SQL");
                Mydb.closeConnection();
                return dt;
            }
        }


        public DataTable LayThongTinDangNHap(int id)
        {
            string query = "select * from log_in where id=@id_employee";
            Mydb.openConnection();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_employee", SqlDbType.Int).Value = id;
                
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = command;
                adapter.Fill(dt);
                Mydb.closeConnection();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assignment SQL");
                Mydb.closeConnection();
                return dt;
            }
        }

        public bool doiThongTinDangNhap(int id, string username, string password)
        {
            string query = "update log_in set username=@ousername, password=@opassword where id= @oid";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                
                command.Parameters.Add("@oid", SqlDbType.Int).Value = id;
                command.Parameters.Add("@ousername", SqlDbType.NChar).Value = username;
                command.Parameters.Add("@opassword", SqlDbType.NChar).Value = password;
                if (command.ExecuteNonQuery() > 0)
                {
                    Mydb.closeConnection();
                    return true;
                }
                Mydb.closeConnection();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Customer SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public bool kiemTraTenDangNhap(string username)
        {
            string query = "select * from log_in where username=@ousername";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@ousername", SqlDbType.NChar).Value = username;
              
                if (command.ExecuteNonQuery() > 0)
                {
                    Mydb.closeConnection();
                    return false;
                }
                Mydb.closeConnection();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Customer SQL");
                Mydb.closeConnection();
                return true;
            }
        }

        public bool ThemNguoiDungMoi(int id,string username, string password)
        {
            string query = "INSERT INTO log_in (id, username, password) values (@oid, @ousername, @opassword)";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);

                command.Parameters.Add("@oid", SqlDbType.Int).Value = id;
                command.Parameters.Add("@ousername", SqlDbType.NChar).Value = username;
                command.Parameters.Add("@opassword", SqlDbType.NChar).Value = password;
                if (command.ExecuteNonQuery() > 0)
                {
                    Mydb.closeConnection();
                    return true;
                }
                Mydb.closeConnection();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Customer SQL");
                Mydb.closeConnection();
                return false;
            }
        }
        public bool XoaNguoiDung(int id)
        {
            string query = "Delete from log_in where id =@oid";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);

                command.Parameters.Add("@oid", SqlDbType.Int).Value = id;
             
                if (command.ExecuteNonQuery() > 0)
                {
                    Mydb.closeConnection();
                    return true;
                }
                Mydb.closeConnection();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Customer SQL");
                Mydb.closeConnection();
                return false;
            }
        }
    }
}
