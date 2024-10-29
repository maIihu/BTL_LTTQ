using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChiTietNhapBLL
    {
        private ChiTietNhapDAL _chiTietNhapDAL;
        public ChiTietNhapBLL() { 
            _chiTietNhapDAL = new ChiTietNhapDAL();
        }

        public string TimTenNhanVien(string mahd)
        {
            return _chiTietNhapDAL.TimTenNhanVien(mahd);
        }

        public string TimNgayNhap(string mahd)
        {
            return _chiTietNhapDAL.TimNgayNhap(mahd);
        }

        public string TimTongTien(string mahd)
        {
            return _chiTietNhapDAL.TimTongTien(mahd);
        }

        public List<ChiTietNhapDTO> LayDsChiTiet(string ma)
        {
            return _chiTietNhapDAL.LayDsChiTiet(ma);
        }
    }
}
