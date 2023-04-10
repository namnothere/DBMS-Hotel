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
    public partial class ThanhToanDienNuoc : Form
    {
        public ThanhToanDienNuoc()
        {
            InitializeComponent();
        }
        SERVICE ServiceSQL = new SERVICE();
        STATISTIC StatisticSQL = new STATISTIC();
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkField())
                {
                    int tien = Convert.ToInt32(txtPrice.Text.Trim());
                    StatisticSQL.AddStatistic("Chi trả: "+ DescriptionTB.Text.Trim(), tien, -1, DateTime.Now);//thêm vào thống kê thu/chi
                    StatisticSQL.AddEvent("Chi trả: " + DescriptionTB.Text.Trim(), tien, "", GlobalVar._id, DateTime.Now);//THêm vào sự kiện để biết ai làm
                    MessageBox.Show("Thêm thành công", "Nhập hàng");
                }
                else
                {
                    MessageBox.Show("Chi tiền không thành công. Vui lòng thử lại", "Nhập hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private bool checkField()
        {
            try
            {
                if (DescriptionTB.Text.Trim()=="")
                {
                    MessageBox.Show("Vui lòng nhập thông tin thanh toán");
                    return false;
                }
                if (txtPrice.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập giá");
                    return false;
                }
                int price = 0;
                if (!int.TryParse(txtPrice.Text, out price))
                {
                    MessageBox.Show("Vui lòng nhập giá là số nguyên");
                    return false;
                }
                return true;
            }
            catch { return false; }
        }

        private void ThanhToanDienNuoc_Load(object sender, EventArgs e)
        {

        }
    }
}
