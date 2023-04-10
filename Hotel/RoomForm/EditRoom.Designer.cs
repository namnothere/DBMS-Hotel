
namespace Hotel
{
    partial class EditRoom
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
            this.CancelBT = new System.Windows.Forms.Button();
            this.AddBT = new System.Windows.Forms.Button();
            this.TypeCCB = new System.Windows.Forms.ComboBox();
            this.roomTB = new System.Windows.Forms.TextBox();
            this.TypeLB = new System.Windows.Forms.Label();
            this.NameLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBT
            // 
            this.CancelBT.BackColor = System.Drawing.Color.Crimson;
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.FlatAppearance.BorderSize = 0;
            this.CancelBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBT.ForeColor = System.Drawing.Color.Black;
            this.CancelBT.Location = new System.Drawing.Point(22, 138);
            this.CancelBT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(112, 41);
            this.CancelBT.TabIndex = 11;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.UseVisualStyleBackColor = false;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // AddBT
            // 
            this.AddBT.BackColor = System.Drawing.Color.SpringGreen;
            this.AddBT.FlatAppearance.BorderSize = 0;
            this.AddBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBT.ForeColor = System.Drawing.Color.Black;
            this.AddBT.Location = new System.Drawing.Point(188, 138);
            this.AddBT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(112, 41);
            this.AddBT.TabIndex = 10;
            this.AddBT.Text = "Edit";
            this.AddBT.UseVisualStyleBackColor = false;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // TypeCCB
            // 
            this.TypeCCB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCCB.FormattingEnabled = true;
            this.TypeCCB.Location = new System.Drawing.Point(135, 73);
            this.TypeCCB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TypeCCB.Name = "TypeCCB";
            this.TypeCCB.Size = new System.Drawing.Size(146, 25);
            this.TypeCCB.TabIndex = 9;
            // 
            // roomTB
            // 
            this.roomTB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTB.Location = new System.Drawing.Point(135, 24);
            this.roomTB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.roomTB.Name = "roomTB";
            this.roomTB.Size = new System.Drawing.Size(146, 24);
            this.roomTB.TabIndex = 8;
            // 
            // TypeLB
            // 
            this.TypeLB.AutoSize = true;
            this.TypeLB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLB.ForeColor = System.Drawing.Color.Black;
            this.TypeLB.Location = new System.Drawing.Point(15, 73);
            this.TypeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeLB.Name = "TypeLB";
            this.TypeLB.Size = new System.Drawing.Size(104, 19);
            this.TypeLB.TabIndex = 7;
            this.TypeLB.Text = "Loại phòng:";
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLB.ForeColor = System.Drawing.Color.Black;
            this.NameLB.Location = new System.Drawing.Point(15, 24);
            this.NameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(90, 19);
            this.NameLB.TabIndex = 6;
            this.NameLB.Text = "Số phòng:";
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(319, 211);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.TypeCCB);
            this.Controls.Add(this.roomTB);
            this.Controls.Add(this.TypeLB);
            this.Controls.Add(this.NameLB);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditRoom";
            this.Text = "EditRoom";
            this.Load += new System.EventHandler(this.EditRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.ComboBox TypeCCB;
        private System.Windows.Forms.TextBox roomTB;
        private System.Windows.Forms.Label TypeLB;
        private System.Windows.Forms.Label NameLB;
    }
}