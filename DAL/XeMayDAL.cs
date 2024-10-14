using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class XeMayDAL
    {

        public XeMayDTO LayXeTheoMa(string maXe)
        {
            string query = "SELECT MaXe, TenXe, LoaiXe, SoKhung, SoMay, BienSo FROM XEMAY WHERE maXe = @maXe ";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { maXe });

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                XeMayDTO xeMay = new XeMayDTO
                {
                    MaXe = row["MaXe"].ToString(),
                    TenXe = row["TenXe"].ToString(),
                    LoaiXe = row["LoaiXe"].ToString(),
                    SoKhung = row["SoKhung"].ToString(),
                    SoMay = row["SoMay"].ToString(),
                    BienSo = row["BienSo"].ToString(),
                };
                return xeMay;
            }

            return null;
        }

        public bool CheckDuplication(string maXe, string currentMaXe = null)
        {
            string query = "SELECT COUNT(*) FROM XeMay WHERE maxe = @maXe ";
            if (currentMaXe != null)
            {
                query += " AND maxe != @currentMaXe ";
            }

            object[] parameters;
            if (currentMaXe != null)
            {
                parameters = new object[] { maXe, currentMaXe };
            }
            else
            {
                parameters = new object[] { maXe };
            }

            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);

            return count > 0;
        }

        public bool ThemXeMay(XeMayDTO xeMay)
        {
            string query = "INSERT INTO XeMay (maxe, tenxe, loaixe, sokhung, somay, bienso, mauxe) VALUES ( @value1 , @value2 , @value3 , @value4 , @value5 , @value6 , @value7 )";

            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                xeMay.MaXe,
                xeMay.TenXe,
                xeMay.LoaiXe,
                xeMay.SoKhung,
                xeMay.SoMay,
                xeMay.BienSo,
                xeMay.MaMau
            });

            return res > 0;
        }

        public bool SuaXeMay(XeMayDTO xeMay)
        {
            string query = "UPDATE XeMay SET tenxe = @value2 , loaixe = @value3 , sokhung = @value4 , somay = @value5 , bienso = @value6 , mauxe = @value7 WHERE maxe = @value1 ";

            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                xeMay.MaXe,
                xeMay.TenXe,
                xeMay.LoaiXe,
                xeMay.SoKhung,
                xeMay.SoMay,
                xeMay.BienSo,
                xeMay.MaMau,
            });

            return res > 0;
        }

        public bool XoaXeMay(string maXe)
        {
            string query = "DELETE FROM XeMay WHERE maxe = @value1 ";

            int res = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maXe });

            return res > 0;
        }

        public List<XeMayDTO> TimXeMayTheoTen(string tenXe)
        {
            string query = "SELECT * FROM XEMAY WHERE TenXe LIKE '%' + @ten + '%'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { tenXe });

            List<XeMayDTO> xeMayList = new List<XeMayDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                XeMayDTO xeMay = new XeMayDTO
                {
                    MaXe = row["MaXe"].ToString(),
                    TenXe = row["TenXe"].ToString(),
                    LoaiXe = row["LoaiXe"].ToString(),
                    SoKhung = row["SoKhung"].ToString(),
                    SoMay = row["SoMay"].ToString(),
                    BienSo = row["BienSo"].ToString(),
                    MaMau = row["MaMau"].ToString()
                };
                xeMayList.Add(xeMay);
            }
            return xeMayList;
        }

        public List<XeMayDTO> LayDanhSachXeMay()
        {
            string query = "SELECT * FROM XEMAY";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            List<XeMayDTO> xeMayList = new List<XeMayDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                XeMayDTO xeMay = new XeMayDTO
                {
                    MaXe = row["MaXe"].ToString(),
                    TenXe = row["TenXe"].ToString(),
                    LoaiXe = row["LoaiXe"].ToString(),
                    SoKhung = row["SoKhung"].ToString(),
                    SoMay = row["SoMay"].ToString(),
                    BienSo = row["BienSo"].ToString(),
                    MaMau = row["MaMau"].ToString()
                };
                xeMayList.Add(xeMay);
            }
            return xeMayList;
        }

    }
}