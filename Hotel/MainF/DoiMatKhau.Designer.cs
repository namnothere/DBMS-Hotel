
namespace Hotel
{
    partial class DoiMatKhau
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
            this.CancelLB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishBT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MatKhauMoi = new System.Windows.Forms.TextBox();
            this.MkHienTai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NhapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelLB
            // 
            this.CancelLB.AutoSize = true;
            this.CancelLB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelLB.ForeColor = System.Drawing.Color.White;
            this.CancelLB.Location = new System.Drawing.Point(228, 24);
            this.CancelLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CancelLB.Name = "CancelLB";
            this.CancelLB.Size = new System.Drawing.Size(59, 18);
            this.CancelLB.TabIndex = 4;
            this.CancelLB.Text = "Hủy bỏ";
            this.CancelLB.Click += new System.EventHandler(this.CancelLB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhập mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập mật khẩu hiện tại và mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // FinishBT
            // 
            this.FinishBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(111)))), ((int)(((byte)(177)))));
            this.FinishBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishBT.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBT.ForeColor = System.Drawing.Color.White;
            this.FinishBT.Location = new System.Drawing.Point(316, 18);
            this.FinishBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FinishBT.Name = "FinishBT";
            this.FinishBT.Size = new System.Drawing.Size(79, 32);
            this.FinishBT.TabIndex = 5;
            this.FinishBT.Text = "Xong";
            this.FinishBT.UseVisualStyleBackColor = false;
            this.FinishBT.Click += new System.EventHandler(this.FinishBT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.CancelLB);
            this.panel1.Controls.Add(this.FinishBT);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 293);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 71);
            this.panel1.TabIndex = 16;
            // 
            // MatKhauMoi
            // 
            this.MatKhauMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.MatKhauMoi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhauMoi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MatKhauMoi.Location = new System.Drawing.Point(13, 182);
            this.MatKhauMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MatKhauMoi.Name = "MatKhauMoi";
            this.MatKhauMoi.Size = new System.Drawing.Size(382, 25);
            this.MatKhauMoi.TabIndex = 15;
            // 
            // MkHienTai
            // 
            this.MkHienTai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.MkHienTai.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MkHienTai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MkHienTai.Location = new System.Drawing.Point(13, 117);
            this.MkHienTai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MkHienTai.Name = "MkHienTai";
            this.MkHienTai.Size = new System.Drawing.Size(382, 25);
            this.MkHienTai.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // NhapLaiMatKhauMoi
            // 
            this.NhapLaiMatKhauMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.NhapLaiMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapLaiMatKhauMoi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NhapLaiMatKhauMoi.Location = new System.Drawing.Point(13, 239);
            this.NhapLaiMatKhauMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NhapLaiMatKhauMoi.Name = "NhapLaiMatKhauMoi";
            this.NhapLaiMatKhauMoi.Size = new System.Drawing.Size(382, 25);
            this.NhapLaiMatKhauMoi.TabIndex = 18;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(407, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NhapLaiMatKhauMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MatKhauMoi);
            this.Controls.Add(this.MkHienTai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CancelLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FinishBT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox MatKhauMoi;
        private System.Windows.Forms.TextBox MkHienTai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NhapLaiMatKhauMoi;
    }
}