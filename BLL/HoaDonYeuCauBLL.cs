using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonYeuCauBLL
    {
        private HoaDonYeuCauDAL hoaDonYeuCauDAL;
        public HoaDonYeuCauBLL()
        {
            hoaDonYeuCauDAL = new HoaDonYeuCauDAL();
        }
        public int LaySLHoaDon()
        {
            return hoaDonYeuCauDAL.LaySLHoaDon();
        }
        public int LaySLYeuCau()
        {
            return hoaDonYeuCauDAL.LaySLYeuCau();
        }
        public bool XoaYeuCauTheoMa(string ma1, string ma2)
        {
            return hoaDonYeuCauDAL.XoaYeuCauTheoMa(ma1, ma2); 
        }
        public bool XoaNhanVienTheoMa(string ma)
        {
            return hoaDonYeuCauDAL.XoaHoaDonTheoMa(ma); 
        }
        public bool ThemHoaDon(string MaHoaDon, string MaNhanVien, string MaPhuTung, string MaSuaChua
            , DateTime NgayIn, string GiaiPhap, int SoLuong, decimal TongTien, string MaKhachHang)
        {
            return hoaDonYeuCauDAL.ThemHoaDon(MaHoaDon, MaNhanVien, MaPhuTung, MaSuaChua, NgayIn, GiaiPhap, SoLuong, TongTien, MaKhachHang);
        }
        public List<Tuple<int, decimal>> LayDoanhThuThang()
        {
            return hoaDonYeuCauDAL.LayDoanhThuTheoThang();  
        }
        public List<Tuple<int, decimal>> LayDoanhThuTuan()
        {
            return hoaDonYeuCauDAL.LayDoanhThuTheoTuan();
        }
        public List<HoaDonYeuCauDTO> LayDSHoaDon()
        {
            return hoaDonYeuCauDAL.LayDSHoaDon();
        }
        public List<HoaDonYeuCauDTO> LayDSHoaDonYeuCau()
        {
            return hoaDonYeuCauDAL.LayDSHoaDonYeuCau();
        }
        public string GetMaHoaDon()
        {
            return hoaDonYeuCauDAL.GetMaHoaDon();
        }
        public string LayTongDoanhThu()
        {
            return hoaDonYeuCauDAL.LayTongDoanhThu();

		}
    }
}
