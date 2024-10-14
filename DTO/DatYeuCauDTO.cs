using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatYeuCauDTO
    {
        public DatYeuCauDTO(string tenKhachHang, string nguyenNhan, DateTime ngaySua)
        {
            TenKhachHang = tenKhachHang;
            NguyenNhan = nguyenNhan;
            NgaySua = ngaySua;
        }

        public DatYeuCauDTO(string MaSuaChua,string TenKhachHang,string MaXe,string NguyenNhan,DateTime NgaySua,string MaKhachHang,string DiaChi,string SoDienThoai) {
            this.MaSuaChua = MaSuaChua;
            this.TenKhachHang = TenKhachHang;
            this.MaXe = MaXe;
            this.NguyenNhan = NguyenNhan;
            this.NgaySua = NgaySua;
            this.MaKhachHang = MaKhachHang;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
        }
        public string MaSuaChua {  get; set; }
        public string TenKhachHang {  get; set; }
        public string MaXe {  get; set; }

        public string NguyenNhan {  get; set; }

        public DateTime NgaySua { get; set; }

        public string MaKhachHang { get; set;}

        public string DiaChi {  get; set; }
        public string SoDienThoai { get; set; }

    }
}
