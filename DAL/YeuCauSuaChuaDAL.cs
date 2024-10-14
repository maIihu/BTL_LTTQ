using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class YeuCauSuaChuaDAL
    {
        public bool ThemYeuCau(YeuCauSuaChuaDTO yeucau)
        {
            string query = "Insert into YEUCAUSUACHUA (MaSuaChua,MaXe,MaKhachHang,NgaySua,MaNguyenNhan) values( @masuachua , @maxe , @makhach , @ngaysua , @manguyennhan )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { yeucau.MaSuaChua, yeucau.MaXe, yeucau.MaKhachHang, yeucau.NgaySua, yeucau.MaNguyenNhan });
            return result > 0;
        }
        public bool XoaYeuCau(string masuachua)
        {
            string query = "Delete from YEUCAUSUACHUA where MaSuaChua = @masuachua ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masuachua });
            return result > 0;
        }
        public bool SuaYeuCau(YeuCauSuaChuaDTO yeucau)
        {
            string query = " Update YEUCAUSUACHUA set  (MaSuaChua,MaXe,MaKhachHang,NgaySua,MaNguyenNhan) values( @masuachua , @maxe , @makhach , @ngaysua , @manguyennhan )";
            int result = DataProvider.Instance.ExecuteNonQuery
               (query, new object[] { yeucau.MaSuaChua, yeucau.MaXe, yeucau.MaKhachHang, yeucau.NgaySua, yeucau.MaNguyenNhan });
            return result > 0;
        }
        public List<YeuCauSuaChuaDTO> LayDanhSachYeuCau()
        {
            string query = "SELECT * FROM YEUCAUSUACHUA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<YeuCauSuaChuaDTO> dsYeuCau = new List<YeuCauSuaChuaDTO>();
            foreach (DataRow row in data.Rows)
            {
                YeuCauSuaChuaDTO yeucau = new YeuCauSuaChuaDTO
                {
                    MaSuaChua = row["MaSuaChua"].ToString(),
                    MaXe = row["MaXe"].ToString(),
                    MaKhachHang = row["MaKhachHang"].ToString(),
                    NgaySua = row["NgaySua"] != DBNull.Value ? Convert.ToDateTime(row["NgaySua"]) : DateTime.MinValue,
                    MaNguyenNhan = row["MaNguyenNhan"].ToString()
                };
                dsYeuCau.Add(yeucau);
            }
            return dsYeuCau;
        }
        public List<YeuCauSuaChuaDTO> SearchByProblem(string maNguyenNhan)
        {
            string query = "select * from YEUCAUSUACHUA where MaNguyenNhan = @manguyennhan ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNguyenNhan });

            List<YeuCauSuaChuaDTO> dsYeuCau = new List<YeuCauSuaChuaDTO>();
            foreach (DataRow row in data.Rows)
            {
                YeuCauSuaChuaDTO yeucau = new YeuCauSuaChuaDTO
                {
                    MaSuaChua = row["MaSuaChua"].ToString(),
                    MaXe = row["MaXe"].ToString(),
                    MaKhachHang = row["MaKhachHang"].ToString(),
                    NgaySua = row["NgaySua"] != DBNull.Value ? Convert.ToDateTime(row["NgaySua"]) : DateTime.MinValue,
                    MaNguyenNhan = row["MaNguyenNhan"].ToString()
                };
                dsYeuCau.Add(yeucau);
            }
            return dsYeuCau;
        }
    }   
}
