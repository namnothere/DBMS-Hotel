
namespace Hotel
{
    partial class ShowAssignmentFrom
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lvAssignment = new System.Windows.Forms.ListView();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnStatics = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(35, 34);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(139, 30);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // lvAssignment
            // 
            this.lvAssignment.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lvAssignment.HideSelection = false;
            this.lvAssignment.Location = new System.Drawing.Point(229, 12);
            this.lvAssignment.Name = "lvAssignment";
            this.lvAssignment.Size = new System.Drawing.Size(530, 404);
            this.lvAssignment.TabIndex = 1;
            this.lvAssignment.UseCompatibleStateImageBehavior = false;
            this.lvAssignment.View = System.Windows.Forms.View.Details;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(35, 86);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(139, 30);
            this.dtpTo.TabIndex = 0;
            // 
            // btnStatics
            // 
            this.btnStatics.BackColor = System.Drawing.Color.DarkCyan;
            this.btnStatics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatics.ForeColor = System.Drawing.Color.White;
            this.btnStatics.Location = new System.Drawing.Point(51, 292);
            this.btnStatics.Name = "btnStatics";
            this.btnStatics.Size = new System.Drawing.Size(123, 46);
            this.btnStatics.TabIndex = 2;
            this.btnStatics.Text = "Thống kê";
            this.btnStatics.UseVisualStyleBackColor = false;
            this.btnStatics.Visible = false;
            this.btnStatics.Click += new System.EventHandler(this.btnStatics_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnStatics);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 450);
            this.panel1.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkCyan;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(51, 213);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(123, 61);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Xem danh sách";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(51, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.Location = new System.Drawing.Point(223, 0);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowHeadersWidth = 100;
            this.dgvShow.Size = new System.Drawing.Size(761, 450);
            this.dgvShow.StandardTab = true;
            this.dgvShow.TabIndex = 3;
            // 
            // ShowAssignmentFrom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvAssignment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ShowAssignmentFrom";
            this.Text = "Thống kê nhân viên";
            this.Load += new System.EventHandler(this.ShowAssignmentFrom_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ListView lvAssignment;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnStatics;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShow;
        public System.Windows.Forms.Button btnDelete;
    }
}