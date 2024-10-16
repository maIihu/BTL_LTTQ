using System;
using System.Collections.Generic;
using System.Data;
using DTO;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DAL
{
    public class KhachHangDAL
    {
        public bool AddCustomer(KhachHangDTO khachHang)
        {
            string query = "SELECT COUNT(*) FROM KHACHHANG WHERE MaKhachHang = @maKhachHang";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { khachHang.MaKhachHang });
            if (Convert.ToInt32(result) <= 0)
            {
                string query1 = "INSERT INTO KHACHHANG (MaKhachHang, TenKhachHang, DiaChi, SoDienThoai) VALUES ( @maKhachHang , @tenKhachHang , @diaChi , @sdt )";

                int result1 = DataProvider.Instance.ExecuteNonQuery
                    (query1, new object[] { khachHang.MaKhachHang, khachHang.TenKhachHang, khachHang.DiaChi, khachHang.SoDienThoai });
                return result1 > 0;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateCustomer(KhachHangDTO khachHang)
        {
            string query = "UPDATE KHACHHANG SET TenKhachHang = @ten , DiaChi = @diaChi , SoDienThoai = @SoDienThoai WHERE MaKhachHang = @maKhach ";
            int result = DataProvider.Instance.ExecuteNonQuery
                (query, new object[] { khachHang.TenKhachHang, khachHang.DiaChi, khachHang.SoDienThoai, khachHang.MaKhachHang });
            return result > 0;
        }
        public bool DeleteCustomer(string maNhanVien)
        {
            string query = "DELETE FROM KHACHHANG WHERE MaKhachHang = @maKhachHang";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNhanVien });
            return result > 0;
        }
        public List<KhachHangDTO> SearchCustomerByName(string tenKhachHang, string soDienThoai)
        {
            string query = "SELECT * FROM KHACHHANG WHERE TenKhachHang COLLATE SQL_Latin1_General_Cp1_CI_AI LIKE '%' + @tenKhachHang + '%'" +
                " OR SoDienThoai LIKE '%' + @soDienThoai + '%' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenKhachHang, soDienThoai });
            List<KhachHangDTO> dsKhachHang = new List<KhachHangDTO>();
            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    MaKhachHang = row["MaKhachHang"].ToString(),
                    TenKhachHang = row["TenKhachHang"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString()
                };
                dsKhachHang.Add(khachHang);
            }
            return dsKhachHang;
        }
        public List<KhachHangDTO> GetCustomerList()
        {
            string query = "SELECT * FROM KHACHHANG ORDER BY MaKhachHang DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<KhachHangDTO> dsKhachHang = new List<KhachHangDTO>();
            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    MaKhachHang = row["MaKhachHang"].ToString(),
                    TenKhachHang = row["TenKhachHang"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString()
                };
                dsKhachHang.Add(khachHang);
            }
            return dsKhachHang;
        }


    }
}
