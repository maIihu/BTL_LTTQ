using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class YeuCauDAL
    {
        public string LayNguyenNhanTheoMa(string ma)
        {
			string query = "SELECT NguyenNhan FROM YEUCAUSUACHUA WHERE MaSuaChua = @ma ";
			object result = DataProvider.Instance.ExecuteScalar(query, new object[] { ma });

			return result != null ? result.ToString() : null;
		}
        public string LayMaKhachLonNhat()
        {
            string query = "SELECT TOP 1 MaKhachHang from KHACHHANG order by MaKhachHang desc";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return row["MaKhachHang"].ToString();
            }

            return null;
        }

        public List<YeuCauDTO> GetListYeuCau()
        {
            string query = "select MaSuaChua, TenKhachHang, MaXe, NguyenNhan, NgaySua,YEUCAUSUACHUA.MaKhachHang,DiaChi,SoDienThoai " +
                "from YEUCAUSUACHUA join KHACHHANG on YEUCAUSUACHUA.MaKhachHang = KHACHHANG.MaKhachHang order by NgaySua desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<YeuCauDTO> listYeuCau = new List<YeuCauDTO>();

            foreach (DataRow row in data.Rows)
            {
                YeuCauDTO yeuCauDTO = new YeuCauDTO(
                    row["MaSuaChua"].ToString(),
                    row["TenKhachHang"].ToString(),
                    row["MaXe"].ToString(),
                    row["NguyenNhan"].ToString(),
                    DateTime.Parse(row["NgaySua"].ToString()),
                    row["MaKhachHang"].ToString(),
                    row["DiaChi"].ToString(),
                    row["SoDienThoai"].ToString()
                );

                listYeuCau.Add(yeuCauDTO);
            }

            return listYeuCau;
        }
        public List<YeuCauDTO> GetTop10YeuCau()
        {
            string query = "select top 10 TenKhachHang, NguyenNhan, NgaySua " +
                            "from YEUCAUSUACHUA join KHACHHANG on YEUCAUSUACHUA.MaKhachHang = KHACHHANG.MaKhachHang " + // thêm khoảng trắng ở đây
                            "order by NgaySua desc";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<YeuCauDTO> listYeuCau = new List<YeuCauDTO>();

            foreach (DataRow row in data.Rows)
            {
                YeuCauDTO yeuCauDTO = new YeuCauDTO(
                    row["TenKhachHang"].ToString(),
                    row["NguyenNhan"].ToString(),
                    DateTime.Parse(row["NgaySua"].ToString())
                );

                listYeuCau.Add(yeuCauDTO);
            }

            return listYeuCau;
        }
        public bool AddYeuCau(string TenKhachHang, string BienSo, string TenNguyenNhan, DateTime NgaySua, string DiaChi, string SoDienThoai)
        {
            string query = "EXEC addThings @tenkhachhang , @bienso , @tennguyennhan , @ngaysua , @diachi , @sodienthoai ";

            object[] parameters = new object[]
            {
                TenKhachHang,
                BienSo,
                TenNguyenNhan,
                NgaySua,
                DiaChi,
                SoDienThoai
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return result > 0;
        }

        public bool DeleteYeuCau(string MaSuaChua,string MaXe)
        {
            string query = "delete from YEUCAUSUACHUA where MaSuaChua = @masuachua " + "delete from XEMAY where MaXe = @maxe ";
            object[] parameters = new object[]{
                MaSuaChua
               ,MaXe
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query,parameters);
            return result > 0;
        }
        public string ReturnTenKH(string SoDienThoai)
        {
            string query = "SELECT TenKhachHang FROM KHACHHANG WHERE SoDienThoai = @sodienthoai ";

            object[] parameters = new object[] { SoDienThoai };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["TenKhachHang"].ToString();
            }

            return string.Empty;
        }
        public string ReturnDiaChi(string SoDienThoai)
        {
            string query = "SELECT DiaChi FROM KHACHHANG WHERE SoDienThoai = @sodienthoai ";

            object[] parameters = new object[] { SoDienThoai };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["DiaChi"].ToString();
            }
            return string.Empty;
        }

        public bool UpdateYeuCau(string TenKhachHang, string NguyenNhan,string DiaChi,string SoDienThoai,string MaKhachHang,string maSuaChua)
        {
            string query = "update KHACHHANG set TenKhachHang = @tenkhachhang , DiaChi = @diachi ,SoDienThoai = @sodienthoai where MaKhachHang = @makhachhang " +
                "update YEUCAUSUACHUA set NguyenNhan = @nguyennhan where MaSuaChua = @masuachua";
            object[] parameters = new object[] {
                TenKhachHang,
                DiaChi,
                SoDienThoai,
                MaKhachHang,
                NguyenNhan,
                maSuaChua
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
