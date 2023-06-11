namespace JobsManagement
{
    partial class ucThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbCVdaHoanThanh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHT = new System.Windows.Forms.DataGridView();
            this.noiDungCV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvchuaHT = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNgay = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnTuan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbCVchuaHoanThanh = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbTatCa = new System.Windows.Forms.Label();
            this.dtpk = new System.Windows.Forms.DateTimePicker();
            this.noiDungCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchuaHT)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCVdaHoanThanh
            // 
            this.lbCVdaHoanThanh.AutoSize = true;
            this.lbCVdaHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCVdaHoanThanh.ForeColor = System.Drawing.Color.White;
            this.lbCVdaHoanThanh.Location = new System.Drawing.Point(3, 15);
            this.lbCVdaHoanThanh.Name = "lbCVdaHoanThanh";
            this.lbCVdaHoanThanh.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbCVdaHoanThanh.Size = new System.Drawing.Size(399, 29);
            this.lbCVdaHoanThanh.TabIndex = 0;
            this.lbCVdaHoanThanh.Text = "Không có công việc đã hoàn thành";
            this.lbCVdaHoanThanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHT);
            this.panel1.Controls.Add(this.dgvchuaHT);
            this.panel1.Location = new System.Drawing.Point(46, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 468);
            this.panel1.TabIndex = 4;
            // 
            // dgvHT
            // 
            this.dgvHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noiDungCV1});
            this.dgvHT.GridColor = System.Drawing.Color.Chocolate;
            this.dgvHT.Location = new System.Drawing.Point(534, 0);
            this.dgvHT.Name = "dgvHT";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHT.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHT.RowHeadersWidth = 51;
            this.dgvHT.RowTemplate.Height = 24;
            this.dgvHT.Size = new System.Drawing.Size(500, 424);
            this.dgvHT.TabIndex = 0;
            // 
            // noiDungCV1
            // 
            this.noiDungCV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noiDungCV1.DataPropertyName = "noiDungCV";
            this.noiDungCV1.HeaderText = "Tên công việc";
            this.noiDungCV1.MinimumWidth = 6;
            this.noiDungCV1.Name = "noiDungCV1";
            // 
            // dgvchuaHT
            // 
            this.dgvchuaHT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvchuaHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvchuaHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvchuaHT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvchuaHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchuaHT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noiDungCV});
            this.dgvchuaHT.GridColor = System.Drawing.Color.Chocolate;
            this.dgvchuaHT.Location = new System.Drawing.Point(3, 3);
            this.dgvchuaHT.Name = "dgvchuaHT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvchuaHT.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvchuaHT.RowHeadersWidth = 51;
            this.dgvchuaHT.RowTemplate.Height = 24;
            this.dgvchuaHT.Size = new System.Drawing.Size(500, 424);
            this.dgvchuaHT.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNgay);
            this.panel2.Controls.Add(this.btnNam);
            this.panel2.Controls.Add(this.btnThang);
            this.panel2.Controls.Add(this.btnTuan);
            this.panel2.Location = new System.Drawing.Point(401, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 40);
            this.panel2.TabIndex = 9;
            // 
            // btnNgay
            // 
            this.btnNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnNgay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNgay.FlatAppearance.BorderSize = 2;
            this.btnNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNgay.ForeColor = System.Drawing.Color.Turquoise;
            this.btnNgay.Location = new System.Drawing.Point(0, 0);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(170, 40);
            this.btnNgay.TabIndex = 0;
            this.btnNgay.Text = "Hôm nay";
            this.btnNgay.UseVisualStyleBackColor = false;
            this.btnNgay.Click += new System.EventHandler(this.btnNgay_Click);
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnNam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNam.FlatAppearance.BorderSize = 2;
            this.btnNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNam.ForeColor = System.Drawing.Color.Turquoise;
            this.btnNam.Location = new System.Drawing.Point(510, 0);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(170, 40);
            this.btnNam.TabIndex = 0;
            this.btnNam.Text = "Theo năm";
            this.btnNam.UseVisualStyleBackColor = false;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnThang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnThang.FlatAppearance.BorderSize = 2;
            this.btnThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThang.ForeColor = System.Drawing.Color.Turquoise;
            this.btnThang.Location = new System.Drawing.Point(340, 0);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(170, 40);
            this.btnThang.TabIndex = 0;
            this.btnThang.Text = "Theo tháng";
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btnTuan
            // 
            this.btnTuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.btnTuan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTuan.FlatAppearance.BorderSize = 2;
            this.btnTuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTuan.ForeColor = System.Drawing.Color.Turquoise;
            this.btnTuan.Location = new System.Drawing.Point(170, 0);
            this.btnTuan.Name = "btnTuan";
            this.btnTuan.Size = new System.Drawing.Size(170, 40);
            this.btnTuan.TabIndex = 0;
            this.btnTuan.Text = "Theo tuần";
            this.btnTuan.UseVisualStyleBackColor = false;
            this.btnTuan.Click += new System.EventHandler(this.btnTuan_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel4.Controls.Add(this.lbCVchuaHoanThanh);
            this.panel4.Location = new System.Drawing.Point(49, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 60);
            this.panel4.TabIndex = 10;
            // 
            // lbCVchuaHoanThanh
            // 
            this.lbCVchuaHoanThanh.AutoSize = true;
            this.lbCVchuaHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCVchuaHoanThanh.ForeColor = System.Drawing.Color.White;
            this.lbCVchuaHoanThanh.Location = new System.Drawing.Point(3, 15);
            this.lbCVchuaHoanThanh.Name = "lbCVchuaHoanThanh";
            this.lbCVchuaHoanThanh.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbCVchuaHoanThanh.Size = new System.Drawing.Size(423, 29);
            this.lbCVchuaHoanThanh.TabIndex = 0;
            this.lbCVchuaHoanThanh.Text = "Không có công việc chưa hoàn thành";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel5.Controls.Add(this.lbCVdaHoanThanh);
            this.panel5.Location = new System.Drawing.Point(580, 149);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 60);
            this.panel5.TabIndex = 10;
            // 
            // lbTatCa
            // 
            this.lbTatCa.AutoSize = true;
            this.lbTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTatCa.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTatCa.Location = new System.Drawing.Point(51, 95);
            this.lbTatCa.Name = "lbTatCa";
            this.lbTatCa.Size = new System.Drawing.Size(760, 32);
            this.lbTatCa.TabIndex = 1;
            this.lbTatCa.Text = "Có tất cả ... công việc trong ngày hôm nay/ tuần này /...";
            // 
            // dtpk
            // 
            this.dtpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpk.Location = new System.Drawing.Point(49, 27);
            this.dtpk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk.Name = "dtpk";
            this.dtpk.Size = new System.Drawing.Size(330, 30);
            this.dtpk.TabIndex = 11;
            this.dtpk.ValueChanged += new System.EventHandler(this.dtpk_ValueChanged);
            // 
            // noiDungCV
            // 
            this.noiDungCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noiDungCV.DataPropertyName = "noiDungCV";
            this.noiDungCV.HeaderText = "Tên công việc";
            this.noiDungCV.MinimumWidth = 6;
            this.noiDungCV.Name = "noiDungCV";
            // 
            // ucThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(97)))));
            this.Controls.Add(this.dtpk);
            this.Controls.Add(this.lbTatCa);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(1130, 646);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchuaHT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCVdaHoanThanh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnTuan;
        private System.Windows.Forms.DataGridView dgvHT;
        private System.Windows.Forms.DataGridView dgvchuaHT;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbCVchuaHoanThanh;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbTatCa;
        private System.Windows.Forms.DateTimePicker dtpk;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungCV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungCV;
    }
}
