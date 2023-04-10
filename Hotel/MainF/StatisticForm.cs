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
using System.Windows.Forms.DataVisualization.Charting;

namespace Hotel
{
    public partial class StatisticForm : Form
    {

        private STATISTIC StatisticSQL = new STATISTIC();
        private BILL BillSQL = new BILL();
        private int totalSalary = 0;
        private string roomMax = "", roomMin = "", MonthMax = "", MonthMin = "";
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            ShowAll();

            chartRevenueRoom.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartRevenueRoom.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            int position = 0;
            int size = 10;
            chartRevenueRoom.ChartAreas[0].AxisX.ScaleView.Zoom(position, size);
            chartRevenueRoom.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

            // set scrollbar small change to blockSize (e.g. 100)
            chartRevenueRoom.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 10;

            chartRevenueDate.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartRevenueDate.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            chartRevenueDate.ChartAreas[0].AxisX.ScaleView.Zoom(position, 6);
            chartRevenueDate.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

            // set scrollbar small change to blockSize (e.g. 100)
            chartRevenueDate.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 6;
        }
        private void ShowAll()
        {
            System.Data.DataTable dt = StatisticSQL.GetAllRevenueByRoom();
            dgvRevenueRoom.DataSource = dt;
            chartRevenueRoom.DataSource = dt;
            chartRevenueRoom.Series["Doanh thu"].XValueMember = "room";
            chartRevenueRoom.Series["Doanh thu"].YValueMembers = "revenue";

            //Doanh thu theo ngày/tháng
            System.Data.DataTable dt2 = StatisticSQL.GetAllRevenueByDate();



            dgvRevenueDate.DataSource = dt2;
            chartRevenueDate.DataSource = dt2;

            chartRevenueDate.Series["Doanh thu"].XValueMember = "date";
            chartRevenueDate.Series["Doanh thu"].YValueMembers = "revenue";

            lbRoomMax.Text = "";
            lbRoomMin.Text = "";
            lbMonthMin.Text = "";
            lbMonthMax.Text = "";
            if (dt.Rows.Count > 0)
            {
                float max = 0, min = float.Parse(dt.Rows[0]["revenue"].ToString());
                roomMin = dt.Rows[0]["room"].ToString();
                foreach (DataRow item in dt.Rows)
                {
                    if (max < float.Parse(item["revenue"].ToString()))
                    {
                        roomMax = item["room"].ToString();
                        max = float.Parse(item["revenue"].ToString());
                    }
                    if (min > float.Parse(item["revenue"].ToString()))
                    {
                        roomMin = item["room"].ToString();
                        min = float.Parse(item["revenue"].ToString());
                    }
                }

            }

            if (dt2.Rows.Count > 0)
            {
                float max = 0, min = float.Parse(dt2.Rows[0]["revenue"].ToString());
                MonthMin = dt2.Rows[0]["date"].ToString();
                foreach (DataRow item in dt2.Rows)
                {
                    if (max < float.Parse(item["revenue"].ToString()))
                    {
                        MonthMax = item["date"].ToString();
                        max = float.Parse(item["revenue"].ToString());
                    }
                    if (min > float.Parse(item["revenue"].ToString()))
                    {
                        MonthMin = item["date"].ToString();
                        min = float.Parse(item["revenue"].ToString());
                    }
                }
            }
            lbMonthMax.Text = "Tháng có doanh thu cao nhất:" + MonthMax;
            lbMonthMin.Text = "Tháng có doanh thu thấp nhất:" + MonthMin;
            lbRoomMax.Text = "Phòng có doanh thu cao nhất:" + roomMax;
            lbRoomMin.Text = "Phòng có doanh thu thấp nhất:" + roomMin;

            //chartRevenue.Series["Doanh thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void ShowByDate()
        {
            System.Data.DataTable dt = StatisticSQL.GetAllRevenueByRoom(dtpFrom.Value, dtpTo.Value);
            dgvRevenueRoom.DataSource = dt;
            chartRevenueRoom.DataSource = dt;
            chartRevenueRoom.Series["Doanh thu"].XValueMember = "room";
            chartRevenueRoom.Series["Doanh thu"].YValueMembers = "revenue";
            System.Data.DataTable dt2 = StatisticSQL.GetAllRevenueByDate(dtpFrom.Value, dtpTo.Value);
            //Doanh thu theo ngày/tháng
            dgvRevenueDate.DataSource = dt2;
            chartRevenueDate.DataSource = dt2;
            chartRevenueDate.Series["Doanh thu"].XValueMember = "date";
            chartRevenueDate.Series["Doanh thu"].YValueMembers = "revenue";

            lbRoomMax.Text = "";
            lbRoomMin.Text = "";
            lbMonthMin.Text = "";
            lbMonthMax.Text = "";
            if (dt.Rows.Count > 0)
            {
                float max = 0, min = float.Parse(dt.Rows[0]["revenue"].ToString());
                foreach (DataRow item in dt.Rows)
                {
                    if (max < float.Parse(item["revenue"].ToString()))
                    {
                        roomMax = item["room"].ToString();
                        max = float.Parse(item["revenue"].ToString());
                    }
                    if (min > float.Parse(item["revenue"].ToString()))
                    {
                        roomMin = item["room"].ToString();
                        min = float.Parse(item["revenue"].ToString());
                    }
                }

            }

            if (dt2.Rows.Count > 0)
            {
                float max = 0, min = float.Parse(dt2.Rows[0]["revenue"].ToString());
                foreach (DataRow item in dt2.Rows)
                {
                    if (max < float.Parse(item["revenue"].ToString()))
                    {
                        MonthMax = item["date"].ToString();
                        max = float.Parse(item["revenue"].ToString());
                    }
                    if (min > float.Parse(item["revenue"].ToString()))
                    {
                        MonthMin = item["date"].ToString();
                        min = float.Parse(item["revenue"].ToString());
                    }
                }
            }
            lbMonthMax.Text = "Tháng có doanh thu cao nhất:" + MonthMax;
            lbMonthMin.Text = "Tháng có doanh thu thấp nhất:" + MonthMin;
            lbRoomMax.Text = "Phòng có doanh thu cao nhất:" + roomMax;
            lbRoomMin.Text = "Phòng có doanh thu thấp nhất:" + roomMin;



        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            try
            {
                chartRevenueRoom.Series["Doanh thu"].Points.Clear();
                chartRevenueDate.Series["Doanh thu"].Points.Clear();
                ShowByDate();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                chartRevenueRoom.Series["Doanh thu"].Points.Clear();
                chartRevenueDate.Series["Doanh thu"].Points.Clear();
                ShowAll();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void Export_Data_To_Word(DataGridView DGV,int typePage, string filename, string text1, string text2)
        {
            try
            {
                if (DGV.Rows.Count != 0)
                {
                    int RowCount = DGV.Rows.Count;
                    int ColumnCount = DGV.Columns.Count;

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


                    Table firstTable = oDoc.Tables.Add(paraHeading.Range, RowCount, ColumnCount, ref missing, ref missing);

                    firstTable.Borders.Enable = 1;
                    int i = 0, j = 0;
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
                                cell.Range.Font.Size = 14;
                                //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
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
                                cell.Range.Font.Size = 13;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                            j++;
                        }
                        j = 0; i++;
                    }


                    paraHeading.Range.Text = "Nhận xét" + "\n" + text2;
                    paraHeading.Range.Font.Name = "Arial";
                    paraHeading.Range.Font.Size = 14;
                    paraHeading.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    paraHeading.Range.InsertParagraphAfter();

                    oDoc.SaveAs2(filename);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnInfoWork_Click(object sender, EventArgs e)
        {
            string query = "";
            if (rbDate.Checked == true)
            {
                query = " CAST(A.date as DATE)=@date ";
            }
            else
            {
                query = " CAST(A.date as DATE)>=@date1 and  CAST(A.date as DATE)<=@date2 ";
            }
            if (cboxID.Checked == true)
            {
                if (query != "")
                    query += " and";
                query += " E.id=@id_employee";

            }
            query = " select A.id_employee as [ID],E.name as [Họ và tên],case when A.status =1 then N'Trực chính' else " +
                "case when A.status = 0 then N'Chưa trực' else N'Vắng' end end as [Tình trạng] " +
                "from assignment as A " +
                "inner join employees as E on E.id = A.id_employee  " +
                "inner join type_employee as T on T.id = E.type where " + query;

            SqlCommand command = new SqlCommand(query);
            if (rbDate.Checked == true)
            {
                command.Parameters.Add("@date", SqlDbType.Date).Value = dtpFromEmployee.Value;
            }
            else
            {
                command.Parameters.Add("@date1", SqlDbType.Date).Value = dtpFromEmployee.Value;
                command.Parameters.Add("@date2", SqlDbType.Date).Value = dtpToEmployee.Value;
            }
            if (cboxID.Checked == true)
            {
                command.Parameters.Add("@id_employee", SqlDbType.Int).Value = int.Parse(txtIDEmployee.Text);

            }
            dgvWorking.Tag = "1";
            dgvWorking.DataSource = StatisticSQL.GetInfoEmployee(command);

        }

        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInfoSalary_Click(object sender, EventArgs e)
        {
            string query = "";
            if (rbDate.Checked == true)
            {
                query = " CAST(A.date as DATE)=@date ";
            }
            else
            {
                query = " CAST(A.date as DATE)>=@date1 and  CAST(A.date as DATE)<=@date2 ";
            }
            if (cboxID.Checked == true)
            {
                if (query != "")
                    query += " and";
                query += " E.id=@id_employee";

            }
            query = " select K.id_employee as ID,K.name as [Họ và tên]," +
            "ROUND(sum(K.work*K.salary/1000),0) as Salary " +
           "from (select A.id_employee, E.name, A.status,work,salary " +
             " from assignment as A " +
           "inner join employees as E on E.id = A.id_employee " +
           "inner join type_employee as T on T.id = E.type where" + query + ") as K group by K.id_employee,K.name";

            SqlCommand command = new SqlCommand(query);
            if (rbDate.Checked == true)
            {
                command.Parameters.Add("@date", SqlDbType.Date).Value = dtpFromEmployee.Value;
            }
            else
            {
                command.Parameters.Add("@date1", SqlDbType.Date).Value = dtpFromEmployee.Value;
                command.Parameters.Add("@date2", SqlDbType.Date).Value = dtpToEmployee.Value;
            }
            if (cboxID.Checked == true)
            {
                command.Parameters.Add("@id_employee", SqlDbType.Int).Value = int.Parse(txtIDEmployee.Text);

            }
            dgvWorking.DataSource = StatisticSQL.GetInfoEmployee(command);
            CalSalary();
            dgvWorking.Tag = "2";
            LoadChartEmployee(dgvWorking.DataSource);
        }

        private void CalSalary()
        {
            double total = 0;
            foreach (DataGridViewRow item in dgvWorking.Rows)
            {
                try
                {
                    total = total + Convert.ToDouble(item.Cells[4].Value);
                }
                catch { }

            }
            totalSalary = Convert.ToInt32(total);
            lbTotal.Text = "Tổng lương:" + ((float)totalSalary / 1000).ToString() + " Triệu";
        }
        #region chart
        private void LoadChartEmployee(object dt)
        {
            chartEmployee.Visible = true;
            chartEmployeeCount.Visible = false;
            chartEmployee.DataSource = dt;
            chartEmployee.Series["Lương"].XValueMember = "Họ và tên";
            chartEmployee.Series["Lương"].YValueMembers = "Nhận";
            chartEmployee.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartEmployee.ChartAreas[0].AxisX.ScaleView.Zoom(0, 10);
            chartEmployee.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

            // set scrollbar small change to blockSize (e.g. 100)
            chartEmployee.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 10;
        }

        

        private void LoadChartStatis(object dt)
        {
            chartStatisDay.DataSource = dt;
            chartStatisDay.Series["Thu"].XValueMember = "Ngày";
            chartStatisDay.Series["Thu"].YValueMembers = "Thu";
            chartStatisDay.Series["Chi"].XValueMember = "Ngày";
            chartStatisDay.Series["Chi"].YValueMembers = "Chi";
            chartStatisDay.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartStatisDay.ChartAreas[0].CursorX.AutoScroll = true;
            chartStatisDay.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }

        private void LoadChartService(object dt)
        {
            chartService.DataSource = dt;
            chartService.Series["Count"].XValueMember = "name";
            chartService.Series["Count"].YValueMembers = "count";
            chartService.Series["Used"].XValueMember = "name";
            chartService.Series["Used"].YValueMembers = "used";
            chartService.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartService.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            chartService.ChartAreas[0].AxisX.ScaleView.Zoom(0, 8);
            chartService.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

            // set scrollbar small change to blockSize (e.g. 100)
            chartService.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 8;

        }
        #endregion
        private void btnPaySalary_Click(object sender, EventArgs e)
        {
            if (cboxID.Checked == true)
            {
                MessageBox.Show("Phải thanh toán lương cho tất cả nhân viêc làm việc trong ngày. Vui lòng thử lại");
                return;
            }
            if (rbRangeDate.Checked == true)
            {
                MessageBox.Show("Chỉ thanh toán lương cho 1 ngày. Vui lòng thử lại");
                return;
            }
            if (StatisticSQL.ExistStatistic("Thanh toán lương", dtpFrom.Value))
            {
                MessageBox.Show("Lương của ngày" + dtpFrom.Value.ToString("d") + " đã được thanh toán. Vui lòng không thanh toán lại");
                return;
            }
            StatisticSQL.AddStatistic("Thanh toán lương", totalSalary * 1000, -1, dtpFrom.Value);
            StatisticSQL.AddEvent("Thanh toán lương", totalSalary * 1000, "Ngày " + DateTime.Now.ToString("d"), GlobalVar._id, DateTime.Now);
            MessageBox.Show("Thanh toán thành công");
        }

        private void btnShowAllService_Click(object sender, EventArgs e)
        {
            try
            {
                SERVICE Service = new SERVICE();
                dgvService.RowTemplate.Height = 80;
                dgvService.DataSource = Service.GetAllService();
                DataGridViewImageColumn Pic = new DataGridViewImageColumn();
                Pic = (DataGridViewImageColumn)dgvService.Columns["image"];
                Pic.ImageLayout = DataGridViewImageCellLayout.Stretch;

                int max = 0, min = (int)dgvService.Rows[0].Cells["used"].Value;
                string namemax = "", namemin = "";
                foreach (DataGridViewRow item in dgvService.Rows)
                {
                    if (max <= (int)item.Cells["used"].Value)
                    {
                        max = (int)item.Cells["used"].Value;
                        namemax = item.Cells["name"].Value.ToString();
                    }

                    if (min >= (int)dgvService.Rows[0].Cells["used"].Value)
                    {
                        min = (int)item.Cells["used"].Value;
                        namemin = item.Cells["name"].Value.ToString();
                    }
                }
                lbMaxService.Text = "Dịch vụ tiêu thụ nhiều nhất:" + namemax;
                lbMinService.Text = "Dịch vụ tiêu thụ ít nhất:" + namemin;
                LoadChartService(dgvService.DataSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Toang", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowChartEmployee_Click(object sender, EventArgs e)
        {
            if (dgvWorking.Tag.ToString() != "1")
                if (btnShowChartEmployee.Tag.ToString() == "1")
                {
                    this.btnShowChartEmployee.BackgroundImage = global::Hotel.Properties.Resources.expand_arrow_96px4;
                    pnlMainEmployee.Dock = DockStyle.Fill;
                    btnShowChartEmployee.Tag = "2";
                }
                else
                {
                    this.btnShowChartEmployee.BackgroundImage = global::Hotel.Properties.Resources.expand_arrow_96px;
                    pnlMainEmployee.Dock = DockStyle.None;
                    btnShowChartEmployee.Tag = "1";
                }

        }

        private void btnPrintService_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "Word documents files(*.docx)|*.docx";
            string text = "Thống kê dịch vụ khách sạn ",
                text2 = "Nhận xét:" + "\n" + lbMaxService.Text + "\n" + lbMinService.Text;

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                ExportDataToWordImage(dgvService, savefile.FileName, text, text2);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowChartService_Click(object sender, EventArgs e)
        {
            if (btnShowChartService.Tag.ToString() == "1")
            {
                this.btnShowChartService.BackgroundImage = global::Hotel.Properties.Resources.expand_arrow_96px4;
                pnlServiceMain.Dock = DockStyle.Fill;
                btnShowChartService.Tag = "2";
            }
            else
            {
                this.btnShowChartService.BackgroundImage = global::Hotel.Properties.Resources.expand_arrow_96px;
                pnlServiceMain.Dock = DockStyle.None;
                btnShowChartService.Tag = "1";
            }
        }

        private void dtpToEmployee_ValueChanged(object sender, EventArgs e)
        {
            if ((dtpTo.Value - DateTime.Now).TotalHours > 23)
            {
                MessageBox.Show("Không có thông tin lương thưởng của ngày mai");
                dtpTo.Value = DateTime.Now;
            }
        }

        

        private void btnPrintInfoEmployee_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "Word documents files(*.docx)|*.docx";
            string text = "";
            if (dgvWorking.Tag.ToString() == "1") {
                text = "Thông tin làm việc ngày ";
            }
            else if (dgvWorking.Tag.ToString() == "2")
            {
                text = "Thôgn tin lương ngày ";
            }
            else text = "Thông tin chuyên cần của nhân viên ngày ";

            string text1 = "";
            if (rbDate.Checked)
            {
                text1 = text + dtpToEmployee.Value.ToString("d");
            }
            else
            {
                text1=text+ dtpToEmployee.Value.ToString("d") +
                " đến " + dtpToEmployee.Value.ToString("d");
            }
                
            string text2 = lbMaxDelay.Text + "\n" + lbMaxSoon.Text + "\n";
            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dgvWorking, 1,savefile.FileName, text1, text2);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStatis_Click(object sender, EventArgs e)
        {
            string query = "";
            if (rbStatis.Checked == true)
            {
                query = " CAST(date as DATE)=@date ";
            }
            else
            {
                query = " CAST(date as DATE)>=@date1 and  CAST(date as DATE)<=@date2 ";
            }

            query = " select id as ID,name as [Họ và tên],price as [Giá  trị]," +
                "case when type=1 then N'Thu' else N'Chi' end as [Loại],date as [Ngày] from statistic where " + query;


            SqlCommand command = new SqlCommand(query);
            if (rbStatis.Checked == true)
            {
                command.Parameters.Add("@date", SqlDbType.Date).Value = dtpFromStatis.Value;
            }
            else
            {
                command.Parameters.Add("@date1", SqlDbType.Date).Value = dtpFromStatis.Value;
                command.Parameters.Add("@date2", SqlDbType.Date).Value = dtpToStatis.Value;
            }
            dgvStatistic.Tag = "1";
            dgvStatistic.DataSource = StatisticSQL.GetInfoEmployee(command);


        }

        private void btnStatisDay_Click(object sender, EventArgs e)
        {
            string query = "";
            if (rbStatis.Checked == true)
            {
                query = " CAST(date as DATE)=@date ";
            }
            else
            {
                query = " CAST(date as DATE)>=@date1 and  CAST(date as DATE)<=@date2 ";
            }

            query = " select CAST(date as DATE) as [Ngày],ROUND(sum(case when type=1 then price else 0 end)/1000000,1) as [Thu]," +
                " ROUND(sum(case when type=-1 then price else 0 end)/1000000,1) as [Chi] from statistic where " + query + " group by CAST(date as DATE)";

            SqlCommand command = new SqlCommand(query);
            if (rbStatis.Checked == true)
            {
                command.Parameters.Add("@date", SqlDbType.Date).Value = dtpFromStatis.Value;
            }
            else
            {
                command.Parameters.Add("@date1", SqlDbType.Date).Value = dtpFromStatis.Value;
                command.Parameters.Add("@date2", SqlDbType.Date).Value = dtpToStatis.Value;
            }
            dgvStatistic.Tag = "2";
            dgvStatistic.DataSource = StatisticSQL.GetInfoEmployee(command);
            LoadChartStatis(dgvStatistic.DataSource);
        }

        private void btnShowChartStatis_Click(object sender, EventArgs e)
        {
            if (dgvStatistic.Tag.ToString() != "1")
                if (btnShowChartStatis.Tag.ToString() == "1")
                {
                    this.btnShowChartStatis.BackgroundImage = global::Hotel.Properties.Resources.expand_arrow_96px4;
                    pnlStatisMain.Dock = DockStyle.Fill;
                    btnShowChartStatis.Tag = "2";
                }
                else
                {
                    this.btnShowChartStatis.BackgroundImage = global::Hotel.Properties.Resources.expand_arrow_96px;
                    pnlStatisMain.Dock = DockStyle.None;
                    btnShowChartStatis.Tag = "1";
                }
        }

        private void dtpFromEmployee_ValueChanged(object sender, EventArgs e)
        {
            if ((dtpTo.Value - dtpFrom.Value).TotalHours > 0)
            {
                MessageBox.Show("Chọn lại ngày bắt đầu");
                dtpFrom.Value = dtpTo.Value;
            }
        }

        private void btnPrintByDate_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "Word documents files(*.docx)|*.docx";
            string text1 = "Thống kê doanh thu theo tháng";
            string text = lbMonthMax.Text + "\n" + lbMonthMin.Text + "\n";
            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dgvRevenueRoom, 0, savefile.FileName, text1, text);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrintThuChi_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = "*.docx";
                savefile.Filter = "Word documents files(*.docx)|*.docx";
                string text = "";
                if (dgvWorking.Tag.ToString() == "1")
                {
                    text = "Thống kê toàn bộ thu/chi ngày ";
                }
                else if (dgvWorking.Tag.ToString() == "2")
                {
                    text = "Thống kê thu chi theo ngày  ";
                }

                string text1 = "";
                if (rbStatis.Checked)
                {
                    text1 = text + dtpToEmployee.Value.ToString("d");
                }
                else
                {
                    text1 = text + dtpToEmployee.Value.ToString("d") +
                    " đến " + dtpToEmployee.Value.ToString("d");
                }

                string text2 = lbMaxDelay.Text + "\n" + lbMaxSoon.Text + "\n";
                if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
                {
                    Export_Data_To_Word(dgvStatistic, 1, savefile.FileName, text1, text2);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void btnShowDGV_Click(object sender, EventArgs e)
        {
            if (btnShowDGV.Tag.ToString() == "1")
            {
                this.btnShowDGV.BackgroundImage = global::Hotel.Properties.Resources.expand_arrow_96px4;
                pnlMain.Dock = DockStyle.Fill;
                btnShowDGV.Tag = "2";
            }
            else
            {
                this.btnShowDGV.BackgroundImage = global::Hotel.Properties.Resources.expand_arrow_96px;
                pnlMain.Dock = DockStyle.None;
                btnShowDGV.Tag = "1";
            }
        }

        private void btnPrintByRoom_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "Word documents files(*.docx)|*.docx";
            string text1 = "Thống kê doanh thu theo phòng";
            string text = lbRoomMax.Text + "\n" + lbRoomMin.Text + "\n";
            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dgvRevenueRoom, 0,savefile.FileName, text1, text);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ExportDataToWordImage(DataGridView DGV, string filename, string text1, string text2)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count + 1;
                int ColumnCount = DGV.Columns.Count;

                Document oDoc = new Document();
                oDoc.Application.Visible = true;
                Object missing = System.Reflection.Missing.Value;

                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                Microsoft.Office.Interop.Word.Paragraph para1 = oDoc.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 2";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Text = text1;
                para1.Range.Font.Name = "Arial";
                para1.Range.Font.Size = 20;
                para1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                para1.Range.InsertParagraphAfter();


                //Add paragraph with Heading 2 style  
                Microsoft.Office.Interop.Word.Paragraph para2 = oDoc.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 1";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Text = "Thống kê chi tiết";
                para1.Range.Font.Name = "Arial";
                para1.Range.Font.Size = 16;
                para2.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                para2.Range.InsertParagraphAfter();



                Table firstTable = oDoc.Tables.Add(para2.Range, RowCount, ColumnCount, ref missing, ref missing);

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
                            cell.Range.Font.Size = 14;
                            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
                            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            //Center alignment for the Header cells  
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                        }
                        //Data row  
                        else
                        {
                            if (j != ColumnCount - 1)
                                cell.Range.Text = DGV.Rows[i].Cells[j].Value.ToString();
                            else
                            {
                                try
                                {
                                    byte[] imgbyte = (byte[])DGV.Rows[i].Cells["image"].Value;
                                    MemoryStream ms = new MemoryStream(imgbyte);
                                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(50, 50)));
                                    Clipboard.SetDataObject(finalPic);
                                    cell.Range.Paste();
                                    cell.Range.InsertParagraphAfter();
                                }
                                catch
                                {
                                    cell.Range.Text = "Trống";
                                }

                            }
                        }
                        j++;
                    }
                    i++;
                    j = 0;
                }

                Microsoft.Office.Interop.Word.Paragraph para3 = oDoc.Content.Paragraphs.Add(ref missing);
                object styleHeading3 = "Heading 2";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Text = text2;
                para1.Range.Font.Name = "Arial";
                para1.Range.Font.Size = 14;
                para2.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                para2.Range.InsertParagraphAfter();

                oDoc.SaveAs(filename);
            }
        }
    }
}
