namespace JobsManagement.GUI
{
    partial class ucAD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.tenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnAD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(175, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 36);
            this.label2.TabIndex = 60;
            this.label2.Text = "Administrator";
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDangNhap,
            this.tenHienThi});
            this.dgvAdmin.Location = new System.Drawing.Point(13, 129);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(541, 262);
            this.dgvAdmin.TabIndex = 61;
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.DataPropertyName = "tenDangNhap";
            this.tenDangNhap.HeaderText = "Tên Tài Khoản";
            this.tenDangNhap.MinimumWidth = 6;
            this.tenDangNhap.Name = "tenDangNhap";
            // 
            // tenHienThi
            // 
            this.tenHienThi.DataPropertyName = "tenHienThi";
            this.tenHienThi.HeaderText = "Tên Người Dùng";
            this.tenHienThi.MinimumWidth = 6;
            this.tenHienThi.Name = "tenHienThi";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gold;
            this.panel15.Location = new System.Drawing.Point(187, 451);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(179, 2);
            this.panel15.TabIndex = 65;
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel15_Paint);
            // 
            // btnAD
            // 
            this.btnAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAD.FlatAppearance.BorderSize = 0;
            this.btnAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAD.ForeColor = System.Drawing.Color.Gold;
            this.btnAD.Location = new System.Drawing.Point(187, 407);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(179, 46);
            this.btnAD.TabIndex = 64;
            this.btnAD.Text = "Xem thông tin";
            this.btnAD.UseVisualStyleBackColor = false;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 66;
            this.label1.Text = "Có ... tài khoản người dùng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Gold;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(3, 467);
            this.panel14.TabIndex = 67;
            // 
            // ucAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.btnAD);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.label2);
            this.Name = "ucAD";
            this.Size = new System.Drawing.Size(554, 467);
            this.Load += new System.EventHandler(this.ucAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHienThi;
    }
}
