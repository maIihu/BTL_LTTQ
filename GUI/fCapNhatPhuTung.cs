using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
	public partial class fCapNhatPhuTung : Form
	{
		string _id;
		private PhuTungBLL _phuTungBLL;
		public fCapNhatPhuTung(string id)
		{
			InitializeComponent();
			_id = id;
			_phuTungBLL = new PhuTungBLL();	
		}
		private void fCapNhatPhuTung_Load(object sender, EventArgs e)
		{
			PhuTungDTO phuTungDTO = _phuTungBLL.LayPhuTung(_id);
			txtMaPT.Text = _id;
			txtTenPT.Text = phuTungDTO.TenPhuTung;
			txtSoLuong.Text = phuTungDTO.SoLuong.ToString();
			txtDGN.Text = phuTungDTO.DonGiaNhap.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
			txtDGB.Text = phuTungDTO.DonGiaBan.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
		}
		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			string ten = txtTenPT.Text;

			int soLuong;
			if (!int.TryParse(txtSoLuong.Text, out soLuong))
			{
				MessageBox.Show("Số lượng không đúng định dạng!");
				return;
			}

			decimal dgn;
			if (!decimal.TryParse(txtDGN.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out dgn))
			{
				MessageBox.Show("Đơn giá nhập không đúng định dạng!");
				return;
			}

			decimal dgb;
			if (!decimal.TryParse(txtDGB.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out dgb))
			{
				MessageBox.Show("Đơn giá bán không đúng định dạng!");
				return;
			}

			bool updatePhuTung = _phuTungBLL.SuaPhuTung(_id, ten, soLuong, dgn, dgb);
			if (updatePhuTung)
			{
				MessageBox.Show("Sửa thông tin phụ tùng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}


		private void fCapNhatPhuTung_Paint(object sender, PaintEventArgs e)
		{
			int borderWidth = 10; 
			Color borderColor = Color.Gray;
			int borderRadius = 30;

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
