namespace JobsManagement
{
    partial class fLogin
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
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(101, 265);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(284, 48);
			this.button4.TabIndex = 3;
			this.button4.Text = "Dang Nhap";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(466, 265);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(267, 48);
			this.button5.TabIndex = 4;
			this.button5.Text = "Thoat ";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(348, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Dang Nhap";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(226, 120);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(356, 22);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "Tai Khoan";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(225, 172);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(357, 22);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "Mat Khau";
			this.textBox2.UseSystemPasswordChar = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(564, 176);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(18, 17);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// fLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Name = "fLogin";
			this.Text = "Đăng Nhập";
			this.Load += new System.EventHandler(this.fLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}

