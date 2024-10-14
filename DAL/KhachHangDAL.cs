using System;
using System.Collections.Generic;
using System.Data;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DAL
{
    public class KhachHangDAL
    {
        private static string stringConection = @"Data Source=MHung\SQLEXPRESS;Initial Catalog=QLSuaXe;Integrated Security=True;Encrypt=False";
        SqlDataAdapter _adapter;

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
        public DataTable SearchCustomerByName(string tenKhachHang)
        {
            string query = "SELECT * FROM KHACHHANG WHERE TenKhachHang COLLATE SQL_Latin1_General_Cp1_CI_AI LIKE '%' + @tenKhachHang + '%'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tenKhachHang });
            return result;
        }
        public List<KhachHangDTO> GetCustomerList()
        {
            string query = "SELECT * FROM KHACHHANG";
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
        // đổ dữ liệu ra bảng
        public DataTable getAllKhachHang()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from KHACHHANG";
            using (SqlConnection sqlConnection = new SqlConnection(stringConection))
            {
                sqlConnection.Open();
                _adapter = new SqlDataAdapter(query, sqlConnection);
                _adapter.Fill(dataTable);
                sqlConnection.Close();

            }

            return dataTable;
        }
        //tạo mã khách hàng mới
        public string GetNewMaKH()
        {
            string mkmoi = "";
            using (SqlConnection sqlConnection = new SqlConnection(stringConection))
            {
                sqlConnection.Open();
                string query = "select max(cast(substring(MaKhachHang,3,len(MaKhachHang)-2)as int)) from KHACHHANG";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    int nextId = Convert.ToInt32(result) + 1;
                    mkmoi = "MK" + nextId.ToString("D3");
                }
                sqlConnection.Close();
            }
            return mkmoi;
        }
        public void ThemKhachHang(string MaKhachHang, string Tenkhach, string Diachi, string sdt)
        {
            using (SqlConnection sqlConnection = new SqlConnection(stringConection))
            {
                sqlConnection.Open();
                string query = "insert into KHACHHANG values (@MaKhachHang,@TenkhachHang,@DiaChi,@SoDienThoai)";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@MaKhachHang ", MaKhachHang);
                command.Parameters.AddWithValue("@TenKhachHang ", Tenkhach);
                command.Parameters.AddWithValue("@DiaChi ", Diachi);
                command.Parameters.AddWithValue("@SoDienThoai ", sdt);
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public void UpdateKhachHang(string makh, string Tenkhach, string Diachi, string sdt)
        {
            using (SqlConnection sqlConnection = new SqlConnection(stringConection))
            {
                sqlConnection.Open();
                string query = "update KHACHHANG set TenKhachHang = @TenKhachHang,DiaChi = @Diachi,SoDienThoai=@SoDienThoai where MaKhachHang=@MaKhachHang";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@MaKhachHang ", makh);
                command.Parameters.AddWithValue("@TenKhachHang ", Tenkhach);
                command.Parameters.AddWithValue("@DiaChi ", Diachi);
                command.Parameters.AddWithValue("@SoDienThoai ", sdt);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sqlConnection.Close();
            }
        }
        public void XoaKhachHang(string makh)
        {
            using (SqlConnection sqlConnection = new SqlConnection(stringConection))
            {
                sqlConnection.Open();
                string query = "delete from KHACHHANG where MaKhachhang = @MaKhachHang and MaKhachHang not in(select MaKhachHang from HOADON)";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@MaKhachHang ", makh);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sqlConnection.Close();
            }
        }
        public DataTable TimKiem(string ten)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(stringConection))
            {
                sqlConnection.Open();
                string query = "select * from KHACHHANG where TenKhachHang like @TenKhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.SelectCommand.Parameters.AddWithValue("@TenKhachHang ", "% " + ten);
                adapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
    }
}
