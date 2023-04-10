using Hotel.DAO;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class CheckOutHotelForm : Form
    {
        public CheckOutHotelForm()
        {
            InitializeComponent();
        }
        private string room;
        private string cmnd;
        private int id_bill = 0;
        private int totalpay = 0;

        SERVICE ServiceSQL = new SERVICE();
        BILL BillSQL = new BILL();
        Room RoomSQL = new Room();
        public CheckOutHotelForm(string room)
        {
            InitializeComponent();
            this.room = room;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private int CalPay(DateTime Checkout)//Tính tiền, có tính phạt 
        {
            TimeSpan t = Checkout - dtpFrom.Value;
            TimeSpan t2 = dtpTo.Value - dtpFrom.Value;
            int hours = 0, day = 0;
            float pay = 0;
            System.Data.DataTable data = RoomSQL.GetPriceRoom(this.room);
            int price_h = (int)data.Rows[0]["price_h"], price_d = (int)data.Rows[0]["price_d"];
            int dayover = t2.Days - t.Days;
            int hoursover = t2.Hours - t.Hours;
            float payover = 0;
            payover += hoursover * price_h * 1.5f;//phạt 50%
            if (payover > price_d)
                payover = price_d;
            payover += price_d * 1.5f * dayover;

            day = t.Days;
            hours = Convert.ToInt32(t.TotalHours);
            pay = price_h + (hours - 1) * price_h * 0.5f;
            if (pay > price_d)
                pay = price_d;
            pay += price_d * t.Days;

            return (int)(pay + payover);
        }

        private void CheckOutHotelForm_Load(object sender, EventArgs e)
        {
            BackColor = Lib._colorBackgroundMain;

            System.Data.DataTable dt = BillSQL.GetCheckOutByRoom(this.room);
            if (dt.Rows.Count == 0 || dt.Rows.Count > 1)//Điều kiện để xác định chỉ có 1 bill đang thuê phòng
            {
                MessageBox.Show("Không tồn tại giao dịch hoặc có nhiều hơn 2 giao dịch. Vui lòng kiểm tra lại giao dịch");
                return;
            }

            this.id_bill = (int)dt.Rows[0]["id_bill"];
            dtpFrom.Value = (DateTime)(dt.Rows[0]["checkin"]);
            if ((DateTime)(dt.Rows[0]["checkout"]) > DateTime.Now)
                dtpTo.Value = (DateTime)(dt.Rows[0]["checkout"]);
            else
            {
                dtpTo.Value = DateTime.Now;
            }
            totalpay = CalPay((DateTime)(dt.Rows[0]["checkout"]));
            this.cmnd = dt.Rows[0]["cmnd"].ToString();

            txtCMND.Text = this.cmnd;
            txtPhong.Text = this.room;
            txtTenKhachHang.Text = dt.Rows[0]["name"].ToString();

            dt = ServiceSQL.GetServiceInRoom(room);
            dt.Rows.Add(new object[] { 0, "Phòng " + this.room, null, 1, totalpay });
            dgvDichVu.DataSource = dt;
            int total = 0;
            foreach (DataGridViewRow item in dgvDichVu.Rows)
            {
                total += Convert.ToInt32(item.Cells["pay"].Value);
            }
            lbTong.Text = "Thanh toán: " + total.ToString();
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename, string text, string text2)
        {
            try
            {
                if (DGV.Rows.Count != 0)
                {
                    int RowCount = DGV.Rows.Count + 1;
                    int ColumnCount = DGV.Columns.Count;

                    Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                    oDoc.Application.Visible = true;
                    Object missing = System.Reflection.Missing.Value;
                    Object oEndOfDoc = "\\endofdoc";
                    oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                    Microsoft.Office.Interop.Word.Paragraph paraHeading = oDoc.Content.Paragraphs.Add(ref missing);
                    paraHeading.Range.Text = "KHÁCH SẠN DC";
                    paraHeading.Range.Font.Size = 16;
                    paraHeading.Range.Font.Name = "Times New Roman";
                    paraHeading.Range.Bold = 1;
                    paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    paraHeading.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                    paraHeading.Range.InsertParagraphAfter();
                    paraHeading.Range.Text = "--------------------***--------------------";
                    paraHeading.Range.InsertParagraphAfter();
                    paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    paraHeading.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;

                    paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                    paraHeading.Range.Font.Size = 12;
                    paraHeading.Range.Font.Name = "Times New Roman";
                    paraHeading.Range.Bold = 0;
                    paraHeading.Range.InsertParagraphAfter();
                    paraHeading.Range.Text = text;


                    Table firstTable = oDoc.Tables.Add(paraHeading.Range, RowCount, ColumnCount, ref missing, ref missing);

                    firstTable.Borders.Enable = 1;
                    int i = -1, j = 0;
                    foreach (Row row in firstTable.Rows)
                    {
                        foreach (Cell cell in row.Cells)
                        {
                            //Header row  
                            if (cell.RowIndex == 1)
                            {
                                cell.Range.Text = DGV.Columns[j].HeaderText;
                                cell.Range.Font.Bold = 1;
                                //other format properties goes here  
                                cell.Range.Font.Name = "Arial";
                                cell.Range.Font.Size = 13;

                                cell.Shading.BackgroundPatternColor = WdColor.wdColorBrightGreen;
                                //Center alignment for the Header cells  
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                            }
                            //Data row  
                            else
                            {
                                cell.Range.Text = DGV.Rows[i].Cells[j].Value.ToString();
                                cell.Range.Font.Name = "Arial";
                                cell.Range.Font.Size = 12;

                                //Center alignment for the Header cells  
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                            j++;
                        }
                        j = 0; i++;
                    }


                    paraHeading.Range.Font.Name = "Arial";
                    paraHeading.Range.Font.Size = 14;
                    paraHeading.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    paraHeading.Range.InsertParagraphAfter();
                    paraHeading.Range.Text = text2;


                    oDoc.SaveAs2(filename);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void TotalPay()
        {
            this.totalpay = 0;
            foreach (DataGridViewRow item in dgvDichVu.Rows)
            {
                totalpay += Convert.ToInt32(item.Cells["pay"].Value);
            }
            lbTong.Text = "Thanh toán: " + totalpay.ToString() + " vnđ";
        }
        private int CheckStatus()
        {
            SqlCommand command = new SqlCommand("select count(*) from bill where room= @room and status=0");
            command.Parameters.Add("@room", SqlDbType.NVarChar).Value = this.room;
            if (BillSQL.GetAllBilMulti(command).Rows.Count > 1)//kiểm tra xem phòng đó còn
                return 0;                                             //có người đặt nữa hay không
            return 2;
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn in hoá đơn", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EMPLOYEES EmployeeSQL = new EMPLOYEES();
                System.Data.DataTable dt = EmployeeSQL.getEmployeeByID(GlobalVar._id);
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = "*.docx";
                savefile.Filter = "Word documents files(*.docx)|*.docx";
                string text = $"Mã giao dịch: " + id_bill.ToString() + "\n"
                    + $"Tên khách hàng: {txtTenKhachHang.Text,-30}" +
                    "Thời điểm vào:" + dtpFrom.Value.ToString("g") + "\n"
                    + $"Phòng: {txtPhong.Text,-43}"
                    + "Thời điểm rời:" + dtpTo.Value.ToString("g") + "\n" +
                    "Chi tiêt dịch vụ:" + "\n";

                string text2 = "Thu ngân\n" + dt.Rows[0][1].ToString();
                if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
                {
                    Export_Data_To_Word(dgvDichVu, savefile.FileName, text, text2);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            int status = CheckStatus();
            DeleteServiceRoom();//Cập nhật lại số lượng các dịch trong các phòng
            RoomSQL.EditStatusRoom(room, status);//Sửa lại trạng thái phòng
            BillSQL.EditBill(room, dtpFrom.Value, dtpTo.Value, -1, totalpay, 1, id_bill);//Cập nhập lại thông tin giao dịch

            STATISTIC Statistic = new STATISTIC();
            Statistic.AddStatistic("Thanh toán phòng " + txtPhong.Text, totalpay, 1, DateTime.Now);//Tạo phiếu thống kê
            Statistic.AddEvent("Thanh toán phòng " + txtPhong.Text, totalpay, "Tính tiền", GlobalVar._id, DateTime.Now);//Tạo sự kiện để theo dõi các hoạt động
            if (MessageBox.Show("CheckOut thành công", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
            }

        }
        private void DeleteServiceRoom()
        {
            foreach (DataGridViewRow item in dgvDichVu.Rows)
            {
                ServiceSQL.UpdateServiceInRoom(this.room, Convert.ToInt32(item.Cells["id"].Value), -Convert.ToInt32(item.Cells["count"].Value));
            }
            ServiceSQL.DeleteServiceEmptyInRoom();
        }
        private void dgvDichVu_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dgvDichVu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow dr = dgvDichVu.Rows[e.RowIndex];
                int count = 0;
                if (!int.TryParse(dr.Cells["price"].Value.ToString(), out count))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dr.Cells["pay"].Value = Convert.ToInt32(dr.Cells["count"].Value) * Convert.ToInt32(dr.Cells["price"].Value);
                TotalPay();
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
