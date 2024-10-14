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

        public int LaySLHoaDon()
        {
            return hoaDonYeuCauDAL.LaySLHoaDon();
        }
        public int LaySLYeuCau()
        {
            return hoaDonYeuCauDAL.LaySLYeuCau();
        }
        public HoaDonYeuCauBLL()
        {
            hoaDonYeuCauDAL = new HoaDonYeuCauDAL();
        }
        public bool ThemHoaDon(string MaHoaDon, string MaNhanVien, string MaPhuTung, string MaSuaChua
            , DateTime NgayIn, string GiaiPhap, int SoLuong, decimal TongTien)
        {
            return hoaDonYeuCauDAL.ThemHoaDon(MaHoaDon, MaNhanVien, MaPhuTung, MaSuaChua, NgayIn, GiaiPhap, SoLuong, TongTien);
        }
        public List<Tuple<int, decimal>> LayDoanhThuThang()
        {
            return hoaDonYeuCauDAL.LayDoanhThuTheoThang();  
        }
        public List<Tuple<int, decimal>> LayDoanhThuTuan()
        {
            return hoaDonYeuCauDAL.LayDoanhThuTheoTuan();
        }
        public List<HoaDonYeuCauDTO> GetListHoaDon()
        {
            return hoaDonYeuCauDAL.GetListHoaDon();
        }
        public string GetMaHoaDon(string MaSuaChua)
        {
            return hoaDonYeuCauDAL.GetMaHoaDon(MaSuaChua);
        }
    }
}
