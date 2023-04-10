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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        public RegisterForm(int id)
        {
            InitializeComponent();
            txtID.Text = id.ToString();
        }
        EMPLOYEES EmployeeSQL = new EMPLOYEES();

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (CheckField())
            {
                if (EmployeeSQL.InsertLogin(int.Parse(txtID.Text), txtUser.Text, txtPw.Text))
                {
                    MessageBox.Show("Tạo tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool CheckField()
        {
            if (txtID.Text.Trim() == "" || txtUser.Text.Trim() == "" || txtPw.Text.Trim() == "" || txtCfpw.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPw.Text!=txtCfpw.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp. Vui lòng kiểm tra lại", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int id = 0;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Vui lòng kiểm tra lại ID", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (EmployeeSQL.ExistID(int.Parse(txtID.Text)))
            {
                MessageBox.Show("Tài khoản của nhân viên này đã tồn tại. VUi lòng chọn lại ID", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (EmployeeSQL.ExistUser(txtUser.Text))
            {
                MessageBox.Show("Đã tồn tại Username. VUi lòng nhập lại", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
