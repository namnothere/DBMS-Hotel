
namespace Hotel
{
    partial class BookRoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlDP = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIDBill = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cbTenPhong = new System.Windows.Forms.ComboBox();
            this.CancelBT = new Hotel.Button_Custom();
            this.btnCustomer = new Hotel.Button_Custom();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnDatPhong = new Hotel.Button_Custom();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new Hotel.Button_Custom();
            this.elipseControl1 = new Hotel.ElipseControl();
            this.pnlDP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại phòng:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Từ:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFrom.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(171, 160);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(214, 35);
            this.dtpFrom.TabIndex = 7;
            this.dtpFrom.Value = new System.DateTime(2021, 4, 28, 20, 24, 55, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTo.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(171, 200);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(214, 35);
            this.dtpTo.TabIndex = 9;
            this.dtpTo.Value = new System.DateTime(2021, 4, 28, 20, 25, 2, 0);
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đến:";
            // 
            // pnlDP
            // 
            this.pnlDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDP.Controls.Add(this.btnSearch);
            this.pnlDP.Controls.Add(this.txtIDBill);
            this.pnlDP.Controls.Add(this.groupBox2);
            this.pnlDP.Controls.Add(this.groupBox1);
            this.pnlDP.Controls.Add(this.CancelBT);
            this.pnlDP.Controls.Add(this.btnCustomer);
            this.pnlDP.Controls.Add(this.splitter1);
            this.pnlDP.Controls.Add(this.btnDatPhong);
            this.pnlDP.Controls.Add(this.label6);
            this.pnlDP.Location = new System.Drawing.Point(-3, 2);
            this.pnlDP.Name = "pnlDP";
            this.pnlDP.Size = new System.Drawing.Size(850, 406);
            this.pnlDP.TabIndex = 11;
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
            this.btnSearch.Location = new System.Drawing.Point(351, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 33);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIDBill
            // 
            this.txtIDBill.Location = new System.Drawing.Point(133, 7);
            this.txtIDBill.Name = "txtIDBill";
            this.txtIDBill.Size = new System.Drawing.Size(212, 35);
            this.txtIDBill.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSdt);
            this.groupBox2.Controls.Add(this.txtCMND);
            this.groupBox2.Controls.Add(this.txtTenKhach);
            this.groupBox2.Controls.Add(this.txtTong);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(414, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 273);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khách hàng";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Location = new System.Drawing.Point(200, 160);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(214, 35);
            this.txtDescription.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 27);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ghi chú";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 27);
            this.label11.TabIndex = 21;
            this.label11.Text = "Số điện thoại:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 27);
            this.label10.TabIndex = 22;
            this.label10.Text = "CMND:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 27);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tên Khách hàng:";
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSdt.Location = new System.Drawing.Point(200, 120);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(214, 35);
            this.txtSdt.TabIndex = 25;
            // 
            // txtCMND
            // 
            this.txtCMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCMND.Location = new System.Drawing.Point(200, 80);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(214, 35);
            this.txtCMND.TabIndex = 26;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKhach.Location = new System.Drawing.Point(200, 40);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(214, 35);
            this.txtTenKhach.TabIndex = 27;
            // 
            // txtTong
            // 
            this.txtTong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTong.Location = new System.Drawing.Point(200, 200);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(214, 35);
            this.txtTong.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 27);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tổng chi phí:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.cbTenPhong);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 273);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // txtType
            // 
            this.txtType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtType.Location = new System.Drawing.Point(173, 117);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(214, 35);
            this.txtType.TabIndex = 31;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatus.Location = new System.Drawing.Point(171, 80);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(214, 35);
            this.txtStatus.TabIndex = 31;
            // 
            // cbTenPhong
            // 
            this.cbTenPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTenPhong.FormattingEnabled = true;
            this.cbTenPhong.Location = new System.Drawing.Point(171, 40);
            this.cbTenPhong.Name = "cbTenPhong";
            this.cbTenPhong.Size = new System.Drawing.Size(214, 35);
            this.cbTenPhong.TabIndex = 16;
            this.cbTenPhong.SelectedIndexChanged += new System.EventHandler(this.cbTenPhong_SelectedIndexChanged);
            // 
            // CancelBT
            // 
            this.CancelBT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBT.BackColor = System.Drawing.Color.DarkOrange;
            this.CancelBT.BorderColor = System.Drawing.Color.Transparent;
            this.CancelBT.BorderSize = 1.75F;
            this.CancelBT.ButtonColor = System.Drawing.SystemColors.Control;
            this.CancelBT.FlatAppearance.BorderSize = 0;
            this.CancelBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.CancelBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelBT.Location = new System.Drawing.Point(567, 342);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Radius = 34;
            this.CancelBT.Size = new System.Drawing.Size(160, 40);
            this.CancelBT.TabIndex = 28;
            this.CancelBT.Text = "Huỷ";
            this.CancelBT.UseVisualStyleBackColor = false;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomer.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCustomer.BorderColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderSize = 1.75F;
            this.btnCustomer.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomer.Location = new System.Drawing.Point(351, 342);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Radius = 34;
            this.btnCustomer.Size = new System.Drawing.Size(160, 40);
            this.btnCustomer.TabIndex = 29;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 406);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDatPhong.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDatPhong.BorderColor = System.Drawing.Color.Transparent;
            this.btnDatPhong.BorderSize = 1.75F;
            this.btnDatPhong.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDatPhong.Location = new System.Drawing.Point(133, 342);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Radius = 34;
            this.btnDatPhong.Size = new System.Drawing.Size(160, 40);
            this.btnDatPhong.TabIndex = 13;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID Bill";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderSize = 1.75F;
            this.btnCancel.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(190, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 34;
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 25;
            this.elipseControl1.TargetControl = this.btnCancel;
            // 
            // BookRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(844, 411);
            this.Controls.Add(this.pnlDP);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(860, 450);
            this.Name = "BookRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Booking Room";
            this.Load += new System.EventHandler(this.BookRoomForm_Load);
            this.pnlDP.ResumeLayout(false);
            this.pnlDP.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlDP;
        private Button_Custom btnDatPhong;
        private Button_Custom btnCancel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox cbTenPhong;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label12;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtCMND;
        private Button_Custom CancelBT;
        private Button_Custom btnCustomer;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtType;
    }
}