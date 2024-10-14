using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonYeuCauDTO
    {
        public HoaDonYeuCauDTO() { }

        public HoaDonYeuCauDTO(string maSuaChua, string maXe,  string maKhachHang, string tenKhachHang)
        {
            MaSuaChua = maSuaChua;
            MaXe = maXe;
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
        }

        public HoaDonYeuCauDTO(string MaHoaDon,string MaNhanVien,string MaPhuTung,string MaSuaChua,string TenKhachHang,string MaXe,DateTime NgayIn,
            string GiaiPhap,int SoLuong,decimal? TongTien,string MaKhachHang)
        {
            this.MaHoaDon = MaHoaDon;
            this.MaNhanVien = MaNhanVien;
            this.MaPhuTung = MaPhuTung;
            this.MaSuaChua = MaSuaChua;
            this.TenKhachHang = TenKhachHang;
            this.MaXe = MaXe;
            this.GiaiPhap = GiaiPhap;   
            this.NgayIn = NgayIn;
            this.SoLuong = SoLuong;
            this.TongTien = TongTien ?? 0;
            this.MaKhachHang = MaKhachHang;
        }

        public string MaHoaDon {  get; set; }
        public string MaNhanVien {  get; set; }

        public string MaPhuTung {  get; set; }
        public string MaSuaChua {  get; set; }
        public string TenKhachHang {  get; set; }
        public string MaXe {  get; set; }
        public DateTime NgayIn {  get; set; }
        public string GiaiPhap { get; set; }
        public int SoLuong {  get; set; }
        public decimal? TongTien {  get; set; }
        public string MaKhachHang { get;set; }
    }
}
