using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL
{
    public class HoaDonYeuCauDAL
    {
        public int LaySLHoaDon()
        {
            string query = "SELECT COUNT(DISTINCT(MaHoaDon)) FROM HOADON";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }

        public int LaySLYeuCau()
        {
            string query = "SELECT COUNT(*) FROM YEUCAUSUACHUA";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }

        

        public bool ThemHoaDon(string MaHoaDon, string MaNhanVien, string MaPhuTung, string MaSuaChua,
            DateTime NgayIn, string GiaiPhap, int SoLuong, decimal TongTien)
        {
            string query = "exec addHoaDon @mahoadon , @manhanvien , @maphutung , @masuachua , @ngayin , @giaiphap , @soluong , @tongtien ";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { (object)MaHoaDon ?? DBNull.Value,MaNhanVien,MaPhuTung
                ,MaSuaChua,NgayIn,GiaiPhap,SoLuong,TongTien});
            return result > 0;

        }
        public string GetMaHoaDon(string MaSuaChua)
        {
            string query = "SELECT MaHoaDon FROM HoaDon WHERE MaSuaChua = @masuachua ";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { MaSuaChua });

            if (dataTable.Rows.Count > 0) 
            {
                DataRow row = dataTable.Rows[0]; 
                return row["MaHoaDon"].ToString(); 
            }

            return null; 
        }

        public List<Tuple<int, decimal>> LayDoanhThuTheoThang()
        {
            string query = "WITH ThangCTE AS ( " +
                           "SELECT 1 AS Thang " +
                           "UNION ALL " +
                           "SELECT Thang + 1 FROM ThangCTE WHERE Thang < 12), " +
                           "DoanhThuThang AS ( " +
                           "SELECT MONTH(NgayIn) AS Thang, SUM(TongTien) AS DoanhThu " +
                           "FROM HOADON " +
                           "WHERE MONTH(NgayIn) IN (SELECT Thang FROM ThangCTE) " +
                           "GROUP BY MONTH(NgayIn) " +
                           ") " +  
                           "SELECT ThangCTE.Thang, ISNULL(DoanhThuThang.DoanhThu, 0) AS DoanhThu " +
                           "FROM ThangCTE " +
                           "LEFT JOIN DoanhThuThang ON ThangCTE.Thang = DoanhThuThang.Thang " +
                           "ORDER BY ThangCTE.Thang;";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<Tuple<int, decimal>> doanhThuList = new List<Tuple<int, decimal>>();

            foreach (DataRow row in data.Rows)
            {
                int thang = (int)row["Thang"];
                decimal doanhThu = (decimal)row["DoanhThu"];
                doanhThuList.Add(new Tuple<int, decimal>(thang, doanhThu));
            }

            return doanhThuList;
        }

        public List<Tuple<int, decimal>> LayDoanhThuTheoTuan()
        {
            string query = "WITH NgayCTE AS (    SELECT 1 AS Ngay   UNION ALL   SELECT Ngay + 1 FROM NgayCTE WHERE Ngay < 8 ) SELECT     NgayCTE.Ngay AS Thu," +
                "  ISNULL(count(HOADON.MaHoaDon), 0) AS DoanhThu FROM     NgayCTE LEFT JOIN  " +
                "    HOADON ON DATEPART(WEEKDAY, HOADON.NgayIn) = NgayCTE.Ngay GROUP BY     NgayCTE.Ngay";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            List<Tuple<int, decimal>> doanhThu = new List<Tuple<int, decimal>>();

            foreach (DataRow row in dataTable.Rows)
            {
                int thu = Convert.ToInt32(row["Thu"]);
                decimal doanhthuValue = Convert.ToDecimal(row["DoanhThu"]);
                doanhThu.Add(new Tuple<int, decimal>(thu, doanhthuValue));
            }

            return doanhThu;
        }


        public List<HoaDonYeuCauDTO> GetListHoaDon()
        {
            string query = "select MaSuaChua, MaXe,YEUCAUSUACHUA.MaKhachHang,TenKhachHang from " +
                "YEUCAUSUACHUA join KHACHHANG on YEUCAUSUACHUA.MaKhachHang = KHACHHANG.MaKhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<HoaDonYeuCauDTO> listYeuCau = new List<HoaDonYeuCauDTO>();
            foreach (DataRow row in data.Rows)
            {
                HoaDonYeuCauDTO hoaDonYeuCauDTO = new HoaDonYeuCauDTO(
                   
                    row["MaSuaChua"].ToString(),
                    row["MaXe"].ToString(),                  
                    row["MaKhachHang"].ToString(),
                    row["TenKhachHang"].ToString()
                    
                );
                listYeuCau.Add(hoaDonYeuCauDTO);
            }
            return listYeuCau;
        }

    }
}
