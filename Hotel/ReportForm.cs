using Microsoft.Office.Interop.Word;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void lbThu_Click(object sender, EventArgs e)
        {

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            STATISTIC Statistic = new STATISTIC();
            DateTime yesterday = DateTime.Now.AddDays(-1);
            lbMain.Text = "Báo cáo ngày " + yesterday.ToString("d");
            string query = "select count(*) from bill where CAST(checkin as DATE)=@date and status=1 group by status";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.Add("@date", SqlDbType.Date).Value = yesterday;
            System.Data.DataTable dt = Statistic.GetInfoEmployee(command);
            if (dt.Rows.Count > 0)
                lbSumRoonIn.Text = "Tổng số hoá đơn thuê phòng: " + dt.Rows[0][0].ToString();
            else
                lbSumRoonIn.Text = "Tổng số hoá đơn thuê phòng: 0";

            query = "select count(*) from bill where CAST(checkin as DATE)=@date and status=-1 group by status";
            command = new SqlCommand(query);
            command.Parameters.Add("@date", SqlDbType.Date).Value = yesterday;
            dt = Statistic.GetInfoEmployee(command);
            if (dt.Rows.Count > 0)
                lbSumRoonIn.Text = "Tổng số hoá đơn trả phòng: " + dt.Rows[0][0].ToString();
            else
                lbSumRoonIn.Text = "Tổng số hoá đơn trả phòng: 0";

            query = "select count(*) from assignment where CAST(date as DATE)=@date and status<>-1 group by status";
            command = new SqlCommand(query);
            command.Parameters.Add("@date", SqlDbType.Date).Value = yesterday;
            dt = Statistic.GetInfoEmployee(command);

            if (dt.Rows.Count > 0)
                lbEmployeeWork.Text = "Tổng nhân viên làm việc: " + dt.Rows[0][0].ToString();
            else
                lbEmployeeWork.Text = "Tổng nhân viên làm việc: 0";

            query = "select count(*) from assignment where CAST(date as DATE)=@date and status=-1 group by status";
            command = new SqlCommand(query);
            command.Parameters.Add("@date", SqlDbType.Date).Value = yesterday;
            dt = Statistic.GetInfoEmployee(command);
            try
            {
                if (dt.Rows.Count > 0)
                    lbEmployeeNotWork.Text = "Tổng nhân viên vắng: " + dt.Rows[0][0].ToString();
                else
                    lbEmployeeNotWork.Text = "Tổng nhân viên vắng: 0";
            }
            catch { lbEmployeeNotWork.Text = "Tổng nhân viên vắng: 0"; }


            query = "select ROUND(sum(price)/1000000,1) from statistic where CAST(date as DATE)=@date and type=1 group by type";
            command = new SqlCommand(query);
            command.Parameters.Add("@date", SqlDbType.Date).Value = yesterday;
            dt = Statistic.GetInfoEmployee(command);
            if (dt.Rows.Count > 0)
                lbThu.Text = "Tổng thu: " + dt.Rows[0][0].ToString() + " Triệu";
            else
                lbThu.Text = "Tổng thu: 0 Triệu";

            query = "select ROUND(sum(price)/1000000,1) from statistic where CAST(date as DATE)=@date and type=-1 group by type";
            command = new SqlCommand(query);
            command.Parameters.Add("@date", SqlDbType.Date).Value = yesterday;
            dt = Statistic.GetInfoEmployee(command);
            try
            {
                if (dt.Rows.Count > 0)
                    lbChi.Text = "Tổng chi: " + dt.Rows[0][0].ToString() + " Triệu";
                else
                    lbThu.Text = "Tổng chi: 0 Triệu";
            }
            catch { lbThu.Text = "Tổng chi: 0 Triệu"; }


        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = "*.docx";
                savefile.Filter = "Word documents files(*.docx)|*.docx";
                string text = "Thông tin báo cáo ngày " + DateTime.Now.AddDays(-1).ToString("d");


                string text2 = lbSumRoonIn.Text + "\n"
                    + lbSumRoomOut.Text + "\n"
                    + lbEmployeeWork.Text + "\n"
                    + lbEmployeeNotWork.Text + "\n"
                    + lbThu.Text + "\n"
                    + lbChi.Text + "\n";
                if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
                {
                    Export_Data_To_Word(1, savefile.FileName, text, text2);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        public void Export_Data_To_Word(int typePage, string filename, string text1, string text2)
        {
            try
            {
                if (text1.Length != 0)
                {

                    Document oDoc = new Document();
                    oDoc.Application.Visible = true;
                    Object missing = System.Reflection.Missing.Value;

                    oDoc.PageSetup.Orientation = (WdOrientation)typePage;

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

                    paraHeading.Range.Font.Size = 13;
                    paraHeading.Range.Font.Name = "Times New Roman";
                    paraHeading.Range.Bold = 0;
                    paraHeading.Range.Text = text1;
                    paraHeading.Range.InsertParagraphAfter();



                    paraHeading.Range.Text = "Nhận xét" + "\n" + text2;
                    paraHeading.Range.Font.Name = "Times New Roman";
                    paraHeading.Range.Font.Size = 13;
                    paraHeading.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    paraHeading.Range.InsertParagraphAfter();

                    oDoc.SaveAs2(filename);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
