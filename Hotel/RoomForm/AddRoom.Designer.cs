
namespace Hotel
{
    partial class AddRoom
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
            this.NameLB = new System.Windows.Forms.Label();
            this.TypeLB = new System.Windows.Forms.Label();
            this.roomTB = new System.Windows.Forms.TextBox();
            this.TypeCCB = new System.Windows.Forms.ComboBox();
            this.AddBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLB.Location = new System.Drawing.Point(20, 30);
            this.NameLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(81, 18);
            this.NameLB.TabIndex = 0;
            this.NameLB.Text = "Số phòng:";
            // 
            // TypeLB
            // 
            this.TypeLB.AutoSize = true;
            this.TypeLB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLB.Location = new System.Drawing.Point(20, 90);
            this.TypeLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TypeLB.Name = "TypeLB";
            this.TypeLB.Size = new System.Drawing.Size(94, 18);
            this.TypeLB.TabIndex = 1;
            this.TypeLB.Text = "Loại phòng:";
            // 
            // roomTB
            // 
            this.roomTB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTB.Location = new System.Drawing.Point(180, 30);
            this.roomTB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.roomTB.Name = "roomTB";
            this.roomTB.Size = new System.Drawing.Size(194, 24);
            this.roomTB.TabIndex = 2;
            // 
            // TypeCCB
            // 
            this.TypeCCB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCCB.FormattingEnabled = true;
            this.TypeCCB.Location = new System.Drawing.Point(180, 90);
            this.TypeCCB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TypeCCB.Name = "TypeCCB";
            this.TypeCCB.Size = new System.Drawing.Size(194, 25);
            this.TypeCCB.TabIndex = 3;
            // 
            // AddBT
            // 
            this.AddBT.BackColor = System.Drawing.Color.SpringGreen;
            this.AddBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBT.ForeColor = System.Drawing.Color.Black;
            this.AddBT.Location = new System.Drawing.Point(250, 170);
            this.AddBT.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(150, 50);
            this.AddBT.TabIndex = 4;
            this.AddBT.Text = "Add";
            this.AddBT.UseVisualStyleBackColor = false;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // CancelBT
            // 
            this.CancelBT.BackColor = System.Drawing.Color.Crimson;
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBT.ForeColor = System.Drawing.Color.Black;
            this.CancelBT.Location = new System.Drawing.Point(30, 170);
            this.CancelBT.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(150, 50);
            this.CancelBT.TabIndex = 5;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = false;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // AddRoom
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.CancelButton = this.CancelBT;
            this.ClientSize = new System.Drawing.Size(425, 260);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.TypeCCB);
            this.Controls.Add(this.roomTB);
            this.Controls.Add(this.TypeLB);
            this.Controls.Add(this.NameLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "AddRoom";
            this.ShowIcon = false;
            this.Text = "AddRoom";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Label TypeLB;
        private System.Windows.Forms.TextBox roomTB;
        private System.Windows.Forms.ComboBox TypeCCB;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.Button CancelBT;
    }
}