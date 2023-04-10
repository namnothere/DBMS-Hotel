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
    public partial class DoiMatKhau : Form
    {
        int eid;
        string tenDangNhap;
        string matKhau;
        Assignment assignment = new Assignment();
        DataTable table = new DataTable();
        public DoiMatKhau(int id)
        {
            InitializeComponent();
            eid = id;
        }

        private void CancelLB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FinishBT_Click(object sender, EventArgs e)
        {
            if (!checkFill())
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả các trường", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MkHienTai.Text.Trim() != table.Rows[0]["password"].ToString().Trim())
                {
                    MessageBox.Show("Sai mật khẩu!", "Sửa mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (MatKhauMoi.Text.Trim() != NhapLaiMatKhauMoi.Text.Trim())
                    {
                        MessageBox.Show("Mật khẩu mới phải giống nhau ở hai trường!", "Sửa mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (assignment.doiThongTinDangNhap(eid, table.Rows[0]["username"].ToString().Trim(), NhapLaiMatKhauMoi.Text.Trim()))
                        {
                            MessageBox.Show("Dổi mật khẩu thành công!", "Sửa mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại!", "Sửa mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            try
            {
                table = assignment.LayThongTinDangNHap(eid);
                //TenDangNhap.Text = table.Rows[0]["username"].ToString().Trim();
                // tenDangNhap = TenDangNhap.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool checkFill()
        {
            if (MkHienTai.Text.Trim() == "" || MatKhauMoi.Text.Trim() == "" || NhapLaiMatKhauMoi.Text.Trim() == "")
            {
                
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
