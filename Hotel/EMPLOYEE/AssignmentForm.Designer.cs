
namespace Hotel
{
    partial class AssignmentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtTimeSpan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditShift = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.btnAssignment = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvDestination = new System.Windows.Forms.DataGridView();
            this.id_employeeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRight = new System.Windows.Forms.Button();
            this.dgvSource = new System.Windows.Forms.DataGridView();
            this.id_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDateShift = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbAutoNO = new System.Windows.Forms.CheckBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.txtTimeSpan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.btnAddShift);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEditShift);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 211);
            this.panel1.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(669, 98);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(39, 26);
            this.numericUpDown3.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(669, 54);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(39, 26);
            this.numericUpDown2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(669, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 26);
            this.numericUpDown1.TabIndex = 7;
            // 
            // txtTimeSpan
            // 
            this.txtTimeSpan.Location = new System.Drawing.Point(240, 97);
            this.txtTimeSpan.Name = "txtTimeSpan";
            this.txtTimeSpan.Size = new System.Drawing.Size(100, 26);
            this.txtTimeSpan.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tuỳ chỉnh";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "HH:mm tt";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(222, 55);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(118, 26);
            this.dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "HH:mm tt";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(222, 15);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(118, 26);
            this.dtpFrom.TabIndex = 3;
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShift.ForeColor = System.Drawing.Color.White;
            this.btnAddShift.Location = new System.Drawing.Point(242, 164);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(120, 35);
            this.btnAddShift.TabIndex = 2;
            this.btnAddShift.Text = "Thêm ca";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(494, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEditShift
            // 
            this.btnEditShift.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditShift.ForeColor = System.Drawing.Color.White;
            this.btnEditShift.Location = new System.Drawing.Point(368, 164);
            this.btnEditShift.Name = "btnEditShift";
            this.btnEditShift.Size = new System.Drawing.Size(120, 35);
            this.btnEditShift.TabIndex = 2;
            this.btnEditShift.Text = "Cập nhật";
            this.btnEditShift.UseVisualStyleBackColor = false;
            this.btnEditShift.Click += new System.EventHandler(this.btnEditShift_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lao công";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lễ tân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quản lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Từ";
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = global::Hotel.Properties.Resources.more_than_96px2;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Location = new System.Drawing.Point(455, 178);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(50, 69);
            this.btnLeft.TabIndex = 16;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnComfirm
            // 
            this.btnComfirm.BackColor = System.Drawing.Color.Orange;
            this.btnComfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComfirm.ForeColor = System.Drawing.Color.White;
            this.btnComfirm.Location = new System.Drawing.Point(535, 312);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(120, 35);
            this.btnComfirm.TabIndex = 10;
            this.btnComfirm.Text = "Xác nhận";
            this.btnComfirm.UseVisualStyleBackColor = false;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // btnAssignment
            // 
            this.btnAssignment.BackColor = System.Drawing.Color.Orange;
            this.btnAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignment.ForeColor = System.Drawing.Color.White;
            this.btnAssignment.Location = new System.Drawing.Point(661, 312);
            this.btnAssignment.Name = "btnAssignment";
            this.btnAssignment.Size = new System.Drawing.Size(120, 35);
            this.btnAssignment.TabIndex = 11;
            this.btnAssignment.Text = "Phân công";
            this.btnAssignment.UseVisualStyleBackColor = false;
            this.btnAssignment.Click += new System.EventHandler(this.btnAssignment_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Orange;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(359, 312);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(170, 35);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Hiện danh sách";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvDestination
            // 
            this.dgvDestination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDestination.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_employeeD,
            this.nameD,
            this.typeD});
            this.dgvDestination.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dgvDestination.Location = new System.Drawing.Point(527, 45);
            this.dgvDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.RowHeadersVisible = false;
            this.dgvDestination.RowHeadersWidth = 51;
            this.dgvDestination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestination.Size = new System.Drawing.Size(440, 250);
            this.dgvDestination.TabIndex = 9;
            // 
            // id_employeeD
            // 
            this.id_employeeD.DataPropertyName = "id_employee_D";
            this.id_employeeD.HeaderText = "ID NV";
            this.id_employeeD.MinimumWidth = 6;
            this.id_employeeD.Name = "id_employeeD";
            // 
            // nameD
            // 
            this.nameD.HeaderText = "Tên Nhân viên";
            this.nameD.MinimumWidth = 6;
            this.nameD.Name = "nameD";
            // 
            // typeD
            // 
            this.typeD.HeaderText = "Chức vụ";
            this.typeD.MinimumWidth = 6;
            this.typeD.Name = "typeD";
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.BackgroundImage = global::Hotel.Properties.Resources.more_than_96px1;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Location = new System.Drawing.Point(455, 111);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(50, 61);
            this.btnRight.TabIndex = 17;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // dgvSource
            // 
            this.dgvSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSource.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_employee,
            this.name,
            this.type});
            this.dgvSource.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dgvSource.Location = new System.Drawing.Point(6, 45);
            this.dgvSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSource.Name = "dgvSource";
            this.dgvSource.RowHeadersVisible = false;
            this.dgvSource.RowHeadersWidth = 51;
            this.dgvSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSource.Size = new System.Drawing.Size(432, 250);
            this.dgvSource.TabIndex = 7;
            // 
            // id_employee
            // 
            this.id_employee.DataPropertyName = "id_employee";
            this.id_employee.FillWeight = 70F;
            this.id_employee.HeaderText = "ID";
            this.id_employee.MinimumWidth = 6;
            this.id_employee.Name = "id_employee";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 96.70051F;
            this.name.HeaderText = "Họ và tên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.FillWeight = 96.70051F;
            this.type.HeaderText = "Chức vụ";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            // 
            // dtpDateShift
            // 
            this.dtpDateShift.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateShift.Location = new System.Drawing.Point(112, 11);
            this.dtpDateShift.Name = "dtpDateShift";
            this.dtpDateShift.Size = new System.Drawing.Size(118, 26);
            this.dtpDateShift.TabIndex = 14;
            this.dtpDateShift.ValueChanged += new System.EventHandler(this.dtpDateShift_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Ngày bắt đầu";
            // 
            // cbShift
            // 
            this.cbShift.FormattingEnabled = true;
            this.cbShift.Location = new System.Drawing.Point(620, 12);
            this.cbShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(146, 28);
            this.cbShift.TabIndex = 13;
            this.cbShift.SelectedIndexChanged += new System.EventHandler(this.cbShift_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ca làm việc";
            // 
            // checkbAutoNO
            // 
            this.checkbAutoNO.AutoSize = true;
            this.checkbAutoNO.Location = new System.Drawing.Point(53, 318);
            this.checkbAutoNO.Name = "checkbAutoNO";
            this.checkbAutoNO.Size = new System.Drawing.Size(254, 24);
            this.checkbAutoNO.TabIndex = 18;
            this.checkbAutoNO.Text = "Đánh lại số thứ tự cho nhân viên";
            this.checkbAutoNO.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dtpEnd);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.btnLeft);
            this.pnlMain.Controls.Add(this.checkbAutoNO);
            this.pnlMain.Controls.Add(this.btnRight);
            this.pnlMain.Controls.Add(this.btnComfirm);
            this.pnlMain.Controls.Add(this.dgvSource);
            this.pnlMain.Controls.Add(this.btnAssignment);
            this.pnlMain.Controls.Add(this.dtpDateShift);
            this.pnlMain.Controls.Add(this.btnShow);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.dgvDestination);
            this.pnlMain.Controls.Add(this.cbShift);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(984, 363);
            this.pnlMain.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ngày kết thúc";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(365, 13);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(118, 26);
            this.dtpEnd.TabIndex = 20;
            // 
            // AssignmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(984, 574);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AssignmentForm";
            this.Text = "Bảng phân công";
            this.Load += new System.EventHandler(this.AssignmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Button btnEditShift;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_employeeD;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameD;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeD;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.DataGridView dgvSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DateTimePicker dtpDateShift;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeSpan;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkbAutoNO;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label9;
    }
}