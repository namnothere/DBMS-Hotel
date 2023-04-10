
namespace Hotel
{
    partial class ManageBillForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cBoxStatus = new System.Windows.Forms.CheckBox();
            this.cBoxRoom = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxDate = new System.Windows.Forms.CheckBox();
            this.dtpChooseTo = new System.Windows.Forms.DateTimePicker();
            this.dtpChooseFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdBill = new System.Windows.Forms.TextBox();
            this.cbChooseStatus = new System.Windows.Forms.ComboBox();
            this.btnSearchWithCon = new System.Windows.Forms.Button();
            this.cbChooseRoom = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTong = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbTenPhong = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.cBoxStatus);
            this.panel1.Controls.Add(this.cBoxRoom);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtIdBill);
            this.panel1.Controls.Add(this.cbChooseStatus);
            this.panel1.Controls.Add(this.btnSearchWithCon);
            this.panel1.Controls.Add(this.cbChooseRoom);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 130);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::Hotel.Properties.Resources.delete_column_128px;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(181, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 56);
            this.btnDelete.TabIndex = 17;
            this.toolTip.SetToolTip(this.btnDelete, "Xoá đơn");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::Hotel.Properties.Resources.add_receipt_128px;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(93, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 56);
            this.btnAdd.TabIndex = 17;
            this.toolTip.SetToolTip(this.btnAdd, "Thêm đơn");
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(-143, 91);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 29);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Follow Date";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.AutoSize = true;
            this.cBoxStatus.Location = new System.Drawing.Point(703, 64);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(122, 29);
            this.cBoxStatus.TabIndex = 21;
            this.cBoxStatus.Text = "Trạng thái";
            this.cBoxStatus.UseVisualStyleBackColor = true;
            // 
            // cBoxRoom
            // 
            this.cBoxRoom.AutoSize = true;
            this.cBoxRoom.Location = new System.Drawing.Point(703, 29);
            this.cBoxRoom.Name = "cBoxRoom";
            this.cBoxRoom.Size = new System.Drawing.Size(91, 29);
            this.cBoxRoom.TabIndex = 21;
            this.cBoxRoom.Text = "Phòng";
            this.cBoxRoom.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxDate);
            this.groupBox2.Controls.Add(this.dtpChooseTo);
            this.groupBox2.Controls.Add(this.dtpChooseFrom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(350, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 117);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // cBoxDate
            // 
            this.cBoxDate.AutoSize = true;
            this.cBoxDate.Location = new System.Drawing.Point(84, 87);
            this.cBoxDate.Name = "cBoxDate";
            this.cBoxDate.Size = new System.Drawing.Size(131, 29);
            this.cBoxDate.TabIndex = 10;
            this.cBoxDate.Text = "Theo Ngày";
            this.cBoxDate.UseVisualStyleBackColor = true;
            // 
            // dtpChooseTo
            // 
            this.dtpChooseTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpChooseTo.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpChooseTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChooseTo.Location = new System.Drawing.Point(108, 60);
            this.dtpChooseTo.Name = "dtpChooseTo";
            this.dtpChooseTo.Size = new System.Drawing.Size(192, 30);
            this.dtpChooseTo.TabIndex = 9;
            this.dtpChooseTo.Value = new System.DateTime(2021, 4, 28, 20, 25, 2, 0);
            // 
            // dtpChooseFrom
            // 
            this.dtpChooseFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpChooseFrom.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpChooseFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChooseFrom.Location = new System.Drawing.Point(108, 25);
            this.dtpChooseFrom.Name = "dtpChooseFrom";
            this.dtpChooseFrom.Size = new System.Drawing.Size(192, 30);
            this.dtpChooseFrom.TabIndex = 7;
            this.dtpChooseFrom.Value = new System.DateTime(2021, 4, 28, 20, 24, 55, 0);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đến:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Từ:";
            // 
            // txtIdBill
            // 
            this.txtIdBill.Location = new System.Drawing.Point(3, 101);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.Size = new System.Drawing.Size(118, 30);
            this.txtIdBill.TabIndex = 19;
            // 
            // cbChooseStatus
            // 
            this.cbChooseStatus.FormattingEnabled = true;
            this.cbChooseStatus.Location = new System.Drawing.Point(808, 58);
            this.cbChooseStatus.Name = "cbChooseStatus";
            this.cbChooseStatus.Size = new System.Drawing.Size(119, 33);
            this.cbChooseStatus.TabIndex = 16;
            // 
            // btnSearchWithCon
            // 
            this.btnSearchWithCon.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchWithCon.BackgroundImage = global::Hotel.Properties.Resources.search_96px;
            this.btnSearchWithCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchWithCon.FlatAppearance.BorderSize = 0;
            this.btnSearchWithCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchWithCon.Location = new System.Drawing.Point(939, 24);
            this.btnSearchWithCon.Name = "btnSearchWithCon";
            this.btnSearchWithCon.Size = new System.Drawing.Size(33, 32);
            this.btnSearchWithCon.TabIndex = 17;
            this.btnSearchWithCon.UseVisualStyleBackColor = false;
            this.btnSearchWithCon.Click += new System.EventHandler(this.btnSearchWithCon_Click);
            // 
            // cbChooseRoom
            // 
            this.cbChooseRoom.FormattingEnabled = true;
            this.cbChooseRoom.Location = new System.Drawing.Point(808, 24);
            this.cbChooseRoom.Name = "cbChooseRoom";
            this.cbChooseRoom.Size = new System.Drawing.Size(119, 33);
            this.cbChooseRoom.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Hotel.Properties.Resources.search_96px;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(121, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 26);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::Hotel.Properties.Resources.refresh_80px;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(12, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 56);
            this.btnRefresh.TabIndex = 17;
            this.toolTip.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 51);
            this.panel2.TabIndex = 1;
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(16, 12);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(69, 25);
            this.lbTong.TabIndex = 0;
            this.lbTong.Text = "Tổng: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(633, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 269);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.cbTenPhong);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 328);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(139, 213);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 36);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(111, 82);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(150, 33);
            this.cbStatus.TabIndex = 16;
            // 
            // cbTenPhong
            // 
            this.cbTenPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTenPhong.FormattingEnabled = true;
            this.cbTenPhong.Location = new System.Drawing.Point(111, 42);
            this.cbTenPhong.Name = "cbTenPhong";
            this.cbTenPhong.Size = new System.Drawing.Size(150, 33);
            this.cbTenPhong.TabIndex = 16;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTo.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(111, 171);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(192, 30);
            this.dtpTo.TabIndex = 9;
            this.dtpTo.Value = new System.DateTime(2021, 4, 28, 20, 25, 2, 0);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đến:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFrom.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(111, 131);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(192, 30);
            this.dtpFrom.TabIndex = 7;
            this.dtpFrom.Value = new System.DateTime(2021, 4, 28, 20, 24, 55, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng:";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.room,
            this.checkin,
            this.checkout,
            this.status,
            this.pay});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvBill.Location = new System.Drawing.Point(0, 130);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(633, 269);
            this.dgvBill.TabIndex = 3;
            this.dgvBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellDoubleClick);
            this.dgvBill.SelectionChanged += new System.EventHandler(this.dgvBill_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id_bill";
            this.id.FillWeight = 70F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // room
            // 
            this.room.DataPropertyName = "room";
            this.room.FillWeight = 77.3604F;
            this.room.HeaderText = "Phòng";
            this.room.MinimumWidth = 6;
            this.room.Name = "room";
            this.room.ReadOnly = true;
            // 
            // checkin
            // 
            this.checkin.DataPropertyName = "checkin";
            this.checkin.FillWeight = 77.3604F;
            this.checkin.HeaderText = "Checkin";
            this.checkin.MinimumWidth = 6;
            this.checkin.Name = "checkin";
            this.checkin.ReadOnly = true;
            // 
            // checkout
            // 
            this.checkout.DataPropertyName = "checkout";
            this.checkout.FillWeight = 77.3604F;
            this.checkout.HeaderText = "Checkout";
            this.checkout.MinimumWidth = 6;
            this.checkout.Name = "checkout";
            this.checkout.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "Nstatus";
            this.status.FillWeight = 77.3604F;
            this.status.HeaderText = "Trạng thái";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // pay
            // 
            this.pay.DataPropertyName = "pay";
            this.pay.FillWeight = 77.3604F;
            this.pay.HeaderText = "Thanh toán";
            this.pay.MinimumWidth = 6;
            this.pay.Name = "pay";
            this.pay.ReadOnly = true;
            // 
            // ManageBillForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ManageBillForm";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.ManageBillForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTenPhong;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtIdBill;
        private System.Windows.Forms.ComboBox cbChooseRoom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtpChooseTo;
        private System.Windows.Forms.DateTimePicker dtpChooseFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cBoxDate;
        private System.Windows.Forms.ComboBox cbChooseStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay;
        private System.Windows.Forms.CheckBox cBoxStatus;
        private System.Windows.Forms.CheckBox cBoxRoom;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnSearchWithCon;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnDelete;
    }
}