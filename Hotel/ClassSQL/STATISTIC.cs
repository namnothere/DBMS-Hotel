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
    class STATISTIC
    {
        MyDB Mydb = new MyDB();


        public bool AddStatistic(string name, int price, int type, DateTime date)//type=0 là chi, 1 là thu
        {
            string query = "insert into statistic (name,price,type,date)" +
                    " values( @name  , @price , @type , @date)";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@price", SqlDbType.Int).Value = price;
                command.Parameters.Add("@type", SqlDbType.Int).Value = type;
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
                MessageBox.Show(ex.Message, "Bill SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public bool AddEvent(string name, int price, string des, int id_e,DateTime date)
        {
            string query = "insert into event (event,value,description,id_employee,date)" +
                    " values( @event  , @value , @des,@id_e,@date)";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@event", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@value", SqlDbType.Int).Value = price;
                command.Parameters.Add("@des", SqlDbType.NVarChar).Value = des;
                command.Parameters.Add("@id_e", SqlDbType.Int).Value = id_e;
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
                MessageBox.Show(ex.Message, "Bill SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public bool ExistStatistic(string name, DateTime date)
        {
            string query = "select * from statistic where name LIKE name% and CAST(date as DATE) = @date" +
                    " values( @name  , @price , @type , @date)";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
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
                MessageBox.Show(ex.Message, "Bill SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public DataTable GetAllEvent()
        {
            string query = "select Event.id,event,value,description,E.name,date from Event inner join Employees as E on Event.id_employee=E.id";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetEvent(DateTime from,DateTime to)
        {
            string query = "select  Event.id,event,value,description,E.name,date from Event inner join" +
                " Employees as E on Event.id_employee=E.id where CAST(date as DATE)>=@from and CAST(date as DATE)<=@to";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@from", SqlDbType.Date).Value = from;
                command.Parameters.Add("@to", SqlDbType.Date).Value = to;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetEventByDate(DateTime datefrom, DateTime dateTo)
        {
            string query = "select * from Event where date between @dateFrom and @dateTo";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@dateFrom", SqlDbType.Date).Value = datefrom;
                command.Parameters.Add("@dateTo", SqlDbType.Date).Value = dateTo;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetAllRevenueByRoom()
        {
            string query = "select room.room,ROUND(CAST(sum(case when pay is null then 0 else pay end) as float)/1000000,1) as revenue from" +
                " bill right join room on bill.room=room.room group by room.room";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetAllRevenueByDate()
        {
            string query = "select str(MONTH(checkin),2,0)+'/'+str(YEAR(checkin),4,0) as date,ROUND(CAST(sum(case when pay is null then 0 else pay end) as float)/1000000,1) as revenue from" +
                " bill inner join room on bill.room=room.room group by YEAR(checkin), MONTH(checkin)";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetAllRevenueByRoom(DateTime from, DateTime to)
        {
            string query = "select room.room,ROUND(CAST(sum(case when pay is null then 0 else pay end) as float)/1000000,1) as revenue " +
                " from  (select * from bill where CAST(checkin as DATE) between @from and @to) as bill right join room on bill.room=room.room   group by room.room";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                command.Parameters.Add("@from", SqlDbType.Date).Value = from;
                command.Parameters.Add("@to", SqlDbType.Date).Value = to;
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetAllRevenueByDate(DateTime from, DateTime to)
        {
            string query = "select str(MONTH(checkin),2,0)+'/'+str(YEAR(checkin),4,0) as date,ROUND(CAST(sum(case when pay is null then 0 else pay end) as float)/1000000,1) as revenue from" +
                " bill inner join room on bill.room=room.room where CAST(checkin as DATE) between @from and @to group by YEAR(checkin), MONTH(checkin)";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                command.Parameters.Add("@from", SqlDbType.Date).Value = from;
                command.Parameters.Add("@to", SqlDbType.Date).Value = to;
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return data;
            }
        }

        

        public DataTable GetInfoEmployee(SqlCommand command)
        {
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                command.Connection = Mydb.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
               
                adapter.Fill(data);
                Mydb.openConnection();
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return data;
            }
        }
    }
}
