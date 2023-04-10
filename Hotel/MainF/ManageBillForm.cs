using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class ManageBillForm : Form
    {
        public ManageBillForm()
        {
            InitializeComponent();
        }

        private int id_bill = 0;
        BILL BillSQL = new BILL();
        Room RoomSQL = new Room();
        CUSTOMER customer = new CUSTOMER();
        private void ManageBillForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvBill.DataSource = BillSQL.GetAllBill();
                cbChooseRoom.DataSource = RoomSQL.GetAllRoom(true); 
                cbTenPhong.DataSource = RoomSQL.GetAllRoom(true); 
                cbChooseRoom.DisplayMember = "room";
                cbChooseRoom.ValueMember = "room";
                cbTenPhong.DisplayMember = "room";
                cbTenPhong.ValueMember = "room";
                cbChooseRoom.SelectedItem = null;
                cbTenPhong.SelectedItem = null;

                cbChooseStatus.DataSource = RoomSQL.GetAllStatusBill();
                cbStatus.DataSource = RoomSQL.GetAllStatusBill();
                cbChooseStatus.SelectedItem = null;
                cbChooseStatus.DisplayMember = "status";
                cbChooseStatus.ValueMember = "id";
                cbStatus.DisplayMember = "status";
                cbStatus.ValueMember = "id";
                cbStatus.SelectedItem = null;
            }
            catch { }

        }

        private void dgvBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvBill.DataSource = BillSQL.GetAllBill();
        }


        private void btnSearchWithCon_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (cBoxRoom.Checked)
                {
                    query = " room=@room";
                }
                if (cBoxStatus.Checked)
                {
                    if (query != "")
                        query += " and ";
                    query += " bill.status=@status";
                }
                if (cBoxDate.Checked)
                {
                    if (query != "")
                        query += " and ";
                    query += " checkin>=@dtpFrom and checkin<=@dtpTo";
                }
                if (query != "")
                    query = "select id_bill,room,checkin,checkout,S.status as Nstatus, pay from bill inner join status_room as S" +
                        " on bill.status=S.id where " + query;
                else
                    query = "select id_bill,room,checkin,checkout,S.status as Nstatus, pay from bill inner join status_room as S" +
                        " on bill.status=S.id";
                SqlCommand command = new SqlCommand(query);

                if (cBoxRoom.Checked)
                {
                    command.Parameters.Add("@room", SqlDbType.VarChar).Value = cbChooseRoom.SelectedValue.ToString();
                }
                if (cBoxStatus.Checked)
                {
                    command.Parameters.Add("@status", SqlDbType.Int).Value = (int)cbChooseStatus.SelectedValue;
                }
                if (cBoxDate.Checked)
                {
                    command.Parameters.Add("@dtpFrom", SqlDbType.DateTime).Value = dtpChooseFrom.Value;
                    command.Parameters.Add("@dtpTo", SqlDbType.DateTime).Value = dtpChooseTo.Value;
                }
                dgvBill.DataSource = BillSQL.GetAllBilMulti(command);
                lbTong.Text = dgvBill.Rows.Count.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private int Status(string status)
        {
            if (status == "Đang thuê")
                return 1;
            if (status == "Đặt trước")
                return 0;
            else
                return -1;
        }

        private void dgvBill_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.id_bill = (int)(dgvBill.CurrentRow.Cells["id"].Value);
                DataTable dt = BillSQL.GetBillByID(id_bill);
                string nameroom = dt.Rows[0]["room"].ToString();
                int status = (int)dt.Rows[0]["status"];
                cbTenPhong.SelectedValue = nameroom;
                cbStatus.SelectedValue = status;
                try
                {
                    dtpTo.Value = (DateTime)dgvBill.CurrentRow.Cells["checkout"].Value;
                }
                catch { dtpTo.Value = DateTime.Now; }
                try
                {
                    dtpFrom.Value = (DateTime)dgvBill.CurrentRow.Cells["checkin"].Value;
                }
                catch { dtpFrom.Value = DateTime.Now; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            STATISTIC Statistic = new STATISTIC();
            if (!checkField())
                return;
            if (GlobalVar._GlobalType == 1)//Giới hạn quyền chỉnh sửa
            {
                if (dgvBill.CurrentRow.Cells["status"].Value.ToString() == "Đã thanh toán")
                {
                    MessageBox.Show("Lễ tân không có quyền sửa các Bill đã thanh toán!", "Manage Bill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dgvBill.CurrentRow.Cells["status"].Value.ToString() == "Đang thuê")
                {
                    if (dgvBill.CurrentRow.Cells["checkin"].Value != null)
                    {
                        if (dtpFrom != dgvBill.CurrentRow.Cells["checkin"].Value)
                        {
                            MessageBox.Show("Lễ tân không có quyền sửa ngày checkin của các phòng đang thuê!", "Manage Bill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    if (BillSQL.EditBill(cbTenPhong.SelectedValue.ToString(), dtpFrom.Value, dtpTo.Value,
                        Status(cbStatus.SelectedItem.ToString()), int.Parse(dgvBill.CurrentRow.Cells["pay"].Value.ToString()),
                        0, id_bill))
                    {

                        Statistic.AddEvent("Sửa Bill:" + dgvBill.CurrentRow.Cells["id_bill"].Value.ToString(),
                            0, "", GlobalVar._id, DateTime.Now);
                        MessageBox.Show("Cập nhật thành công");
                    }
                }
                else
                {
                    if (BillSQL.EditBill(cbTenPhong.SelectedValue.ToString(), dtpFrom.Value, dtpTo.Value,
                        Status(cbStatus.SelectedItem.ToString()), int.Parse(dgvBill.CurrentRow.Cells["pay"].Value.ToString()),
                        0, id_bill))
                    {
                        MessageBox.Show("Cập nhật thành công");
                    }
                }
            }
            else
            {
                if (BillSQL.EditBill(cbTenPhong.SelectedValue.ToString(), dtpFrom.Value, dtpTo.Value,
                       Status(cbStatus.SelectedItem.ToString()), int.Parse(dgvBill.CurrentRow.Cells["pay"].Value.ToString()),
                       0, id_bill))
                {
                    Statistic.AddEvent("Sửa Bill:" + dgvBill.CurrentRow.Cells["id_bill"].Value.ToString(),
                           0, "", GlobalVar._id, DateTime.Now);
                    MessageBox.Show("Cập nhật thành công");
                }
            }
        }

        private bool checkField()
        {
            if (cbTenPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tên phòng", "Manage Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tên phòng", "Manage Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("Vui lòng chọn ngày CheckIn nhỏ hơn ngày CheckOut", "Manage Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            STATISTIC Statistic = new STATISTIC();
            if (!checkField())
                return;
            if (GlobalVar._GlobalType == 1)//Giới hạn quyền chỉnh sửa
            {
                MessageBox.Show("Lễ tân không có quyền xoá các Bill", "Manage Bill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (BillSQL.DeleteBill(id_bill)&&customer.DeleteCustomer(id_bill))
                {
                    Statistic.AddEvent("Xoá Bill:" + dgvBill.CurrentRow.Cells["id"].Value.ToString(),
                           0, "", GlobalVar._id, DateTime.Now);
                    MessageBox.Show("Xoá thành công");
                }
                else
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
        }
    }
}
