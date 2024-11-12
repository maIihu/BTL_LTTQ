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
using DAL;
using DTO;
using BLL;
using System.Globalization;
namespace GUI
{
    public partial class fKhoPhuTung : Form
    {
        private int pageSize = 10;
        private int currentPagePT = 1;
        private int currentPageHDN = 1;
        private int totalPagesPT = 1;
        private int totalPagesHDN = 1;

        private string _idLogin;
        private string _idChoosing;
        private PhuTungBLL _phuTungBLL;
        private HoaDonNhapBLL _hoaDonNhapBLL;
        private ChiTietHoaDonNhapBLL _chiTietHoaDonNhapBLL;

        private List<HoaDonNhapDTO> listHoaDon;
        List<PhuTungDTO> listPhuTung;

        private int countHdn;
        private int countPt;
        
        private Font font = new Font("Segoe UI", 12, FontStyle.Bold);
        private Font fontSub = new Font("Segoe UI", 10, FontStyle.Regular);
        public int CornerRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
        public float BorderThickness { get; set; } = 0.5f;
        private string whatIsRunning = "PhuTung"; 
        public fKhoPhuTung(string idLogin)
        {
            InitializeComponent();
            _phuTungBLL = new PhuTungBLL();
            _hoaDonNhapBLL = new HoaDonNhapBLL();
            _chiTietHoaDonNhapBLL = new ChiTietHoaDonNhapBLL();
            this._idLogin = idLogin;
        }
        private void fKho_Load(object sender, EventArgs e)
        {

            SetupDGVPhuTung();
            SetupDGVHDN();

            HienThiDSHoaDonNhap();
            HienThiDSPhuTung();

            SetupPanelHDN();

            btnPhuTung_Click(this, EventArgs.Empty);
        }
        private void LaySoLieuHoaDon()
        {
            string temp = _phuTungBLL.LayMaHoaDonLonNhat();
            string numberPart = temp.Substring(3);
            countHdn = int.Parse(numberPart);
            countHdn++;
        }
        public void HienThiDSHoaDonNhap()
        {
            listHoaDon = _hoaDonNhapBLL.LayHoaDonNhap();
            totalPagesHDN = (int)Math.Ceiling((double)listHoaDon.Count / pageSize);
            currentPageHDN = 1;

            DisplayCurrentPage_HoaDon();
            LaySoLieuHoaDon();
            
        }
        private void DisplayCurrentPage_HoaDon()
        {
            var itemsToShow = listHoaDon.Skip((currentPageHDN - 1) * pageSize).Take(pageSize).ToList();
            ThemDuLieuHoaDon(itemsToShow);

            lblShowResult.Text = $"{currentPageHDN}/{totalPagesHDN}";
        }
        private void ThemDuLieuHoaDon(List<HoaDonNhapDTO> dsHoaDonNhap)
        {
            dgvHDN.Rows.Clear();
            int i = (currentPageHDN - 1) * pageSize + 1; ;
            foreach (var hdn in dsHoaDonNhap)
            {
                string formattedDate = hdn.NgayNhap.ToString("dd/MM/yyyy");
                string tienVND = hdn.TongTien.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
                dgvHDN.Rows.Add(i++, hdn.MaHDN, hdn.MaNV, formattedDate, tienVND);
            }
        }
        private void HienThiDSPhuTung()
        {
            listPhuTung = _phuTungBLL.LayDSPhuTung();
            totalPagesPT = (int)Math.Ceiling((double)listHoaDon.Count / pageSize);
            currentPagePT = 1;

            DisplayCurrentPage_PhuTung();

            countPt = listPhuTung.Count;
        }
        private void DisplayCurrentPage_PhuTung()
        {
            var itemsToShow = listPhuTung.Skip((currentPagePT - 1) * pageSize).Take(pageSize).ToList();
            ThemDuLieuPhuTung(itemsToShow);

            lblShowResult.Text = $"{currentPagePT}/{totalPagesPT}";
        }
        private void ThemDuLieuPhuTung(List<PhuTungDTO> dsPhuTung)
        {
            dgvPhuTung.Rows.Clear();
            int i = (currentPagePT - 1) * pageSize + 1;
            foreach (var phuTung in dsPhuTung)
            {
                string donGiaNhapVND = phuTung.DonGiaNhap.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
                string donGiaBanVND = phuTung.DonGiaBan.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
                dgvPhuTung.Rows.Add(i++, phuTung.MaPhuTung, phuTung.TenPhuTung, 
                    phuTung.SoLuong, donGiaNhapVND, donGiaBanVND);
            }
        }

