
namespace Hotel
{
    partial class LCNForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LCNForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlCheckin = new System.Windows.Forms.Panel();
            this.btnShowPanelTab = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnTenNhanVen = new System.Windows.Forms.Button();
            this.btnCaLamViec = new System.Windows.Forms.Button();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.Work = new System.Windows.Forms.Button();
            this.pnlChoose = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dtpDemo = new System.Windows.Forms.DateTimePicker();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlBottom_canle = new System.Windows.Forms.Panel();
            this.timerTransform = new System.Windows.Forms.Timer(this.components);
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.elipseControl1 = new Hotel.ElipseControl();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(171)))), ((int)(((byte)(137)))));
            this.pnlHeader.Controls.Add(this.pnlCheckin);
            this.pnlHeader.Controls.Add(this.btnShowPanelTab);
            this.pnlHeader.Controls.Add(this.lbTitle);
            this.pnlHeader.Controls.Add(this.btnTenNhanVen);
            this.pnlHeader.Controls.Add(this.btnCaLamViec);
            this.pnlHeader.Controls.Add(this.picClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1275, 60);
            this.pnlHeader.TabIndex = 3;
            this.pnlHeader.DoubleClick += new System.EventHandler(this.pnlHeader_DoubleClick);
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // pnlCheckin
            // 
            this.pnlCheckin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCheckin.Location = new System.Drawing.Point(773, 0);
            this.pnlCheckin.Name = "pnlCheckin";
            this.pnlCheckin.Size = new System.Drawing.Size(0, 60);
            this.pnlCheckin.TabIndex = 7;
            this.pnlCheckin.Tag = "0";
            // 
            // btnShowPanelTab
            // 
            this.btnShowPanelTab.BackgroundImage = global::Hotel.Properties.Resources.menu_rounded_96px;
            this.btnShowPanelTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPanelTab.FlatAppearance.BorderSize = 0;
            this.btnShowPanelTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPanelTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPanelTab.Location = new System.Drawing.Point(0, 0);
            this.btnShowPanelTab.Name = "btnShowPanelTab";
            this.btnShowPanelTab.Size = new System.Drawing.Size(65, 60);
            this.btnShowPanelTab.TabIndex = 5;
            this.btnShowPanelTab.UseVisualStyleBackColor = true;
            this.btnShowPanelTab.Click += new System.EventHandler(this.btnShowPanelTab_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(71, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(45, 24);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Title";
            // 
            // btnTenNhanVen
            // 
            this.btnTenNhanVen.BackColor = System.Drawing.Color.Transparent;
            this.btnTenNhanVen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTenNhanVen.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTenNhanVen.FlatAppearance.BorderSize = 0;
            this.btnTenNhanVen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTenNhanVen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnTenNhanVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTenNhanVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenNhanVen.Image = global::Hotel.Properties.Resources.user_shield_96px;
            this.btnTenNhanVen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTenNhanVen.Location = new System.Drawing.Point(773, 0);
            this.btnTenNhanVen.Name = "btnTenNhanVen";
            this.btnTenNhanVen.Size = new System.Drawing.Size(251, 60);
            this.btnTenNhanVen.TabIndex = 3;
            this.btnTenNhanVen.Text = "Nhân viên: Trần Bảo Duy";
            this.btnTenNhanVen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTenNhanVen.UseVisualStyleBackColor = false;
            // 
            // btnCaLamViec
            // 
            this.btnCaLamViec.BackColor = System.Drawing.Color.Transparent;
            this.btnCaLamViec.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCaLamViec.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCaLamViec.FlatAppearance.BorderSize = 0;
            this.btnCaLamViec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCaLamViec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnCaLamViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaLamViec.Image = global::Hotel.Properties.Resources.workstation_96px;
            this.btnCaLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaLamViec.Location = new System.Drawing.Point(1024, 0);
            this.btnCaLamViec.Name = "btnCaLamViec";
            this.btnCaLamViec.Size = new System.Drawing.Size(201, 60);
            this.btnCaLamViec.TabIndex = 2;
            this.btnCaLamViec.Text = "Ca làm việc: 6h-10h";
            this.btnCaLamViec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaLamViec.UseVisualStyleBackColor = false;
            // 
            // picClose
            // 
            this.picClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picClose.Image = global::Hotel.Properties.Resources.shutdown_40px;
            this.picClose.Location = new System.Drawing.Point(1225, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(50, 60);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.pnlLeft.Controls.Add(this.btnSetting);
            this.pnlLeft.Controls.Add(this.Work);
            this.pnlLeft.Controls.Add(this.pnlChoose);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 60);
            this.pnlLeft.MaximumSize = new System.Drawing.Size(230, 3000);
            this.pnlLeft.MinimumSize = new System.Drawing.Size(65, 620);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(65, 620);
            this.pnlLeft.TabIndex = 4;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::Hotel.Properties.Resources.settings_64px1;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(-5, 552);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(230, 65);
            this.btnSetting.TabIndex = 10;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // Work
            // 
            this.Work.BackColor = System.Drawing.Color.Transparent;
            this.Work.FlatAppearance.BorderSize = 0;
            this.Work.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Work.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Work.Image = global::Hotel.Properties.Resources.human_resources_48px;
            this.Work.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Work.Location = new System.Drawing.Point(1, 73);
            this.Work.Margin = new System.Windows.Forms.Padding(0);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(228, 70);
            this.Work.TabIndex = 9;
            this.Work.Text = "  Ca làm";
            this.Work.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Work.UseVisualStyleBackColor = false;
            this.Work.Click += new System.EventHandler(this.Work_Click);
            // 
            // pnlChoose
            // 
            this.pnlChoose.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChoose.Location = new System.Drawing.Point(0, 0);
            this.pnlChoose.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChoose.Name = "pnlChoose";
            this.pnlChoose.Size = new System.Drawing.Size(10, 70);
            this.pnlChoose.TabIndex = 5;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.dtpDemo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(65, 640);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1210, 40);
            this.pnlBottom.TabIndex = 6;
            // 
            // dtpDemo
            // 
            this.dtpDemo.CustomFormat = "dd/MM/yyyy HH:mm tt";
            this.dtpDemo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDemo.Location = new System.Drawing.Point(1020, 14);
            this.dtpDemo.Name = "dtpDemo";
            this.dtpDemo.Size = new System.Drawing.Size(153, 20);
            this.dtpDemo.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(65, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1210, 580);
            this.pnlMain.TabIndex = 7;
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnlBottom_canle
            // 
            this.pnlBottom_canle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom_canle.Location = new System.Drawing.Point(0, 680);
            this.pnlBottom_canle.Name = "pnlBottom_canle";
            this.pnlBottom_canle.Size = new System.Drawing.Size(1275, 10);
            this.pnlBottom_canle.TabIndex = 0;
            // 
            // timerTransform
            // 
            this.timerTransform.Interval = 1;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 60000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 15;
            this.elipseControl1.TargetControl = this.btnCaLamViec;
            // 
            // LCNForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1275, 690);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBottom_canle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1275, 690);
            this.Name = "LCNForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCNForm";
            this.Load += new System.EventHandler(this.LTForm_Load);
            this.Resize += new System.EventHandler(this.LTForm_Resize);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private ElipseControl elipseControl1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlChoose;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCaLamViec;
        private System.Windows.Forms.Button btnTenNhanVen;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnShowPanelTab;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnlBottom_canle;
        private System.Windows.Forms.Timer timerTransform;
        private System.Windows.Forms.DateTimePicker dtpDemo;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Panel pnlCheckin;
        private System.Windows.Forms.Button Work;
        private System.Windows.Forms.Button btnSetting;
    }
}