
namespace Hotel
{
    partial class Setting
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
            this.NameTB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TenDangNhap = new System.Windows.Forms.Label();
            this.MatKhau = new System.Windows.Forms.Label();
            this.EditUserName = new System.Windows.Forms.Button();
            this.EditPassword = new System.Windows.Forms.Button();
            this.ShowLLB = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.AutoSize = true;
            this.NameTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(20, 40);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(158, 23);
            this.NameTB.TabIndex = 0;
            this.NameTB.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu:";
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.AutoSize = true;
            this.TenDangNhap.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDangNhap.Location = new System.Drawing.Point(20, 80);
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Size = new System.Drawing.Size(68, 23);
            this.TenDangNhap.TabIndex = 2;
            this.TenDangNhap.Text = "label2";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSize = true;
            this.MatKhau.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhau.Location = new System.Drawing.Point(20, 200);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(68, 23);
            this.MatKhau.TabIndex = 3;
            this.MatKhau.Text = "label3";
            // 
            // EditUserName
            // 
            this.EditUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(111)))), ((int)(((byte)(177)))));
            this.EditUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUserName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserName.Location = new System.Drawing.Point(320, 60);
            this.EditUserName.Name = "EditUserName";
            this.EditUserName.Size = new System.Drawing.Size(130, 43);
            this.EditUserName.TabIndex = 4;
            this.EditUserName.Text = "Chỉnh sửa";
            this.EditUserName.UseVisualStyleBackColor = false;
            this.EditUserName.Click += new System.EventHandler(this.EditUserName_Click);
            // 
            // EditPassword
            // 
            this.EditPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(111)))), ((int)(((byte)(177)))));
            this.EditPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPassword.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPassword.Location = new System.Drawing.Point(320, 180);
            this.EditPassword.Name = "EditPassword";
            this.EditPassword.Size = new System.Drawing.Size(130, 41);
            this.EditPassword.TabIndex = 5;
            this.EditPassword.Text = "Chỉnh sửa";
            this.EditPassword.UseVisualStyleBackColor = false;
            this.EditPassword.Click += new System.EventHandler(this.EditPassword_Click);
            // 
            // ShowLLB
            // 
            this.ShowLLB.AutoSize = true;
            this.ShowLLB.BackColor = System.Drawing.Color.Transparent;
            this.ShowLLB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLLB.LinkColor = System.Drawing.Color.White;
            this.ShowLLB.Location = new System.Drawing.Point(237, 200);
            this.ShowLLB.Name = "ShowLLB";
            this.ShowLLB.Size = new System.Drawing.Size(77, 21);
            this.ShowLLB.TabIndex = 6;
            this.ShowLLB.TabStop = true;
            this.ShowLLB.Text = "Hiển thị";
            this.ShowLLB.Click += new System.EventHandler(this.ShowLLB_LinkClicked);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(844, 644);
            this.Controls.Add(this.ShowLLB);
            this.Controls.Add(this.EditPassword);
            this.Controls.Add(this.EditUserName);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.TenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTB);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TenDangNhap;
        private System.Windows.Forms.Label MatKhau;
        private System.Windows.Forms.Button EditUserName;
        private System.Windows.Forms.Button EditPassword;
        private System.Windows.Forms.LinkLabel ShowLLB;
    }
}