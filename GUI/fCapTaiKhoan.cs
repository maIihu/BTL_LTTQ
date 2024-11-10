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
using DAL;

namespace GUI
{
	public partial class fCapTaiKhoan : Form
	{
		private AccountBLL _accountBLL;
		public fCapTaiKhoan()
		{
			InitializeComponent();
		}
		private void fCapTaiKhoan_Load(object sender, EventArgs e)
		{
			_accountBLL = new AccountBLL();	
		}
		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			string tk = txtTaiKhoan.Text;
			string mk = txtMatKhau.Text;
			string nhapLaiMk = txtNhapLaiMK.Text;

			if (string.IsNullOrWhiteSpace(tk))
			{
				MessageBox.Show("Vui lòng nhập tài khoản.");
				return;
			}
			if (string.IsNullOrWhiteSpace(mk))
			{
				MessageBox.Show("Vui lòng nhập mật khẩu.");
				return;
			}
			if (string.IsNullOrWhiteSpace(nhapLaiMk))
			{
				MessageBox.Show("Vui lòng nhập lại mật khẩu.");
				return;
			}

			if (mk != nhapLaiMk)
			{
				MessageBox.Show("Mật khẩu không khớp.");
				return;
			}

			bool createAccount = _accountBLL.CreateAccount(tk, mk);
			if (createAccount)
			{
				MessageBox.Show("Tạo tài khoản thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("Tạo tài khoản thất bại.");
			}
		}


		private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
