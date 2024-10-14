using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietHDNDAL
    {
        public bool ThemChiTietHDN(ChiTietHDNDTO chiTietHDN) {

            string query = "SELECT COUNT(*) FROM CHITIETHDN WHERE MaPhuTung = @maPhuTung ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] {chiTietHDN.MaPhuTung} );

            if(Convert.ToInt32(result) < 0)
            {
                string query1 = "INSERT INTO CHITIETHDN (MaHDN, MaPhuTung, SoLuongNhap) VALUES ( @maHDN , @maPhuTung , @soLuongNhap )";
                int result1 = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { chiTietHDN.MaHDN, chiTietHDN.MaPhuTung, chiTietHDN.SoLuongNhap });
                return result1 > 0;
            }
            else
            {
                string query2 = "UPDATE CHITIETHDN SET SoLuongNhap = @soLuongNhap WHERE MaPhuTung = @maPhuTung ";
                int result2 = DataProvider.Instance.ExecuteNonQuery(query2, new object[] { chiTietHDN.SoLuongNhap, chiTietHDN.MaPhuTung });
                return result2 > 0;
            }

        }
    }
}
