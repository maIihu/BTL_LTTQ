using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class LoaiXeDAL
    {
        public bool ThemLoaiXe(LoaiXeDTO loaiXe)
        {
            string query = "INSERT INTO LoaiXe (maloai, tenloai) VALUES ( @value1 , @value2 )";

            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                loaiXe.MaLoai,
                loaiXe.TenLoai,
            });

            return res > 0;
        }

        public bool SuaLoaiXe(LoaiXeDTO loaiXe)
        {
            string query = "UPDATE HoaDonNhap SET tenloai = @value2 WHERE maloai = @value1 ";

            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                loaiXe.MaLoai,
                loaiXe.TenLoai,
            });

            return res > 0;
        }

        public bool XoaLoaiXe(string maLoai)
        {
            string query = "DELETE FROM LoaiXe WHERE maloai = @value1";

            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLoai });

            return res > 0;
        }

        public List<LoaiXeDTO> LayDanhSachLoaiXe()
        {
            string query = "SELECT * FROM LoaiXe";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            List<LoaiXeDTO> list = new List<LoaiXeDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                LoaiXeDTO loaiXe = new LoaiXeDTO
                {
                    MaLoai = row["maloai"].ToString(),
                    TenLoai = row["tenloai"].ToString(),
                };
                list.Add(loaiXe);
            }
            return list;
        }
    }
}