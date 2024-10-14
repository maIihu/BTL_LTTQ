using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO
{
    public class HoaDonDTO
    {
        public string MaHoaDon {  get; set; }
        public string MaNhanVien {  get; set; }
        public string MaKhachHang { get; set; }
        public string MaGiaiPhap {  get; set; }
        public string MaPhuTung {  get; set; }
        public DateTime NgayIn {  get; set; }
        public long ThanhTien {  get; set; }
    }
}