        private void SetupPanelHDN()
        {
            panelHDN.Location = new Point(27, 34);

            dtpNgayNhap.ValueChanged += (s, ev) =>
            {
                txtNgayNhap.Text = dtpNgayNhap.Value.ToString("dddd, dd/MM/yyyy");
            };

            panelHDN.Visible = false;
        }


        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (whatIsRunning == "PhuTung")
            {
                if (string.IsNullOrEmpty(txtSearchBar.Text))
                {
                    listPhuTung = _phuTungBLL.LayDSPhuTung();
                }
                else
                {
                    listPhuTung = _phuTungBLL.TimDsTheoTen(txtSearchBar.Text);
                }
                currentPagePT = 1;
                totalPagesPT = (int)Math.Ceiling((double)listPhuTung.Count / pageSize);
                DisplayCurrentPage_PhuTung();
            }

        }
        private void txtSearchBar_Click(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == "Tìm kiếm...")
            {
                txtSearchBar.Text = "";
            }
        }


        private void txtSearchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBar.Text))
            {
                txtSearchBar.Text = "Tìm kiếm...";
            }
            if (string.IsNullOrWhiteSpace(txtSearchBar.Text) || txtSearchBar.Text == "Tìm kiếm...")
            {
                listPhuTung = _phuTungBLL.LayDSPhuTung();
                currentPagePT = 1;
                totalPagesPT = (int)Math.Ceiling((double)listPhuTung.Count / pageSize);

                DisplayCurrentPage_PhuTung();
            }
        }
        private void SetupDGVPhuTung()
        {

            dgvPhuTung.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvPhuTung.EnableHeadersVisualStyles = false;
            dgvPhuTung.GridColor = Color.LightGray;
            dgvPhuTung.ColumnHeadersDefaultCellStyle.BackColor = dgvPhuTung.BackColor;
            dgvPhuTung.ColumnHeadersDefaultCellStyle.ForeColor = dgvPhuTung.ForeColor;

            dgvPhuTung.DefaultCellStyle.SelectionBackColor = dgvPhuTung.DefaultCellStyle.BackColor;
            dgvPhuTung.DefaultCellStyle.SelectionForeColor = dgvPhuTung.DefaultCellStyle.ForeColor;

            dgvPhuTung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
            actionsColumn.Name = "Actions";
            actionsColumn.HeaderText = "";
            actionsColumn.Text = "...";
            actionsColumn.UseColumnTextForButtonValue = true;
            dgvPhuTung.Columns.Add(actionsColumn);

            dgvPhuTung.Columns["No"].FillWeight = 5;
            dgvPhuTung.Columns["MaPhuTung_PhuTung"].FillWeight = 15;
            dgvPhuTung.Columns["TenPhuTung"].FillWeight = 23;
            dgvPhuTung.Columns["SoLuong"].FillWeight = 15;
            dgvPhuTung.Columns["DonGiaNhap_PhuTung"].FillWeight = 15;
            dgvPhuTung.Columns["DonGiaBan"].FillWeight = 15;
            dgvPhuTung.Columns["Actions"].FillWeight = 5;

            dgvPhuTung.RowTemplate.Height = 60;
            dgvPhuTung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPhuTung.ColumnHeadersHeight = 60;
        }

        private void SetupDGVHDN()
        {

            dgvHDN.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvHDN.EnableHeadersVisualStyles = false;
            dgvHDN.GridColor = Color.LightGray;
            dgvHDN.ColumnHeadersDefaultCellStyle.BackColor = dgvHDN.BackColor;
            dgvHDN.ColumnHeadersDefaultCellStyle.ForeColor = dgvHDN.ForeColor;

            dgvHDN.DefaultCellStyle.SelectionBackColor = dgvHDN.DefaultCellStyle.BackColor;
            dgvHDN.DefaultCellStyle.SelectionForeColor = dgvHDN.DefaultCellStyle.ForeColor;

            dgvHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
            actionsColumn.Name = "Actions";
            actionsColumn.HeaderText = "";
            actionsColumn.Text = "...";
            actionsColumn.UseColumnTextForButtonValue = true;
            dgvHDN.Columns.Add(actionsColumn);

            dgvHDN.Columns["Stt"].FillWeight = 5;
            dgvHDN.Columns["MaHDN"].FillWeight = 15;
            dgvHDN.Columns["MaNV"].FillWeight = 15;
            dgvHDN.Columns["NgayNhap"].FillWeight = 15;
            dgvHDN.Columns["Tien"].FillWeight = 15;
            dgvHDN.Columns["Actions"].FillWeight = 5;

            dgvHDN.RowTemplate.Height = 60;
            dgvHDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHDN.ColumnHeadersHeight = 60;



        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvHDN.Columns["Actions"].Index && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellRectangle = dgvHDN.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmsKho.Show(dgvHDN, cellRectangle.Left, cellRectangle.Bottom - 20);
            }
        }
        private void dgvPhuTung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPhuTung.Columns["Actions"].Index && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellRectangle = dgvPhuTung.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmsKho.Show(dgvPhuTung, cellRectangle.Left, cellRectangle.Bottom - 20);
                _idChoosing = dgvPhuTung.Rows[e.RowIndex].Cells["MaPhuTung_PhuTung"].Value?.ToString();
			}
         
        }

        private void Update_Click(object sender, EventArgs e)
        {
            fCapNhatPhuTung form = new fCapNhatPhuTung(_idChoosing);
            form.ShowDialog();
            HienThiDSPhuTung();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete selected!");
        }
        private void txtMaPhuTung_Leave(object sender, EventArgs e)
        {
            if (txtMaPhuTung.Text != "")
            {
                string maPt = txtMaPhuTung.Text;
                bool kiemtraPt = _phuTungBLL.TimPhuTung(maPt);
                if (kiemtraPt)
                {
                    coPhuTung = true;
                    PhuTungDTO phuTung = _phuTungBLL.LayPhuTung(maPt);

                    if (phuTung != null)
                    {
                        txtTenPhuTung.Text = phuTung.TenPhuTung;
                        // txtSoLuong.Text = phuTung.SoLuong.ToString();
                        txtDonGiaNhap.Text = phuTung.DonGiaNhap.ToString("N0"); 
                        txtDonGiaBan.Text = phuTung.DonGiaBan.ToString("N0"); 
                    }
                    else
                    {
                        txtTenPhuTung.Text = string.Empty;
                        txtSoLuong.Text = string.Empty;
                        txtDonGiaNhap.Text = string.Empty;
                        txtDonGiaBan.Text = string.Empty;
                    }
                }
                else
                {
                    coPhuTung = false;
                }
            }
        }
        private void btnHDN_Click(object sender, EventArgs e)
        {
            lblShowResult.Text = $"{currentPageHDN}/{totalPagesPT}";
            lblChiTiet.Visible = true;
            if (panelDS.Visible == false)
            {
                panelDS.Visible = true;
                panelDS.Enabled = true;
            }

            if (panelHDN.Visible == true)
            {
                panelHDN.Visible = false;
            }

            dgvHDN.FirstDisplayedScrollingRowIndex = 0;

            foreach (DataGridViewColumn column in dgvHDN.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            dgvPhuTung.Visible = false;

            dgvHDN.Visible = true;

            btnHDN.BackgroundColor = SystemColors.GradientActiveCaption;
            btnHDN.ForeColor = Color.White;

            btnPhuTung.BackgroundColor = SystemColors.Control;
            btnPhuTung.ForeColor = SystemColors.ControlText;

            //btnAddHDN.BackgroundColor = SystemColors.Control;
            //btnAddHDN.ForeColor = SystemColors.ControlText;
            whatIsRunning = "HoaDonNhap";

        }

        private void btnPhuTung_Click(object sender, EventArgs e)
        {
            lblShowResult.Text = $"{currentPagePT}/{totalPagesPT}";
            lblChiTiet.Visible = false;
            if (panelDS.Visible == false)
            {
                panelDS.Visible = true;
            }

            if (panelHDN.Visible == true)
            {
                panelHDN.Visible = false;
            }

            dgvPhuTung.FirstDisplayedScrollingRowIndex = 0;

            foreach (DataGridViewColumn column in dgvPhuTung.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            dgvHDN.Visible = false;

            dgvPhuTung.Visible = true;

            btnPhuTung.BackgroundColor = SystemColors.GradientActiveCaption;
            btnPhuTung.ForeColor = Color.White;

            btnHDN.BackgroundColor = SystemColors.Control;
            btnHDN.ForeColor = SystemColors.ControlText;

            whatIsRunning = "PhuTung"; // sao thêm cái này vào bị lỗi nhỉ ( để đầu thì lỗi, đề cuối thì không)
        }


        private void btnAddHDN_Click(object sender, EventArgs e)
        {
            panelDS.Visible = false;

            panelHDN.Visible = true;


            btnHDN.BackgroundColor = SystemColors.Control;
            btnHDN.ForeColor = SystemColors.ControlText;

            btnPhuTung.BackgroundColor = SystemColors.Control;
            btnPhuTung.ForeColor = SystemColors.ControlText;
            txtManv.Text = _idLogin;
            txtHdn.Text = "MDN" + countHdn.ToString();
            txtNgayNhap.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
            thanhTien = 0;

            txtMaPhuTung.Clear();
            txtTenPhuTung.Clear();
            txtDonGiaNhap.Clear();
            txtDonGiaBan.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();
            foreach (Control ct in panelHDN.Controls)
            {
                if (ct is Label lb)
                {
                    if (lb.Name.Contains("lbWarning"))
                    {
                        lb.Visible = false;
                    }
                }
            }
            txtMaPhuTung.Text = "MPT";
        }
        bool coPhuTung;

        decimal thanhTien;
        private void btnThemPhuTung_Click(object sender, EventArgs e)
        {
            // kiem tra xem co chua

            if (txtMaPhuTung.Text == "") { lbWarningMa.Visible = true; return; }
            if (txtTenPhuTung.Text == "") { lbWarningTen.Visible = true; return; }
            if (txtDonGiaNhap.Text == "") { lbWarningGiaNhap.Visible = true; return; }
            if (txtSoLuong.Text == "") { lbWarningSL.Visible = true; return; }
            if (txtDonGiaBan.Text == "") { lbWarningGiaBan.Visible = true; return; }
            if (txtNgayNhap.Text == "") { lbWarningNgay.Visible = true; return; }


            string mahdn = txtHdn.Text;
            string maPt = txtMaPhuTung.Text;
            string tenPt = txtTenPhuTung.Text;
            string dgNhap = txtDonGiaNhap.Text;
            string dgBan = txtDonGiaBan.Text;
            string ngayNhap = txtNgayNhap.Text;

            decimal donGiaNhap;
            decimal donGiaBan;

            if(!decimal.TryParse(dgNhap, out donGiaNhap) || donGiaNhap < 0)
            {
                lbWarningGiaNhap1.Visible = true;
                txtDonGiaNhap.Clear();
                txtDonGiaNhap.Focus();
                return;
            }

            if (!decimal.TryParse(dgBan, out donGiaBan) || donGiaBan < 0)
            {
                lbWarningGiaBan1.Visible = true;
                txtDonGiaBan.Clear();
                txtDonGiaBan.Focus();
                return;
            }

            int soLuong;
            if(!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong < 0)
            {
                lbWarningSL1.Visible = true; 
                txtSoLuong.Clear();
                txtSoLuong.Focus();
                return;
            }

            thanhTien += donGiaNhap * soLuong;
            txtThanhTien.Text = thanhTien.ToString();

            foreach (Control ct in panelHDN.Controls)
            {
                if (ct is Label lb)
                {
                    if (lb.Name.Contains("lbWarning"))
                    {
                        lb.Visible = false;
                    }
                }
            }

            // HDN -> PHUTUNG -> CHITIET           
            bool themHdn = _hoaDonNhapBLL.ThemHoaDonNhap(new HoaDonNhapDTO(mahdn, _idLogin, DateTime.Parse(ngayNhap), thanhTien));

            if (themHdn)
            {
                MessageBox.Show("Thêm hóa đơn nhập");
            }
            // ton tai phu tung roi
            if (coPhuTung)
            {

                bool suaPt = _phuTungBLL.SuaSLPhuTung(maPt, soLuong);
                if (suaPt)
                {
                    //MessageBox.Show("Them so luong thanh cong");
                }
            }
            else
            {
                bool themPt = _phuTungBLL.ThemPhuTung(new PhuTungDTO(maPt, tenPt, soLuong, donGiaNhap, donGiaBan));
                if (themPt)
                {
                    //MessageBox.Show("Them duoc phu tung");
                }
            }

            bool themCt = _chiTietHoaDonNhapBLL.ThemHDN(new ChiTietHDNDTO(mahdn, maPt, soLuong));
            if (themCt)
            {
                MessageBox.Show("Thêm chi tiết hóa đơn", "Thông báo", MessageBoxButtons.OK);  
                
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK);
            }

            //txtHdn.Clear();
            txtMaPhuTung.Text = "MPT";
            txtTenPhuTung.Clear();
            txtDonGiaNhap.Clear();
            txtDonGiaBan.Clear();
            txtSoLuong.Clear();
            //txtNgayNhap.Clear();

            HienThiDSHoaDonNhap();
            HienThiDSPhuTung();
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

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel8, 15, BorderColor, BorderThickness, e);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel9, 15, BorderColor, BorderThickness, e);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel10, 15, BorderColor, BorderThickness, e);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel11, 15, BorderColor, BorderThickness, e);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel12, 15, BorderColor, BorderThickness, e);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel13, 15, BorderColor, BorderThickness, e);
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel17, 15, BorderColor, BorderThickness, e);
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel18, 15, BorderColor, BorderThickness, e);
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel19, 15, BorderColor, BorderThickness, e);
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel20, 15, BorderColor, BorderThickness, e);
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel21, 15, BorderColor, BorderThickness, e);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel5, 15, BorderColor, BorderThickness, e);
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if(whatIsRunning == "HoaDonNhap" && currentPageHDN < totalPagesHDN)
            {
                currentPageHDN++;
                DisplayCurrentPage_HoaDon(); 
            }
            else if(whatIsRunning == "PhuTung" && currentPagePT < totalPagesPT){
                currentPagePT++;
                DisplayCurrentPage_PhuTung(); 
            }
            
        }
        // 1 la phu tung
        private void btnPrevious_Click(object sender, EventArgs e)
        {

            if (whatIsRunning == "HoaDonNhap" && currentPageHDN > 1)
            {
                currentPageHDN--;
                DisplayCurrentPage_HoaDon();
            }
            else if (whatIsRunning == "PhuTung" && currentPagePT > 1)
            {
                currentPagePT--;
                DisplayCurrentPage_PhuTung();
            }        
        }

        private void panelDS_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panelDS, 15, BorderColor, BorderThickness, e);
        }

        private void panelHDN_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panelHDN, 15, BorderColor, BorderThickness, e);
        }

        private void dgvHDN_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHDN = dgvHDN.Rows[e.RowIndex].Cells["MaHDN"].Value.ToString();
                fChiTietHoaDonNhap x = new fChiTietHoaDonNhap(maHDN);
                x.Show();
            }
        }
    }
}
