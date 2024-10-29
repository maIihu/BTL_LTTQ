using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietNhapDAL
    {
        public string TimTenNhanVien(string mahd)
        {
            string query = "select TenNhanVien " +
                " from HOADONNHAPPHUTUNG join NHANVIEN on HOADONNHAPPHUTUNG.MaNhanVien = NHANVIEN.MaNhanVien " +
                " where MaHDN = @mahd ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { mahd });
            return result != null ? result.ToString() : null;
        }

        public string TimNgayNhap(string mahd)
        {
            string query = "select NgayNhap from HOADONNHAPPHUTUNG where MaHDN = @mahd";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { mahd });
            if (result != null && DateTime.TryParse(result.ToString(), out DateTime ngayNhap))
            {
                return ngayNhap.ToString("dd/MM/yyyy"); 
            }
            return null;
        }


        public string TimTongTien(string mahd)
        {
            string query = "select TongTien from HOADONNHAPPHUTUNG where MaHDN = @mahd";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { mahd });
            if (result != null)
            {
                decimal tongTien = Convert.ToDecimal(result);
                return tongTien.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")); 
            }
            return null;
        }

        public List<ChiTietNhapDTO> LayDsChiTiet(string ma)
        {
            string query = "select PHUTUNG.MaPhuTung, TenPhuTung, SoLuongNhap, DonGiaNhap " +
                "from CHITIETHDN join HOADONNHAPPHUTUNG on CHITIETHDN.MaHDN = HOADONNHAPPHUTUNG.MaHDN " +
                "join NHANVIEN on HOADONNHAPPHUTUNG.MaNhanVien = NHANVIEN.MaNhanVien " +
                "join PHUTUNG on PHUTUNG.MaPhuTung = CHITIETHDN.MaPhuTung " +
                "where HOADONNHAPPHUTUNG.MaHDN = @ma ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {ma});

            List<ChiTietNhapDTO> dsChiTiet = new List<ChiTietNhapDTO>();

            foreach (DataRow row in data.Rows)
            {
                ChiTietNhapDTO chiTietDTO = new ChiTietNhapDTO(
                    row["MaPhuTung"].ToString(),
                    row["TenPhuTung"].ToString(),
                    int.Parse(row["SoLuongNhap"].ToString()),
                    decimal.Parse(row["DonGiaNhap"].ToString())
                );

                dsChiTiet.Add(chiTietDTO);
            }

            return dsChiTiet;
        }
    }
}
