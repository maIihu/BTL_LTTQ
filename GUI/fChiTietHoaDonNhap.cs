using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class fChiTietHoaDonNhap : Form
    {
        private ChiTietNhapBLL _chiTietNhapBLL;
        private string _maHoaDon;
        public fChiTietHoaDonNhap(string maHoaDon)
        {
            InitializeComponent();
            _maHoaDon = maHoaDon;
            _chiTietNhapBLL = new ChiTietNhapBLL();
        }

        private void fChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            lblMaHD.Text = "Mã hóa đơn nhập: " + _maHoaDon;
            lblTen.Text = "Tên người nhập: " + _chiTietNhapBLL.TimTenNhanVien(_maHoaDon);
            lblNgayNhap.Text = "Ngày nhập: " + _chiTietNhapBLL.TimNgayNhap(_maHoaDon);
            lblTien.Text = "Tổng tiền: " + _chiTietNhapBLL.TimTongTien(_maHoaDon);   
            HienThiDsChiTiet();       
        }

        private void HienThiDsChiTiet()
        {
            List<ChiTietNhapDTO> dsChiTiet1 = _chiTietNhapBLL.LayDsChiTiet(_maHoaDon);
            ThemDuLieuDsChiTiet(dsChiTiet1);
        }

        private void ThemDuLieuDsChiTiet(List<ChiTietNhapDTO> dsChiTiet)
        {
            dgvChiTiet.Rows.Clear();
            int stt = 1;
            foreach (var x in dsChiTiet)
            {
                string donGiaNhapVND = x.DonGiaNhap.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));

                dgvChiTiet.Rows.Add(stt++, x.MaPT, x.TenPT, x.SLNhap, donGiaNhapVND);
            }
        }


    }
}
