using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL _khachHangDAL;
        public KhachHangBLL() { 
            _khachHangDAL = new KhachHangDAL();
        }
        public bool AddCustomer(KhachHangDTO khachHang)
        {
            return _khachHangDAL.AddCustomer(khachHang);
        }
        public bool UpdateCustomer(KhachHangDTO khachHang)
        {
            return _khachHangDAL.UpdateCustomer(khachHang);
        }
        public bool DeleteCustomer(string maNhanVien)
        {
            return _khachHangDAL.DeleteCustomer(maNhanVien);
        }
        public DataTable SearchCustomerByName(string tenKhachHang)
        {
            return _khachHangDAL.SearchCustomerByName(tenKhachHang);
        }

        public List<KhachHangDTO> GetCustomerList()
        {
            return _khachHangDAL.GetCustomerList();
        }
    }
}
