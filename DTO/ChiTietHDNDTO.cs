using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHDNDTO
    {
        public ChiTietHDNDTO() { }

        public ChiTietHDNDTO(string maHDN, string maPhuTung, int soLuongNhap)
        {
            MaHDN = maHDN;
            MaPhuTung = maPhuTung;
            SoLuongNhap = soLuongNhap;
        }

        public string MaHDN {  get; set; }
        public string MaPhuTung { get; set; }
        public int SoLuongNhap { get; set; }
    }
}
