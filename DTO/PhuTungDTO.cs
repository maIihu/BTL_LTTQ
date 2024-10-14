using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhuTungDTO
    {
        public PhuTungDTO() { }

        public PhuTungDTO(string maPhuTung, string tenPhuTung, int soLuong, decimal donGiaNhap, decimal donGiaBan)
        {
            MaPhuTung = maPhuTung;
            TenPhuTung = tenPhuTung;
            SoLuong = soLuong;
            DonGiaNhap = donGiaNhap;
            DonGiaBan = donGiaBan;
        }

        public string MaPhuTung { get; set; }
        public string TenPhuTung { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
    }
}
