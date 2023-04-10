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
    public partial class AssignmentForm : Form
    {
        public AssignmentForm()
        {
            InitializeComponent();
        }

        Assignment AssignmentSQL = new Assignment();
        private void LoadShift()
        {
            cbShift.DataSource = AssignmentSQL.GetShift();
            cbShift.ValueMember = "shift";
            cbShift.DisplayMember = "shift";
            cbShift.SelectedItem = null;
        }

        private void LoadDGVSource()
        {
            if (dgvSource.Rows.Count > 0)
            {
                dgvSource.Rows.Clear();
            }
            DataTable dt = AssignmentSQL.GetEmployee(dtpDateShift.Value);
            foreach (DataRow item in dt.Rows)
            {
                dgvSource.Rows.Add(item.ItemArray);
            }
        }

        private void LoadDGVDestination()
        {
            if (dgvDestination.Rows.Count > 0)
            {
                dgvDestination.Rows.Clear();
            }
            DataTable dt = AssignmentSQL.GetEmployeeInDateAndShift(Convert.ToInt32(cbShift.SelectedValue), dtpDateShift.Value);
            foreach (DataRow item in dt.Rows)
            {
                dgvDestination.Rows.Add(item.ItemArray);
            }
        }

        private void AssignmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadShift();
                LoadDGVSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Toang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (dgvSource.Rows.Count == 1)
            {
                MessageBox.Show("Đã chọn hết nhân viên", "Phân công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvSource.SelectedRows.Count != 0)
            {
                var listitem = dgvSource.SelectedRows;
                foreach (DataGridViewRow item in listitem)
                {
                    dgvDestination.Rows.Add(new object[] { item.Cells["id_employee"].Value, item.Cells["name"].Value, item.Cells["type"].Value });
                    dgvSource.Rows.RemoveAt(item.Index);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn nhân viên", "Phân công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (dgvDestination.Rows.Count == 1)
            {
                MessageBox.Show("Đã chọn hết nhân viên", "Phân công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvDestination.SelectedRows.Count != 0)
            {
                var listitem = dgvDestination.SelectedRows;
                foreach (DataGridViewRow item in listitem)
                {
                    dgvSource.Rows.Add(new object[] { item.Cells["id_employeeD"].Value, item.Cells["nameD"].Value, item.Cells["typeD"].Value });
                    dgvDestination.Rows.RemoveAt(item.Index);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn nhân viên", "Phân công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (cbShift.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn ca");
                return;
            }
            int shift = Convert.ToInt32(cbShift.SelectedValue);

            DateTime dtChechin = new DateTime(dtpDateShift.Value.Year, dtpDateShift.Value.Month, dtpDateShift.Value.Day);
            AssignmentSQL.DeleteEmployeesInShiftAndDate(shift, dtpDateShift.Value);
            for (int i = 0; i < dgvDestination.Rows.Count - 1; i++)
            {
                if (!AssignmentSQL.AddEmployeesInShiftAndDate(int.Parse(dgvDestination.Rows[i].Cells["id_employeeD"].Value.ToString()), shift, dtChechin, 0, -1))
                {
                    MessageBox.Show("Lỗi", "Phân công");
                    return;
                }
            }
            MessageBox.Show("Xác nhận thành công");

        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            int id = AssignmentSQL.GetShift().Rows.Count;

            if (AssignmentSQL.AddShift(id + 1, dtpFrom.Value, dtpTo.Value, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown1.Value)))
            {
                MessageBox.Show("Thêm ca thành công", "Phân công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thêm ca không thành công", "Phân công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cbShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDGVDestination();
                LoadDGVSource();
                DataTable dt = AssignmentSQL.GetShift(Convert.ToInt32(cbShift.SelectedValue));
                dtpFrom.Value = DateTime.Parse(dt.Rows[0][1].ToString());
                dtpTo.Value = DateTime.Parse(dt.Rows[0][2].ToString());
                TimeSpan t = dtpTo.Value - dtpFrom.Value;
                txtTimeSpan.Text = t.Hours.ToString();
                numericUpDown1.Value = int.Parse(dt.Rows[0][3].ToString());
                numericUpDown2.Value = int.Parse(dt.Rows[0][4].ToString());
                numericUpDown3.Value = int.Parse(dt.Rows[0][5].ToString());

            }
            catch
            {

            }
        }

        private bool DeleteAssignmentAfterDate(DateTime dt)
        {
            if (AssignmentSQL.DeleteEmployeesAfterDate(dt))
            {
                MessageBox.Show("Xoá thành công", "Phân công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Xoá không thành công", "Phân công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
        private bool checkError()
        {
            if (AssignmentSQL.CheckExistDate(dtpDateShift.Value))
            {
                DialogResult re = MessageBox.Show("Ngày này đã được phân công trực. Bạn có muốn xoá bảng phân cũ để phân công lại không!"
                    , "Phân công", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    return DeleteAssignmentAfterDate(dtpDateShift.Value);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkError())
                {
                    MessageBox.Show("Lỗi phân công");
                    return;
                }
                if (checkbAutoNO.Checked == true)
                    AutoNumberEmployee();//tự động tạo 

                int n = (int)(dtpEnd.Value - dtpDateShift.Value).TotalDays;//số ngày phân công
                if (n < 1)
                {
                    MessageBox.Show("Chọn lại ngày kết thúc phân công", "Phân công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime dateSource = dtpDateShift.Value;
                DateTime dateF = dtpDateShift.Value;
                DataTable dt = new DataTable();

                Dictionary<int, int> dictQL = new Dictionary<int, int>();
                Dictionary<int, int> dictLT = new Dictionary<int, int>();
                Dictionary<int, int> dictLC = new Dictionary<int, int>();

                dt = AssignmentSQL.GetEmployeeInType(0);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dictQL.Add(int.Parse(dt.Rows[i]["stt"].ToString()), int.Parse(dt.Rows[i]["id"].ToString()));
                }
                dt = AssignmentSQL.GetEmployeeInType(1);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dictLT.Add(int.Parse(dt.Rows[i]["stt"].ToString()), int.Parse(dt.Rows[i]["id"].ToString()));
                }
                dt = AssignmentSQL.GetEmployeeInType(2);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dictLC.Add(int.Parse(dt.Rows[i]["stt"].ToString()), int.Parse(dt.Rows[i]["id"].ToString()));
                }

                dt = AssignmentSQL.GetFirstEmployee(dateF);
                int i0 = 0, i1 = 0, i2 = 0, temp = 0;
                try
                {
                    i0 = int.Parse(dt.Rows[0][0].ToString());
                    i1 = int.Parse(dt.Rows[1][0].ToString());
                    i2 = int.Parse(dt.Rows[2][0].ToString());
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                int item0 = 0, item1 = 0, item2 = 0;
                dt = AssignmentSQL.GetTimeFromAllShift();
                int[,] arrMax = new int[dt.Rows.Count, 3];

                Dictionary<int, DateTime> dictTimeFrom = new Dictionary<int, DateTime>();
                Dictionary<int, DateTime> dictTimeTo = new Dictionary<int, DateTime>();
                foreach (DataRow item in dt.Rows)
                {
                    dictTimeFrom.Add(int.Parse(item["shift"].ToString()), DateTime.Parse(item["timeFrom"].ToString()));
                    dictTimeTo.Add(int.Parse(item["shift"].ToString()), DateTime.Parse(item["timeTo"].ToString()));
                    dt = AssignmentSQL.CountEmployeeEachShiftAndType(temp + 1);
                    arrMax[temp, 0] = arrMax[temp, 1] = arrMax[temp, 2] = 0;
                    try
                    {
                        arrMax[temp, 0] = int.Parse(dt.Rows[0][0].ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try { arrMax[temp, 1] = int.Parse(dt.Rows[0][1].ToString()); }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    try { arrMax[temp, 2] = int.Parse(dt.Rows[0][2].ToString()); }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    temp++;
                }


                for (int i = 0; i < n; i++)
                {
                    dateSource = dateSource.AddDays(1);
                    for (int shift = 1; shift <= dictTimeFrom.Count; shift++)
                    {
                        for (int k = 0; k < arrMax[shift - 1, 0]; k++)
                        {
                            if (!AssignmentSQL.AddEmployeesInShiftAndDate(dictQL[(item0 + i0) % dictQL.Count + 1], shift,
                                new DateTime(dateSource.Year, dateSource.Month, dateSource.Day),0, -1))
                            {
                                MessageBox.Show("Lỗi tạo bảng phân công");
                            }
                            item0++;
                        }
                        for (int k = 0; k < arrMax[shift - 1, 1]; k++)
                        {
                            if (!AssignmentSQL.AddEmployeesInShiftAndDate(dictLT[(item1 + i1) % dictLT.Count + 1], shift,
                                new DateTime(dateSource.Year, dateSource.Month, dateSource.Day) , 0, -1))
                            {
                                MessageBox.Show("Lỗi tạo bảng phân công");
                            }
                            item1++;
                        }
                        for (int k = 0; k < arrMax[shift - 1, 2]; k++)
                        {
                            if (!AssignmentSQL.AddEmployeesInShiftAndDate(dictLC[(item2 + i2) % dictLC.Count + 1], shift,
                                new DateTime(dateSource.Year, dateSource.Month, dateSource.Day)
                               , 0, -1))
                            {
                                MessageBox.Show("Lỗi tạo bảng phân công");
                            }
                            item2++;
                        }
                    }
                    item0 = 0; item1 = 0; item2 = 0;
                    i0++;
                    i1++;
                    i2++;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            Form ShowList = new ShowAssignmentFrom();
            ShowList.ShowDialog();
        }

        private void AutoNumberEmployee()
        {
            AssignmentSQL.SetZeroSTTOfEmployee();
            int i = 1, type = 0;
            DataTable dt = new DataTable();
            for (type = type; type < 3; type++)
            {
                i = 1;
                dt = AssignmentSQL.GetAllEmployeeInType(type);
                foreach (DataRow item in dt.Rows)
                {
                    AssignmentSQL.EditSTT(int.Parse(item[0].ToString()), i++);
                }
            }
        }
        private void btnEditShift_Click(object sender, EventArgs e)
        {

        }

        private void dtpDateShift_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDGVDestination();
                LoadDGVSource();
                DataTable dt = AssignmentSQL.GetShift(Convert.ToInt32(cbShift.SelectedValue));
                if (dt.Rows.Count == 0)
                    return;
                dtpFrom.Value = DateTime.Parse(dt.Rows[0][1].ToString());
                dtpTo.Value = DateTime.Parse(dt.Rows[0][2].ToString());
                TimeSpan t = dtpTo.Value - dtpFrom.Value;
                txtTimeSpan.Text = t.Hours.ToString();
                numericUpDown1.Value = int.Parse(dt.Rows[0][3].ToString());
                numericUpDown2.Value = int.Parse(dt.Rows[0][4].ToString());
                numericUpDown3.Value = int.Parse(dt.Rows[0][5].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
