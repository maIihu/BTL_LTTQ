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
    public class DatYeuCauDAL
    {

        public List<DatYeuCauDTO> GetListYeuCau()
        {
            string query = "select MaSuaChua, TenKhachHang, MaXe, NguyenNhan, NgaySua,YEUCAUSUACHUA.MaKhachHang,DiaChi,SoDienThoai from YEUCAUSUACHUA join KHACHHANG on YEUCAUSUACHUA.MaKhachHang = KHACHHANG.MaKhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<DatYeuCauDTO> listYeuCau = new List<DatYeuCauDTO>();

            foreach (DataRow row in data.Rows)
            {
                DatYeuCauDTO yeuCauDTO = new DatYeuCauDTO(
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
        public List<DatYeuCauDTO> GetTop10YeuCau()
        {
            string query = "select top 10 TenKhachHang, NguyenNhan, NgaySua " +
    "from YEUCAUSUACHUA join KHACHHANG on YEUCAUSUACHUA.MaKhachHang = KHACHHANG.MaKhachHang " + // thêm khoảng trắng ở đây
    "order by NgaySua desc";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<DatYeuCauDTO> listYeuCau = new List<DatYeuCauDTO>();

            foreach (DataRow row in data.Rows)
            {
                DatYeuCauDTO yeuCauDTO = new DatYeuCauDTO(
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
