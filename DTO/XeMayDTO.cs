using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class XeMayDTO
    {
        public XeMayDTO() { }
        public XeMayDTO(string maXe, string tenXe, string loaiXe, string soKhung, string soMay, string bienSo)
        {
            MaXe = maXe;
            TenXe = tenXe;
            LoaiXe = loaiXe;
            SoKhung = soKhung;
            SoMay = soMay;
            BienSo = bienSo;
        }

        public XeMayDTO(string maXe, string tenXe, string loaiXe, string soKhung, string soMay, string bienSo, string maMau)
        {
            MaXe = maXe;
            TenXe = tenXe;
            LoaiXe = loaiXe;
            SoKhung = soKhung;
            SoMay = soMay;
            BienSo = bienSo;
            MaMau = maMau;
        }

        public string MaXe { get; set; }
        public string TenXe { get; set; }
        public string LoaiXe { get; set; }
        //public string LoaiXe { get; set; }
        public string SoKhung { get; set; }
        public string SoMay { get; set; }
        public string BienSo { get; set; }
        public string MaMau { get; set; }
    }
}