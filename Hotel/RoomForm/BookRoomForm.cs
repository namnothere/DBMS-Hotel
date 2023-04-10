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
    public partial class BookRoomForm : Form
    {
        public BookRoomForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        LoadRoom loadRoom = new LoadRoom();
        public BookRoomForm(string room, int func)
        {
            InitializeComponent();
            this.nameRoom = room;
            this.func = func;
        }
        private string nameRoom = "";
        private int func;
        private int id_bill = 0;

        Room RoomSQL = new Room();
        BILL BillSQL = new BILL();
        CUSTOMER Customer = new CUSTOMER();
        private void LoadcbTenPhong()
        {
            DataTable dt = RoomSQL.GetAllRoom(true);
            foreach (DataRow item in dt.Rows)
            {
                cbTenPhong.Items.Add(item[0]);
            }
            cbTenPhong.SelectedItem = null;
        }

        private int CalPay()
        {
            TimeSpan t = dtpTo.Value - dtpFrom.Value;
            int hours = 0, day = 0;
            float pay = 0;
            DataTable data = RoomSQL.GetPriceRoom(this.nameRoom);
            int price_h = (int)data.Rows[0]["price_h"], price_d = (int)data.Rows[0]["price_d"];
            day = t.Days;
            hours = Convert.ToInt32(t.TotalHours);
            pay = price_h + (hours - 1) * price_h * 0.5f;
            if (pay > price_d)
                pay = price_d;
            pay += price_d * t.Days;

            return (int)pay;

        }
        private void btnDatPhong_click(object sender, EventArgs e)
        {
            if (checkFill() && checkTime())
            {
                STATISTIC Statistic = new STATISTIC();
                int pay = CalPay();

                int current_status = 0;
                TimeSpan t = dtpFrom.Value - DateTime.Now;
                if (t.TotalMinutes > 30)
                {
                    current_status = 0;
                }
                else
                {
                    current_status = 1;
                }
                int id_bill = BillSQL.AddBill(nameRoom, dtpFrom.Value, dtpTo.Value, current_status, pay, 0);
                if (id_bill > 0)
                {
                    if (Customer.AddCustomer(txtTenKhach.Text, txtCMND.Text, txtSdt.Text, id_bill, txtDescription.Text, 1))
                    {
                        RoomSQL.EditStatusRoom(nameRoom, current_status);
                        Statistic.AddEvent("Giao phòng " + cbTenPhong.Text, int.Parse(txtTong.Text), "Khách:" + txtTenKhach.Text, GlobalVar._id, DateTime.Now);
                        MessageBox.Show("Đặt phòng thành công");
                    }
                    else
                        MessageBox.Show("Thêm khách hàng không thành công", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Lỗi lấy ID Hoá đơn");
                }

            }
        }

        private bool checkTime()//dùng trong trường hợp đặt phòng,kiểm tra xem thời gian của những lần đặt phòng 
        {                       //khác có trùng với lần này không       
            if((dtpTo.Value-dtpFrom.Value).TotalMinutes<59)
            {
                MessageBox.Show("Thời gian thuê phòng ít nhất là 1h","Đặt phòng",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            DataTable dt = BillSQL.GetAllBillByRoom(this.nameRoom);
            if (dt.Rows.Count == 0)
                return true;
            TimeSpan t;
            DateTime Checkin, Checkout;
            foreach (DataRow item in dt.Rows)
            {
                if ((int)item["id_bill"] != this.id_bill)
                {
                    Checkin = (DateTime)(item["checkin"]);
                    Checkout = (DateTime)(item["checkout"]);
                    if ((Checkin<dtpFrom.Value && Checkout>dtpFrom.Value) || (Checkout>dtpTo.Value && Checkin<dtpTo.Value)
                        ||(Checkin>dtpFrom.Value && Checkout<dtpTo.Value))
                    {
                        MessageBox.Show("Trong thời gian này đã có người đặt phòng", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;

        }

        private void btnNhanPhong_click(object sender, EventArgs e)
        {
            STATISTIC Statistic = new STATISTIC();
            DialogResult re = MessageBox.Show("Nhận phòng", "Book Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                if (checkFill() && checkTime())
                {
                    int pay = CalPay();//Viết hàm tính tiền sau
                    if (BillSQL.EditBill(cbTenPhong.SelectedItem.ToString(), dtpFrom.Value, dtpTo.Value, 1, pay, 0, id_bill))
                    {
                        if (Customer.EditCustomer(txtTenKhach.Text, txtCMND.Text, txtSdt.Text, id_bill,txtDescription.Text,1))
                        {
                            RoomSQL.EditStatusRoom(nameRoom, 1);
                            Statistic.AddEvent("Giao phòng " + cbTenPhong.Text, int.Parse(txtTong.Text), "Khách:" + txtTenKhach.Text, GlobalVar._id, DateTime.Now);
                            MessageBox.Show("Nhận phòng thành công");
                        }
                    }
                }
            }
        }

        private bool checkFill()
        {
            DateTime hientai = DateTime.Now;
            if (txtTenKhach.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCMND.Text.Trim() == "" || !txtCMND.Text.All(char.IsNumber))
            {
                MessageBox.Show("Vui lòng nhập lại CMND khách hàng", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSdt.Text.Trim() == "" || !txtSdt.Text.All(char.IsNumber))
            {
                MessageBox.Show("Vui lòng nhập SĐT khách hàng", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(dtpFrom.Value<hientai.AddMinutes(-20)||dtpTo.Value<hientai||dtpFrom.Value>dtpTo.Value)
            {
                MessageBox.Show("Ngày đặt không hợp lệ!", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }    
            return true;
        }

        private void cleanField()
        {
            try
            {
                txtIDBill.Text = "";
                cbTenPhong.SelectedItem = null;
                dtpFrom.Value = DateTime.Now;
                dtpTo.Value = DateTime.Now;
                txtCMND.Text = "";
                txtSdt.Text = "";
                txtDescription.Text = "";
                txtStatus.Text = "";
                txtType.Text = "";
                txtTong.Text = "";
            }
            catch
            {

            }
        }
        #region LoadForm

        private void BookRoomForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = RoomSQL.GetAllRoom(true);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    cbTenPhong.Items.Add(data.Rows[i]["room"].ToString());
                    if (data.Rows[i]["room"].ToString() == nameRoom)
                        cbTenPhong.SelectedIndex = i;
                }
                DataTable dt = RoomSQL.GetTypeAndStatusRoom(nameRoom);
                txtStatus.Text = dt.Rows[0][0].ToString().Trim();
                txtStatus.ReadOnly = true;
                txtType.Text = dt.Rows[0][1].ToString().Trim();
                txtType.ReadOnly = true;
                //TypeCCB.SelectedItem = dt.Rows[0][1].ToString().Trim();
                if (this.func == 1)
                {
                    this.dtpFrom.Value = this.dtpTo.Value = DateTime.Now;
                    this.btnDatPhong.Tag = "1";
                    this.btnDatPhong.Click += btnDatPhong_click;
                }
                else
                {
                    dt = BillSQL.GetBillCheckinMin(nameRoom);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm được giao dịch");
                        btnDatPhong.Text = "Đặt phòng";
                        btnDatPhong.Tag = "1";
                        btnDatPhong.Click += btnDatPhong_click;
                        return;
                    }
                    dtpFrom.Value = DateTime.Parse(dt.Rows[0]["checkin"].ToString());
                    dtpTo.Value = DateTime.Parse(dt.Rows[0]["checkout"].ToString());
                    this.id_bill = int.Parse(dt.Rows[0][0].ToString());
                    dt = Customer.GetCustomerOwnByIDBill(id_bill);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm được khách hàng đã đặt phòng");
                        btnDatPhong.Text = "Đặt phòng";
                        btnDatPhong.Tag = "1";
                        btnDatPhong.Click += btnDatPhong_click;
                        return;
                    }
                    this.txtCMND.Text = dt.Rows[0]["cmnd"].ToString();
                    this.txtSdt.Text = dt.Rows[0]["phone"].ToString();
                    this.txtTenKhach.Text = dt.Rows[0]["name"].ToString();
                    this.btnDatPhong.Text = "Nhận phòng";
                    this.btnDatPhong.Tag = "2";//đánh dấu đang gán sự kiện nhận phòng
                    this.btnDatPhong.Click += btnNhanPhong_click;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearEvent()//xoá sự kiện btnDatPhong
        {
            if (btnDatPhong.Tag.ToString() == "1")
            {
                btnDatPhong.Click -= btnDatPhong_click;
            }
            else if (btnDatPhong.Tag.ToString()== "2")
            {
                btnDatPhong.Click -= btnNhanPhong_click;
            }
        }
        private int Pay(TimeSpan time)
        {
            DataTable dt = RoomSQL.GetPriceRoom(this.nameRoom);
            int price_h = int.Parse(dt.Rows[0][0].ToString());
            int price_d = int.Parse(dt.Rows[0][1].ToString());
            int pay = 0;
            if (time.TotalDays > 0)
            {
                pay += (int)(time.TotalDays) * price_d;
            }
            else
            {
                pay += (int)time.TotalHours * price_h;
            }
            return pay;
        }
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

            TimeSpan dt = dtpTo.Value - dtpFrom.Value;
            if (dt.TotalMinutes < 0)
            {
                dtpFrom.Value = DateTime.Now;
                txtTong.Text = "";
            }
            else
            {
                txtTong.Text = CalPay().ToString();
                txtTong.ReadOnly = true;
                //txtTong.Text = dt.Days.ToString() + " Ngày " + dt.Hours.ToString() + " giờ " + dt.Minutes.ToString() + " phút";
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan dt = dtpTo.Value - dtpFrom.Value;
            if (dt.TotalMinutes < 0)
            {
                dtpTo.Value = DateTime.Now;
                txtTong.Text = "";
            }
            else
            {
                txtTong.Text = CalPay().ToString();
            }
        }

        private void cbTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenPhong.SelectedItem != null)
            {
                if (nameRoom != cbTenPhong.SelectedItem.ToString())
                {
                    nameRoom = cbTenPhong.SelectedItem.ToString();
                    DataTable dt = RoomSQL.GetTypeAndStatusRoom(nameRoom);
                    txtStatus.Text = dt.Rows[0][0].ToString().Trim();
                    txtType.Text = dt.Rows[0][1].ToString().Trim();
                    //TypeCCB.SelectedItem = dt.Rows[0][1].ToString().Trim();
                }
            }
        }
        #endregion load

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (id_bill <= 0)
            {
                MessageBox.Show("Vui lòng thực hiện thao tác đặt phòng trước", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InfoCustomerForm infoFrm = new InfoCustomerForm(id_bill);
                infoFrm.ShowDialog();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (!int.TryParse(txtIDBill.Text.Trim(), out id))
            {
                MessageBox.Show("Vui lòng kiểm tra lại ID Bill", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable data = BillSQL.GetBillByID(id);
            if (data.Rows.Count < 1)
            {
                MessageBox.Show("Không tìm thấy hoá đơn này", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                nameRoom = data.Rows[0]["room"].ToString();
                for (int i = 0; i < cbTenPhong.Items.Count; i++)
                {
                    if (cbTenPhong.Items[i].ToString() == nameRoom)
                    {
                        cbTenPhong.SelectedIndex = i;
                        break;
                    }
                }
                DataTable dt = RoomSQL.GetTypeAndStatusRoom(nameRoom);
                txtStatus.Text = dt.Rows[0][0].ToString().Trim();
                txtType.Text = dt.Rows[0][1].ToString().Trim();

                dtpTo.Value = (DateTime)(data.Rows[0]["checkout"]);
                dtpFrom.Value = (DateTime)(data.Rows[0]["checkin"]);

                dt = Customer.GetCustomerByIDBill(id);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng");
                    return;
                }

                txtCMND.Text = dt.Rows[0]["cmnd"].ToString();
                txtTenKhach.Text = dt.Rows[0]["name"].ToString();
                txtSdt.Text = dt.Rows[0]["phone"].ToString();
                clearEvent();
                this.btnDatPhong.Click += btnNhanPhong_click;

            }
            catch { }
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
