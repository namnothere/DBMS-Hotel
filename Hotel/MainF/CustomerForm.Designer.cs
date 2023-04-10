
namespace Hotel
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.cbStatusCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.id_bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInfoCustomer = new System.Windows.Forms.Panel();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.cbOwn = new System.Windows.Forms.CheckBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDBillSearch = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIDBill = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.pnlInfoCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.cbStatusCustomer);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.txtIDBillSearch);
            this.pnlHeader.Controls.Add(this.label6);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // cbStatusCustomer
            // 
            this.cbStatusCustomer.FormattingEnabled = true;
            this.cbStatusCustomer.Items.AddRange(new object[] {
            "Tất cả",
            "Đang thuê",
            "Đặt trước",
            "Đã trả phòng"});
            this.cbStatusCustomer.Location = new System.Drawing.Point(720, 42);
            this.cbStatusCustomer.Name = "cbStatusCustomer";
            this.cbStatusCustomer.Size = new System.Drawing.Size(146, 28);
            this.cbStatusCustomer.TabIndex = 5;
            this.cbStatusCustomer.SelectedIndexChanged += new System.EventHandler(this.cbStatusCustomer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trạng thái";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 627);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 65);
            this.panel1.TabIndex = 1;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_bill,
            this.name,
            this.cmnd,
            this.phone,
            this.room,
            this.description});
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvKhachHang.Location = new System.Drawing.Point(138, 75);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(730, 552);
            this.dgvKhachHang.TabIndex = 2;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            this.dgvKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellDoubleClick);
            this.dgvKhachHang.SelectionChanged += new System.EventHandler(this.dgvKhachHang_SelectionChanged);
            // 
            // id_bill
            // 
            this.id_bill.DataPropertyName = "id_bill";
            this.id_bill.FillWeight = 80F;
            this.id_bill.HeaderText = "ID Bill";
            this.id_bill.MinimumWidth = 6;
            this.id_bill.Name = "id_bill";
            this.id_bill.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 120F;
            this.name.HeaderText = "Họ và tên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.MinimumWidth = 6;
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Số điện thoại";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // room
            // 
            this.room.DataPropertyName = "room";
            this.room.HeaderText = "Phòng";
            this.room.MinimumWidth = 6;
            this.room.Name = "room";
            this.room.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Ghi chú";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpRoom.BackColor = System.Drawing.Color.Transparent;
            this.flpRoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpRoom.Location = new System.Drawing.Point(0, 75);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(138, 552);
            this.flpRoom.TabIndex = 3;
            // 
            // pnlInfoCustomer
            // 
            this.pnlInfoCustomer.BackColor = System.Drawing.Color.Honeydew;
            this.pnlInfoCustomer.Controls.Add(this.txtIDBill);
            this.pnlInfoCustomer.Controls.Add(this.label8);
            this.pnlInfoCustomer.Controls.Add(this.cbRoom);
            this.pnlInfoCustomer.Controls.Add(this.cbOwn);
            this.pnlInfoCustomer.Controls.Add(this.txtPhone);
            this.pnlInfoCustomer.Controls.Add(this.label4);
            this.pnlInfoCustomer.Controls.Add(this.txtDescription);
            this.pnlInfoCustomer.Controls.Add(this.label5);
            this.pnlInfoCustomer.Controls.Add(this.txtCMND);
            this.pnlInfoCustomer.Controls.Add(this.label3);
            this.pnlInfoCustomer.Controls.Add(this.txtTenKhachHang);
            this.pnlInfoCustomer.Controls.Add(this.label2);
            this.pnlInfoCustomer.Controls.Add(this.label7);
            this.pnlInfoCustomer.Controls.Add(this.btnDelete);
            this.pnlInfoCustomer.Controls.Add(this.btnEditCustomer);
            this.pnlInfoCustomer.Controls.Add(this.btnAddCustomer);
            this.pnlInfoCustomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfoCustomer.Location = new System.Drawing.Point(868, 75);
            this.pnlInfoCustomer.Name = "pnlInfoCustomer";
            this.pnlInfoCustomer.Size = new System.Drawing.Size(332, 552);
            this.pnlInfoCustomer.TabIndex = 4;
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(153, 69);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(130, 28);
            this.cbRoom.TabIndex = 35;
            // 
            // cbOwn
            // 
            this.cbOwn.AutoSize = true;
            this.cbOwn.Location = new System.Drawing.Point(85, 327);
            this.cbOwn.Name = "cbOwn";
            this.cbOwn.Size = new System.Drawing.Size(145, 24);
            this.cbOwn.TabIndex = 34;
            this.cbOwn.Text = "Người đặt phòng";
            this.cbOwn.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(153, 181);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 26);
            this.txtPhone.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Số điện thoại";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(153, 216);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(130, 96);
            this.txtDescription.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ghi chú";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(153, 145);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(130, 26);
            this.txtCMND.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "CMND";
            // 
            // txtIDBillSearch
            // 
            this.txtIDBillSearch.Location = new System.Drawing.Point(249, 44);
            this.txtIDBillSearch.Name = "txtIDBillSearch";
            this.txtIDBillSearch.Size = new System.Drawing.Size(130, 26);
            this.txtIDBillSearch.TabIndex = 32;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(153, 107);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(130, 26);
            this.txtTenKhachHang.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "ID Hoá đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Phòng";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.Gold;
            this.btnEditCustomer.FlatAppearance.BorderSize = 0;
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Location = new System.Drawing.Point(116, 384);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(96, 39);
            this.btnEditCustomer.TabIndex = 21;
            this.btnEditCustomer.Text = "Cập nhật";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Location = new System.Drawing.Point(6, 384);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(97, 39);
            this.btnAddCustomer.TabIndex = 22;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(224, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 39);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Hotel.Properties.Resources.search_96px;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(386, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 30);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIDBill
            // 
            this.txtIDBill.Location = new System.Drawing.Point(153, 37);
            this.txtIDBill.Name = "txtIDBill";
            this.txtIDBill.ReadOnly = true;
            this.txtIDBill.Size = new System.Drawing.Size(130, 26);
            this.txtIDBill.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "ID Hoá đơn";
            // 
            // CustomerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.pnlInfoCustomer);
            this.Controls.Add(this.flpRoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerForm";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.KhachHangForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.pnlInfoCustomer.ResumeLayout(false);
            this.pnlInfoCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Panel pnlInfoCustomer;
        private System.Windows.Forms.ComboBox cbStatusCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDBillSearch;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbOwn;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIDBill;
        private System.Windows.Forms.Label label8;
    }
}