using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HoaDonNhapDAL
    {
        public bool ThemHoaDonNhap(HoaDonNhapDTO hoaDonNhap)
        {

            string query = "SELECT COUNT(*) FROM HOADONNHAPPHUTUNG WHERE MaHDN = @mahdn ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { hoaDonNhap.MaHDN });
            if(Convert.ToInt32(result) <= 0)
            {
                string query1 = "INSERT INTO HOADONNHAPPHUTUNG (MaHDN, NgayNhap, MaNhanVien, TongTien) VALUES ( @maHDN , @ngayNhap , @maNV , @thanhTien )";
                int result1 = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { hoaDonNhap.MaHDN, hoaDonNhap.NgayNhap, hoaDonNhap.MaNV, hoaDonNhap.TongTien });
                return result1 > 0;

            }
            else
            {
                string query2 = "UPDATE HOADONNHAPPHUTUNG SET TongTien = @thanhTien WHERE MaHDN = @mahdn ";
                int result2 = DataProvider.Instance.ExecuteNonQuery(query2, new object[] { hoaDonNhap.TongTien, hoaDonNhap.MaHDN });
                return result2 > 0;
            }
        }
        public List<HoaDonNhapDTO> LayHoaDonNhap()
        {           
            string query = "SELECT * FROM HOADONNHAPPHUTUNG";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            List<HoaDonNhapDTO> listHoaDon = new List<HoaDonNhapDTO>();
            foreach (DataRow row in dataTable.Rows) {
                HoaDonNhapDTO dto = new HoaDonNhapDTO()
                {
                    MaHDN = row["MaHDN"].ToString(),
                    MaNV = row["MaNhanVien"].ToString(),
                    NgayNhap = DateTime.Parse(row["NgayNhap"].ToString()),
                    TongTien = decimal.TryParse(row["TongTien"].ToString(), out decimal donGiaNhapValue) ? donGiaNhapValue : 0
                };
                listHoaDon.Add(dto);
            }  
            return listHoaDon;
        }
    }
}
