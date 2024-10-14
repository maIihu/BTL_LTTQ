using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

        public AccountDTO(string taiKhoan, string matKhau)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
        }
    }
}
