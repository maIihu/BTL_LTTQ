using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class fHoaDon : Form
    {
        string idLogin;

        PhuTungBLL _phuTungBLL;
        private HoaDonYeuCauBLL _hoaDonYeuCauBLL;
        YeuCauSuaChuaBLL _yeuCauSuaChuaBLL;


        private Font font = new Font("Segoe UI", 12, FontStyle.Bold);
        private Font fontSub = new Font("Segoe UI", 10, FontStyle.Regular);

        public int CornerRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
        public float BorderThickness { get; set; } = 0.5f;
        private int rowIndex = -1;
        private Point panelPos = new Point(48, 118);
        public fHoaDon(string idLogin)
        {
            InitializeComponent();
            _hoaDonYeuCauBLL = new HoaDonYeuCauBLL();
            _phuTungBLL = new PhuTungBLL();
            _yeuCauSuaChuaBLL = new YeuCauSuaChuaBLL();

            SetupDataGridView();


            ListHoaDon();

            cmbOrder.SelectedIndex = 0;
            this.idLogin = idLogin;
        }
        private void fHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDSHoaDonYeuCau();
        }

        private void HienThiDSHoaDonYeuCau()
        {
            List<HoaDonYeuCauDTO> listHoaDon = _hoaDonYeuCauBLL.LayDSHoaDon();
            // hien thi ds tai day...
            ThemDuLieuHoaDon(listHoaDon);
        }

        private void ThemDuLieuHoaDon(List<HoaDonYeuCauDTO> dsHoaDon)
        {
            dgvHoaDon.Rows.Clear();
            foreach(var x in dsHoaDon)
            {
                dgvHoaDon.Rows.Add(x.MaHoaDon, x.MaKhachHang, x.MaNhanVien, x.NgayIn.ToString("dd/MM/yyyy"), x.GiaiPhap, x.TongTien);
            }
        }

        private void SetupDataGridView()
        {
            dgvHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.GridColor = Color.LightGray;
            dgvHoaDon.ColumnHeadersDefaultCellStyle.BackColor = dgvHoaDon.BackColor;
            dgvHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = dgvHoaDon.ForeColor;

            dgvHoaDon.DefaultCellStyle.SelectionBackColor = dgvHoaDon.DefaultCellStyle.BackColor;
            dgvHoaDon.DefaultCellStyle.SelectionForeColor = dgvHoaDon.DefaultCellStyle.ForeColor;

            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
            actionsColumn.Name = "Actions";
            actionsColumn.HeaderText = "";
            actionsColumn.Text = "...";
            actionsColumn.UseColumnTextForButtonValue = true;
            dgvHoaDon.Columns.Add(actionsColumn);


            dgvHoaDon.Columns["MaHoaDon"].FillWeight = 10;
            dgvHoaDon.Columns["TenKhachHang"].FillWeight = 15;
            dgvHoaDon.Columns["MaNhanVien"].FillWeight = 10;
            dgvHoaDon.Columns["NgayIn"].FillWeight = 10;
            dgvHoaDon.Columns["GiaiPhap"].FillWeight = 20;
            dgvHoaDon.Columns["ThanhTien"].FillWeight = 10;

            dgvHoaDon.Columns["Actions"].FillWeight = 5;

            dgvHoaDon.RowTemplate.Height = 60;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHoaDon.ColumnHeadersHeight = 60;

        }

        private void dgvHoaDon_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        }

        private void dgvCMSHoaDon_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                string cellValue = e.Value?.ToString() ?? string.Empty;
                if (cellValue != string.Empty)
                {
                    Rectangle rect = e.CellBounds;
                    e.Graphics.DrawString(cellValue, font, Brushes.Gray, rect.X, rect.Y + 15);
                }
            }
        }

        private void yourDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvHoaDon.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                var cellRectangle = dgvHoaDon.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                rowIndex = e.RowIndex;
                cmsHoaDon.Show(dgvHoaDon, cellRectangle.Left, cellRectangle.Bottom - 20);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update selected!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete selected!");
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

        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapHoaDon_Click(object sender, EventArgs e)
        {
            
        }


        private void cmsItemSua_Click(object sender, EventArgs e)
        {
            //lay thong tin bang rowIndex
        }

        private void cmsItemXoa_Click(object sender, EventArgs e)
        {
            //lay thong tin bang rowIndex
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel2, 15, BorderColor, BorderThickness, e);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel4, 15, BorderColor, BorderThickness, e);
        }

 

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel3, 15, BorderColor, BorderThickness, e);
        }


        #region

        private void ListHoaDon()
        {
            dgvHoaDon.Rows.Clear();
            List<HoaDonYeuCauDTO> dsHoaDon = _hoaDonYeuCauBLL.LayDSHoaDonYeuCau();
            foreach (var hoaDon in dsHoaDon)
            {
                dgvHoaDon.Rows.Add(hoaDon.MaSuaChua, hoaDon.TenKhachHang, hoaDon.MaXe, hoaDon.MaKhachHang);
            }
        }


        #endregion

    }
}
