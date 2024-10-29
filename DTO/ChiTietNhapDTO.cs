using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietNhapDTO
    {
        public ChiTietNhapDTO() { }
        public ChiTietNhapDTO(string maPT, string tenPT, int sLNhap, decimal donGiaNhap)
        {
            MaPT = maPT;
            TenPT = tenPT;
            SLNhap = sLNhap;
            DonGiaNhap = donGiaNhap;
        }

        public ChiTietNhapDTO(string maHDN, string tenNV, string maPT, string tenPT, 
            int sLNhap, DateTime ngayNhap, decimal donGiaNhap, decimal tongTien)
        {
            MaHDN = maHDN;
            TenNV = tenNV;
            MaPT = maPT;
            TenPT = tenPT;
            SLNhap = sLNhap;
            NgayNhap = ngayNhap;
            DonGiaNhap = donGiaNhap;
            TongTien = tongTien;
        }

        public string MaHDN {  get; set; }
        public string TenNV { get; set; }  
        public string MaPT { get; set; }   
        public string TenPT { get; set; }  
        public int SLNhap { get; set; }    
        public DateTime NgayNhap { get; set; } 
        public decimal DonGiaNhap { get; set; }    
        public decimal TongTien {  get; set; } 
    }
}
