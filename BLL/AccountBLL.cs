using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace BLL
{
    public class AccountBLL
    {
        private AccountDAL _accountDAL;
        private static readonly string usernamePattern = @"^[a-zA-Z0-9]{3,}$";
        private static readonly string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$";

        public AccountBLL()
        {
            _accountDAL = new AccountDAL();
        }
        public string ValidateLogin(AccountDTO user)
        {
            if (!Regex.IsMatch(user.TaiKhoan, usernamePattern))
            {
                return "Tai khoan khong hop le";
            }
            if(!Regex.IsMatch(user.MatKhau, passwordPattern))
            {
                return "Mat khau khong hop le";
            }
            return "Incorrect";
        }
        public bool CheckAccountInDatabase(AccountDTO user)
        {
            return _accountDAL.CheckAccountInDatabase(user);
        }
        public bool CheckUsernameInDatabase(string username)
        {
            return _accountDAL.CheckUsernameInDatabase(username);
        }
        public bool InsertAccountInDatabase(AccountDTO user) {
            return _accountDAL.AddAccount(user);
        }
    }
}
