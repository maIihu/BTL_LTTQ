using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
				//MessageBox.Show("Enter a Username.", "Notification",  MessageBoxButtons.OK, MessageBoxIcon.Information);
				//txtUsername.Focus();              
				return;
			}

			if (thongTinMk == "" || thongTinMk == "Nhập mật khẩu")
			{
				//MessageBox.Show("Enter a Password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//txtPassword.Focus();
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
	}
}
