namespace JobsManagement
{
    partial class fAddJob
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnNgayMai = new System.Windows.Forms.Button();
            this.btnHomNay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudPhut = new System.Windows.Forms.NumericUpDown();
            this.nudGio = new System.Windows.Forms.NumericUpDown();
            this.cbbLapLai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCongViec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGio)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnNgayMai);
            this.panel1.Controls.Add(this.btnHomNay);
            this.panel1.Location = new System.Drawing.Point(15, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 57);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(365, 30);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnNgayMai
            // 
            this.btnNgayMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNgayMai.Location = new System.Drawing.Point(636, 3);
            this.btnNgayMai.Name = "btnNgayMai";
            this.btnNgayMai.Size = new System.Drawing.Size(137, 50);
            this.btnNgayMai.TabIndex = 0;
            this.btnNgayMai.Text = "Ngày mai";
            this.btnNgayMai.UseVisualStyleBackColor = true;
            // 
            // btnHomNay
            // 
            this.btnHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHomNay.Location = new System.Drawing.Point(3, 3);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(137, 50);
            this.btnHomNay.TabIndex = 0;
            this.btnHomNay.Text = "Hôm nay";
            this.btnHomNay.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudPhut);
            this.panel2.Controls.Add(this.nudGio);
            this.panel2.Controls.Add(this.cbbLapLai);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbCongViec);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(15, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 266);
            this.panel2.TabIndex = 1;
            // 
            // nudPhut
            // 
            this.nudPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudPhut.Location = new System.Drawing.Point(394, 134);
            this.nudPhut.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudPhut.Name = "nudPhut";
            this.nudPhut.Size = new System.Drawing.Size(48, 30);
            this.nudPhut.TabIndex = 4;
            // 
            // nudGio
            // 
            this.nudGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudGio.Location = new System.Drawing.Point(268, 134);
            this.nudGio.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudGio.Name = "nudGio";
            this.nudGio.Size = new System.Drawing.Size(46, 30);
            this.nudGio.TabIndex = 3;
            // 
            // cbbLapLai
            // 
            this.cbbLapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbLapLai.FormattingEnabled = true;
            this.cbbLapLai.Items.AddRange(new object[] {
            "Một lần",
            "Hằng ngày",
            "Hằng tuần"});
            this.cbbLapLai.Location = new System.Drawing.Point(268, 219);
            this.cbbLapLai.Name = "cbbLapLai";
            this.cbbLapLai.Size = new System.Drawing.Size(294, 33);
            this.cbbLapLai.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(54, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lặp lại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(448, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "phút";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(320, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(54, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian: ";
            // 
            // txbCongViec
            // 
            this.txbCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbCongViec.Location = new System.Drawing.Point(268, 34);
            this.txbCongViec.Multiline = true;
            this.txbCongViec.Name = "txbCongViec";
            this.txbCongViec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCongViec.Size = new System.Drawing.Size(448, 78);
            this.txbCongViec.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công việc: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Location = new System.Drawing.Point(15, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 57);
            this.panel3.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(457, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(137, 50);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(177, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(137, 50);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // fAddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fAddJob";
            this.Text = "addJob";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGio)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnNgayMai;
        private System.Windows.Forms.Button btnHomNay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCongViec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLapLai;
        private System.Windows.Forms.NumericUpDown nudGio;
        private System.Windows.Forms.NumericUpDown nudPhut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}