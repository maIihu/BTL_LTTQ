using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class YeuCauBLL
    {
        private YeuCauDAL _yeuCauDAL;
        public YeuCauBLL()
        {
            _yeuCauDAL = new YeuCauDAL();
        }
        public string LayMaKhachLonNhat()
        {
            return _yeuCauDAL.LayMaKhachLonNhat();
        }
        public string LayNguyenNhanTheoMa(string ma)
        {
            return _yeuCauDAL.LayNguyenNhanTheoMa(ma);
        }

		public List<YeuCauDTO> GetListYeuCau()
        {
            return _yeuCauDAL.GetListYeuCau();
        }
        public List<YeuCauDTO> GetListTop10()
        {
            return _yeuCauDAL.GetTop10YeuCau();
        }
        public bool AddYeuCau(string TenKhachHang, string BienSo, string TenNguyenNhan, DateTime NgaySua, string DiaChi, string SoDienThoai)
        {
            return _yeuCauDAL.AddYeuCau(TenKhachHang, BienSo, TenNguyenNhan, NgaySua, DiaChi, SoDienThoai);
        }
        public bool DeleteYeuCau(string MaSuaChua,string MaXe)
        {
            return _yeuCauDAL.DeleteYeuCau(MaSuaChua,MaXe);
        }
        public string ReturnTenKhachHang(string SoDienThoai)
        {
            return _yeuCauDAL.ReturnTenKH(SoDienThoai);
        }

        public string ReturnDiaChi(string SoDienThoai)
        {
            return _yeuCauDAL.ReturnDiaChi(SoDienThoai);
        }

        public bool UpdateYeuCau(string TenKhachHang, string NguyenNhan, string DiaChi, string SoDienThoai,string MaKhachHang,string MaSuaChua) {
            return _yeuCauDAL.UpdateYeuCau(TenKhachHang, NguyenNhan, DiaChi, SoDienThoai, MaKhachHang,MaSuaChua);
        }
    }
}
