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
    public partial class EditService : Form
    {
        int sid;
        public EditService(int id)
        {
            InitializeComponent();
            sid = id;
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openf = new OpenFileDialog();
            openf.Filter = "Select Image(*jpg;*png;*bmp;*gif)|*jpg;*png;*bmp;*gif";
            if (openf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openf.FileName);
            }
        }
        BindingSource DataBinding = new BindingSource();
        SERVICE ServiceSQL = new SERVICE();
        Room RoomSQL = new Room();
        private void EditService_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = ServiceSQL.getServiceByID(sid);

            AddService dichvu = new AddService();
            //dichvu.Show();
            txtName.Text = table.Rows[0]["name"].ToString();
            //dichvu.cbType.DataSource = ServiceSQL.GetAllType();
            DataTable dt = ServiceSQL.GetAllType();
            foreach (DataRow item in dt.Rows)
            {
                cbType.Items.Add(item[0]);
            }
            cbType.SelectedItem = table.Rows[0]["type"].ToString();
            txtPrice.Text = table.Rows[0]["price"].ToString();
            txtDescription.Text = table.Rows[0]["description"].ToString();
            byte[] pic = (byte[])table.Rows[0]["image"];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int prince = Convert.ToInt32(txtPrice.Text);
            string decription = txtDescription.Text;
            MemoryStream image = new MemoryStream();
            pictureBox1.Image.Save(image, pictureBox1.Image.RawFormat);
            string type = cbType.SelectedItem.ToString();
            try
            {
                if (checkFill())
                {
                    if (ServiceSQL.updateServiceByID(sid, name, type, prince, decription, image))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Sửa thông tin dịch vụ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Sửa thông tin dịch vụ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }
        private bool checkFill()
        {
            int price;
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền tên dịch vụ", "Thêm Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbType.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại dịch vụ", "Thêm Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPrice.Text.Trim() == "" || int.TryParse(txtPrice.Text, out price) == false)
            {
                MessageBox.Show("Vui lòng điền giá dịch vụ", "Thêm Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng thêm hình ảnh dịch vụ", "Thêm Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddTypeService_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnlAddType.Tag.ToString() == "1")
                {
                    pnlAddType.Location = new Point(pnlAddType.Location.X, pnlAddType.Location.Y + 50);
                    pnlAddType.Tag = "2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Toang", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thêm loại dịch vụ này?", "Thêm dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                cbType.Items.Add(txtAddType.Text);
            }
            pnlAddType.Tag = "1";
            pnlAddType.Location = new Point(pnlAddType.Location.X, pnlAddType.Location.Y - 50);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            pnlAddType.Location = new Point(pnlAddType.Location.X, pnlAddType.Location.Y - 50);
            pnlAddType.Tag = "1";
        }
    }
}
