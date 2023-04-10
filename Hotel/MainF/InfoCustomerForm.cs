using Hotel.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class InfoCustomerForm : Form
    {
        public InfoCustomerForm()
        {
            InitializeComponent();
        }
        public InfoCustomerForm(int id_bill)
        {
            InitializeComponent();
            this.id_bill = id_bill;
            this.cbID.Items.Add(id_bill.ToString());
            this.cbID.SelectedIndex = 0;
        }

        CUSTOMER CustomerSQL = new CUSTOMER();
        private int id_bill = 0;
   
        private void InfoCustomerForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (cbID.Items.Count == 0)
            {
                BILL BillSQL = new BILL();
                dt = BillSQL.GetAllBill();
                if (dt.Rows.Count == 0)
                    return;
                foreach (DataRow item in dt.Rows)
                {
                    cbID.Items.Add(item[0].ToString());
                }
            }
            else
            {
                if (txtCMND.Text != "")
                {
                    LoadCustomer();
                }
            }
        }
        private void LoadCustomer()
        {
            DataTable dt = CustomerSQL.GetCustomerByIDBillAndCMND(this.id_bill, txtCMND.Text);
            if (dt.Rows.Count > 0)
            {
                txtTenKhachHang.Text = dt.Rows[0]["name"].ToString();
                txtPhone.Text = dt.Rows[0]["phone"].ToString();
            }
        }

        private bool CheckFill()
        {
            return true;
        }

        private void ClearFill()
        {
            this.txtCMND.Text = "";
            this.txtTenKhachHang.Text = "";
            this.txtPhone.Text = "";
            cbID.SelectedItem = null;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbID.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Hoá đơn", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (CheckFill())
            {
                if (CustomerSQL.AddCustomer(txtTenKhachHang.Text,txtCMND.Text,txtPhone.Text,int.Parse(cbID.SelectedItem.ToString()),"",0))
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng không thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn chắc chắn đã nhập xong thông tin cho khách hàng",
                "Thêm khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
                this.Close();
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
