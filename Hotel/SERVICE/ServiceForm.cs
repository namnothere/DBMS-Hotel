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
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
            BackColor = Lib._colorBackgroundMain;
        }

        BindingSource DataBinding = new BindingSource();
        SERVICE ServiceSQL = new SERVICE();
        Room RoomSQL = new Room();
        int currentService=0;
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            LoadDichVu();
            LoadRoom();
        }
        private void LoadDichVu()
        {
            if (lvService.Items.Count != 0)
            {
                lvService.Items.Clear();
                lvService.Groups.Clear();
            }

            DataTable dt = ServiceSQL.GetAllType() ;
            Dictionary<string, ListViewGroup> DictGroup = new Dictionary<string, ListViewGroup>();

            foreach (DataRow item in dt.Rows)
            {
                ListViewGroup group = new ListViewGroup(item[0].ToString());
                DictGroup.Add(item[0].ToString(), group);
                lvService.Groups.Add(group);
            }
            dt = ServiceSQL.GetAllService();

            lvService.Columns.Add("Tên Dịch vụ");
            lvService.View = View.LargeIcon;
            ImageList imLarge = new ImageList() { ImageSize = new Size(72, 72) };
            ImageList imSmall = new ImageList() { ImageSize = new Size(36, 36) };
            int i = 0;

            foreach (DataRow item in dt.Rows)
            {
                ListViewItem lvitem = new ListViewItem();
                lvitem.Text = item[1].ToString();
                lvitem.Tag = item[0].ToString();
                
                
                lvitem.ImageIndex = i++;
                byte[] pic = (byte[])item["image"];
                MemoryStream picture = new MemoryStream(pic);
                imLarge.Images.Add(Image.FromStream(picture));
                imSmall.Images.Add(Image.FromStream(picture));
                DictGroup[item["type"].ToString()].Items.Add(lvitem);
                lvService.Items.Add(lvitem);
                //lvService.TopLevelControl = false;
                int id = Convert.ToInt32(item["id"].ToString());
                ContextMenuStrip menuStrip = RightClick(id);
                //lvService.Controls.Add(menuStrip);
            }
            lvService.LargeImageList = imLarge;
            lvService.SmallImageList = imSmall;

        }

        private void LoadRoom()
        {
            if (cbPhong.Items.Count != 0)
            {
                cbPhong.Items.Clear();
            }
            DataTable dt = RoomSQL.GetRoomUsed(true);
            foreach (DataRow item in dt.Rows)
            {
                this.cbPhong.Items.Add(item[0].ToString().Trim());

            }
            cbPhong.SelectedItem = null;
        }
        private void LoadServiceInRoom(string id)
        {
            
            dgvDichVu.DataSource = ServiceSQL.GetServiceInRoom(id);
            TotalPay();
        }

        private void TotalPay()
        {
            int total = 0;
            foreach (DataGridViewRow item in dgvDichVu.Rows)
            {
                total += Convert.ToInt32(item.Cells["pay"].Value);
            }
            lbTong.Text = "Tổng: " + total.ToString() + " vnđ";
        }

    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddService dichvu = new AddService();
            dichvu.Show();
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPhong.SelectedItem == null)
                    return;
                string id = cbPhong.SelectedItem.ToString();
                dgvDichVu.DataSource = ServiceSQL.GetServiceInRoom(id);
                TotalPay();
            }
            catch { }
        }

        private void dgvDichVu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow dr = dgvDichVu.Rows[e.RowIndex];
                dr.Cells["pay"].Value = Convert.ToInt32(dr.Cells["count"].Value) * Convert.ToInt32(dr.Cells["price"].Value);
                TotalPay();
            }
        }

        private void lvService_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (cbPhong.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn phòng cần thêm dịch vụ", "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ListViewItem select = lvService.SelectedItems[0];
                currentService = int.Parse(select.Tag.ToString());
                txtNameService.Text = select.Text;
                numCount.Value = 1;
            }
            catch { }
        }

        private bool RemoveServiceInList(int id)
        {
            if (cbPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng", "Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string id_room = cbPhong.SelectedItem.ToString();
            if (ServiceSQL.DeleteServiceInRoom(id_room, id ))
                return true;
            return false;
        }

        private void dgvDichVu_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá dịch vụ này ra khỏi danh sách?", "Dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (RemoveServiceInList(Convert.ToInt32(e.Row.Cells["id"].Value)))
                    MessageBox.Show("Xoá thành công", "Xoá dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Xoá không thành công", "Xoá dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }
            else
                e.Cancel = true;
        }

        private void btnResetPhong_Click(object sender, EventArgs e)
        {
            LoadRoom();
        }

        private void dgvDichVu_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtNameService.Text = dgvDichVu.CurrentRow.Cells["name"].Value.ToString();
                currentService = Convert.ToInt32(dgvDichVu.CurrentRow.Cells["id"].Value);
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDichVu();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvService.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xoá", "Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ListViewItem select = lvService.SelectedItems[0];
           
            if (ServiceSQL.CountServiceInService_detail(int.Parse(select.Tag.ToString())) > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xoá dịch vụ này tại các phòng đã đặt", "Dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    
                    if (!ServiceSQL.DeleteService_detail(int.Parse(select.Tag.ToString())))
                    {
                        MessageBox.Show("Xoá dịch vụ tại các phòng không thành công");
                        return;
                    }
                }
                else
                    return;
            }
            
            if (ServiceSQL.DeleteServiceByID(int.Parse(select.Tag.ToString())))
                MessageBox.Show("Xoá dịch vụ thành công");
            else
                MessageBox.Show("Xoá không thành công");

        }

        private void btnAddServiceToRoom_Click(object sender, EventArgs e)
        {
            if (currentService ==0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ");
                return;
            }
            bool flag = false;
            foreach(DataGridViewRow item in dgvDichVu.Rows)
            {
                if (item.Cells["id"].Value.ToString().Equals(currentService.ToString()))
                {
                    flag = true;
                    break;
                }
            }
            int count = ServiceSQL.CountServiceByID(currentService);
            if (count < Convert.ToInt32(numCount.Value))//Kiểm tra số lượng hàng trong kho
            {
                MessageBox.Show("Không đủ hàng trong kho", "Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (flag==false)//Nếu chưa thêm dịch vụ này cho phòng thì thêm vào
            {
                if (ServiceSQL.AddServiceInRoom(cbPhong.SelectedItem.ToString(), currentService, Convert.ToInt32(numCount.Value)))
                    MessageBox.Show("Thêm dịch vụ thành công", "Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Thêm dịch vụ không thành công", "Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else//Nêu đã có dịch vụ này trong phòng thì update lại số lượng
            {
                if (ServiceSQL.UpdateServiceInRoom(cbPhong.SelectedItem.ToString(), currentService, Convert.ToInt32(numCount.Value)))
                    MessageBox.Show("Thêm dịch vụ thành công", "Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Thêm dịch vụ không thành công", "Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            if (ServiceSQL.UpdateService(currentService,-Convert.ToInt32(numCount.Value))==false)
                MessageBox.Show("Lỗi cập nhập kho", "Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LoadServiceInRoom(cbPhong.SelectedItem.ToString());
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Form importf=new ImportServiceForm();
            importf.ShowDialog();
        }

        private ContextMenuStrip RightClick(int id)
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            /*ToolStripMenuItem nameItem = new ToolStripMenuItem(id.ToString());
            nameItem.Click += new EventHandler(roomItemRightClick);
            nameItem.Name = id.ToString();
            menuStrip.Items.Add(nameItem);*/
            ToolStripMenuItem addItem = new ToolStripMenuItem("Thêm");
            addItem.Click += new EventHandler(ItemRightClick);
            addItem.Name = id.ToString();
            menuStrip.Items.Add(addItem);
            ToolStripMenuItem editItem = new ToolStripMenuItem("Sửa");
            editItem.Click += new EventHandler(ItemRightClick);
            editItem.Name = id.ToString();
            menuStrip.Items.Add(editItem);
            ToolStripMenuItem delItem = new ToolStripMenuItem("Xóa");
            delItem.Click += new EventHandler(ItemRightClick);
            delItem.Name = id.ToString();
            menuStrip.Items.Add(delItem);
            //this.ContextMenuStrip = menuStrip;
            return menuStrip;

        }

        void ItemRightClick(object sender, EventArgs e)
        {
            int rID = 0;
            ToolStripItem menuItem = (ToolStripItem)sender;
            rID = Convert.ToInt32(menuItem.Name);

            if (menuItem.Text == "Thêm")
            {
                AddRoom addRoom = new AddRoom();
                addRoom.Show();
            }
            else
            {
                if (menuItem.Text == "Sửa")
                {
                    EditRoom editRoom = new EditRoom(rID);
                    editRoom.Show();
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa dịch vụ " + rID.ToString() + " chứ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        RoomSQL.DeleteRoom(rID);
                    else
                    {
                        MessageBox.Show("Dịch vụ chưa được xóa", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvService.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xoá", "Dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ListViewItem select = lvService.SelectedItems[0];

            EditService editService = new EditService(int.Parse(select.Tag.ToString()));
            editService.Show();
        }

        private void ThanhToanBT_Click(object sender, EventArgs e)
        {
            ThanhToanDienNuoc thanhToanDienNuoc = new ThanhToanDienNuoc();
            thanhToanDienNuoc.Show();
        }
    }
}
