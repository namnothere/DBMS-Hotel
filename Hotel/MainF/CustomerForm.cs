using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DAO;
using System.Windows.Forms;

namespace Hotel
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            BackColor = Lib._colorBackgroundMain;
        }

        CUSTOMER CustomerSQL = new CUSTOMER();
        Room RoomSQL = new Room();
        BILL BillSQL = new BILL();
        private string roomChoose;
        private void LoadKhachHang()
        {
            int status = checkStatus();

            if (roomChoose.Equals("All"))
            {
                if (status == 4)
                    dgvKhachHang.DataSource = CustomerSQL.GetCustomerWithName();
                else
                    dgvKhachHang.DataSource = CustomerSQL.GetCustomerByStatus(status, null);
            }
            else
            {
                if (status == 4)
                    dgvKhachHang.DataSource = CustomerSQL.GetCustomerWithName(roomChoose);
                else
                    dgvKhachHang.DataSource = CustomerSQL.GetCustomerByStatus(status, roomChoose);
            }

        }
        private void LoadRoom()
        {
            DataTable dt = RoomSQL.GetAllRoom(true);
            Button btnAll = new Button() { Size = new Size(200, 50), Text = "Tất cả phòng", Tag = "All" };
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.BackColor = Color.Crimson;
            btnAll.TextAlign = ContentAlignment.MiddleLeft;
            btnAll.Margin = new Padding(0);
            btnAll.Click += Btn_Click;
            flpRoom.Controls.Add(btnAll);
            this.roomChoose = "All";
            foreach (DataRow item in dt.Rows)
            {
                Button btn = new Button();
                btn.Size = new Size(200, 50);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Text = "Phòng " + item["room"].ToString();
                btn.Tag = item["room"].ToString();//đánh dấu room để dễ sử dụng khi gọi sự kiện click
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.Crimson;
                btn.Margin = new Padding(0);
                //btn.Padding= new Padding(0);
                btn.Click += Btn_Click;
                flpRoom.Controls.Add(btn);
            }
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            this.roomChoose = ((Button)sender).Tag.ToString();
            LoadKhachHang();
        }

        private int checkStatus()
        {
            if (cbStatusCustomer.SelectedIndex == 0)
                return 4;
            else if (cbStatusCustomer.SelectedIndex == 1)
                return 1;
            else if (cbStatusCustomer.SelectedIndex == 2)
                return 0;
            else
                return -1;
        }

        private bool CheckFill()
        {
            return true;
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRoom();
                cbStatusCustomer.SelectedIndex = 0;
                LoadKhachHang();
                cbRoom.DataSource = RoomSQL.GetAllRoom(true);
                cbRoom.ValueMember = "room";
                cbRoom.DisplayMember = "room";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Toang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void cbStatusCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadKhachHang();
            }
            catch
            {

            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            int own = 0;
            if (cbOwn.Checked)
            {
                own = 1;
                if (CustomerSQL.CheckCustomerOwn(int.Parse(txtIDBill.Text),txtCMND.Text))
                {
                    
                    MessageBox.Show("Đã có khách hàng đặt phòng, vui lòng thử lại");
                    return;
                }
            }


            if (CheckFill())
            {
                if (CustomerSQL.AddCustomer(txtTenKhachHang.Text, txtCMND.Text, txtPhone.Text,
                    int.Parse(txtIDBill.Text), txtDescription.Text, own))
                {
                    STATISTIC Statistic = new STATISTIC();
                    MessageBox.Show("Thêm khách hàng thành công");
                    Statistic.AddEvent("Thêm khách hàng", 0, "Phòng:" + cbRoom.Text, GlobalVar._id, DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng không thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = CustomerSQL.GetCustomerByIDBillAndCMND((int)dgvKhachHang.CurrentRow.Cells["id_bill"].Value, dgvKhachHang.CurrentRow.Cells["cmnd"].Value.ToString());
            cbRoom.SelectedValue = dgvKhachHang.CurrentRow.Cells["room"].Value.ToString();
            this.txtPhone.Text =dt.Rows[0]["phone"].ToString();
            this.txtCMND.Text = dt.Rows[0]["cmnd"].ToString();
            this.txtTenKhachHang.Text = dt.Rows[0]["name"].ToString();
            txtIDBill.Text = dt.Rows[0]["id_bill"].ToString();
            txtDescription.Text = dt.Rows[0]["description"].ToString();
            if ((int)dt.Rows[0]["own"] == 1)
            {
                cbOwn.Checked = true;
            }
            else
                cbOwn.Checked = false;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            int own = 0;
            if (cbOwn.Checked)
            {
                own = 1;
                if (CustomerSQL.CheckCustomerOwn(int.Parse(txtIDBill.Text), dgvKhachHang.CurrentRow.Cells["cmnd"].Value.ToString()))
                {
                    MessageBox.Show("Đã có khách hàng đặt phòng, vui lòng thử lại");
                    return;
                }
            }

            if (CheckFill())
            {
                if (CustomerSQL.EditCustomer(txtTenKhachHang.Text, txtCMND.Text, txtPhone.Text,
                    int.Parse(txtIDBill.Text), txtDescription.Text, own))
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                    STATISTIC Statistic = new STATISTIC();
                    Statistic.AddEvent("Sửa thông tin khách hàng", 0, "Phòng:" + cbRoom.Text, GlobalVar._id, DateTime.Now);

                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng không thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbOwn.Checked)
                {
                    MessageBox.Show("Không được quyền xoá người đặt phòng");
                    return;
                }

                if (CustomerSQL.DeleteCustomer(int.Parse(txtIDBill.Text.Trim()), txtCMND.Text.Trim()))
                {
                    MessageBox.Show("Xoá thành công");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id_bill = 0;
            if(!int.TryParse(txtIDBillSearch.Text,out id_bill)){
                MessageBox.Show("Vui lòng kiểm tra lại ID Bill");
                return;
            }
            dgvKhachHang.DataSource= CustomerSQL.GetCustomerWithIDBill(id_bill);

        }
    }
}
