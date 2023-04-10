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
    public partial class Setting : Form
    {
        int eid;
        string mk;
        int check;
        public Setting(int id)
        {
            InitializeComponent();
            eid = id;
        }
        Assignment assignment = new Assignment();
        private void Setting_Load(object sender, EventArgs e)
        {
            DataTable table = assignment.LayThongTinDangNHap(eid);
            TenDangNhap.Text = table.Rows[0]["username"].ToString();
            mk = table.Rows[0]["password"].ToString();
            MatKhau.Text = "**********";
            check = 1;
        }

        private void ShowLLB_LinkClicked(object sender, EventArgs e)
        {
            if (check == 1)
            {
                MatKhau.Text = mk;
                ShowLLB.Text = "Ẩn";
                check = 2;
            }
            else
            {
                MatKhau.Text = "***********";
                ShowLLB.Text = "Hiện";
                check = 1;
            }    
        }

        private void EditUserName_Click(object sender, EventArgs e)
        {
            DoiTenDangNhap doiTenDangNhap=new DoiTenDangNhap(eid);
            doiTenDangNhap.Show();
        }

        private void EditPassword_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(eid);
            doiMatKhau.Show();
        }
    }

}
