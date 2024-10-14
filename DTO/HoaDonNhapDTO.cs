using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonNhapDTO
    {
        public HoaDonNhapDTO() { }  
        public HoaDonNhapDTO(string maHDN, string maNV, DateTime ngayNhap, decimal tongTien)
        {
            MaHDN = maHDN;
            MaNV = maNV;
            NgayNhap = ngayNhap;
            TongTien = tongTien;
        }

        public string MaHDN {  get; set; }
        public string MaNV { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal TongTien { get; set; }
       
    }
}
