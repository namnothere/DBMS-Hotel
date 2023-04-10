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
    public partial class ShowAssignmentFrom : Form
    {
        public ShowAssignmentFrom()
        {
            InitializeComponent();
        }
        Assignment AssignmentSQL = new Assignment();
        private void LoadDate()
        {
            if (lvAssignment.Items.Count != 0)
            {
                lvAssignment.Items.Clear();
                lvAssignment.Groups.Clear();
                lvAssignment.Columns.Clear();
            }
            lvAssignment.Columns.Add("ID", 80);
            lvAssignment.Columns.Add("Họ và tên", 150);
            lvAssignment.Columns.Add("Chức vụ", 150);
            DataTable dt = AssignmentSQL.GetShift();
            Dictionary<string, ListViewGroup> DictGroup = new Dictionary<string, ListViewGroup>();

            foreach (DataRow item in dt.Rows)
            {
                ListViewGroup group = new ListViewGroup("Ca làm việc " + item[0].ToString());
                DictGroup.Add(item[0].ToString(), group);
                lvAssignment.Groups.Add(group);
            }

            for (int i = 1; i <= DictGroup.Count; i++)
            {
                dt = AssignmentSQL.GetEmployeeInDateAndShift(i, dtpFrom.Value);
                foreach (DataRow item in dt.Rows)
                {
                    ListViewItem lvitem = new ListViewItem();
                    lvitem.Text = item[0].ToString();
                    lvitem.SubItems.Add(item[1].ToString());
                    lvitem.SubItems.Add(item[2].ToString());
                    DictGroup[i.ToString()].Items.Add(lvitem);
                    lvAssignment.Items.Add(lvitem);
                }
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadDate();
        }

        private void ShowAssignmentFrom_Load(object sender, EventArgs e)
        {
            LoadDate();
        }



        private void btnStatics_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShow.Rows.Count > 0)
                {
                    dgvShow.Rows.Clear();
                    dgvShow.Columns.Clear();
                }
                dgvShow.DataSource = AssignmentSQL.CountWorkingEmployee(dtpFrom.Value, dtpTo.Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi phân công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dtpTo.Value < dtpFrom.Value)
            {
                MessageBox.Show("Check lại ngày ");
                return;
            }
            if (dgvShow.DataSource != null)
            {
                dgvShow.DataSource = null;
            }
            if (dgvShow.Rows.Count != 0)
            {
                try
                {
                    dgvShow.Rows.Clear();
                    dgvShow.Columns.Clear();
                }
                catch { }

            }
            DataTable dt = AssignmentSQL.GetShift();
            DateTime datesource = dtpFrom.Value;
            int t = (int)(dtpTo.Value - dtpFrom.Value).TotalDays+2;
            for (int i = 0; i < t; i++)
            {
                dgvShow.Columns.Add("date" + i.ToString(), datesource.ToString("d"));
                datesource = datesource.AddDays(1);
            }
            DataTable dt2 = new DataTable();
            int maxRow = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvShow.Rows.Add("Ca " + dt.Rows[i]["shift"].ToString());

                maxRow = dgvShow.Rows.Count;
                datesource = dtpFrom.Value;
                for (int j = 0; j < t; j++)
                {

                    dt2 = AssignmentSQL.GetEmployeeInDateAndShift((int)dt.Rows[i]["shift"], datesource);
                    for (int z = 0; z < dt2.Rows.Count; z++)
                    {
                        if (dgvShow.Rows.Count - maxRow - 1 < z)
                        {
                            dgvShow.Rows.Add();
                        }
                        dgvShow.Rows[maxRow + z].Cells[j].Value = dt2.Rows[z]["name"].ToString() + " (" + dt2.Rows[z]["type"].ToString() + ")";
                    }
                    datesource = datesource.AddDays(1);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtpTo.Value.Day - dtpFrom.Value.Day < 0)
            {
                MessageBox.Show("Vui lòng chọn ngày hợp lệ");
                return;
            }
            DialogResult re = MessageBox.Show("Bạn có chắc chắn xoá nội dung phân công không? Điều này " +
                "sẽ làm ảnh hưởng tới các thông số thống kê và chấm công!", "Phân công", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                if (AssignmentSQL.DeleteEmployeesBetweenDate(dtpFrom.Value, dtpTo.Value)){
                    MessageBox.Show("Xoá thành công");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
            

        }
    }
}
