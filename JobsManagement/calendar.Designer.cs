namespace JobsManagement
{
    partial class fCalendar
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
            this.btnTom = new System.Windows.Forms.Button();
            this.btnHomNay = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSun = new System.Windows.Forms.Button();
            this.btnSat = new System.Windows.Forms.Button();
            this.btnFri = new System.Windows.Forms.Button();
            this.btnThurs = new System.Windows.Forms.Button();
            this.btnWed = new System.Windows.Forms.Button();
            this.btnTues = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.paMatrix = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnTodayJob = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTom);
            this.panel1.Controls.Add(this.btnHomNay);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(10, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnTom
            // 
            this.btnTom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTom.Location = new System.Drawing.Point(555, 4);
            this.btnTom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTom.Name = "btnTom";
            this.btnTom.Size = new System.Drawing.Size(105, 32);
            this.btnTom.TabIndex = 1;
            this.btnTom.Text = "Ngày mai";
            this.btnTom.UseVisualStyleBackColor = true;
            this.btnTom.Click += new System.EventHandler(this.btnTom_Click);
            // 
            // btnHomNay
            // 
            this.btnHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHomNay.Location = new System.Drawing.Point(129, 4);
            this.btnHomNay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(105, 32);
            this.btnHomNay.TabIndex = 1;
            this.btnHomNay.Text = "Hôm nay";
            this.btnHomNay.UseVisualStyleBackColor = true;
            this.btnHomNay.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker.Location = new System.Drawing.Point(253, 6);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(282, 26);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dtpkValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnPrevious);
            this.panel4.Controls.Add(this.btnSun);
            this.panel4.Controls.Add(this.btnSat);
            this.panel4.Controls.Add(this.btnFri);
            this.panel4.Controls.Add(this.btnThurs);
            this.panel4.Controls.Add(this.btnWed);
            this.panel4.Controls.Add(this.btnTues);
            this.panel4.Controls.Add(this.btnMon);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(10, 116);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 55);
            this.panel4.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(669, 5);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 41);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Tháng Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(3, 5);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(120, 41);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Tháng trước";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSun
            // 
            this.btnSun.Location = new System.Drawing.Point(588, 5);
            this.btnSun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSun.Name = "btnSun";
            this.btnSun.Size = new System.Drawing.Size(72, 41);
            this.btnSun.TabIndex = 6;
            this.btnSun.Text = "C.Nhật";
            this.btnSun.UseVisualStyleBackColor = true;
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(512, 5);
            this.btnSat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(72, 41);
            this.btnSat.TabIndex = 5;
            this.btnSat.Text = "Thứ 7";
            this.btnSat.UseVisualStyleBackColor = true;
            // 
            // btnFri
            // 
            this.btnFri.Location = new System.Drawing.Point(435, 5);
            this.btnFri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFri.Name = "btnFri";
            this.btnFri.Size = new System.Drawing.Size(72, 41);
            this.btnFri.TabIndex = 4;
            this.btnFri.Text = "Thứ 6";
            this.btnFri.UseVisualStyleBackColor = true;
            // 
            // btnThurs
            // 
            this.btnThurs.Location = new System.Drawing.Point(358, 5);
            this.btnThurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThurs.Name = "btnThurs";
            this.btnThurs.Size = new System.Drawing.Size(72, 41);
            this.btnThurs.TabIndex = 3;
            this.btnThurs.Text = "Thứ 5";
            this.btnThurs.UseVisualStyleBackColor = true;
            // 
            // btnWed
            // 
            this.btnWed.Location = new System.Drawing.Point(282, 5);
            this.btnWed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWed.Name = "btnWed";
            this.btnWed.Size = new System.Drawing.Size(72, 41);
            this.btnWed.TabIndex = 2;
            this.btnWed.Text = "Thứ 4";
            this.btnWed.UseVisualStyleBackColor = true;
            this.btnWed.Click += new System.EventHandler(this.btnWed_Click);
            // 
            // btnTues
            // 
            this.btnTues.Location = new System.Drawing.Point(206, 5);
            this.btnTues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTues.Name = "btnTues";
            this.btnTues.Size = new System.Drawing.Size(72, 41);
            this.btnTues.TabIndex = 1;
            this.btnTues.Text = "Thứ 3";
            this.btnTues.UseVisualStyleBackColor = true;
            // 
            // btnMon
            // 
            this.btnMon.Location = new System.Drawing.Point(129, 5);
            this.btnMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(72, 41);
            this.btnMon.TabIndex = 0;
            this.btnMon.Text = "Thứ 2";
            this.btnMon.UseVisualStyleBackColor = true;
            // 
            // paMatrix
            // 
            this.paMatrix.Location = new System.Drawing.Point(139, 176);
            this.paMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paMatrix.Name = "paMatrix";
            this.paMatrix.Size = new System.Drawing.Size(531, 344);
            this.paMatrix.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnStatistics);
            this.panel5.Controls.Add(this.btnTodayJob);
            this.panel5.Controls.Add(this.btnCalendar);
            this.panel5.Location = new System.Drawing.Point(10, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(792, 50);
            this.panel5.TabIndex = 2;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStatistics.Location = new System.Drawing.Point(669, 3);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(120, 41);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnTodayJob
            // 
            this.btnTodayJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTodayJob.Location = new System.Drawing.Point(222, 3);
            this.btnTodayJob.Name = "btnTodayJob";
            this.btnTodayJob.Size = new System.Drawing.Size(338, 41);
            this.btnTodayJob.TabIndex = 1;
            this.btnTodayJob.Text = "Việc cần làm hôm nay";
            this.btnTodayJob.UseVisualStyleBackColor = true;
            this.btnTodayJob.Click += new System.EventHandler(this.btnTodayJob_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Enabled = false;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCalendar.Location = new System.Drawing.Point(3, 3);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(120, 41);
            this.btnCalendar.TabIndex = 0;
            this.btnCalendar.Text = "Lịch";
            this.btnCalendar.UseVisualStyleBackColor = true;
            // 
            // fCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(812, 531);
            this.Controls.Add(this.paMatrix);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fCalendar";
            this.Text = "calendar";
            this.Load += new System.EventHandler(this.fCalendar_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTom;
        private System.Windows.Forms.Button btnHomNay;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSun;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Button btnFri;
        private System.Windows.Forms.Button btnThurs;
        private System.Windows.Forms.Button btnWed;
        private System.Windows.Forms.Button btnTues;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.Panel paMatrix;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnTodayJob;
        private System.Windows.Forms.Button btnCalendar;
    }
}