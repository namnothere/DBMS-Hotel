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
    public partial class AddRoom : Form
    {
        Room room = new Room();
        LoadRoom loadRoom = new LoadRoom();
        public AddRoom()
        {
            InitializeComponent();
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
            this.Close();
            
            loadRoom.flpPhong.Controls.Clear();
            loadRoom.LoadListRoom(true);
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            try
            {
                TypeCCB.DataSource = room.getRoomType();
                TypeCCB.DisplayMember = "name";
                TypeCCB.ValueMember = "type";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            try
            {
                int roomid = Convert.ToInt32(roomTB.Text);
                int status = 0;
                int type = Convert.ToInt32(TypeCCB.SelectedValue.ToString().Trim());
                if (!room.ExistRoom(roomid))
                {
                    if (room.AddNewRoom(roomid, status, type))
                    {
                        MessageBox.Show("Đã thêm phòng!", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm lỗi!", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Phòng này đã tồn tại!", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            loadRoom.flpPhong.Controls.Clear();
            loadRoom.LoadListRoom(true);
        }
    }
}
