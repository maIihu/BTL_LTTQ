using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.Login
{
	public partial class fLogin : Form
	{
		private AccountBLL _accountBLL;
		private bool _showPassword;
		public string tenDangNhap;
		public fLogin()
		{
			InitializeComponent();
		}

		private void fLogin_Load(object sender, EventArgs e)
		{
			_showPassword = false;
			txtTaiKhoan.Text = "Nhập tài khoản";
			txtMatKhau.Text = "Nhập mật khẩu";
			_accountBLL = new AccountBLL();
		}

		private void ckBoxHienMK_CheckedChanged(object sender, EventArgs e)
		{
			_showPassword = !_showPassword;
			if (txtMatKhau.Text == "Nhập mật khẩu") return;
			txtMatKhau.UseSystemPasswordChar = !txtMatKhau.UseSystemPasswordChar;
		}
		#region TaiKhoan
		private void txtTaiKhoan_Enter(object sender, EventArgs e)
		{
			if (txtTaiKhoan.Text == "Nhập tài khoản")
			{
				txtTaiKhoan.Text = "";
			}
		}

		private void txtTaiKhoan_Leave(object sender, EventArgs e)
		{
			if (txtTaiKhoan.Text == "")
			{
				txtTaiKhoan.Text = "Nhập tài khoản";
			}
		}
		#endregion

		#region MatKhau
		private void txtMatKhau_Enter(object sender, EventArgs e)
		{
			if (txtMatKhau.Text == "Nhập mật khẩu")
			{
				txtMatKhau.Text = "";				
				txtMatKhau.UseSystemPasswordChar = !_showPassword;				
			}
		}
		private void txtMatKhau_Leave(object sender, EventArgs e)
		{
			if (txtMatKhau.Text == "")
			{
				txtMatKhau.Text = "Nhập mật khẩu";
				txtMatKhau.UseSystemPasswordChar = false; // khong bat
			}
		}
		#endregion

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			string thongTinTk = txtTaiKhoan.Text;
			string thongTinMk = txtMatKhau.Text;
			tenDangNhap = thongTinTk;
			AccountDTO user = new AccountDTO(thongTinTk, thongTinMk);
			bool isLoginSuccessful = _accountBLL.CheckAccountInDatabase(user);

			if (thongTinTk == "" || thongTinTk == "Nhập tài khoản")
			{
				MessageBox.Show("Nhập tài khoản.", "Thông báo",  MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtTaiKhoan.Focus();              
				return;
			}

			if (thongTinMk == "" || thongTinMk == "Nhập mật khẩu")
			{
				MessageBox.Show("Nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtMatKhau.Focus();
				return;
			}

			if (isLoginSuccessful)
			{
				//MessageBox.Show("Đăng nhập thành công!");
				fBase fBase = new fBase(tenDangNhap);
				this.Dispose();
				fBase.Show();
			}
			else
			{
				MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtMatKhau.Focus();
				e.SuppressKeyPress = true;
			}
		}

		private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnDangNhap_Click(null, EventArgs.Empty);
				e.SuppressKeyPress = true;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void fLogin_Paint(object sender, PaintEventArgs e)
		{
			int borderWidth = 10;
			Color borderColor = Color.Gray;
			int borderRadius = 20;

			using (GraphicsPath path = new GraphicsPath())
			using (Pen pen = new Pen(borderColor, borderWidth))
			{
				path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
				path.AddArc(this.ClientSize.Width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 90);
				path.AddArc(this.ClientSize.Width - borderRadius - 1, this.ClientSize.Height - borderRadius - 1, borderRadius, borderRadius, 0, 90);
				path.AddArc(0, this.ClientSize.Height - borderRadius - 1, borderRadius, borderRadius, 90, 90);
				path.CloseFigure();

				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				e.Graphics.DrawPath(pen, path);
			}
		}
	}
}
