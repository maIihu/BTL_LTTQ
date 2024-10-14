using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChiTietHoaDonNhapBLL
    {
        private ChiTietHDNDAL _chiTietHDNDAL;
        public ChiTietHoaDonNhapBLL() { 
            _chiTietHDNDAL = new ChiTietHDNDAL();   
        }
        public bool ThemHDN(ChiTietHDNDTO chiTietHDN) { 
            return _chiTietHDNDAL.ThemChiTietHDN(chiTietHDN);
        }
    }
}
