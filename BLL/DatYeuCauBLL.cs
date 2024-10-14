using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DatYeuCauBLL
    {
        private DatYeuCauDAL datYeuCauDAL;
        public DatYeuCauBLL()
        {
            datYeuCauDAL = new DatYeuCauDAL();
        }
        public List<DatYeuCauDTO> GetListYeuCau()
        {
            return datYeuCauDAL.GetListYeuCau();
        }
        public List<DatYeuCauDTO> GetListTop10()
        {
            return datYeuCauDAL.GetTop10YeuCau();
        }
        public bool AddYeuCau(string TenKhachHang, string BienSo, string TenNguyenNhan, DateTime NgaySua, string DiaChi, string SoDienThoai)
        {
            return datYeuCauDAL.AddYeuCau(TenKhachHang, BienSo, TenNguyenNhan, NgaySua, DiaChi, SoDienThoai);
        }
        public bool DeleteYeuCau(string MaSuaChua,string MaXe)
        {
            return datYeuCauDAL.DeleteYeuCau(MaSuaChua,MaXe);
        }
        public string ReturnTenKhachHang(string SoDienThoai)
        {
            return datYeuCauDAL.ReturnTenKH(SoDienThoai);
        }

        public string ReturnDiaChi(string SoDienThoai)
        {
            return datYeuCauDAL.ReturnDiaChi(SoDienThoai);
        }

        public bool UpdateYeuCau(string TenKhachHang, string NguyenNhan, string DiaChi, string SoDienThoai,string MaKhachHang,string MaSuaChua) {
            return datYeuCauDAL.UpdateYeuCau(TenKhachHang, NguyenNhan, DiaChi, SoDienThoai, MaKhachHang,MaSuaChua);
        }
    }
}
