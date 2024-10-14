using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhuTungDAL
    {
        public bool KiemTraPhuTung(string maPt)
        {
            string query = "SELECT COUNT(*) FROM PHUTUNG WHERE MaPhuTung = @mapt ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maPt});
            return Convert.ToInt32(result) > 0;
        }
        public object[] LayPhuTung(string maPt)
        {
            string query = "SELECT TenPhuTung, SoLuong, DonGiaNhap, DonGiaBan FROM PHUTUNG WHERE MaPhuTung = @mapt";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { maPt });

            if (dataTable.Rows.Count > 0) // Nếu có bản ghi
            {
                DataRow row = dataTable.Rows[0]; 
                return new object[]
                {
                    row["TenPhuTung"],
                    row["SoLuong"],
                    row["DonGiaNhap"],
                    row["DonGiaBan"]
                };
            }

            return null;
        }
        public bool SuaPhuTung(string ma, int sl)
        {
            string query = "UPDATE PHUTUNG SET SoLuong += @soLuongNhap WHERE MaPhuTung = @maPhuTung ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sl, ma });
            return result > 0;
        }
        public bool ThemPhuTung(PhuTungDTO phuTung)
        {
            string query = "INSERT INTO PHUTUNG (MaPhuTung, TenPhuTung, SoLuong, DonGiaNhap, DonGiaBan) VALUES ( @maPhuTung , @tenPhuTung , @soLuong , @donGiaNhap , @donGiaBan )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, 
                new object[] { phuTung.MaPhuTung, phuTung.TenPhuTung, phuTung.SoLuong, phuTung.DonGiaNhap, phuTung.DonGiaBan});
            return result > 0;
        }
        public List<PhuTungDTO> TimDsTheoTen(string ten)
        {
            string query = "SELECT * FROM PHUTUNG WHERE TenPhuTung COLLATE SQL_Latin1_General_Cp1_CI_AI LIKE '%' + @ten + '%'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { ten });
            List<PhuTungDTO> listKho = new List<PhuTungDTO>();
            foreach (DataRow row in dataTable.Rows)
            {
                PhuTungDTO khoPhuTungDTO = new PhuTungDTO
                {
                    MaPhuTung = row["MaPhuTung"].ToString(),
                    TenPhuTung = row["TenPhuTung"].ToString(),
                    SoLuong = int.Parse(row["SoLuong"].ToString()),
                    DonGiaNhap = decimal.TryParse(row["DonGiaNhap"].ToString(), out decimal donGiaNhapValue) ? donGiaNhapValue : 0,
                    DonGiaBan = decimal.TryParse(row["DonGiaBan"].ToString(), out decimal donGiaBanValue) ? donGiaBanValue : 0

                };
                listKho.Add(khoPhuTungDTO);
            }
            return listKho;
        }

        public List<PhuTungDTO> LayDSKhoPhuTung()
        {
            string query = "SELECT * FROM PHUTUNG ";
 
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            List<PhuTungDTO> listKho = new List<PhuTungDTO>();
            foreach (DataRow row in dataTable.Rows)
            {
                PhuTungDTO khoPhuTungDTO = new PhuTungDTO
                {
                    MaPhuTung = row["MaPhuTung"].ToString(),
                    TenPhuTung = row["TenPhuTung"].ToString(),
                    SoLuong = int.Parse(row["SoLuong"].ToString()),
                    DonGiaNhap = decimal.TryParse(row["DonGiaNhap"].ToString(), out decimal donGiaNhapValue) ? donGiaNhapValue : 0,
                    DonGiaBan = decimal.TryParse(row["DonGiaBan"].ToString(), out decimal donGiaBanValue) ? donGiaBanValue : 0

                };
                listKho.Add(khoPhuTungDTO);
            }
            return listKho;
        }

    }
}
