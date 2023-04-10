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
    class SERVICE
    {
        MyDB Mydb = new MyDB();
        public DataTable GetAllService()
        {
            string query = "select * from service";
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

      

        public bool AddService(string name, string type, int price, string des,int count, MemoryStream image)
        {
            string query = "insert into service(name,type,price,description,count,used,image) values(@name,@type," +
                "@price,@description,@count,@used,@image)";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
                command.Parameters.Add("@price", SqlDbType.Int).Value = price;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = des;
                command.Parameters.Add("@count", SqlDbType.Int).Value = count;
                command.Parameters.Add("@used", SqlDbType.Int).Value = 0;
                command.Parameters.Add("@image", SqlDbType.Image).Value = image.ToArray();
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
                MessageBox.Show(ex.Message, "Service SQL");
                Mydb.closeConnection();
                return false;
            }
        }
        public DataTable GetServiceInRoom(string room)
        {
            string query = "select service.id as id,name,price,service_detail.count,price*service_detail.count as pay from service inner join service_detail " +
                    "on service.id=service_detail.id_service where service_detail.id= @id";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = room;
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

        public bool DeleteServiceInRoom(string room, int id_service)
        {
            string query = "delete from service_detail where id= @id and id_service= @id_service";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = room;
                command.Parameters.Add("@id_service", SqlDbType.Int).Value = id_service;
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
                MessageBox.Show(ex.Message, "Service SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public bool DeleteServiceEmptyInRoom()
        {
            string query = "delete from service_detail where count=0";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
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
                MessageBox.Show(ex.Message, "Service SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public DataTable GetAllType()
        {
            string query = "select distinct type from service";
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
        public bool DeleteService_detail(int id_service)
        {
            string query = "delete from service_detail where id_service= @id_service";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_service", SqlDbType.Int).Value = id_service;
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
                MessageBox.Show(ex.Message, "Service SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public bool DeleteServiceByID(int id_service)
        {
            string query = "delete from service where id= @id";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id_service;
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
                MessageBox.Show(ex.Message, "Service SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public int CountServiceInService_detail(int id_service)
        {
            string query = "select count(*) from service_detail where id_service= @id_service";
            Mydb.openConnection();
            int result = -1;
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_service", SqlDbType.Int).Value = id_service;
                result = Convert.ToInt32(command.ExecuteScalar());
                Mydb.closeConnection();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return result;
            }
        }

        public int CountServiceByID(int id_service)
        {
            string query = "select count from service where id= @id";
            Mydb.openConnection();
            int result = -1;
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id_service;
                result = Convert.ToInt32(command.ExecuteScalar());
                Mydb.closeConnection();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Mydb.closeConnection();
                return result;
            }
        }

        public bool AddServiceInRoom(string room, int id_service, int count)
        {
            string query = "insert into service_detail(id,id_service,count) values( @room , @id_service, @count )";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@room", SqlDbType.NVarChar).Value = room;
                command.Parameters.Add("@id_service", SqlDbType.Int).Value = id_service;
                command.Parameters.Add("@count", SqlDbType.Int).Value = count;
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

        public bool UpdateServiceInRoom(string room, int id_service, int count)
        {
            string query = "update service_detail set count=count+ @count where id= @id and id_service= @id_service";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_service", SqlDbType.Int).Value = id_service;
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = room;
                command.Parameters.Add("@count", SqlDbType.Int).Value = count;
                if (command.ExecuteNonQuery() > 0)
                {
                    Mydb.closeConnection();
                    UpdateService(id_service, count);
                    return true;
                }
                Mydb.closeConnection();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Service SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public bool UpdateService(int id_service, int count)
        {
            string query = "update service set count= count+ @count where id= @id";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id_service;
                command.Parameters.Add("@count", SqlDbType.Int).Value = count;
                if (command.ExecuteNonQuery() >0)
                {
                    Mydb.closeConnection();
                    return true;
                }
                Mydb.closeConnection();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Service SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public int countIDService()
        {
            SqlCommand command = new SqlCommand("SELECT count(id) as SoLuong from service", Mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable data = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(data);
            return Convert.ToInt32(data.Rows[0]["SoLuong"]);
        }

        public DataTable getServiceByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * from service where id = @id", Mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable data = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(data);
            return data;
        }

        public bool updateServiceByID(int id, string name, string type, int price, string description, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("UPDATE service set name = @oname, type = @otype, price = @oprice, image = @oimage where id = @oid", Mydb.getConnection);
            Mydb.openConnection();
            command.Parameters.Add("oid", SqlDbType.Int).Value = id;
            command.Parameters.Add("oname", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("otype", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("oprice", SqlDbType.Int).Value = price;
            command.Parameters.Add("oimage", SqlDbType.Image).Value = image.ToArray();
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
    }
}
