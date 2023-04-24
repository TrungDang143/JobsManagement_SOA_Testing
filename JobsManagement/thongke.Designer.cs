namespace JobsManagement
{
    partial class fThongKe
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbCVdaHoanThanh = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbCVchuaHoanThanh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnTodayJob = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.lbCVdaHoanThanh);
            this.panel4.Location = new System.Drawing.Point(549, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 527);
            this.panel4.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(520, 457);
            this.dataGridView2.TabIndex = 1;
            // 
            // lbCVdaHoanThanh
            // 
            this.lbCVdaHoanThanh.AutoSize = true;
            this.lbCVdaHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCVdaHoanThanh.Location = new System.Drawing.Point(3, 23);
            this.lbCVdaHoanThanh.Name = "lbCVdaHoanThanh";
            this.lbCVdaHoanThanh.Size = new System.Drawing.Size(379, 29);
            this.lbCVdaHoanThanh.TabIndex = 0;
            this.lbCVdaHoanThanh.Text = "Không có công việc đã hoàn thành";
            this.lbCVdaHoanThanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.lbCVchuaHoanThanh);
            this.panel3.Location = new System.Drawing.Point(14, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 527);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(520, 457);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbCVchuaHoanThanh
            // 
            this.lbCVchuaHoanThanh.AutoSize = true;
            this.lbCVchuaHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCVchuaHoanThanh.Location = new System.Drawing.Point(3, 23);
            this.lbCVchuaHoanThanh.Name = "lbCVchuaHoanThanh";
            this.lbCVchuaHoanThanh.Size = new System.Drawing.Size(403, 29);
            this.lbCVchuaHoanThanh.TabIndex = 0;
            this.lbCVchuaHoanThanh.Text = "Không có công việc chưa hoàn thành";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStatistics);
            this.panel2.Controls.Add(this.btnTodayJob);
            this.panel2.Controls.Add(this.btnCalendar);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 61);
            this.panel2.TabIndex = 0;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStatistics.Location = new System.Drawing.Point(892, 4);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(160, 50);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btnTodayJob
            // 
            this.btnTodayJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTodayJob.Location = new System.Drawing.Point(296, 4);
            this.btnTodayJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnTodayJob.Name = "btnTodayJob";
            this.btnTodayJob.Size = new System.Drawing.Size(450, 50);
            this.btnTodayJob.TabIndex = 1;
            this.btnTodayJob.Text = "Việc cần làm hôm nay";
            this.btnTodayJob.UseVisualStyleBackColor = true;
            this.btnTodayJob.Click += new System.EventHandler(this.btnTodayJob_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCalendar.Location = new System.Drawing.Point(4, 4);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(160, 50);
            this.btnCalendar.TabIndex = 0;
            this.btnCalendar.Text = "Lịch";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "fThongKe";
            this.Text = "thongke";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnTodayJob;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbCVdaHoanThanh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbCVchuaHoanThanh;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}