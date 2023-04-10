
namespace Hotel
{
    partial class ThemNhanVien
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
            this.AddBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            this.UploadAVTBT = new System.Windows.Forms.Button();
            this.AVT = new System.Windows.Forms.PictureBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.CMNDTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.BDateTPK = new System.Windows.Forms.DateTimePicker();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.bdateLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.IDLB = new System.Windows.Forms.Label();
            this.GenderGB = new System.Windows.Forms.GroupBox();
            this.MaleRB = new System.Windows.Forms.RadioButton();
            this.FemaleRB = new System.Windows.Forms.RadioButton();
            this.TypeGRB = new System.Windows.Forms.GroupBox();
            this.QLRB = new System.Windows.Forms.RadioButton();
            this.LTRB = new System.Windows.Forms.RadioButton();
            this.LCRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.AVT)).BeginInit();
            this.GenderGB.SuspendLayout();
            this.TypeGRB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBT
            // 
            this.AddBT.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBT.ForeColor = System.Drawing.Color.White;
            this.AddBT.Location = new System.Drawing.Point(178, 527);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(105, 38);
            this.AddBT.TabIndex = 63;
            this.AddBT.Text = "Thêm";
            this.AddBT.UseVisualStyleBackColor = false;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // CancelBT
            // 
            this.CancelBT.BackColor = System.Drawing.Color.Red;
            this.CancelBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBT.ForeColor = System.Drawing.Color.White;
            this.CancelBT.Location = new System.Drawing.Point(54, 527);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(105, 38);
            this.CancelBT.TabIndex = 62;
            this.CancelBT.Text = "Hủy";
            this.CancelBT.UseVisualStyleBackColor = false;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // UploadAVTBT
            // 
            this.UploadAVTBT.BackColor = System.Drawing.Color.SandyBrown;
            this.UploadAVTBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadAVTBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UploadAVTBT.ForeColor = System.Drawing.Color.Black;
            this.UploadAVTBT.Location = new System.Drawing.Point(110, 440);
            this.UploadAVTBT.Name = "UploadAVTBT";
            this.UploadAVTBT.Size = new System.Drawing.Size(165, 38);
            this.UploadAVTBT.TabIndex = 56;
            this.UploadAVTBT.Text = "Thêm ảnh";
            this.UploadAVTBT.UseVisualStyleBackColor = false;
            this.UploadAVTBT.Click += new System.EventHandler(this.UploadAVTBT_Click);
            // 
            // AVT
            // 
            this.AVT.BackColor = System.Drawing.Color.Beige;
            this.AVT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AVT.Location = new System.Drawing.Point(110, 295);
            this.AVT.Name = "AVT";
            this.AVT.Size = new System.Drawing.Size(165, 140);
            this.AVT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AVT.TabIndex = 55;
            this.AVT.TabStop = false;
            // 
            // AddressTB
            // 
            this.AddressTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTB.Location = new System.Drawing.Point(110, 217);
            this.AddressTB.MaxLength = 64000;
            this.AddressTB.Multiline = true;
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(165, 72);
            this.AddressTB.TabIndex = 54;
            // 
            // CMNDTB
            // 
            this.CMNDTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMNDTB.Location = new System.Drawing.Point(110, 184);
            this.CMNDTB.Name = "CMNDTB";
            this.CMNDTB.Size = new System.Drawing.Size(165, 26);
            this.CMNDTB.TabIndex = 53;
            // 
            // PhoneTB
            // 
            this.PhoneTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTB.Location = new System.Drawing.Point(110, 153);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(165, 26);
            this.PhoneTB.TabIndex = 52;
            // 
            // BDateTPK
            // 
            this.BDateTPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BDateTPK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BDateTPK.Location = new System.Drawing.Point(110, 85);
            this.BDateTPK.MaxDate = new System.DateTime(2021, 5, 21, 0, 0, 0, 0);
            this.BDateTPK.MinDate = new System.DateTime(1961, 12, 31, 0, 0, 0, 0);
            this.BDateTPK.Name = "BDateTPK";
            this.BDateTPK.Size = new System.Drawing.Size(165, 26);
            this.BDateTPK.TabIndex = 51;
            this.BDateTPK.Value = new System.DateTime(2021, 5, 21, 0, 0, 0, 0);
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(110, 54);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(165, 26);
            this.NameTB.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(16, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Hình ảnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(18, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "CMND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(18, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Địa chỉ";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneLabel.Location = new System.Drawing.Point(18, 158);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(54, 20);
            this.phoneLabel.TabIndex = 46;
            this.phoneLabel.Text = "Số ĐT";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genderLabel.Location = new System.Drawing.Point(18, 123);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(67, 20);
            this.genderLabel.TabIndex = 45;
            this.genderLabel.Text = "Giới tính";
            // 
            // bdateLabel
            // 
            this.bdateLabel.AutoSize = true;
            this.bdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bdateLabel.Location = new System.Drawing.Point(16, 92);
            this.bdateLabel.Name = "bdateLabel";
            this.bdateLabel.Size = new System.Drawing.Size(78, 20);
            this.bdateLabel.TabIndex = 44;
            this.bdateLabel.Text = "Ngày sinh";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fnameLabel.Location = new System.Drawing.Point(16, 59);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(77, 20);
            this.fnameLabel.TabIndex = 43;
            this.fnameLabel.Text = "Họ và tên";
            // 
            // IDTB
            // 
            this.IDTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTB.Location = new System.Drawing.Point(110, 11);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(165, 26);
            this.IDTB.TabIndex = 65;
            // 
            // IDLB
            // 
            this.IDLB.AutoSize = true;
            this.IDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IDLB.Location = new System.Drawing.Point(10, 15);
            this.IDLB.Name = "IDLB";
            this.IDLB.Size = new System.Drawing.Size(102, 20);
            this.IDLB.TabIndex = 64;
            this.IDLB.Text = "ID nhân viên:";
            // 
            // GenderGB
            // 
            this.GenderGB.Controls.Add(this.MaleRB);
            this.GenderGB.Controls.Add(this.FemaleRB);
            this.GenderGB.Location = new System.Drawing.Point(110, 108);
            this.GenderGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenderGB.Name = "GenderGB";
            this.GenderGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenderGB.Size = new System.Drawing.Size(165, 40);
            this.GenderGB.TabIndex = 90;
            this.GenderGB.TabStop = false;
            // 
            // MaleRB
            // 
            this.MaleRB.AutoSize = true;
            this.MaleRB.Checked = true;
            this.MaleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MaleRB.Location = new System.Drawing.Point(5, 14);
            this.MaleRB.Name = "MaleRB";
            this.MaleRB.Size = new System.Drawing.Size(60, 24);
            this.MaleRB.TabIndex = 80;
            this.MaleRB.TabStop = true;
            this.MaleRB.Text = "Nam";
            this.MaleRB.UseVisualStyleBackColor = true;
            // 
            // FemaleRB
            // 
            this.FemaleRB.AutoSize = true;
            this.FemaleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FemaleRB.Location = new System.Drawing.Point(97, 14);
            this.FemaleRB.Name = "FemaleRB";
            this.FemaleRB.Size = new System.Drawing.Size(47, 24);
            this.FemaleRB.TabIndex = 82;
            this.FemaleRB.Text = "Nữ";
            this.FemaleRB.UseVisualStyleBackColor = true;
            // 
            // TypeGRB
            // 
            this.TypeGRB.Controls.Add(this.QLRB);
            this.TypeGRB.Controls.Add(this.LTRB);
            this.TypeGRB.Controls.Add(this.LCRB);
            this.TypeGRB.Location = new System.Drawing.Point(31, 483);
            this.TypeGRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeGRB.Name = "TypeGRB";
            this.TypeGRB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeGRB.Size = new System.Drawing.Size(263, 39);
            this.TypeGRB.TabIndex = 91;
            this.TypeGRB.TabStop = false;
            // 
            // QLRB
            // 
            this.QLRB.AutoSize = true;
            this.QLRB.Checked = true;
            this.QLRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.QLRB.Location = new System.Drawing.Point(5, 10);
            this.QLRB.Name = "QLRB";
            this.QLRB.Size = new System.Drawing.Size(80, 24);
            this.QLRB.TabIndex = 81;
            this.QLRB.TabStop = true;
            this.QLRB.Text = "Quản lý";
            this.QLRB.UseVisualStyleBackColor = true;
            // 
            // LTRB
            // 
            this.LTRB.AutoSize = true;
            this.LTRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LTRB.Location = new System.Drawing.Point(94, 10);
            this.LTRB.Name = "LTRB";
            this.LTRB.Size = new System.Drawing.Size(72, 24);
            this.LTRB.TabIndex = 83;
            this.LTRB.Text = "Lễ tân";
            this.LTRB.UseVisualStyleBackColor = true;
            // 
            // LCRB
            // 
            this.LCRB.AutoSize = true;
            this.LCRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LCRB.Location = new System.Drawing.Point(166, 10);
            this.LCRB.Name = "LCRB";
            this.LCRB.Size = new System.Drawing.Size(93, 24);
            this.LCRB.TabIndex = 84;
            this.LCRB.Text = "Lao công";
            this.LCRB.UseVisualStyleBackColor = true;
            // 
            // ThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(305, 589);
            this.Controls.Add(this.TypeGRB);
            this.Controls.Add(this.GenderGB);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.IDLB);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.bdateLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UploadAVTBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AVT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.BDateTPK);
            this.Controls.Add(this.CMNDTB);
            this.Controls.Add(this.PhoneTB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThemNhanVien";
            this.Text = "Thêm nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.AVT)).EndInit();
            this.GenderGB.ResumeLayout(false);
            this.GenderGB.PerformLayout();
            this.TypeGRB.ResumeLayout(false);
            this.TypeGRB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button UploadAVTBT;
        private System.Windows.Forms.PictureBox AVT;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox CMNDTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.DateTimePicker BDateTPK;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label bdateLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.Label IDLB;
        private System.Windows.Forms.GroupBox GenderGB;
        private System.Windows.Forms.RadioButton MaleRB;
        private System.Windows.Forms.RadioButton FemaleRB;
        private System.Windows.Forms.GroupBox TypeGRB;
        private System.Windows.Forms.RadioButton QLRB;
        private System.Windows.Forms.RadioButton LTRB;
        private System.Windows.Forms.RadioButton LCRB;
    }
}