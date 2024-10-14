using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HoaDonNhapBLL
    {
        private HoaDonNhapDAL _hoaDonNhapDAL;
        public HoaDonNhapBLL() { 
            _hoaDonNhapDAL = new HoaDonNhapDAL();   
        }
        public bool ThemHoaDonNhap(HoaDonNhapDTO hoaDonNhap) {
            return _hoaDonNhapDAL.ThemHoaDonNhap(hoaDonNhap);
        }
        public List<HoaDonNhapDTO> LayHoaDonNhap()
        {
            return _hoaDonNhapDAL.LayHoaDonNhap();
        }
    }
}
