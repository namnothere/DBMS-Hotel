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
 
    class Room
    {  
        MyDB Mydb = new MyDB();
        public bool EditStatusRoom(string room,int status)
        {
            string query = "update room set status= @status where room= @room";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@status", SqlDbType.Int).Value = status;
                command.Parameters.Add("@room", SqlDbType.NVarChar).Value = room;
                
                if (command.ExecuteNonQuery() > 0)
                {
                    Mydb.closeConnection();
                    return true;
                }
                Mydb.closeConnection();
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Room SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        
        public DataTable GetPriceRoom(string room)
        {
            string query = "select price_h,price_d from room inner join type_room on room.type=type_room.type" +
                " where room= @room";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@room", SqlDbType.NVarChar).Value = room;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                return data;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return data;
            }
        }

        public DataTable GetTypeAndStatusRoom(string room)
        {
            string query = "select S.status,name from Room inner join type_room on Room.type=type_room.type" +
                " inner join status_room as S on Room.status=S.id where room=@room";

            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@room", SqlDbType.NVarChar).Value = room;
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

        public DataTable GetAllRoom(bool check)
        {
            string query = "";
            if(check==true)
            {
                query = "select room,R.status,R.type,S.status,T.name from Room as R inner join status_room as S on R.status=S.id" +
                    " inner join type_room as T on R.type=T.type ";
            }    
            else
                query = "select room,R.status,R.type,S.status,T.name from Room as R inner join status_room as S on R.status=S.id" +
                    " inner join type_room as T on R.type=T.type order by R.status";
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


        public DataTable GetAllStatusBill()
        {
            string query = "select * from status_room as S where id=1 or id=0 or id=-1";
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

        public bool AddNewRoom(int roomid, int status, int typer)
        {
            status = 2;
            SqlCommand command = new SqlCommand("INSERT INTO room (room, status, type) Values (@oroom, @ostatus, @otype)", Mydb.getConnection);
            command.Parameters.Add("@oroom", SqlDbType.Int).Value = roomid;
            command.Parameters.Add("@ostatus", SqlDbType.Int).Value = status;
            command.Parameters.Add("otype", SqlDbType.Int).Value = typer;

            Mydb.openConnection();
            if(command.ExecuteNonQuery()>0)
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

        public bool UpdateRoom(int roomid, int status , int type)
        {
            status = 2;
            SqlCommand command = new SqlCommand("Update room set status=@ostatus, type=@otype Where room = @oroom", Mydb.getConnection);
            command.Parameters.Add("@oroom", SqlDbType.Int).Value = roomid;
            command.Parameters.Add("@ostatus", SqlDbType.Int).Value = status;
            command.Parameters.Add("@otype", SqlDbType.Int).Value = type;

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

        public bool DeleteRoom(int roomid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM room WHERE room= @oroom", Mydb.getConnection);
            command.Parameters.Add("@oroom", SqlDbType.Int).Value = roomid;
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
        public DataTable getRoomByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE room =@nID", Mydb.getConnection);
            command.Parameters.Add("@nID", SqlDbType.Int).Value = id;

            Mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count != 0))
            {
                Mydb.closeConnection();
                return table;

            }
            else
            {
                Mydb.closeConnection();
                return table;
            }
        }
        public DataTable getRoomType()
        {
            SqlCommand command = new SqlCommand("Select * FROM type_room", Mydb.getConnection);
            command.Connection = Mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool ExistRoom(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE room =@nID", Mydb.getConnection);
            command.Parameters.Add("@nID", SqlDbType.Int).Value = id;

            Mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count != 0))
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

        public DataTable GetRoomUsed(bool check)
        {
            string query = "";
            if (check == true)
            {
                query = "select room,R.status,R.type,S.status,T.name from Room as R inner join status_room as S on R.status=S.id" +
                    " inner join type_room as T on R.type=T.type where R.status='1' ";
            }
            else
                query = "select room,R.status,R.type,S.status,T.name from Room as R inner join status_room as S on R.status=S.id" +
                    " inner join type_room as T on R.type=T.type where S.status=1 order by R.status";
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

    }
}
