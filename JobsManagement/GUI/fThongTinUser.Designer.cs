namespace JobsManagement.GUI
{
    partial class fThongTinUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongTinUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.icoClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.lbCC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTDN = new System.Windows.Forms.Label();
            this.lbTHT = new System.Windows.Forms.Label();
            this.lbTL = new System.Windows.Forms.Label();
            this.lbCHBM = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.lbCanhBao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.icoClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 87);
            this.panel1.TabIndex = 31;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 5);
            this.panel3.TabIndex = 23;
            // 
            // icoClose
            // 
            this.icoClose.Image = global::JobsManagement.Properties.Resources.multipy_icon;
            this.icoClose.Location = new System.Drawing.Point(510, 12);
            this.icoClose.Name = "icoClose";
            this.icoClose.Size = new System.Drawing.Size(30, 30);
            this.icoClose.TabIndex = 19;
            this.icoClose.TabStop = false;
            this.icoClose.Click += new System.EventHandler(this.icoClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(95, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thông tin người dùng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.ForeColor = System.Drawing.Color.White;
            this.lbMK.Location = new System.Drawing.Point(158, 189);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(98, 25);
            this.lbMK.TabIndex = 30;
            this.lbMK.Text = "Password";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmatkhau.ForeColor = System.Drawing.Color.Turquoise;
            this.lbmatkhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbmatkhau.Location = new System.Drawing.Point(48, 189);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(104, 25);
            this.lbmatkhau.TabIndex = 28;
            this.lbmatkhau.Text = "Mật khẩu: ";
            this.lbmatkhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCC
            // 
            this.lbCC.AutoSize = true;
            this.lbCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCC.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCC.Location = new System.Drawing.Point(48, 312);
            this.lbCC.Name = "lbCC";
            this.lbCC.Size = new System.Drawing.Size(368, 25);
            this.lbCC.TabIndex = 24;
            this.lbCC.Text = "Độ chăm chỉ: = tỉ lệ hoàn thành công việc";
            this.lbCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(48, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tên hiển thị: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(48, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tên đăng nhập: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(48, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Câu hỏi bảo mật: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(48, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Trả lời: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTDN
            // 
            this.lbTDN.AutoSize = true;
            this.lbTDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTDN.ForeColor = System.Drawing.Color.White;
            this.lbTDN.Location = new System.Drawing.Point(210, 107);
            this.lbTDN.Name = "lbTDN";
            this.lbTDN.Size = new System.Drawing.Size(98, 25);
            this.lbTDN.TabIndex = 30;
            this.lbTDN.Text = "Password";
            // 
            // lbTHT
            // 
            this.lbTHT.AutoSize = true;
            this.lbTHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTHT.ForeColor = System.Drawing.Color.White;
            this.lbTHT.Location = new System.Drawing.Point(179, 148);
            this.lbTHT.Name = "lbTHT";
            this.lbTHT.Size = new System.Drawing.Size(98, 25);
            this.lbTHT.TabIndex = 30;
            this.lbTHT.Text = "Password";
            // 
            // lbTL
            // 
            this.lbTL.AutoSize = true;
            this.lbTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTL.ForeColor = System.Drawing.Color.White;
            this.lbTL.Location = new System.Drawing.Point(131, 271);
            this.lbTL.Name = "lbTL";
            this.lbTL.Size = new System.Drawing.Size(98, 25);
            this.lbTL.TabIndex = 30;
            this.lbTL.Text = "Password";
            // 
            // lbCHBM
            // 
            this.lbCHBM.AutoSize = true;
            this.lbCHBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCHBM.ForeColor = System.Drawing.Color.White;
            this.lbCHBM.Location = new System.Drawing.Point(220, 230);
            this.lbCHBM.Name = "lbCHBM";
            this.lbCHBM.Size = new System.Drawing.Size(98, 25);
            this.lbCHBM.TabIndex = 30;
            this.lbCHBM.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(175, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 2);
            this.panel2.TabIndex = 34;
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnXoaTK.FlatAppearance.BorderSize = 0;
            this.btnXoaTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.Red;
            this.btnXoaTK.Location = new System.Drawing.Point(175, 410);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(188, 46);
            this.btnXoaTK.TabIndex = 33;
            this.btnXoaTK.Text = "Xoá Tài khoản";
            this.btnXoaTK.UseVisualStyleBackColor = false;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // lbCanhBao
            // 
            this.lbCanhBao.AutoSize = true;
            this.lbCanhBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCanhBao.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbCanhBao.Location = new System.Drawing.Point(27, 347);
            this.lbCanhBao.Name = "lbCanhBao";
            this.lbCanhBao.Size = new System.Drawing.Size(489, 50);
            this.lbCanhBao.TabIndex = 35;
            this.lbCanhBao.Text = "Sẽ không thể khôi phục lại tài khoản sau khi xoá. \r\nXác nhận xoá?";
            this.lbCanhBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCanhBao.Visible = false;
            this.lbCanhBao.Click += new System.EventHandler(this.label7_Click);
            // 
            // fThongTinUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(552, 479);
            this.Controls.Add(this.lbCanhBao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXoaTK);
            this.Controls.Add(this.lbCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTDN);
            this.Controls.Add(this.lbCHBM);
            this.Controls.Add(this.lbTL);
            this.Controls.Add(this.lbTHT);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbmatkhau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThongTinUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fThongTinUser";
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            this.Load += new System.EventHandler(this.fThongTinUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox icoClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Label lbCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTDN;
        private System.Windows.Forms.Label lbTHT;
        private System.Windows.Forms.Label lbTL;
        private System.Windows.Forms.Label lbCHBM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Label lbCanhBao;
    }
}