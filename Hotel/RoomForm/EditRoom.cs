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
    public partial class EditRoom : Form
    {
        int id = 0;
        public EditRoom(int rID)
        {
            InitializeComponent();
            id = rID;
        }
        Room room = new Room();
        LoadRoom loadRoom = new LoadRoom();
        private void EditRoom_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = room.getRoomByID(id);
            try
            {
                TypeCCB.DataSource = room.getRoomType();
                TypeCCB.DisplayMember = "name";
                TypeCCB.ValueMember = "type";
               // TypeCCB.SelectedItem = null;

                roomTB.Text = id.ToString();
                roomTB.ReadOnly = true;
                TypeCCB.SelectedItem = table.Rows[0][2].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CancelBT_Click(object sender, EventArgs e)
        {
            this.Close();

            loadRoom.flpPhong.Controls.Clear();
            loadRoom.LoadListRoom(true);
        }
        private void AddBT_Click(object sender, EventArgs e)
        {
            try
            {
                int roomid = Convert.ToInt32(roomTB.Text);
                int status = 0;
                //string typeR = TypeCCB.SelectedText.Trim();
                int type = Convert.ToInt32(TypeCCB.SelectedValue.ToString());

                if (room.UpdateRoom(roomid, status, type))
                {
                    MessageBox.Show("Đã cập nhật phòng!", "Edit room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật lỗi!", "Edit room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            loadRoom.flpPhong.Controls.Clear();
            loadRoom.LoadListRoom(true);
        }
    }
}
