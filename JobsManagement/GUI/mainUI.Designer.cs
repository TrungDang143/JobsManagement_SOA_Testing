namespace JobsManagement
{
    partial class mainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainUI));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.dongHo = new System.Windows.Forms.Label();
            this.pnlHighLight4 = new System.Windows.Forms.Panel();
            this.pnlHighLight3 = new System.Windows.Forms.Panel();
            this.pnlHighLight2 = new System.Windows.Forms.Panel();
            this.pnlHighLight1 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.icoMinus = new System.Windows.Forms.PictureBox();
            this.icoClose = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tmThongBaoAll = new System.Windows.Forms.Timer(this.components);
            this.ThongBao = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tmThongBaoCV = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoClose)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.pnlMenu.Controls.Add(this.dongHo);
            this.pnlMenu.Controls.Add(this.pnlHighLight4);
            this.pnlMenu.Controls.Add(this.pnlHighLight3);
            this.pnlMenu.Controls.Add(this.pnlHighLight2);
            this.pnlMenu.Controls.Add(this.pnlHighLight1);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.btnTK);
            this.pnlMenu.Controls.Add(this.btnCalendar);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(253, 753);
            this.pnlMenu.TabIndex = 0;
            // 
            // dongHo
            // 
            this.dongHo.AutoSize = true;
            this.dongHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dongHo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.dongHo.Location = new System.Drawing.Point(44, 690);
            this.dongHo.Name = "dongHo";
            this.dongHo.Size = new System.Drawing.Size(151, 38);
            this.dongHo.TabIndex = 6;
            this.dongHo.Text = "00:00:00";
            this.dongHo.Click += new System.EventHandler(this.dongHo_Click);
            // 
            // pnlHighLight4
            // 
            this.pnlHighLight4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlHighLight4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlHighLight4.Location = new System.Drawing.Point(0, 601);
            this.pnlHighLight4.Name = "pnlHighLight4";
            this.pnlHighLight4.Size = new System.Drawing.Size(5, 71);
            this.pnlHighLight4.TabIndex = 5;
            this.pnlHighLight4.Visible = false;
            // 
            // pnlHighLight3
            // 
            this.pnlHighLight3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlHighLight3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlHighLight3.Location = new System.Drawing.Point(0, 404);
            this.pnlHighLight3.Name = "pnlHighLight3";
            this.pnlHighLight3.Size = new System.Drawing.Size(5, 68);
            this.pnlHighLight3.TabIndex = 4;
            this.pnlHighLight3.Visible = false;
            // 
            // pnlHighLight2
            // 
            this.pnlHighLight2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlHighLight2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlHighLight2.Location = new System.Drawing.Point(0, 336);
            this.pnlHighLight2.Name = "pnlHighLight2";
            this.pnlHighLight2.Size = new System.Drawing.Size(5, 68);
            this.pnlHighLight2.TabIndex = 4;
            this.pnlHighLight2.Visible = false;
            // 
            // pnlHighLight1
            // 
            this.pnlHighLight1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlHighLight1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlHighLight1.Location = new System.Drawing.Point(0, 268);
            this.pnlHighLight1.Name = "pnlHighLight1";
            this.pnlHighLight1.Size = new System.Drawing.Size(5, 68);
            this.pnlHighLight1.TabIndex = 3;
            this.pnlHighLight1.Visible = false;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSetting.Image = global::JobsManagement.Properties.Resources.icons8_settings_50;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(5, 601);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(248, 71);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            this.btnSetting.MouseEnter += new System.EventHandler(this.btnSetting_MouseHover);
            this.btnSetting.MouseLeave += new System.EventHandler(this.btnSetting_MouseLeave);
            // 
            // btnTK
            // 
            this.btnTK.FlatAppearance.BorderSize = 0;
            this.btnTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTK.Image = global::JobsManagement.Properties.Resources.icons8_chart_48;
            this.btnTK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTK.Location = new System.Drawing.Point(5, 404);
            this.btnTK.Name = "btnTK";
            this.btnTK.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnTK.Size = new System.Drawing.Size(248, 68);
            this.btnTK.TabIndex = 2;
            this.btnTK.Text = "Thống kê";
            this.btnTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            this.btnTK.MouseEnter += new System.EventHandler(this.button2_MouseHover);
            this.btnTK.MouseLeave += new System.EventHandler(this.btnTK_MouseLeave);
            // 
            // btnCalendar
            // 
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnCalendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalendar.Image = global::JobsManagement.Properties.Resources.icons8_calendar_48;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalendar.Location = new System.Drawing.Point(5, 336);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(23, 0, 20, 0);
            this.btnCalendar.Size = new System.Drawing.Size(248, 68);
            this.btnCalendar.TabIndex = 2;
            this.btnCalendar.Text = "Lịch";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            this.btnCalendar.MouseEnter += new System.EventHandler(this.button1_MouseHover);
            this.btnCalendar.MouseLeave += new System.EventHandler(this.btnCalendar_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHome.Image = global::JobsManagement.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(5, 268);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(248, 68);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseHover);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 249);
            this.panel1.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbUserName.Location = new System.Drawing.Point(70, 198);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(103, 22);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "UserName";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JobsManagement.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(51, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.AutoScrollMinSize = new System.Drawing.Size(1137, 800);
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContent.Location = new System.Drawing.Point(253, 59);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1137, 694);
            this.pnlContent.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTitle.Location = new System.Drawing.Point(6, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(173, 38);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Trang chủ";
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // icoMinus
            // 
            this.icoMinus.Image = global::JobsManagement.Properties.Resources.minus_icon;
            this.icoMinus.Location = new System.Drawing.Point(1048, 12);
            this.icoMinus.Name = "icoMinus";
            this.icoMinus.Size = new System.Drawing.Size(30, 30);
            this.icoMinus.TabIndex = 0;
            this.icoMinus.TabStop = false;
            this.icoMinus.Click += new System.EventHandler(this.icoMinus_Click);
            // 
            // icoClose
            // 
            this.icoClose.Image = global::JobsManagement.Properties.Resources.multipy_icon;
            this.icoClose.Location = new System.Drawing.Point(1095, 12);
            this.icoClose.Name = "icoClose";
            this.icoClose.Size = new System.Drawing.Size(30, 30);
            this.icoClose.TabIndex = 0;
            this.icoClose.TabStop = false;
            this.icoClose.Click += new System.EventHandler(this.icoClose_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.pnlTitle.Controls.Add(this.lbTitle);
            this.pnlTitle.Controls.Add(this.icoClose);
            this.pnlTitle.Controls.Add(this.icoMinus);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.Location = new System.Drawing.Point(253, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1137, 59);
            this.pnlTitle.TabIndex = 2;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // tmThongBaoAll
            // 
            this.tmThongBaoAll.Enabled = true;
            this.tmThongBaoAll.Interval = 10000;
            this.tmThongBaoAll.Tick += new System.EventHandler(this.tmThongBaoAll_Tick);
            // 
            // ThongBao
            // 
            this.ThongBao.Icon = ((System.Drawing.Icon)(resources.GetObject("ThongBao.Icon")));
            this.ThongBao.Text = "Thông báo công việc";
            this.ThongBao.Visible = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // tmThongBaoCV
            // 
            this.tmThongBaoCV.Enabled = true;
            this.tmThongBaoCV.Tick += new System.EventHandler(this.tmThongBaoCV_Tick);
            // 
            // mainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 753);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainUI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainUI_FormClosed);
            this.Load += new System.EventHandler(this.btnHome_Click);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoClose)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlHighLight1;
        private System.Windows.Forms.Panel pnlHighLight3;
        private System.Windows.Forms.Panel pnlHighLight2;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel pnlHighLight4;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.PictureBox icoMinus;
        private System.Windows.Forms.PictureBox icoClose;
        private System.Windows.Forms.Panel pnlTitle;
        public System.Windows.Forms.Label dongHo;
        public System.Windows.Forms.Timer tmThongBaoAll;
        public System.Windows.Forms.NotifyIcon ThongBao;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Timer tmThongBaoCV;
    }
}