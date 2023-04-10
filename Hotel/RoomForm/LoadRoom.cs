using Hotel.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace Hotel
{
    public partial class LoadRoom : Form
    {
        public LoadRoom()
        {
            InitializeComponent();
            BackColor = Lib._colorBackgroundMain;
        }
        Room RoomSQL = new Room();
        public int id;
        bool SortByName = true;
        public void LoadListRoom(bool check)
        {
            
            DataTable dt = RoomSQL.GetAllRoom(check);
            foreach (DataRow item in dt.Rows)
            {
                Panel_Custom pnl = CreatePanel(item);
                
                pnl.ContextMenuStrip = roomRightClick(Convert.ToInt32(item[0].ToString()));
                this.flpPhong.Controls.Add(pnl);
                
                 
            }
            this.ContextMenuStrip = outRightClick();
            
        }
        
        private Panel_Custom CreatePanel(DataRow dt)
        {
            Panel_Custom pnl_c = new Panel_Custom();
            pnlStatus.Name = "pnl_c" + dt[0].ToString();
            pnl_c.Tag = dt[0].ToString();
            pnl_c.Size = new Size(200, 200);
            pnl_c.Margin = new System.Windows.Forms.Padding(10);
            int indexColorButton = 0;
            if ((int)dt[1] == 2)
                indexColorButton = 0;
            else if ((int)dt[1] == 1)
                indexColorButton = 1;
            else if ((int)dt[1]==0)
                indexColorButton = 2;
            else if ((int)dt[1] == 3)
                indexColorButton = 3;
            else
                indexColorButton = 4;
            Label lb1 = new Label() { Location=new Point(15,20),AutoSize=true};
            lb1.Text = "Phòng: ";
            Label roomLb = new Label() {Location = new Point(90, 20), AutoSize = true };
            roomLb.Text = dt[0].ToString();
            Label lb2 = new Label() { Text = dt[3].ToString(),Location=new Point(15,70) };
            Label lb3 = new Label() { Text = "Loại: "+dt[4].ToString(), Location = new Point(15, 120) , AutoSize = true };
            Button_Custom btn1 = new Button_Custom() { Size=new Size(90,40),ForeColor=Color.Black,
                                        Tag=dt[0].ToString(),Radius=20,BackColor=Color.DeepSkyBlue};
            Button_Custom btn2 = new Button_Custom() { Size = new Size(90, 40) ,ForeColor=Color.Black,
                                        Tag = dt[0].ToString(),Radius=20,BackColor=Color.Azure};
            
            if((int)dt[1]==1)
            {
                btn1.Text = "Đặt";
                btn2.Text = "Trả";
                btn1.Click += BtnDatPhong_Click;
                btn2.Click += BtnTraPhong_Click;
                /*id = Convert.ToInt32(dt[0].ToString());
                pnl_c.ContextMenuStrip = roomRightClick(id);*/ 
            }
            else if((int)dt[1]==0)
            {
                btn1.Text = "Đặt";
                btn2.Text = "Nhận";
                btn1.Click += BtnDatPhong_Click;
                btn2.Click += BtnNhanPhong_Click;
                /*id = Convert.ToInt32(dt[0].ToString());
                pnl_c.ContextMenuStrip = roomRightClick(Convert.ToInt32(id));*/
            }
            else if((int)dt[1]==2)
            {
                btn1.Text = "Đặt";
                btn2.Text = "Nhận";
                btn1.Click += BtnDatPhong_Click;
                btn2.Enabled = false;
                //id = Convert.ToInt32(dt[0].ToString());
                /*pnl_c.ContextMenuStrip = roomRightClick(Convert.ToInt32(id));*/
            }

            btn1.Location = new Point(5, 150);
            btn2.Location = new Point(105, 150);
            pnl_c.Controls.AddRange(new Control[] { lb1, roomLb, lb2, lb3,btn1,btn2});
            pnl_c.BackColor = ColorTranslator.FromHtml(Lib.ColorRoomDefault[indexColorButton]);
           
            return pnl_c;

        }
        private void PanelCustom_RightClick(object sender, EventArgs e)
        {
            

        }
        private void BtnDatPhong_Click(object sender, EventArgs e)
        {
            BookRoomForm bookRoom = new BookRoomForm(((Button_Custom)sender).Tag.ToString().Trim(),1);
            bookRoom.ShowDialog();
        }
        private void BtnNhanPhong_Click(object sender, EventArgs e)
        {
            BookRoomForm bookRoom = new BookRoomForm(((Button_Custom)sender).Tag.ToString().Trim(),2);
            bookRoom.ShowDialog();
        }
        private void BtnTraPhong_Click(object sender, EventArgs e)
        {
            CheckOutHotelForm checkout = new CheckOutHotelForm(((Button_Custom)sender).Tag.ToString().Trim());
            checkout.ShowDialog();
        }

        public void LoadRoom_Load(object sender, EventArgs e)
        {
            LoadListRoom(SortByName);
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.Show();
        }

        private ContextMenuStrip roomRightClick(int id)
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            /*ToolStripMenuItem nameItem = new ToolStripMenuItem(id.ToString());
            nameItem.Click += new EventHandler(roomItemRightClick);
            nameItem.Name = id.ToString();
            menuStrip.Items.Add(nameItem);*/
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
            return menuStrip;
            
        }

        void roomItemRightClick(object sender, EventArgs e)
        {
            int rID =0;
            ToolStripItem menuItem = (ToolStripItem)sender;
            rID = Convert.ToInt32(menuItem.Name);

                if (menuItem.Text == "Add")
                {
                    AddRoom addRoom = new AddRoom();
                    addRoom.Show();
                }
                else
                {
                    if (menuItem.Text == "Edit")
                    {
                        EditRoom editRoom = new EditRoom(rID);
                        editRoom.Show();
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc muốn xóa phòng " + rID.ToString() + " chứ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            RoomSQL.DeleteRoom(rID);
                        else
                        {
                            MessageBox.Show("Phòng chưa được xóa", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
            }
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            flpPhong.Controls.Clear();
            LoadListRoom(SortByName);
        }

        private ContextMenuStrip outRightClick()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            /*ToolStripMenuItem nameItem = new ToolStripMenuItem(id.ToString());
            nameItem.Click += new EventHandler(roomItemRightClick);
            nameItem.Name = id.ToString();
            menuStrip.Items.Add(nameItem);*/
            ToolStripMenuItem refreshItem = new ToolStripMenuItem("Refresh");
            refreshItem.Click += new EventHandler(OutRightClick);
            refreshItem.Name = "Refresh";
            menuStrip.Items.Add(refreshItem); 
            ToolStripMenuItem SortItem = new ToolStripMenuItem("Sort by");
            //SortItem.Click += new EventHandler(OutRightClick);
            SortItem.Name = "Sort by";

            ToolStripMenuItem byID = new ToolStripMenuItem("By Status");
            byID.Name = id.ToString();
            byID.Click += new EventHandler(OutRightClick);
            SortItem.DropDownItems.Add(byID);

            ToolStripMenuItem byName = new ToolStripMenuItem("By Name");
            byName.Click += new EventHandler(OutRightClick);
            byName.Name = id.ToString();
            SortItem.DropDownItems.Add(byName);

            menuStrip.Items.Add(SortItem);
            ToolStripMenuItem addItem = new ToolStripMenuItem("New");
            addItem.Click += new EventHandler(OutRightClick);
            addItem.Name = id.ToString();
            menuStrip.Items.Add(addItem);
            //this.ContextMenuStrip = menuStrip;
            return menuStrip;
        }
        void OutRightClick(object sender, EventArgs e)
        {
            //int rID = 0;
            ToolStripItem menuItem = (ToolStripItem)sender;
            //rID = Convert.ToInt32(menuItem.Name);

            if (menuItem.Text == "New")
            {
                AddRoom addRoom = new AddRoom();
                addRoom.Show();
            }
            else
            {
                if (menuItem.Text == "Refresh")
                {
                    flpPhong.Controls.Clear();
                    LoadListRoom(true);
                    SortByName = true;
                }
                else
                {
                    if(menuItem.Text == "By Name")
                    {
                        flpPhong.Controls.Clear();
                        LoadListRoom(true);
                    }  
                    else
                    {
                        flpPhong.Controls.Clear();
                        LoadListRoom(false);
                    }       
                }
            }
        }
    }
}
