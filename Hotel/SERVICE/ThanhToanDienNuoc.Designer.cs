
namespace Hotel
{
    partial class ThanhToanDienNuoc
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.DonGiaLB = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.DescriptionLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(72, 28);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 24);
            this.txtPrice.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Crimson;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(131, 192);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 32);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Xóa";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(29, 192);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(91, 32);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Thêm";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // DonGiaLB
            // 
            this.DonGiaLB.AutoSize = true;
            this.DonGiaLB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGiaLB.Location = new System.Drawing.Point(9, 32);
            this.DonGiaLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DonGiaLB.Name = "DonGiaLB";
            this.DonGiaLB.Size = new System.Drawing.Size(66, 17);
            this.DonGiaLB.TabIndex = 6;
            this.DonGiaLB.Text = "Đơn giá:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTB.Location = new System.Drawing.Point(72, 64);
            this.DescriptionTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(140, 103);
            this.DescriptionTB.TabIndex = 15;
            // 
            // DescriptionLB
            // 
            this.DescriptionLB.AutoSize = true;
            this.DescriptionLB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLB.Location = new System.Drawing.Point(9, 68);
            this.DescriptionLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLB.Name = "DescriptionLB";
            this.DescriptionLB.Size = new System.Drawing.Size(52, 17);
            this.DescriptionLB.TabIndex = 14;
            this.DescriptionLB.Text = "Mô tả:";
            // 
            // ThanhToanDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(235, 236);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.DescriptionLB);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.DonGiaLB);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThanhToanDienNuoc";
            this.Text = "Chi tiền";
            this.Load += new System.EventHandler(this.ThanhToanDienNuoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label DonGiaLB;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Label DescriptionLB;
    }
}