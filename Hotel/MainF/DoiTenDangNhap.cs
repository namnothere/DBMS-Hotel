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
    public partial class DoiTenDangNhap : Form
    {
        int eid;
        string tenDangNhap;
        string matKhau;
        Assignment assignment = new Assignment();
        DataTable table = new DataTable();
        public DoiTenDangNhap(int id)
        {
            InitializeComponent();
            eid = id;
        }
        
        private void CancelLB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoiTenDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                table = assignment.LayThongTinDangNHap(eid);
                TenDangNhap.Text = table.Rows[0]["username"].ToString().Trim();
                tenDangNhap = TenDangNhap.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FinishBT_Click(object sender, EventArgs e)
        {
            tenDangNhap = TenDangNhap.Text.Trim();
            matKhau = MatKhau.Text.Trim();
            if(matKhau!=table.Rows[0]["password"].ToString().Trim())
            {
                MessageBox.Show("Sai mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!assignment.kiemTraTenDangNhap(tenDangNhap))
                {
                    if (assignment.doiThongTinDangNhap(eid, tenDangNhap, matKhau))
                    {
                        MessageBox.Show("Đổi tên đăng nhập thành công", "Đổi tên đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đổi tên đăng nhập thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }    
        }
    }
}
