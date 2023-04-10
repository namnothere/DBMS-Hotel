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
    class BILL
    {
        MyDB Mydb = new MyDB();


        public int AddBill(string room, DateTime checkin, DateTime checkout, int status, int pay, int status_pay)
        {
            string query = "insert into bill(room,checkin,checkout,status,pay,status_pay)" +
                    " values( @room  , @checkin , @checkout , @status , @pay , @status_pay )";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@room", SqlDbType.VarChar).Value = room;
                command.Parameters.Add("@checkin", SqlDbType.DateTime).Value = checkin;
                command.Parameters.Add("@checkout", SqlDbType.DateTime).Value = checkout;
                command.Parameters.Add("@status", SqlDbType.Int).Value = status;
                command.Parameters.Add("@pay", SqlDbType.Int).Value = pay;
                command.Parameters.Add("@status_pay", SqlDbType.Int).Value = status_pay;
                if (command.ExecuteNonQuery() > 0)
                {
                    command = new SqlCommand("select id_bill from bill where room=@room and checkin=@checkin", Mydb.getConnection);
                    command.Parameters.Add("@room", SqlDbType.VarChar).Value = room;
                    command.Parameters.Add("@checkin", SqlDbType.DateTime).Value = checkin;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    Mydb.closeConnection();
                    if (dt.Rows.Count > 0)
                        return int.Parse(dt.Rows[0][0].ToString());
                    else
                        return -1;
                }
                else
                    return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bill SQL");
                Mydb.closeConnection();
                return -1;
            }
        }

        public DataTable GetAllBillByRoom(string room)
        {
            string query = "select id_bill,room,checkin,checkout,S.status as Nstatus, pay from bill inner join status_room as S" +
                " on bill.status=S.id where room= @room and bill.status<>-1";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@room", SqlDbType.VarChar).Value = room;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bill");
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetAllBilMulti(SqlCommand command)
        {
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                command.Connection = Mydb.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bill");
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetAllBill()
        {
            string query = "select id_bill,room,checkin,checkout,S.status as Nstatus, pay from bill inner join status_room as S" +
                " on bill.status=S.id ";
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
                MessageBox.Show(ex.Message, "Bill");
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetBillByID(int id)
        {
            string query = "select id_bill,room,checkin,checkout,status ,pay from bill" +
                "  where id_bill= @id_bill";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_bill", SqlDbType.Int).Value = id;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bill");
                Mydb.closeConnection();
                return data;
            }
        }

        public bool EditBill(string room,  DateTime checkin, DateTime checkout, int status, int pay, int status_pay,int id)
        {
            string query = "update bill set room= @room  ,checkin= @checkin ," +
                       "checkout= @checkout ,status= @status ,pay= @pay ,status_pay= @status_pay" +
                       " where id_bill=@id_bill";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@room", SqlDbType.VarChar).Value = room;
                command.Parameters.Add("@checkin", SqlDbType.DateTime).Value = checkin;
                command.Parameters.Add("@checkout", SqlDbType.DateTime).Value = checkout;
                command.Parameters.Add("@status", SqlDbType.Int).Value = status;
                command.Parameters.Add("@pay", SqlDbType.Int).Value = pay;
                command.Parameters.Add("@status_pay", SqlDbType.Int).Value = status_pay;
                command.Parameters.Add("@id_bill", SqlDbType.Int).Value = id;
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
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return false;
            }
        }

        public bool DeleteBill(int id)
        {
            string query = "delete from Bill where id_bill=@id_bill";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_bill", SqlDbType.Int).Value = id;
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
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return false;
            }
        }

        public DataTable GetBillCheckinMin(string room)
        {
            string query = "select * from bill where room= @room and checkin=(select min(checkin)" +
                        " from bill where room= @room2 and status=0)";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@room", SqlDbType.VarChar).Value = room;
                command.Parameters.Add("@room2", SqlDbType.VarChar).Value = room;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bill");
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetBillCheckInMax(string room)
        {
            string query = "select max(checkin)" +
                        " from bill where room= @room";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@room", SqlDbType.VarChar).Value = room;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bill");
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetCheckOutByRoom(string room)
        {
            string query = "select bill.id_bill,room,checkin,checkout,name,cmnd from bill inner join customer as C" +
                " on bill.id_bill=C.id_bill where room= @room and own=1 and bill.status=1";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@room", SqlDbType.VarChar).Value = room;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bill");
                Mydb.closeConnection();
                return data;
            }
        }
            
    
    }
}
