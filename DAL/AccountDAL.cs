using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    // truy xuất dữ liệu từ CSDL
    public class AccountDAL
    {
        public bool CheckAccountInDatabase(AccountDTO user)
        {
            string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE TaiKhoan = @taiKhoan AND MatKhau = @matKhau";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { user.TaiKhoan, user.MatKhau });
            return Convert.ToInt32(result) > 0;
        }

        public bool CheckUsernameInDatabase(string username) {
            string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE TaiKhoan = @taiKhoan";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { username });
            return Convert.ToInt32(result) > 0;
        }
        public bool AddAccount(AccountDTO user)
        {
            string query = "INSERT INTO TAIKHOAN (TaiKhoan, MatKhau) VALUES ( @username , @password )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { user.TaiKhoan, user.MatKhau });
            return result > 0;
        }
    }
}
