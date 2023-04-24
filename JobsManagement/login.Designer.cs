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
			this.txbUsername = new System.Windows.Forms.TextBox();
			this.txbPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.showPassword = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(87, 307);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(284, 48);
			this.button4.TabIndex = 3;
			this.button4.Text = "Đăng nhập ";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.White;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(465, 307);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(267, 48);
			this.button5.TabIndex = 4;
			this.button5.Text = "Thoát";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(250, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(271, 54);
			this.label1.TabIndex = 5;
			this.label1.Text = "Đăng Nhập ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txbUsername
			// 
			this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txbUsername.Location = new System.Drawing.Point(226, 120);
			this.txbUsername.Name = "txbUsername";
			this.txbUsername.Size = new System.Drawing.Size(356, 38);
			this.txbUsername.TabIndex = 6;
			// 
			// txbPassword
			// 
			this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txbPassword.Location = new System.Drawing.Point(225, 172);
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.Size = new System.Drawing.Size(357, 38);
			this.txbPassword.TabIndex = 7;
			this.txbPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(81, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 32);
			this.label2.TabIndex = 9;
			this.label2.Text = "Tài khoản";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(80, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 32);
			this.label3.TabIndex = 9;
			this.label3.Text = "Mật khẩu";
			// 
			// showPassword
			// 
			this.showPassword.AutoSize = true;
			this.showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.showPassword.Location = new System.Drawing.Point(225, 237);
			this.showPassword.Name = "showPassword";
			this.showPassword.Size = new System.Drawing.Size(159, 29);
			this.showPassword.TabIndex = 10;
			this.showPassword.Text = "Hiện mật khẩu";
			this.showPassword.UseVisualStyleBackColor = true;
			this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
			// 
			// fLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.showPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txbPassword);
			this.Controls.Add(this.txbUsername);
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
		private System.Windows.Forms.TextBox txbUsername;
		private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showPassword;
    }
}

