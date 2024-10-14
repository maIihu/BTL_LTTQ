using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class YeuCauSuaChuaBLL
    {
        private YeuCauSuaChuaDAL yeuCauDAL;
        public YeuCauSuaChuaBLL() 
        {
            yeuCauDAL = new YeuCauSuaChuaDAL();
        }

        public bool ThemYeuCau(YeuCauSuaChuaDTO yeuCau)
        {
            if(yeuCau == null || string.IsNullOrEmpty(yeuCau.MaSuaChua) || string.IsNullOrEmpty(yeuCau.MaXe) || string.IsNullOrEmpty(yeuCau.MaKhachHang)){
                throw new ArgumentException("Vui long nhap day du thong tin");
            }
            return yeuCauDAL.ThemYeuCau(yeuCau);
        }
        public bool XoaYeuCau(string maSuaChua)
        {
            return yeuCauDAL.XoaYeuCau(maSuaChua);
        }
        public bool SuaYeuCau(YeuCauSuaChuaDTO yeuCau)
        {
            if(yeuCau == null || string.IsNullOrEmpty(yeuCau.MaSuaChua) || string.IsNullOrEmpty(yeuCau.MaXe) || string.IsNullOrEmpty(yeuCau.MaKhachHang))
            {
                throw new ArgumentException("Vui Long nhap day du thong tin");
            }
            return yeuCauDAL.SuaYeuCau(yeuCau);
        }
        public List<YeuCauSuaChuaDTO> LayDanhSachYeuCau()
        {
            return yeuCauDAL.LayDanhSachYeuCau();
        }
        public List<YeuCauSuaChuaDTO> TimKiemTheoNguyenNhan(string maNguyenNhan)
        {
            if (string.IsNullOrEmpty(maNguyenNhan))
            {
                throw new ArgumentException("Mã nguyên nhân không hợp lệ.");
            }

            return yeuCauDAL.SearchByProblem(maNguyenNhan);
        }
    }
}
