using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.MainF
{
    public partial class CheckCustomer : Form
    {
        MyDB Mydb = new MyDB();
        public CheckCustomer()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Mydb.openConnection();
            string sql = "SELECT * FROM dbo.Check_Customer(@cmnd)";
            SqlCommand command = new SqlCommand(sql, Mydb.getConnection);

            // Add the @status parameter to the command
            SqlParameter parameter = new SqlParameter("@cmnd", SqlDbType.Int);
            parameter.Value = int.Parse(textBox1.Text);
            command.Parameters.Add(parameter);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

    }
}
