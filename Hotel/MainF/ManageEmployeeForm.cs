using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Hotel
{
    public partial class ManageEmployeeForm : Form
    {
        public ManageEmployeeForm()
        {
            InitializeComponent();
        }

        EMPLOYEES EmployeesSQL = new EMPLOYEES();
        
        public void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            fillGrid(1);
        }
        Assignment assignment = new Assignment();
        public void fillGrid(int id)
        {
            dgvEmployee.RowTemplate.Height = 80;
            dgvEmployee.DataSource = EmployeesSQL.GetAllEmployee(id);
            DataGridViewImageColumn Pic = new DataGridViewImageColumn();
            Pic = (DataGridViewImageColumn)dgvEmployee.Columns["picture"];
            Pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void roomItemRightClick(object sender, EventArgs e)
        {
            int rID = 0;
            ToolStripItem menuItem = (ToolStripItem)sender;
            rID = Convert.ToInt32(menuItem.Name);
            if (menuItem.Text == "Refresh")
            {
                fillGrid(1);
            }
            else
            {
                if (menuItem.Text == "Add")
                {
                    ThemNhanVien themNhanVien = new ThemNhanVien();
                    themNhanVien.Show();

                    fillGrid(1);

                }
                else
                {
                    if (menuItem.Text == "Edit")
                    {
                        SuaThongTinNhanVien suaThongTinNhanVien = new SuaThongTinNhanVien(rID);
                        suaThongTinNhanVien.Show();
                    }
                    else
                    {
                        if (menuItem.Text == "By ID")
                        {
                            fillGrid(1);
                        }
                        else
                        {
                            if (menuItem.Text == "By Name")
                            {
                                fillGrid(2);
                            }
                            else
                            {
                                if (menuItem.Text == "By Type")
                                {
                                    fillGrid(3);
                                }
                                else
                                {
                                    if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên" + rID.ToString() + " chứ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        EmployeesSQL.DeleteEmployees(rID);
                                        assignment.XoaNguoiDung(rID);
                                        fillGrid(1);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nhân viên chưa được xóa", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void dgvEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    int id = Convert.ToInt32(dgvEmployee.CurrentRow.Cells["id"].Value.ToString());
                    ContextMenuStrip menuStrip = new ContextMenuStrip();
                    ToolStripMenuItem nameItem = new ToolStripMenuItem(id.ToString());
                    nameItem.Click += new EventHandler(roomItemRightClick);
                    nameItem.Name = id.ToString();
                    menuStrip.Items.Add(nameItem);

                    ToolStripMenuItem SortItem = new ToolStripMenuItem("Sort by");
                    SortItem.Click += new EventHandler(roomItemRightClick);
                    SortItem.Name = id.ToString();
                    menuStrip.Items.Add(SortItem);

                    ToolStripMenuItem byID = new ToolStripMenuItem("By ID");
                    byID.Name = id.ToString();
                    byID.Click += new EventHandler(roomItemRightClick);
                    SortItem.DropDownItems.Add(byID);

                    ToolStripMenuItem byName = new ToolStripMenuItem("By Name");
                    byName.Click += new EventHandler(roomItemRightClick);
                    byName.Name = id.ToString();
                    SortItem.DropDownItems.Add(byName);

                    ToolStripMenuItem byType = new ToolStripMenuItem("By Type");
                    byType.Click += new EventHandler(roomItemRightClick);
                    byType.Name = id.ToString();
                    SortItem.DropDownItems.Add(byType);

                    ToolStripMenuItem addItem = new ToolStripMenuItem("Add");
                    addItem.Click += new EventHandler(roomItemRightClick);
                    addItem.Name = id.ToString();
                    menuStrip.Items.Add(addItem);


                    ToolStripMenuItem editItem = new ToolStripMenuItem("Edit");
                    editItem.Click += new EventHandler(roomItemRightClick);
                    editItem.Name = id.ToString();
                    menuStrip.Items.Add(editItem);

                    ToolStripMenuItem delItem = new ToolStripMenuItem("Delete");
                    delItem.Click += new EventHandler(roomItemRightClick);
                    delItem.Name = id.ToString();
                    menuStrip.Items.Add(delItem);

                    ToolStripMenuItem refreshItem = new ToolStripMenuItem("Refresh");
                    refreshItem.Click += new EventHandler(roomItemRightClick);
                    refreshItem.Name = id.ToString();
                    menuStrip.Items.Add(refreshItem);



                    int currentMouseOverRow = dgvEmployee.HitTest(e.X, e.Y).RowIndex;
                    menuStrip.Show(dgvEmployee, new System.Drawing.Point(e.X, e.Y));

                    /*ContextMenu m = new ContextMenu();
                    m.MenuItems.Add(new MenuItem(dgvEmployee.CurrentRow.Cells["id"].Value.ToString()));
                    m.MenuItems.Add(new MenuItem("Cut"));

                    m.MenuItems.Add(new MenuItem("Copy"));
                    m.MenuItems.Add(new MenuItem("Paste"));

                    int currentMouseOverRow = dgvEmployee.HitTest(e.X, e.Y).RowIndex;

                    if (currentMouseOverRow >= 0)
                    {
                        m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                    }

                    m.Show(dgvEmployee, new Point(e.X, e.Y));*/
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn trường hợp lệ!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintBT_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                ExportDataToWord(dgvEmployee, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ExportDataToWord(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;

                Document oDoc = new Document();
                oDoc.Application.Visible = true;
                Object missing = System.Reflection.Missing.Value;

                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                Microsoft.Office.Interop.Word.Paragraph para1 = oDoc.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 2";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Text = "Thống kê doanh thu khách sạn DC";
                para1.Range.Font.Name = "Arial";
                para1.Range.Font.Size = 24;
                para1.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                para1.Range.InsertParagraphAfter();


                //Add paragraph with Heading 2 style  
                Microsoft.Office.Interop.Word.Paragraph para2 = oDoc.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 1";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Text = "Thống kê chi tiết";
                para1.Range.Font.Name = "Arial";
                para1.Range.Font.Size = 20;
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
                            cell.Range.Font.Size = 18;
                            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
                            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            //Center alignment for the Header cells  
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                        }
                        //Data row  
                        else
                        {
                            if (j != 8)
                                cell.Range.Text = DGV.Rows[i].Cells[j].Value.ToString();
                            else
                            {
                                try
                                {
                                    byte[] imgbyte = (byte[])DGV.Rows[i].Cells["picture"].Value;
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
                
                oDoc.SaveAs(filename);
            }
        }

        private void dgvEmployee_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dgvEmployee.Rows[e.RowIndex].Selected = true;
                dgvEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            }
        }
    }
}
