namespace JobsManagement
{
    partial class fForgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fForgot));
            this.label1 = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.lbCopied = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.icoClose = new System.Windows.Forms.PictureBox();
            this.icoMinus = new System.Windows.Forms.PictureBox();
            this.HLtenTK = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbTenTK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iconCopy = new System.Windows.Forms.PictureBox();
            this.HLchbm = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tcbCHBM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnXN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMinus)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCopy)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(123, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lấy lại mật khẩu";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.ForeColor = System.Drawing.Color.Turquoise;
            this.lbmatkhau.Location = new System.Drawing.Point(54, 330);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(114, 25);
            this.lbmatkhau.TabIndex = 3;
            this.lbmatkhau.Text = "Mật khẩu: ";
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.ForeColor = System.Drawing.Color.White;
            this.lbMK.Location = new System.Drawing.Point(174, 332);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(98, 25);
            this.lbMK.TabIndex = 15;
            this.lbMK.Text = "Password";
            this.lbMK.Visible = false;
            // 
            // lbCopied
            // 
            this.lbCopied.AutoSize = true;
            this.lbCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCopied.ForeColor = System.Drawing.Color.Turquoise;
            this.lbCopied.Location = new System.Drawing.Point(175, 355);
            this.lbCopied.Name = "lbCopied";
            this.lbCopied.Size = new System.Drawing.Size(81, 22);
            this.lbCopied.TabIndex = 15;
            this.lbCopied.Text = "Đã copy!";
            this.lbCopied.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.icoClose);
            this.panel1.Controls.Add(this.icoMinus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 87);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(655, 5);
            this.panel3.TabIndex = 23;
            // 
            // icoClose
            // 
            this.icoClose.Image = global::JobsManagement.Properties.Resources.multipy_icon;
            this.icoClose.Location = new System.Drawing.Point(467, 12);
            this.icoClose.Name = "icoClose";
            this.icoClose.Size = new System.Drawing.Size(30, 30);
            this.icoClose.TabIndex = 19;
            this.icoClose.TabStop = false;
            this.icoClose.Click += new System.EventHandler(this.icoClose_Click);
            // 
            // icoMinus
            // 
            this.icoMinus.Image = global::JobsManagement.Properties.Resources.minus_icon;
            this.icoMinus.Location = new System.Drawing.Point(431, 13);
            this.icoMinus.Name = "icoMinus";
            this.icoMinus.Size = new System.Drawing.Size(30, 30);
            this.icoMinus.TabIndex = 18;
            this.icoMinus.TabStop = false;
            this.icoMinus.Click += new System.EventHandler(this.icoMinus_Click);
            // 
            // HLtenTK
            // 
            this.HLtenTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.HLtenTK.Location = new System.Drawing.Point(59, 198);
            this.HLtenTK.Name = "HLtenTK";
            this.HLtenTK.Size = new System.Drawing.Size(377, 2);
            this.HLtenTK.TabIndex = 22;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel14.Controls.Add(this.txbTenTK);
            this.panel14.Location = new System.Drawing.Point(59, 150);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(377, 49);
            this.panel14.TabIndex = 21;
            // 
            // txbTenTK
            // 
            this.txbTenTK.AcceptsTab = true;
            this.txbTenTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txbTenTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenTK.ForeColor = System.Drawing.Color.White;
            this.txbTenTK.Location = new System.Drawing.Point(18, 14);
            this.txbTenTK.MaxLength = 19;
            this.txbTenTK.Multiline = true;
            this.txbTenTK.Name = "txbTenTK";
            this.txbTenTK.Size = new System.Drawing.Size(341, 28);
            this.txbTenTK.TabIndex = 4;
            this.txbTenTK.Click += new System.EventHandler(this.txbTenTK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(54, 116);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label7.Size = new System.Drawing.Size(144, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tên tài khoản";
            // 
            // iconCopy
            // 
            this.iconCopy.Image = ((System.Drawing.Image)(resources.GetObject("iconCopy.Image")));
            this.iconCopy.Location = new System.Drawing.Point(408, 332);
            this.iconCopy.Name = "iconCopy";
            this.iconCopy.Size = new System.Drawing.Size(28, 23);
            this.iconCopy.TabIndex = 23;
            this.iconCopy.TabStop = false;
            // 
            // HLchbm
            // 
            this.HLchbm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.HLchbm.Location = new System.Drawing.Point(59, 300);
            this.HLchbm.Name = "HLchbm";
            this.HLchbm.Size = new System.Drawing.Size(377, 2);
            this.HLchbm.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.tcbCHBM);
            this.panel4.Location = new System.Drawing.Point(59, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 49);
            this.panel4.TabIndex = 25;
            // 
            // tcbCHBM
            // 
            this.tcbCHBM.AcceptsTab = true;
            this.tcbCHBM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.tcbCHBM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tcbCHBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcbCHBM.ForeColor = System.Drawing.Color.White;
            this.tcbCHBM.Location = new System.Drawing.Point(18, 14);
            this.tcbCHBM.MaxLength = 19;
            this.tcbCHBM.Multiline = true;
            this.tcbCHBM.Name = "tcbCHBM";
            this.tcbCHBM.Size = new System.Drawing.Size(341, 28);
            this.tcbCHBM.TabIndex = 4;
            this.tcbCHBM.Click += new System.EventHandler(this.tcbCHBM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 218);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Size = new System.Drawing.Size(183, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "Câu hỏi bảo mật: ";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SeaGreen;
            this.panel12.Location = new System.Drawing.Point(172, 56);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(182, 2);
            this.panel12.TabIndex = 19;
            // 
            // btnXN
            // 
            this.btnXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnXN.FlatAppearance.BorderSize = 0;
            this.btnXN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXN.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnXN.Location = new System.Drawing.Point(172, 12);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(182, 46);
            this.btnXN.TabIndex = 18;
            this.btnXN.Text = "Xác nhận";
            this.btnXN.UseVisualStyleBackColor = false;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.btnXN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 88);
            this.panel2.TabIndex = 27;
            // 
            // fForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(509, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HLchbm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconCopy);
            this.Controls.Add(this.HLtenTK);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCopied);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.lbmatkhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fForgot";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fForgot";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMinus)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCopy)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Label lbCopied;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox icoMinus;
        private System.Windows.Forms.PictureBox icoClose;
        private System.Windows.Forms.Panel HLtenTK;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txbTenTK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox iconCopy;
        private System.Windows.Forms.Panel HLchbm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tcbCHBM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnXN;
        private System.Windows.Forms.Panel panel2;
    }
}