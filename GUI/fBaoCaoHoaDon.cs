using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.QLSuaXeDataSet2TableAdapters;
using Microsoft.Reporting.WinForms;

namespace GUI
{
	public partial class fBaoCaoHoaDon : Form
	{
		private string _maHd;
		private string _hoTen;
		private string _diaChi;
		private string _sdt;
		private string _nguyenNhan;
		private string _giaiPhap;
		private string _tenNv;
		private string _thanhTien;
		public fBaoCaoHoaDon(string maHd, string hoTen, string diaChi, 
			string sdt, string nguyenNhan, string giaiPhap, string tenNv, string thanhTien)
		{
			InitializeComponent();
			this._maHd = maHd;
			this._hoTen = hoTen;
			this._diaChi = diaChi;
			this._sdt = sdt;
			this._nguyenNhan = nguyenNhan;
			_giaiPhap = giaiPhap;
			_tenNv = tenNv;
			this._thanhTien = thanhTien;	
			
		}
		private void fBaoCaoHoaDon_Load(object sender, EventArgs e)
		{
			reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.QuanLy.rdlc";
			reportViewer1.LocalReport.DataSources.Clear();
			MessageBox.Show($"hoTen: {_hoTen}, diaChi: {_diaChi}, sdt: {_sdt}, nguyenNhan: {_nguyenNhan}, giaiPhap: {_giaiPhap}, tenNv: {_tenNv}");

			var reportParams = new List<ReportParameter>
			{
				new ReportParameter("hoTen", this._hoTen),
				new ReportParameter("diaChi", this._diaChi),
				new ReportParameter("sdt", this._sdt),
				new ReportParameter("nguyenNhan", this._nguyenNhan),
				new ReportParameter("giaiPhap", this._giaiPhap),
				new ReportParameter("tenNhanVien", this._tenNv),
				new ReportParameter("thanhTien", this._thanhTien),
				new ReportParameter("maHd", this._maHd)
			};

			reportViewer1.LocalReport.SetParameters(reportParams);

			LoadReportHoaDon(_maHd);
			LoadReportPhuTung(_maHd);

			reportViewer1.RefreshReport();
		}

		private void LoadReportHoaDon(string maHoaDon)
		{
			if (_nguyenNhan == "Bảo dưỡng định kỳ" ||
				_nguyenNhan == "Độ xe hoặc nâng cấp" ||
				_nguyenNhan == "Sửa chữa điện xe máy" ||
				_nguyenNhan == "Rửa xe và chăm sóc xe" ||
				_nguyenNhan == "Tư vấn và kiểm tra xe")
			{
				DataTable emptyTable = new DataTable();
				ReportDataSource emptyDataSource = new ReportDataSource("DataSetHoaDon", emptyTable);
				reportViewer1.LocalReport.DataSources.Add(emptyDataSource);
				return;
			}
				QLSuaXeDataSet qlSuaXe = new QLSuaXeDataSet();
				HOADONTableAdapter hoaDon = new HOADONTableAdapter();


			hoaDon.Fill(qlSuaXe.HOADON);

			var filteredRows = qlSuaXe.HOADON.AsEnumerable()
											  .Where(row => row.Field<string>("MaHoaDon") == maHoaDon)
											  .Where(row => row["MaHoaDon"] != DBNull.Value); 

			// Nếu có kết quả lọc
			if (filteredRows.Any())
			{
				// Tính tổng tiền
				decimal totalAmount = filteredRows.Sum(row => row.Field<decimal>("TongTien"));

				// Tạo tham số báo cáo cho tổng tiền
				ReportParameter totalAmountParam = new ReportParameter("thanhTien", totalAmount.ToString("N0"));

				// Thêm tham số vào báo cáo
				reportViewer1.LocalReport.SetParameters(totalAmountParam);

				// Chuẩn bị dữ liệu cho báo cáo
				DataTable filteredTable = filteredRows.CopyToDataTable();
				ReportDataSource rdsHoaDon = new ReportDataSource("DataSetHoaDon", filteredTable);
				reportViewer1.LocalReport.DataSources.Add(rdsHoaDon);
			}
			else
			{
				MessageBox.Show("Không tìm thấy hóa đơn với mã này.");
			}
		}


		private void LoadReportPhuTung(string maHoaDon)
		{
			if (_nguyenNhan == "Bảo dưỡng định kỳ" ||
				_nguyenNhan == "Độ xe hoặc nâng cấp" ||
				_nguyenNhan == "Sửa chữa điện xe máy" ||
				_nguyenNhan == "Rửa xe và chăm sóc xe" ||
				_nguyenNhan == "Tư vấn và kiểm tra xe")
			{
				DataTable emptyTable = new DataTable();
				ReportDataSource emptyDataSource = new ReportDataSource("DataSetPhuTung", emptyTable);
				reportViewer1.LocalReport.DataSources.Add(emptyDataSource);
				return;
			}
			QLSuaXeDataSet qlSuaXe = new QLSuaXeDataSet();
			HOADONTableAdapter hoaDon = new HOADONTableAdapter();
			PHUTUNGTableAdapter phuTung = new PHUTUNGTableAdapter();

			hoaDon.Fill(qlSuaXe.HOADON);  // Lấy tất cả các hóa đơn
			phuTung.Fill(qlSuaXe.PHUTUNG); // Lấy tất cả các phụ tùng

			// Lọc hóa đơn theo mã hóa đơn
			var hoaDonRows = qlSuaXe.HOADON.AsEnumerable()
										   .Where(row => row.Field<string>("MaHoaDon") == maHoaDon)
										   .Where(row => row["MaHoaDon"] != DBNull.Value); // Kiểm tra không có giá trị null trong mã hóa đơn

			if (hoaDonRows.Any())
			{
				// Lấy tất cả mã phụ tùng từ hóa đơn, chỉ lấy những giá trị hợp lệ (không phải null)
				var maPhuTungList = hoaDonRows.Select(row => row.Field<string>("MaPhuTung"))
											  .Where(ma => ma != null); // Lọc các mã phụ tùng không null

				// Duyệt qua bảng PHUTUNG và lấy các phụ tùng có mã trong danh sách maPhuTungList
				var filteredPhuTungRows = qlSuaXe.PHUTUNG.AsEnumerable()
														  .Where(row => maPhuTungList.Contains(row.Field<string>("MaPhuTung"))
																	   && row["MaPhuTung"] != DBNull.Value); // Kiểm tra không có giá trị null trong mã phụ tùng

				if (filteredPhuTungRows.Any())
				{
					// Tạo DataTable chứa các phụ tùng đã lọc
					DataTable filteredTable = filteredPhuTungRows.CopyToDataTable();

					// Tạo ReportDataSource cho phụ tùng và thêm vào DataSources của báo cáo
					ReportDataSource rdsPhuTung = new ReportDataSource("DataSetPhuTung", filteredTable);
					reportViewer1.LocalReport.DataSources.Add(rdsPhuTung);
				}
				else
				{
					MessageBox.Show("Không tìm thấy phụ tùng cho mã hóa đơn này.");
				}
			}
			else
			{
				MessageBox.Show("Không tìm thấy hóa đơn với mã này.");
			}
		}



	}
}
