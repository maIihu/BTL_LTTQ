using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows;
using FontStyle = System.Drawing.FontStyle;

namespace GUI
{
	public partial class fTrangChu : Form
	{
		DatYeuCauBLL _datYeuCauBLL;
        HoaDonYeuCauBLL _hoaDonYeuCauBLL;

		string idLogin;
        private Font font = new Font("Segoe UI", 12f, FontStyle.Bold);
		private Font fontSub = new Font("Segoe UI", 10f, FontStyle.Regular);
		public int CornerRadius { get; set; } = 20;
		public Color BorderColor { get; set; } = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
		public float BorderThickness { get; set; } = 0.5f;
        private Image[] avatars = new Image[5];
        public fTrangChu(string idLogin)
		{
            _datYeuCauBLL = new DatYeuCauBLL();
            _hoaDonYeuCauBLL = new HoaDonYeuCauBLL();

            InitializeComponent();

            ImportAvatar();

            SetupDataGridView();

			this.idLogin = idLogin;
			
           
        }
        private void fTrangChu_Load(object sender, EventArgs e)
        {
            HienThiDSYeuCau();
            lbTongYeuCau.Text = _hoaDonYeuCauBLL.LaySLYeuCau().ToString() + " đơn";
            lbTongHoaDon.Text = _hoaDonYeuCauBLL.LaySLHoaDon().ToString() + " đơn";
            SetUpChartDoanhThuThang();             
            SetUpChartThongKeTuan();
        }
        private void SetUpChartThongKeTuan()
        {
            List<Tuple<int, decimal>> doanhThu = _hoaDonYeuCauBLL.LayDoanhThuTuan();

            var doanhThuValues = new ChartValues<double>();

            for (int i = 2; i <= 8; i++) 
            {
                var thangData = doanhThu.FirstOrDefault(dt => dt.Item1 == i);
                doanhThuValues.Add((double)(thangData?.Item2 ?? 0)); 
            }

            BieuDoTongKet.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Doanh Thu Theo Tuần",
                    Values = doanhThuValues
                }
            };

