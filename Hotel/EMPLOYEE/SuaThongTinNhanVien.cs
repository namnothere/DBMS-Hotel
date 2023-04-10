using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hotel
{
    public partial class SuaThongTinNhanVien : Form
    {
        int eid;
        EMPLOYEES EmployeeSQL = new EMPLOYEES();
        public SuaThongTinNhanVien(int id)
        {
            InitializeComponent();
            eid = id;
        }

        private void UploadAVTBT_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                if ((opf.ShowDialog() == DialogResult.OK))
                {
                    AVT.Image = Image.FromFile(opf.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Toang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SuaThongTinNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
               
                DataTable table = new DataTable();
                table = EmployeeSQL.getEmployeeByID(eid);

                IDTB.Text = table.Rows[0]["id"].ToString();
                IDTB.ReadOnly = true;
                NameTB.Text = table.Rows[0]["name"].ToString();
                BDateTPK.Value = (DateTime)table.Rows[0]["bdate"];
                if (table.Rows[0]["gender"].ToString().ToUpper() == "NAM")
                {
                    MaleRB.Checked = true;
                }
                else
                    FemaleRB.Checked = true;
                int type = Convert.ToInt32(table.Rows[0]["type"].ToString());
                if (type == 0)
                {
                    QLRB.Checked = true;
                }
                else
                {
                    if (type == 1)
                        LTRB.Checked = true;
                    else
                        LCRB.Checked = true;
                }    
                    
                PhoneTB.Text = table.Rows[0]["phone"].ToString();
                CMNDTB.Text = table.Rows[0]["cmnd"].ToString();
                AddressTB.Text = table.Rows[0]["address"].ToString();
                byte[] pic;

                if (table.Rows[0]["picture"]!=System.DBNull.Value)
                {
                    pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    AVT.Image = Image.FromStream(picture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sửa thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(IDTB.Text);
                string name = NameTB.Text.Trim();
                //string lname = lastNameTextBox.Text.Trim();
                //bdDateTimePicker.Format = DateTimePickerFormat.Short;
                DateTime bdate = BDateTPK.Value;
                string phone = PhoneTB.Text.Trim();
                string adrs = AddressTB.Text.Trim();
                string cmnt = CMNDTB.Text.Trim();
                string gender = "Nam";
                int type;
                if (FemaleRB.Checked)
                {
                    gender = "Nữ";
                }
                if (QLRB.Checked)
                {
                    type = 0;
                }
                else
                {
                    if (LTRB.Checked)
                    {
                        type = 1;
                    }
                    else
                    {
                        type =2;
                    }
                }
                MemoryStream pic = new MemoryStream();
                int born_year = BDateTPK.Value.Year;
                int this_year = DateTime.Now.Year;
                if ((this_year - born_year) < 18 || (this_year - born_year) > 80)
                {
                    MessageBox.Show("Tuổi của nhân viên không hợp lệ!!", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (verif())
                    {
                        AVT.Image.Save(pic, AVT.Image.RawFormat);
                        //int ID, string name, string gender, DateTime bdate, string phone, string address, int type, MemoryStream picture , int stt);
                        if ((EmployeeSQL.CMNDExist(cmnt)))
                        {
                            if (EmployeeSQL.UpdateEmployeesByID(id, name, gender, cmnt, bdate, phone, adrs, type, pic))
                            {
                                MessageBox.Show("Sửa thông tin nhân viên thành công!", "Sửa thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Sửa thông tin nhân viên thất bại!", "Sửa thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("CMND/CCCD không hợp lệ", "Sửa thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }    

                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Sửa thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sửa thông tin nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {
            if ((IDTB.Text.Trim() == "")
                || (NameTB.Text.Trim() == "")
                || (AddressTB.Text.Trim() == "")
                || (PhoneTB.Text.Trim() == "")
                || (CMNDTB.Text.Trim() == ""))
            {
                return false;
            }
            if (!CMNDTB.Text.All(char.IsNumber))
            {
                MessageBox.Show("CMND không được chứa kí tự", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!PhoneTB.Text.All(char.IsNumber))
            {
                MessageBox.Show("Số điện thoại không được chứa kí tự", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void MaleRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
