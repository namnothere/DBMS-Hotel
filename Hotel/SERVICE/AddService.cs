using Hotel.DAO;
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
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }
        SERVICE ServiceSQL = new SERVICE();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (checkFill())
            {
                MemoryStream image = new MemoryStream();
                pictureBox1.Image.Save(image, pictureBox1.Image.RawFormat);
                int price = int.Parse(txtPrice.Text);
                
                
                if (ServiceSQL.AddService(txtName.Text, cbType.SelectedItem.ToString(), price, txtDescription.Text,0, image ))
                {
                    MessageBox.Show("Thêm dịch vụ thành công", "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm dịch vụ không thành công", "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if(txtPrice.Text.Trim()=="" || int.TryParse(txtPrice.Text,out price) == false)
            {
                MessageBox.Show("Vui lòng điền giá dịch vụ", "Thêm Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(pictureBox1.Image==null)
            {
                MessageBox.Show("Vui lòng thêm hình ảnh dịch vụ", "Thêm Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AddService_Load(object sender, EventArgs e)
        {
            DataTable dt = ServiceSQL.GetAllType();
            foreach(DataRow item in dt.Rows)
            {
                cbType.Items.Add(item[0]);
            }
            pnlAddType.Tag= "1";
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
            catch(Exception ex)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