            BieuDoTongKet.AxisX.Add(new Axis
            {
                Title = "Ngày Trong Tuần",
                Labels = new[] {  "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy", "Chủ Nhật" },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = true
                }
            });

            BieuDoTongKet.AxisY.Add(new Axis
            {
                Title = "Số Lượng Hóa Đơn",
                LabelFormatter = value => value.ToString("N0"), 

            });

        }
        private void SetUpChartDoanhThuThang()
        {
            List<Tuple<int, decimal>> doanhThu = _hoaDonYeuCauBLL.LayDoanhThuThang();

            var doanhThuValues = new ChartValues<double>();

            for (int i = 0; i < 12; i++)
            {
                var thangData = doanhThu.FirstOrDefault(dt => dt.Item1 == i + 1);
                doanhThuValues.Add((double)thangData.Item2);
            }

            BieuDoDoanhThu.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Doanh Thu",
                    Values = doanhThuValues
                }
            };

            BieuDoDoanhThu.AxisX.Add(new Axis
            {
                Title = "Tháng",
                Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = true
                }
            });

            BieuDoDoanhThu.AxisY.Add(new Axis
            {
                Title = "Doanh Thu (VNĐ)",
                LabelFormatter = value => value.ToString("C0"),
                Margin = new Thickness(0, 0, 20, 0)
            });
        }

        private void ImportAvatar()
        {
            avatars[0] = Properties.Resources.Avatar;
            avatars[1] = Properties.Resources.Avatar_1_;
            avatars[2] = Properties.Resources.Avatar_2_;
            avatars[3] = Properties.Resources.Avatar_3_;
            avatars[4] = Properties.Resources.Avatar_4_;
        }
        public int RandId(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void SetUpData(List<DatYeuCauDTO> listYeuCau)
        {
            dgvTrangChu.Rows.Clear();
            int stt = 1;
            foreach (var x in listYeuCau)
            {
                string ngaySuaFormatted = x.NgaySua.ToString("dd/mm/yyyy"); 
                dgvTrangChu.Rows.Add(stt++, x.TenKhachHang, x.NguyenNhan, ngaySuaFormatted);
            }
        }

        private void HienThiDSYeuCau()
		{
			List<DatYeuCauDTO> listYeuCau = _datYeuCauBLL.GetListTop10();
			SetUpData(listYeuCau);	


        }
        private void SetupDataGridView()
		{

			dgvTrangChu.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
			/*dgvTrangChu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;*/
			/*dgvTrangChu.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;*/
			dgvTrangChu.EnableHeadersVisualStyles = false;
			dgvTrangChu.GridColor = Color.LightGray;
			dgvTrangChu.ColumnHeadersDefaultCellStyle.BackColor = dgvTrangChu.BackColor;
			dgvTrangChu.ColumnHeadersDefaultCellStyle.ForeColor = dgvTrangChu.ForeColor;

			dgvTrangChu.DefaultCellStyle.SelectionBackColor = dgvTrangChu.DefaultCellStyle.BackColor;
			dgvTrangChu.DefaultCellStyle.SelectionForeColor = dgvTrangChu.DefaultCellStyle.ForeColor;

			dgvTrangChu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			dgvTrangChu.Columns["No"].FillWeight = 5;
			dgvTrangChu.Columns["TenKhachHang"].FillWeight = 18;
            dgvTrangChu.Columns["NguyenNhan"].FillWeight = 30;
            dgvTrangChu.Columns["NgaySua"].FillWeight = 12;
			


			// Tùy chỉnh
			/*dgvTrangChu.Dock = DockStyle.Fill;*/

			// Điều chỉnh chiều cao hàng tự động để vừa với nội dung
			/*dgvTrangChu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;*/

			dgvTrangChu.RowTemplate.Height = 60;
			dgvTrangChu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvTrangChu.ColumnHeadersHeight = 60;



			/*this.Controls.Add(dgvTrangChu);*/
		}

		private void dgvPanel_Paint(object sender, PaintEventArgs e)
		{
			DrawRoundedPanel(dgvPanel, 15, BorderColor, BorderThickness, e);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			DrawRoundedPanel(panel1, 15, BorderColor, BorderThickness, e);
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			DrawRoundedPanel(panel2, 15, BorderColor, BorderThickness, e);
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{
			DrawRoundedPanel(panel3, 15, BorderColor, BorderThickness, e);
		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{
			DrawRoundedPanel(panel4, 15, BorderColor, BorderThickness, e);
		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{
			DrawRoundedPanel(panel5, 15, BorderColor, BorderThickness, e);
		}

		private void DrawRoundedPanel(Panel panel, int radius, Color borderColor, float borderThickness, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;

			GraphicsPath path = new GraphicsPath();
			Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

			path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
			path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
			path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
			path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
			path.CloseFigure();

			panel.Region = new Region(path);

			using (Pen pen = new Pen(borderColor, borderThickness))
			{
				g.DrawPath(pen, path);
			}
		}



		private void dgvTrangChu_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
            if (e.RowIndex >= 0)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                string cellValue = e.Value?.ToString() ?? string.Empty;
                if (cellValue != string.Empty)
                {
                    Rectangle rect = e.CellBounds;
                    e.Graphics.DrawString(cellValue, font, Brushes.Black, rect.X, rect.Y + 15);
                }
            }
            //if (e.RowIndex >= 0)
            //{
            //	e.Handled = true;
            //	e.PaintBackground(e.ClipBounds, true);

            //	if (e.ColumnIndex == dgvTrangChu.Columns["No"].Index &&
            //		dgvTrangChu.Rows[e.RowIndex].Cells["No"].Value != null)
            //	{
            //		Rectangle rect = e.CellBounds;

            //		string no = (string)dgvTrangChu.Rows[e.RowIndex].Cells["No"].Value;

            //		e.Graphics.DrawString(no, font, Brushes.Gray, rect.X + 5, rect.Y + 5);
            //	}
            //	else if (e.ColumnIndex == dgvTrangChu.Columns["TenKhachHang"].Index &&
            //		dgvTrangChu.Rows[e.RowIndex].Cells["TenKhachHang"].Value != null)
            //	{
            //		Rectangle rect = e.CellBounds;

            //		Image img = avatars[RandId(0, 5)];
            //		Rectangle imgRect = new Rectangle(rect.X + 5, rect.Y + 5, 40, 40);
            //		e.Graphics.DrawImage(img, imgRect);

            //		string[] parts = ((string)dgvTrangChu.Rows[e.RowIndex].Cells["TenKhachHang"].Value).Split('\n');
            //		string userName = parts[0];
            //		//string userCode = parts[1];


            //		e.Graphics.DrawString(userName, font, Brushes.Black, rect.X + 50, rect.Y + 5);
            //		//e.Graphics.DrawString(userCode, fontSub, Brushes.Gray, rect.X + 50, rect.Y + 25);
            //	}
            //	else if (e.ColumnIndex == dgvTrangChu.Columns["NgaySua"].Index &&
            //		dgvTrangChu.Rows[e.RowIndex].Cells["NgaySua"].Value != null)

            //             {
            //		Rectangle rect = e.CellBounds;

            //		DateTime dateValue = (DateTime)dgvTrangChu.Rows[e.RowIndex].Cells["NgaySua"].Value;
            //		string datePart = dateValue.ToString("dd/MM/yyyy");
            //		string timePart = dateValue.ToString("HH:mm:ss");

            //		e.Graphics.DrawString(datePart, font, Brushes.Black, rect.X, rect.Y + 5);
            //		e.Graphics.DrawString(timePart, fontSub, Brushes.Gray, rect.X, rect.Y + 25);
            //	}
            //	else if (e.ColumnIndex == dgvTrangChu.Columns["NguyenNhan"].Index &&
            //		dgvTrangChu.Rows[e.RowIndex].Cells["NguyenNhan"].Value != null)
            //	{
            //		Rectangle rect = e.CellBounds;

            //		string status = (string)dgvTrangChu.Rows[e.RowIndex].Cells["NguyenNhan"].Value;

            //		e.Graphics.DrawString(status, font, Brushes.Black, rect.X, rect.Y + 5);
            //	}
            //	//else if (e.ColumnIndex == dgvTrangChu.Columns["Price"].Index &&
            //	//	dgvTrangChu.Rows[e.RowIndex].Cells["Price"].Value != null)
            //	//{
            //	//	Rectangle rect = e.CellBounds;

            //	//	string status = (string)dgvTrangChu.Rows[e.RowIndex].Cells["Price"].Value;

            //	//	e.Graphics.DrawString(status, font, Brushes.Black, rect.X, rect.Y + 5);
            //	//}
            //	//else if (e.ColumnIndex == dgvTrangChu.Columns["Customers"].Index &&
            //	//	dgvTrangChu.Rows[e.RowIndex].Cells["Customers"].Value != null)
            //	//{
            //	//	Rectangle rect = e.CellBounds;

            //	//	string status = (string)dgvTrangChu.Rows[e.RowIndex].Cells["Customers"].Value;

            //	//	e.Graphics.DrawString(status, font, Brushes.Black, rect.X, rect.Y + 5);
            //	//}

        
		}


    }
}
