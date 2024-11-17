using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
	public class DichVuDAL
	{
		public string LayGiaTien(string ma)
		{
			string query = "SELECT GiaTien FROM DichVu WHERE TenDichVu = @ma";
			object result = DataProvider.Instance.ExecuteScalar(query, new object[] { ma });

			return result != null ? result.ToString() : null;
		}
		public List<DichVuDTO> DanhSachDichVu()
		{
			string query = "SELECT * FROM DichVu";
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			List<DichVuDTO> list = new List<DichVuDTO>();

			foreach (DataRow row in dataTable.Rows)
			{
				DichVuDTO loaiXe = new DichVuDTO
				{
					MaDichVu = row["MaDichVu"].ToString(),
					TenDichVu = row["TenDichVu"].ToString(),				
				};
				list.Add(loaiXe);
			}
			return list;
		}
	}
}
