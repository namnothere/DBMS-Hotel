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
    public partial class ImportServiceForm : Form
    {
        public ImportServiceForm()
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
                    if (ServiceSQL.UpdateService((int)cbName.SelectedValue, Convert.ToInt32(numCount.Value)))
                    {
                        int value = Convert.ToInt32(numCount.Value) * int.Parse(txtPrice.Text);
                        StatisticSQL.AddStatistic("Nhập kho", value, -1, DateTime.Now);//thêm vào thống kê thu/chi
                        StatisticSQL.AddEvent("Nhập kho:" + cbName.Text, value, "",GlobalVar._id,DateTime.Now);//THêm vào sự kiện để biết ai làm
                        MessageBox.Show("Thêm thành công", "Nhập hàng");
                    }
                    else
                    {
                        MessageBox.Show("Nhập hàng không thành công. Vui lòng thử lại", "Nhập hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private bool checkField()
        {
            try
            {
                if (cbName.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ");
                    return false;
                }
                if (txtPrice.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập giá");
                    return false;
                }
                int price = 0;
                if (!int.TryParse(txtPrice.Text,out price))
                {
                    MessageBox.Show("Vui lòng nhập giá là số nguyên");
                    return false;
                }
                return true;
            }
            catch { return false; }
        }

        private void ImportServiceForm_Load(object sender, EventArgs e)
        {
            try
            {
                cbName.DataSource = ServiceSQL.GetAllService();
                cbName.DisplayMember = "name";
                cbName.ValueMember = "id";
                cbName.SelectedItem = null;
            }
            catch { }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbName.SelectedItem = null;
            numCount.Value = 1;
            txtPrice.Text = "";
        }
    }
}
