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
        public string GetCustomerNameWithId(string ma)
		{
            return _khachHangDAL.GetCustomerNameWithId(ma);
        }

		public string GetCustomerPhoneWithId(string ma)
		{
			return _khachHangDAL.GetCustomerPhoneWithId(ma);
		}
		public string GetCustomerAddressWithId(string ma)
		{
			return _khachHangDAL.GetCustomerAddressWithId(ma);
		}
		public bool IsPhoneNumberExists(string soDienThoai, string maKhachHang)
        {
            return _khachHangDAL.IsPhoneNumberExists(soDienThoai, maKhachHang);
        }

		public bool UpdateCustomer(KhachHangDTO khachHang)
        {
            return _khachHangDAL.UpdateCustomer(khachHang);
        }
        public bool DeleteCustomer(string maKhachHang)
        {
            return _khachHangDAL.DeleteCustomer(maKhachHang);
        }
        public List<KhachHangDTO> SearchCustomerByName(string tenKhachHang, string soDienThoai)
        {
            return _khachHangDAL.SearchCustomerByName(tenKhachHang, soDienThoai);
        }

        public List<KhachHangDTO> GetCustomerList()
        {
            return _khachHangDAL.GetCustomerList();
        }
    }
}
