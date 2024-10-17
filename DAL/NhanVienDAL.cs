using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        public string TimTenNhanVienTheoMa(string maNV)
        {
            string query = "SELECT TenNhanVien FROM NHANVIEN WHERE MaNhanVien = @maNV";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maNV });

            return result != null ? result.ToString() : null;
        }
        public string TimTrinhDoNhanVien(string maNV) {
            string query = "SELECT MaTrinhDo FROM NHANVIEN WHERE MaNhanVien = @maNV";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maNV });

            return result != null ? result.ToString() : null;
        }
        public string TimNgaySinhNhanVien(string maNV)
        {
            string query = "SELECT NgaySinh FROM NHANVIEN WHERE MaNhanVien = @maNV";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maNV });


            if (result != null && result is DateTime)
            {
                return ((DateTime)result).ToString("dd/MM/yyyy");
            }

            return null;
        }
        public string TimGioiTinh(string maNV)
        {
            string query = "SELECT GioiTinh FROM NHANVIEN WHERE MaNhanVien = @maNV";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maNV });

            return result != null ? result.ToString() : null;
        }
        public string TimSoDienThoai(string maNV)
        {
            string query = "SELECT SoDienThoai FROM NHANVIEN WHERE MaNhanVien = @maNV";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maNV });

            return result != null ? result.ToString() : null;
        }
        public string TimNgayBatDau(string maNV)
        {
            string query = "SELECT NgayBatDau FROM NHANVIEN WHERE MaNhanVien = @maNV";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maNV });

            if (result != null && result is DateTime)
            {
                return ((DateTime)result).ToString("dd/MM/yyyy");
            }

            return null;
        }

        public string TimDiaChi(string maNV)
        {
            string query = "SELECT DiaChi FROM NHANVIEN WHERE MaNhanVien = @maNV";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maNV });

            return result != null ? result.ToString() : null;
        }
    }
}
