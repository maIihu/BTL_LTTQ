using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
	public class DichVuBLL
	{
		private DichVuDAL _dichVuDAL;

		public DichVuBLL()
		{
			_dichVuDAL = new DichVuDAL();
		}

		public string GiaTienDichVu(string ma)
		{
			return _dichVuDAL.LayGiaTien(ma);
		}
		public List<DichVuDTO> DanhSachDichVu()
		{
			return _dichVuDAL.DanhSachDichVu();
		}
	}
}
