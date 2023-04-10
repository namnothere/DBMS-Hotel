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

namespace Hotel
{
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }
        ManageEmployeeForm manageEmployeeForm = new ManageEmployeeForm();
        Assignment assignment = new Assignment();
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

        private void AddBT_Click(object sender, EventArgs e)
        {
            try
            {
                EMPLOYEES EmployeeSQL = new EMPLOYEES();
                int id = Convert.ToInt32(IDTB.Text);
                string name = NameTB.Text.Trim();
                //string lname = lastNameTextBox.Text.Trim();
                //bdDateTimePicker.Format = DateTimePickerFormat.Short;
                DateTime bdate = BDateTPK.Value;
                string phone = PhoneTB.Text.Trim();
                string adrs = AddressTB.Text.Trim();
                string cmnd = CMNDTB.Text.Trim();
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

                     type = 2;
                        
                    }
                }
                MemoryStream pic = new MemoryStream();
                int born_year = BDateTPK.Value.Year;
                int this_year = DateTime.Now.Year;
                string mk = "12345";
                if ((this_year - born_year) < 18 || (this_year - born_year) > 80)
                {
                    MessageBox.Show("Tuổi của nhân viên không hợp lệ!!", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (verif())
                    {
                        AVT.Image.Save(pic, AVT.Image.RawFormat);
                        if (EmployeeSQL.InsertEmployees(id, name, gender, cmnd, bdate, phone, adrs, type, pic, 0))
                        {
                            if(assignment.ThemNguoiDungMoi(id, cmnd, mk)==true)
                            {
                                MessageBox.Show("Thêm nhân viên thành công! Tên đăng nhập: "+cmnd+"Mật khẩu: "+mk, "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }    
                           // MessageBox.Show("Thêm nhân viên thành công!", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //manageEmployeeForm.CancelButton = new EventHandler(manageEmployeeForm.ManageEmployeeForm_Load);
                            manageEmployeeForm.fillGrid(1);
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại!", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CancelBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
