namespace GUI
{
	partial class fCapTaiKhoan
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label1.Location = new System.Drawing.Point(67, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tài khoản:";
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtTaiKhoan.Location = new System.Drawing.Point(67, 95);
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(350, 29);
			this.txtTaiKhoan.TabIndex = 1;
			this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtMatKhau.Location = new System.Drawing.Point(67, 165);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(350, 29);
			this.txtMatKhau.TabIndex = 3;
			this.txtMatKhau.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label2.Location = new System.Drawing.Point(67, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mật khẩu:";
			// 
			// txtNhapLaiMK
			// 
			this.txtNhapLaiMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNhapLaiMK.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtNhapLaiMK.Location = new System.Drawing.Point(67, 235);
			this.txtNhapLaiMK.Name = "txtNhapLaiMK";
			this.txtNhapLaiMK.Size = new System.Drawing.Size(350, 29);
			this.txtNhapLaiMK.TabIndex = 5;
			this.txtNhapLaiMK.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label3.Location = new System.Drawing.Point(67, 210);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nhập lại mật khẩu:";
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnXacNhan.Location = new System.Drawing.Point(177, 280);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(131, 39);
			this.btnXacNhan.TabIndex = 6;
			this.btnXacNhan.Text = "Xác nhận";
			this.btnXacNhan.UseVisualStyleBackColor = true;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label4.Location = new System.Drawing.Point(123, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(238, 46);
			this.label4.TabIndex = 7;
			this.label4.Text = "Cấp tài khoản";
			// 
			// fCapTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnXacNhan);
			this.Controls.Add(this.txtNhapLaiMK);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTaiKhoan);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fCapTaiKhoan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.fCapTaiKhoan_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTaiKhoan;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNhapLaiMK;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnXacNhan;
		private System.Windows.Forms.Label label4;
	}
}