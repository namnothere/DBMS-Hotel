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
    class CUSTOMER
    {
        MyDB Mydb = new MyDB();

        public DataTable GetCustomerWithName(string room = null)
        {
            string query;
            Mydb.openConnection();
            SqlCommand command;
            DataTable data = new DataTable();
            try
            {
                if (room == null)
                {
                    query = "select bill.id_bill, name,cmnd,phone,bill.room,customer.description from customer inner join bill " +
                        "on customer.id_bill=bill.id_bill";
                    command = new SqlCommand(query, Mydb.getConnection);
                }
                else
                {
                    query = "select bill.id_bill, name,cmnd,phone,bill.room,customer.description from customer inner join bill " +
                        "on customer.id_bill=bill.id_bill  where bill.room=@room";
                    command = new SqlCommand(query, Mydb.getConnection);
                    command.Parameters.Add("@room", SqlDbType.NVarChar).Value = room;
                }

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

        public DataTable GetCustomerWithIDBill(int id_bill)
        {
            string query;
            Mydb.openConnection();
            SqlCommand command;
            DataTable data = new DataTable();
            try
            {
                query = "select bill.id_bill, name,cmnd,phone,bill.room,customer.description from customer inner join bill " +
                    "on customer.id_bill=bill.id_bill  where bill.id_bill=@id_bill";
                command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_bill", SqlDbType.NVarChar).Value = id_bill;

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

        public DataTable GetCustomerByStatus(int status, string room = null)
        {
            string query;
            DataTable data = new DataTable();
            SqlCommand command;
            try
            {
                if (room == null)
                {
                    query = "select bill.id_bill, name,cmnd,phone,bill.room,customer.description from customer inner join bill " +
                        "on customer.id_bill=bill.id_bill where bill.status=@status";
                    command = new SqlCommand(query, Mydb.getConnection);
                }

                else
                {
                    query = "select bill.id_bill, name,cmnd,phone,bill.room,customer.description from customer inner join bill " +
                        "on customer.id_bill=bill.id_bill where bill.status=@status and bill.room=@room";
                    command = new SqlCommand(query, Mydb.getConnection);
                    command.Parameters.Add("@room", SqlDbType.NVarChar).Value = room;
                }
                command.Parameters.Add("@status", SqlDbType.Int).Value = status;
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

        public bool AddCustomer(string name, string cmnd, string phone, int id_bill, string des, int own)
        {
            string query = "insert into customer(name,cmnd,phone,id_bill,description,own)" +
                    " values( @name , @cmnd , @phone , @id_bill,@des,@own )";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
                command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
                command.Parameters.Add("@id_bill", SqlDbType.NVarChar).Value = id_bill;
                command.Parameters.Add("@des", SqlDbType.NVarChar).Value = des;
                command.Parameters.Add("@own", SqlDbType.Int).Value = own;
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
                MessageBox.Show(ex.Message, "Customer SQL");
                Mydb.closeConnection();
                return false;
            }
        }

        public bool EditCustomer(string name, string cmnd, string phone, int id_bill, string des, int own)
        {
            string query = "update customer set name= @name ,phone= @phone ,cmnd=@cmnd,description=@des,own=@own " +
                            "where id_bill= @id_bill";
            Mydb.openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
                command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
                command.Parameters.Add("@id_bill", SqlDbType.Int).Value = id_bill;
                command.Parameters.Add("@des", SqlDbType.NVarChar).Value = des;
                command.Parameters.Add("@own", SqlDbType.Int).Value = own;
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

        public DataTable GetCustomerByIDBillAndCMND(int id_bill, string cmnd)
        {
            string query = "select * from customer where id_bill= @id_bill and cmnd= @cmnd";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_bill", SqlDbType.NVarChar).Value = id_bill;
                command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
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

        public DataTable GetCustomerByIDBill(int id_bill)
        {
            string query = "select * from customer where id_bill= @id_bill";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_bill", SqlDbType.NVarChar).Value = id_bill;
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

        public DataTable GetCustomerOwnByIDBill(int id_bill)
        {
            string query = "select * from customer where id_bill= @id_bill and own=1";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_bill", SqlDbType.NVarChar).Value = id_bill;
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

        public bool CheckCustomerOwn(int id_bill, string cmnd)
        {
            string query = "select * from customer inner join bill on bill.id_bill=customer.id_bill" +
                " where bill.id_bill= @id_bill and own=1 and cmnd<>@cmnd";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@id_bill", SqlDbType.Int).Value = id_bill;
                command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                Mydb.closeConnection();
                if (data.Rows.Count > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bill");
                Mydb.closeConnection();
                return true;
            }
        }
        public bool DeleteCustomer(int id_bill)
        {
            string query = "Delete from customer where id_bill = @oid_bill";
            Mydb.openConnection();
            DataTable data = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@oid_bill", SqlDbType.Int).Value = id_bill;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
                Mydb.closeConnection();
                if (data.Rows.Count > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bill");
                Mydb.closeConnection();
                return true;
            }
        }

        public bool DeleteCustomer(int id_bill, string cmnd)
        {
            string query = "Delete from customer where id_bill = @oid_bill and cmnd=@ocmnd";
            Mydb.openConnection();

                SqlCommand command = new SqlCommand(query, Mydb.getConnection);
                command.Parameters.Add("@oid_bill", SqlDbType.Int).Value = id_bill;
                command.Parameters.Add("@ocmnd", SqlDbType.NVarChar).Value = cmnd;
  
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
