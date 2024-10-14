using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        public string TimNhanVienTheoMa(string maNV)
        {
            string query = "SELECT TenNhanVien FROM NHANVIEN WHERE MaNhanVien = @maNV";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maNV });

            return result != null ? result.ToString() : null;
        }

    }
}
