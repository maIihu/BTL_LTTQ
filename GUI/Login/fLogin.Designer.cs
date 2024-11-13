namespace GUI.Login
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.ckBoxHienMK = new System.Windows.Forms.CheckBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(172)))), ((int)(((byte)(205)))));
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(350, 450);
			this.panel1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(327, 37);
			this.label4.TabIndex = 1;
			this.label4.Text = "Quản lý cửa hàng sửa xe";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::GUI.Properties.Resources.LOGO1;
			this.pictureBox1.Location = new System.Drawing.Point(100, 85);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtTaiKhoan.Location = new System.Drawing.Point(9, 8);
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(330, 22);
			this.txtTaiKhoan.TabIndex = 30;
			this.txtTaiKhoan.Enter += new System.EventHandler(this.txtTaiKhoan_Enter);
			this.txtTaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
			this.txtTaiKhoan.Leave += new System.EventHandler(this.txtTaiKhoan_Leave);
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtMatKhau.Location = new System.Drawing.Point(14, 8);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(320, 22);
			this.txtMatKhau.TabIndex = 31;
			this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
			this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
			this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label1.Location = new System.Drawing.Point(25, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Tên đăng nhập:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label2.Location = new System.Drawing.Point(25, 235);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mật khẩu:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnClose);
			this.panel2.Controls.Add(this.btnDangNhap);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.ckBoxHienMK);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(350, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(400, 450);
			this.panel2.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.BackgroundImage = global::GUI.Properties.Resources.exit_button;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(365, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(30, 30);
			this.btnClose.TabIndex = 10;
			this.btnClose.TabStop = false;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.btnDangNhap.ForeColor = System.Drawing.Color.White;
			this.btnDangNhap.Location = new System.Drawing.Point(30, 350);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(161, 47);
			this.btnDangNhap.TabIndex = 9;
			this.btnDangNhap.TabStop = false;
			this.btnDangNhap.Text = "ĐĂNG NHẬP";
			this.btnDangNhap.UseVisualStyleBackColor = false;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(20, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 37);
			this.label3.TabIndex = 8;
			this.label3.Text = "Đăng nhập";
			// 
			// ckBoxHienMK
			// 
			this.ckBoxHienMK.AutoSize = true;
			this.ckBoxHienMK.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.ckBoxHienMK.Location = new System.Drawing.Point(245, 305);
			this.ckBoxHienMK.Name = "ckBoxHienMK";
			this.ckBoxHienMK.Size = new System.Drawing.Size(130, 25);
			this.ckBoxHienMK.TabIndex = 7;
			this.ckBoxHienMK.TabStop = false;
			this.ckBoxHienMK.Text = "Hiện mật khẩu";
			this.ckBoxHienMK.UseVisualStyleBackColor = true;
			this.ckBoxHienMK.CheckedChanged += new System.EventHandler(this.ckBoxHienMK_CheckedChanged);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.txtMatKhau);
			this.panel4.Location = new System.Drawing.Point(25, 260);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(350, 40);
			this.panel4.TabIndex = 6;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.txtTaiKhoan);
			this.panel3.Location = new System.Drawing.Point(25, 180);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(350, 40);
			this.panel3.TabIndex = 5;
			// 
			// fLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(750, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.fLogin_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.fLogin_Paint);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtTaiKhoan;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox ckBoxHienMK;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnClose;
	}
}