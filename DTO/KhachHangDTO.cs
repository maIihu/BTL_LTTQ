using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO() { }
        public KhachHangDTO(string tenKhachHang, string diaChi, string soDienThoai)
        {
            TenKhachHang = tenKhachHang;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }

        public KhachHangDTO(string maKhachHang, string tenKhachHang, string diaChi, string soDienThoai) 
        {
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }

        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai {  get; set; }
    }
}
