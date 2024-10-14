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
        DatYeuCauBLL _datYeuCauBLL;
        private HoaDonYeuCauBLL _hoaDonYeuCauBLL;
        YeuCauSuaChuaBLL _yeuCauSuaChuaBLL;

        int amountPt = 0;
        int amountHdYeuCau;

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

            SetupDataGridViewCMS();
            SetupDataGridViewKqPhuTung();

            ListHoaDon();

            panelChiTiet.Location = panelPos;
            panelChiTiet.Visible = false;

            cmbOrder.SelectedIndex = 0;
            this.idLogin = idLogin;
        }
        private void fHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDSPhuTung();
            HienThiDSHoaDonYeuCau();
        }
        private void ThemDuLieuPhuTung(List<PhuTungDTO> dsPhuTung)
        {
            dgvCMSHoaDon.Rows.Clear();

            foreach (var phuTung in dsPhuTung)
            {
                dgvCMSHoaDon.Rows.Add(phuTung.MaPhuTung, phuTung.TenPhuTung, phuTung.SoLuong,  phuTung.DonGiaBan);
            }
        }
        private void HienThiDSHoaDonYeuCau()
        {
            List<HoaDonYeuCauDTO> listHDYeuCau = _hoaDonYeuCauBLL.GetListHoaDon();
            // hien thi ds tai day...
            amountHdYeuCau = listHDYeuCau.Count;
        }
        private void HienThiDSPhuTung()
        {
            List<PhuTungDTO> listPhuTung = _phuTungBLL.LayDSPhuTung();
            ThemDuLieuPhuTung(listPhuTung);
            amountPt = listPhuTung.Count;
        }

        int backIndex;
        Dictionary<string, int> soLuongDict = new Dictionary<string, int>();


        private void dgvCMSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCMSHoaDon.Rows[e.RowIndex];
                string maPhuTung = selectedRow.Cells["MaPhuTung"].Value?.ToString();
                string tenPhuTung = selectedRow.Cells["PhuTung"].Value?.ToString();
                decimal giaBan = decimal.Parse(selectedRow.Cells["Gia"].Value?.ToString());
                int soLuong1 = int.Parse(selectedRow.Cells["SoLuong"].Value?.ToString());
                if (!soLuongDict.ContainsKey(maPhuTung))
                {
                    soLuongDict[maPhuTung] = 0;
                }

                if (soLuong1 > 0)
                {
                    soLuongDict[maPhuTung]++;
                    _phuTungBLL.SuaPhuTung(maPhuTung, -1);
                    HienThiDSPhuTung();

                    decimal tongTien = giaBan * soLuongDict[maPhuTung];

                    bool itemExists = false;
                    foreach (DataGridViewRow item in dgvKqPhuTung.Rows)
                    {
                        if (item.Cells["Ma"].Value?.ToString() == maPhuTung)
                        {
                            item.Cells["So"].Value = soLuongDict[maPhuTung].ToString();
                            item.Cells["ThanhTien"].Value = tongTien.ToString();
                            itemExists = true;
                            break;
                        }
                    }

                    if (!itemExists)
                    {
                        int newRowIndex = dgvKqPhuTung.Rows.Add();
                        DataGridViewRow newRow = dgvKqPhuTung.Rows[newRowIndex];
                        newRow.Cells["Ma"].Value = maPhuTung;
                        newRow.Cells["Ten"].Value = tenPhuTung;
                        newRow.Cells["So"].Value = soLuongDict[maPhuTung].ToString();
                        newRow.Cells["ThanhTien"].Value = tongTien.ToString();
                    }

                    backIndex = e.RowIndex;
                    if (backIndex > 0) backIndex--;
                    dgvCMSHoaDon.FirstDisplayedScrollingRowIndex = backIndex;
                }

            }
        }
        private void dgvKqPhuTung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKqPhuTung.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvKqPhuTung.Rows[e.RowIndex];
                string maPhuTung = selectedRow.Cells["Ma"].Value?.ToString();
                int soLuong1 = int.Parse(selectedRow.Cells["So"].Value?.ToString());

                if (soLuongDict.ContainsKey(maPhuTung))
                {
                    soLuongDict[maPhuTung] -= soLuong1;
                    if (soLuongDict[maPhuTung] <= 0)
                    {
                        soLuongDict.Remove(maPhuTung);
                    }
                }

                dgvKqPhuTung.Rows.RemoveAt(e.RowIndex);
                _phuTungBLL.SuaPhuTung(maPhuTung, soLuong1);
                HienThiDSPhuTung();

                dgvCMSHoaDon.FirstDisplayedScrollingRowIndex = backIndex;
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


            dgvHoaDon.Columns["MaBooking"].FillWeight = 13;
            dgvHoaDon.Columns["TenKH"].FillWeight = 20;
            dgvHoaDon.Columns["MaXe"].FillWeight = 12;
            dgvHoaDon.Columns["MaKhachHang"].FillWeight = 5;
            dgvHoaDon.Columns["Actions"].FillWeight = 5;

            dgvHoaDon.RowTemplate.Height = 60;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHoaDon.ColumnHeadersHeight = 60;

            dgvHoaDon.Rows.Clear();
        }

        private void SetupDataGridViewCMS()
        {

            dgvCMSHoaDon.EnableHeadersVisualStyles = false;
            dgvCMSHoaDon.GridColor = Color.LightGray;
            dgvCMSHoaDon.ColumnHeadersDefaultCellStyle.BackColor = dgvCMSHoaDon.BackColor;
            dgvCMSHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = dgvCMSHoaDon.ForeColor;

            dgvCMSHoaDon.DefaultCellStyle.SelectionBackColor = dgvCMSHoaDon.DefaultCellStyle.BackColor;
            dgvCMSHoaDon.DefaultCellStyle.SelectionForeColor = dgvCMSHoaDon.DefaultCellStyle.ForeColor;

            dgvCMSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvCMSHoaDon.Columns["MaPhuTung"].FillWeight = 20;
            dgvCMSHoaDon.Columns["PhuTung"].FillWeight = 25;
            dgvCMSHoaDon.Columns["SoLuong"].FillWeight = 10;
            dgvCMSHoaDon.Columns["Gia"].FillWeight = 15;

            dgvCMSHoaDon.Columns["PhuTung"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCMSHoaDon.Columns["Gia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCMSHoaDon.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvCMSHoaDon.RowTemplate.Height = 60;
            dgvCMSHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCMSHoaDon.ColumnHeadersHeight = 60;

            dgvCMSHoaDon.Rows.Clear();
        }

        private void SetupDataGridViewKqPhuTung()
        {
            dgvKqPhuTung.EnableHeadersVisualStyles = false;
            dgvKqPhuTung.GridColor = Color.LightGray;
            dgvKqPhuTung.ColumnHeadersDefaultCellStyle.BackColor = dgvKqPhuTung.BackColor;
            dgvKqPhuTung.ColumnHeadersDefaultCellStyle.ForeColor = dgvKqPhuTung.ForeColor;

            dgvKqPhuTung.DefaultCellStyle.SelectionBackColor = dgvKqPhuTung.DefaultCellStyle.BackColor;
            dgvKqPhuTung.DefaultCellStyle.SelectionForeColor = dgvKqPhuTung.DefaultCellStyle.ForeColor;

            dgvKqPhuTung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
            actionsColumn.Name = "Actions";
            actionsColumn.HeaderText = "";
            actionsColumn.Text = "X";
            actionsColumn.UseColumnTextForButtonValue = true;

            dgvKqPhuTung.Columns.Add(actionsColumn);

            // Thiết lập font cho actionsColumn sau khi nó được thêm vào
            dgvKqPhuTung.Columns["Actions"].DefaultCellStyle.Font = new Font("Arial", 10); // Giảm kích thước font
            dgvKqPhuTung.Columns["Actions"].DefaultCellStyle.ForeColor = Color.Red; // Đặt màu chữ là đỏ

            dgvKqPhuTung.Columns["Ma"].FillWeight = 15;
            dgvKqPhuTung.Columns["Ten"].FillWeight = 20;
            dgvKqPhuTung.Columns["So"].FillWeight = 10;
            dgvKqPhuTung.Columns["ThanhTien"].FillWeight = 15;
            dgvKqPhuTung.Columns["Actions"].FillWeight = 5;

            //dgvKqPhuTung.Columns["PhuTung"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvKqPhuTung.Columns["Gia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvKqPhuTung.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvKqPhuTung.RowTemplate.Height = 40;
            dgvKqPhuTung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKqPhuTung.ColumnHeadersHeight = 60;

            dgvKqPhuTung.Rows.Clear();
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

        private void cmsItemChiTiet_Click(object sender, EventArgs e)
        {
            panelChiTiet.Visible = true;
            panelDSHoaDon.Visible = false;
            txtNgayIn.Text = DateTime.Today.ToString();

            DataGridViewRow selectedRow = dgvHoaDon.Rows[rowIndex];

            txtMaSuaChua.Text = selectedRow.Cells["MaBooking"].Value.ToString();
            txtTenKH.Text = selectedRow.Cells["TenKH"].Value.ToString();
            txtMaKH.Text = selectedRow.Cells["MaKhachHang"].Value.ToString();
            txtMaNV.Text = idLogin;

        }

        private void cmsItemSua_Click(object sender, EventArgs e)
        {
            //lay thong tin bang rowIndex
        }

        private void cmsItemXoa_Click(object sender, EventArgs e)
        {
            //lay thong tin bang rowIndex
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            panelDSHoaDon.Visible = true;
            panelChiTiet.Visible = false;
        }

        private void btnOKHoaDon_Click(object sender, EventArgs e)
        {
            if (txtGiaiPhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giải pháp!");
                return;
            }
            string maHoaDon_Chinh = null;
            foreach (DataGridViewRow row in dgvKqPhuTung.Rows)
            {
                if (!row.IsNewRow)
                {
                    string maPhuTung = row.Cells["Ma"].Value?.ToString(); 
                    string tenPhuTung = row.Cells["Ten"].Value?.ToString(); 
                    int soLuong = int.Parse(row.Cells["So"].Value?.ToString() ?? "0");
                    decimal thanhTien = decimal.Parse(row.Cells["ThanhTien"].Value?.ToString() ?? "0"); 


                    DateTime ngayIn = DateTime.Parse(txtNgayIn.Text);
                   
                    bool themHd = _hoaDonYeuCauBLL.ThemHoaDon(maHoaDon_Chinh, idLogin, maPhuTung, txtMaSuaChua.Text, 
                        ngayIn, txtGiaiPhap.Text, soLuong, thanhTien);
                    if (themHd)
                    {
                         maHoaDon_Chinh = _hoaDonYeuCauBLL.GetMaHoaDon(txtMaSuaChua.Text);
                        txtMaHoaDon.Text = maHoaDon_Chinh;
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {

                    }
                }
            }

        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel2, 15, BorderColor, BorderThickness, e);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel4, 15, BorderColor, BorderThickness, e);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel6, 15, BorderColor, BorderThickness, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel1, 15, BorderColor, BorderThickness, e);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel5, 15, BorderColor, BorderThickness, e);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel7, 15, BorderColor, BorderThickness, e);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel8, 15, BorderColor, BorderThickness, e);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel9, 30, BorderColor, BorderThickness, e);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel10, 15, BorderColor, BorderThickness, e);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel12, 15, BorderColor, BorderThickness, e);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel13, 15, BorderColor, BorderThickness, e);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel3, 15, BorderColor, BorderThickness, e);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int borderWidth = 2; // Độ dày của đường viền

            // Vẽ đường viền trên
            using (Pen pen = new Pen(Color.Black, borderWidth))
            {
                e.Graphics.DrawLine(pen, 0, 0, panel.Width, 0); // Vẽ đường từ (0,0) đến (panel.Width, 0)
            }
        }

        #region

        private void ListHoaDon()
        {
            dgvHoaDon.Rows.Clear();
            List<HoaDonYeuCauDTO> dsHoaDon = _hoaDonYeuCauBLL.GetListHoaDon();
            foreach (var hoaDon in dsHoaDon)
            {
                dgvHoaDon.Rows.Add(hoaDon.MaSuaChua, hoaDon.TenKhachHang, hoaDon.MaXe, hoaDon.MaKhachHang);
            }
        }


        #endregion

        private void dgvCMSHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvCMSHoaDon.SelectedCells.Count > 0) {
                
            }
        }

        private void dgvKqPhuTung_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                Font consistentFont = new Font("Segoe UI", 10, FontStyle.Bold);
                e.CellStyle.Font = consistentFont;

                if (e.ColumnIndex == dgvKqPhuTung.Columns["Actions"].Index)
                {
                    e.Handled = true;
                    e.PaintBackground(e.ClipBounds, true);
                    string cellValue = e.Value?.ToString() ?? string.Empty;

                    if (cellValue != string.Empty)
                    {
                        Rectangle rect = e.CellBounds;
                        using (Brush brush = new SolidBrush(Color.Red)) 
                        {
                            e.Graphics.DrawString(cellValue, consistentFont, brush, rect.X + 5, rect.Y + 5);
                        }
                    }
                }
                else
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                }
            }
        }





    }
}
