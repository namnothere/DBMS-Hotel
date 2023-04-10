
namespace Hotel
{
    partial class ServiceForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDatDV = new System.Windows.Forms.Panel();
            this.btnAddServiceToRoom = new System.Windows.Forms.Button();
            this.txtNameService = new System.Windows.Forms.TextBox();
            this.lbTong = new System.Windows.Forms.Label();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btnResetPhong = new System.Windows.Forms.Button();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.ThanhToanBT = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lvService = new System.Windows.Forms.ListView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlDatDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatDV
            // 
            this.pnlDatDV.BackColor = System.Drawing.Color.LightCyan;
            this.pnlDatDV.Controls.Add(this.btnAddServiceToRoom);
            this.pnlDatDV.Controls.Add(this.txtNameService);
            this.pnlDatDV.Controls.Add(this.lbTong);
            this.pnlDatDV.Controls.Add(this.dgvDichVu);
            this.pnlDatDV.Controls.Add(this.numCount);
            this.pnlDatDV.Controls.Add(this.btnResetPhong);
            this.pnlDatDV.Controls.Add(this.cbPhong);
            this.pnlDatDV.Controls.Add(this.label3);
            this.pnlDatDV.Controls.Add(this.label2);
            this.pnlDatDV.Controls.Add(this.label1);
            this.pnlDatDV.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDatDV.Location = new System.Drawing.Point(474, 64);
            this.pnlDatDV.Name = "pnlDatDV";
            this.pnlDatDV.Size = new System.Drawing.Size(526, 459);
            this.pnlDatDV.TabIndex = 4;
            // 
            // btnAddServiceToRoom
            // 
            this.btnAddServiceToRoom.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddServiceToRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServiceToRoom.Location = new System.Drawing.Point(338, 40);
            this.btnAddServiceToRoom.Name = "btnAddServiceToRoom";
            this.btnAddServiceToRoom.Size = new System.Drawing.Size(83, 26);
            this.btnAddServiceToRoom.TabIndex = 8;
            this.btnAddServiceToRoom.Text = "Thêm";
            this.btnAddServiceToRoom.UseVisualStyleBackColor = false;
            this.btnAddServiceToRoom.Click += new System.EventHandler(this.btnAddServiceToRoom_Click);
            // 
            // txtNameService
            // 
            this.txtNameService.Location = new System.Drawing.Point(64, 40);
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.Size = new System.Drawing.Size(127, 30);
            this.txtNameService.TabIndex = 7;
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(6, 401);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(64, 25);
            this.lbTong.TabIndex = 6;
            this.lbTong.Text = "Tổng:";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dgvDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.count,
            this.pay});
            this.dgvDichVu.GridColor = System.Drawing.Color.Gold;
            this.dgvDichVu.Location = new System.Drawing.Point(7, 77);
            this.dgvDichVu.MultiSelect = false;
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.RowHeadersVisible = false;
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(507, 307);
            this.dgvDichVu.TabIndex = 5;
            this.dgvDichVu.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellValueChanged);
            this.dgvDichVu.SelectionChanged += new System.EventHandler(this.dgvDichVu_SelectionChanged);
            this.dgvDichVu.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDichVu_UserDeletingRow);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 30F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên dịch vụ";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Đơn giá";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "Số lượng";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pay
            // 
            this.pay.DataPropertyName = "pay";
            this.pay.HeaderText = "Thành tiền";
            this.pay.MinimumWidth = 6;
            this.pay.Name = "pay";
            this.pay.ReadOnly = true;
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(285, 40);
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(46, 30);
            this.numCount.TabIndex = 4;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnResetPhong
            // 
            this.btnResetPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnResetPhong.BackgroundImage = global::Hotel.Properties.Resources.available_updates_96px;
            this.btnResetPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetPhong.FlatAppearance.BorderSize = 0;
            this.btnResetPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPhong.Location = new System.Drawing.Point(197, 6);
            this.btnResetPhong.Name = "btnResetPhong";
            this.btnResetPhong.Size = new System.Drawing.Size(31, 27);
            this.btnResetPhong.TabIndex = 2;
            this.btnResetPhong.UseVisualStyleBackColor = false;
            this.btnResetPhong.Click += new System.EventHandler(this.btnResetPhong_Click);
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(64, 6);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(127, 33);
            this.cbPhong.TabIndex = 1;
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.cbPhong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlHeader.Controls.Add(this.ThanhToanBT);
            this.pnlHeader.Controls.Add(this.btnImport);
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.btnRemove);
            this.pnlHeader.Controls.Add(this.btnEdit);
            this.pnlHeader.Controls.Add(this.btnAdd);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 64);
            this.pnlHeader.TabIndex = 2;
            // 
            // ThanhToanBT
            // 
            this.ThanhToanBT.BackgroundImage = global::Hotel.Properties.Resources.external_80px;
            this.ThanhToanBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThanhToanBT.FlatAppearance.BorderSize = 0;
            this.ThanhToanBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThanhToanBT.Location = new System.Drawing.Point(445, 1);
            this.ThanhToanBT.Name = "ThanhToanBT";
            this.ThanhToanBT.Size = new System.Drawing.Size(60, 60);
            this.ThanhToanBT.TabIndex = 2;
            this.toolTip.SetToolTip(this.ThanhToanBT, "Thanh toán");
            this.ThanhToanBT.UseVisualStyleBackColor = true;
            this.ThanhToanBT.Click += new System.EventHandler(this.ThanhToanBT_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackgroundImage = global::Hotel.Properties.Resources.shipped_80px;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(351, 1);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(60, 60);
            this.btnImport.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnImport, "Nhập hàng");
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Hotel.Properties.Resources.refresh_80px;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(269, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 60);
            this.btnRefresh.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::Hotel.Properties.Resources.remove_property_80px;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(182, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 60);
            this.btnRemove.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnRemove, "Xoá dịch vụ");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::Hotel.Properties.Resources.edit_property_80px;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(93, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 60);
            this.btnEdit.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnEdit, "Sửa dịch vụ");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Hotel.Properties.Resources.add_to_collection_80px;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(0, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Tag = "1";
            this.toolTip.SetToolTip(this.btnAdd, "Thêm dịch vụ");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 523);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1000, 27);
            this.pnlBottom.TabIndex = 3;
            // 
            // lvService
            // 
            this.lvService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvService.HideSelection = false;
            this.lvService.Location = new System.Drawing.Point(0, 64);
            this.lvService.Name = "lvService";
            this.lvService.Size = new System.Drawing.Size(474, 459);
            this.lvService.TabIndex = 0;
            this.lvService.UseCompatibleStateImageBehavior = false;
            this.lvService.DoubleClick += new System.EventHandler(this.lvService_DoubleClick);
            // 
            // ServiceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.lvService);
            this.Controls.Add(this.pnlDatDV);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceForm";
            this.Text = "Dịch vụ";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.pnlDatDV.ResumeLayout(false);
            this.pnlDatDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlDatDV;
        private System.Windows.Forms.Button btnResetPhong;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.ListView lvService;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnAddServiceToRoom;
        private System.Windows.Forms.TextBox txtNameService;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button ThanhToanBT;
    }
}