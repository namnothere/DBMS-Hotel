
namespace Hotel
{
    partial class ReportForm
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
            this.lbSumRoonIn = new System.Windows.Forms.Label();
            this.lbSumRoomOut = new System.Windows.Forms.Label();
            this.lbEmployeeWork = new System.Windows.Forms.Label();
            this.lbEmployeeNotWork = new System.Windows.Forms.Label();
            this.lbThu = new System.Windows.Forms.Label();
            this.lbChi = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.lbMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSumRoonIn
            // 
            this.lbSumRoonIn.AutoSize = true;
            this.lbSumRoonIn.Location = new System.Drawing.Point(13, 67);
            this.lbSumRoonIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSumRoonIn.Name = "lbSumRoonIn";
            this.lbSumRoonIn.Size = new System.Drawing.Size(173, 20);
            this.lbSumRoonIn.TabIndex = 0;
            this.lbSumRoonIn.Text = "Tổng phòng được thuê:";
            // 
            // lbSumRoomOut
            // 
            this.lbSumRoomOut.AutoSize = true;
            this.lbSumRoomOut.Location = new System.Drawing.Point(13, 105);
            this.lbSumRoomOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSumRoomOut.Name = "lbSumRoomOut";
            this.lbSumRoomOut.Size = new System.Drawing.Size(143, 20);
            this.lbSumRoomOut.TabIndex = 0;
            this.lbSumRoomOut.Text = "Tổng phòng đã trả:";
            // 
            // lbEmployeeWork
            // 
            this.lbEmployeeWork.AutoSize = true;
            this.lbEmployeeWork.Location = new System.Drawing.Point(13, 141);
            this.lbEmployeeWork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmployeeWork.Name = "lbEmployeeWork";
            this.lbEmployeeWork.Size = new System.Drawing.Size(166, 20);
            this.lbEmployeeWork.TabIndex = 0;
            this.lbEmployeeWork.Text = "Tổng nhân viên đi làm:";
            // 
            // lbEmployeeNotWork
            // 
            this.lbEmployeeNotWork.AutoSize = true;
            this.lbEmployeeNotWork.Location = new System.Drawing.Point(13, 174);
            this.lbEmployeeNotWork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmployeeNotWork.Name = "lbEmployeeNotWork";
            this.lbEmployeeNotWork.Size = new System.Drawing.Size(159, 20);
            this.lbEmployeeNotWork.TabIndex = 0;
            this.lbEmployeeNotWork.Text = "Tổng nhân viên vắng:";
            // 
            // lbThu
            // 
            this.lbThu.AutoSize = true;
            this.lbThu.Location = new System.Drawing.Point(13, 209);
            this.lbThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(76, 20);
            this.lbThu.TabIndex = 0;
            this.lbThu.Text = "Tổng thu:";
            this.lbThu.Click += new System.EventHandler(this.lbThu_Click);
            // 
            // lbChi
            // 
            this.lbChi.AutoSize = true;
            this.lbChi.Location = new System.Drawing.Point(13, 242);
            this.lbChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChi.Name = "lbChi";
            this.lbChi.Size = new System.Drawing.Size(73, 20);
            this.lbChi.TabIndex = 0;
            this.lbChi.Text = "Tổng chỉ:";
            this.lbChi.Click += new System.EventHandler(this.lbThu_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Gold;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(162, 272);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(119, 41);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "In Báo Cáo";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.Location = new System.Drawing.Point(41, 23);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(158, 29);
            this.lbMain.TabIndex = 2;
            this.lbMain.Text = "Báo cáo ngày";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 325);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lbChi);
            this.Controls.Add(this.lbThu);
            this.Controls.Add(this.lbEmployeeNotWork);
            this.Controls.Add(this.lbEmployeeWork);
            this.Controls.Add(this.lbSumRoomOut);
            this.Controls.Add(this.lbSumRoonIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSumRoonIn;
        private System.Windows.Forms.Label lbSumRoomOut;
        private System.Windows.Forms.Label lbEmployeeWork;
        private System.Windows.Forms.Label lbEmployeeNotWork;
        private System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.Label lbChi;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lbMain;
    }
}