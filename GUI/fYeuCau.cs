using BLL;
using DTO;
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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class fYeuCau : Form
    {

        string idLogin;

        private DatYeuCauBLL _datYeuCauBLL;
        PhuTungBLL _phuTungBLL;
        XeMayBLL _xeMayBLL;
        HoaDonNhapBLL _hoaDonNhapBLL;
        HoaDonYeuCauBLL _hoaDonYeuCauBLL;

        private Font font = new Font("Segoe UI", 12, FontStyle.Bold);
        private Font fontSub = new Font("Segoe UI", 10, FontStyle.Regular);
        public int CornerRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
        public float BorderThickness { get; set; } = 0.5f;
        private bool addNewClicked = false, thongTinReveal = false, updateClicked = false;
        private Point posAy = new Point(19, 80), posBy = new Point(19, 227);
        private Size defaultDGVSize = new Size(1060, 402 + 227 - 80), smallerDGVSize = new Size(738, 402 + 227 - 80);
        private int status = 1;
        private bool isAddNew = true;
        private int rowIndex = -1;
        private Point panelPos = new Point(48, 118);

        int backIndex;
        Dictionary<string, int> soLuongDict = new Dictionary<string, int>();

        public fYeuCau(string idLogin)
        {
            InitializeComponent();
            panelHoaDon.Location = panelPos;
            panelHoaDon.Visible = false;
            panelThongTin.Visible = false;

            panelAddNew.Visible = false;
            dgvYeuCau.Location = posAy;
            panelThongTin.Location = new Point(763, posAy.Y);

            _datYeuCauBLL = new DatYeuCauBLL();
            _phuTungBLL = new PhuTungBLL();
            _xeMayBLL = new XeMayBLL();
            _hoaDonNhapBLL = new HoaDonNhapBLL();
            _hoaDonYeuCauBLL = new HoaDonYeuCauBLL();

            SetupAddPanel();

            SetupDataGridView();

            cmbOrder.SelectedIndex = 0;

            DoubleBuffering();

            this.idLogin = idLogin;
            SetupDataGridViewPhuTung();
            SetupDataGridViewKqPhuTung();
        }
        private void fYeuCau_Load(object sender, EventArgs e)
        {
            HienThiDSPhuTung();
        }
        private void SetupDataGridViewPhuTung()
        {
            dgvPhuTung.EnableHeadersVisualStyles = false;
            dgvPhuTung.GridColor = Color.LightGray;
            dgvPhuTung.ColumnHeadersDefaultCellStyle.BackColor = dgvPhuTung.BackColor;
            dgvPhuTung.ColumnHeadersDefaultCellStyle.ForeColor = dgvPhuTung.ForeColor;
            dgvPhuTung.DefaultCellStyle.SelectionBackColor = dgvPhuTung.DefaultCellStyle.BackColor;
            dgvPhuTung.DefaultCellStyle.SelectionForeColor = dgvPhuTung.DefaultCellStyle.ForeColor;
            dgvPhuTung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhuTung.Columns["MaPhuTung"].FillWeight = 20;
            dgvPhuTung.Columns["PhuTung"].FillWeight = 25;
            dgvPhuTung.Columns["SoLuong"].FillWeight = 10;
            dgvPhuTung.Columns["Gia"].FillWeight = 15;
            dgvPhuTung.Columns["PhuTung"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhuTung.Columns["Gia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPhuTung.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPhuTung.RowTemplate.Height = 60;
            dgvPhuTung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPhuTung.ColumnHeadersHeight = 60;
            dgvPhuTung.Rows.Clear();
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
        private void HienThiDSPhuTung()
        {
            List<PhuTungDTO> listPhuTung = _phuTungBLL.LayDSPhuTung();
            ThemDuLieuPhuTung(listPhuTung);
        }
        private void ThemDuLieuPhuTung(List<PhuTungDTO> dsPhuTung)
        {
            dgvPhuTung.Rows.Clear();

            foreach (var phuTung in dsPhuTung)
            {
                dgvPhuTung.Rows.Add(phuTung.MaPhuTung, phuTung.TenPhuTung, phuTung.SoLuong, phuTung.DonGiaBan);
            }
        }
        private void SetupAddPanel()
        {
            /*panelAddNew.Controls.Add(label2);
            panelAddNew.Controls.Add(label3);
            panelAddNew.Controls.Add(label4);
            panelAddNew.Controls.Add(label5);
            panelAddNew.Controls.Add(label6);
            panelAddNew.Controls.Add(panel7);
            panelAddNew.Controls.Add(panel8);
            panelAddNew.Controls.Add(panel9);
            panelAddNew.Controls.Add(panel10);
            panelAddNew.Controls.Add(panel11);
            panelAddNew.Controls.Add(panel12);
            panelAddNew.Controls.Add(panel14);
            panelAddNew.Controls.Add(txtTenKH);
            panelAddNew.Controls.Add(txtSDT);
            panelAddNew.Controls.Add(txtDiaChi);
            panelAddNew.Controls.Add(txtMaXe);
            panelAddNew.Controls.Add(txtNguyenNhan);
            panelAddNew.Controls.Add(txtNgaySua);
            panelAddNew.Controls.Add(btnAdd);*/
            dtpNgaySua.ValueChanged += (s, ev) =>
            {
                txtNgaySua.Text = dtpNgaySua.Value.ToString("dddd, dd/MM/yyyy");
            };
        }

        private void DoubleBuffering()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dgvYeuCau, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, panelFooter, new object[] { true });
        }

        private void SetupDataGridView()
        {
            dgvYeuCau.Size = defaultDGVSize;
            panelFooter.Width = defaultDGVSize.Width;
            thongTinReveal = false;

            dgvYeuCau.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvYeuCau.EnableHeadersVisualStyles = false;
            dgvYeuCau.GridColor = Color.LightGray;
            dgvYeuCau.ColumnHeadersDefaultCellStyle.BackColor = dgvYeuCau.BackColor;
            dgvYeuCau.ColumnHeadersDefaultCellStyle.ForeColor = dgvYeuCau.ForeColor;

            dgvYeuCau.DefaultCellStyle.SelectionBackColor = dgvYeuCau.DefaultCellStyle.BackColor;
            dgvYeuCau.DefaultCellStyle.SelectionForeColor = dgvYeuCau.DefaultCellStyle.ForeColor;

            dgvYeuCau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
            actionsColumn.Name = "Actions";
            actionsColumn.HeaderText = "";
            actionsColumn.Text = "...";
            actionsColumn.UseColumnTextForButtonValue = true;
            dgvYeuCau.Columns.Add(actionsColumn);


            dgvYeuCau.Columns["MaBooking"].FillWeight = 10;
            dgvYeuCau.Columns["TenKH"].FillWeight = 25;
            dgvYeuCau.Columns["MaXe"].FillWeight = 10;
            dgvYeuCau.Columns["NguyenNhan"].FillWeight = 30;
            dgvYeuCau.Columns["NgaySua"].FillWeight = 20;
            dgvYeuCau.Columns["Actions"].FillWeight = 5;

            dgvYeuCau.RowTemplate.Height = 60;
            dgvYeuCau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvYeuCau.ColumnHeadersHeight = 60;

            ListYeuCau();

        }

        private void ListYeuCau()
        {
            dgvYeuCau.Rows.Clear();

            List<DatYeuCauDTO> dsYeuCau = _datYeuCauBLL.GetListYeuCau();
            foreach (var yeuCau in dsYeuCau)
            {
                dgvYeuCau.Rows.Add(yeuCau.MaSuaChua, yeuCau.TenKhachHang, yeuCau.MaXe, yeuCau.NguyenNhan, yeuCau.NgaySua, yeuCau.MaKhachHang, yeuCau.DiaChi, yeuCau.SoDienThoai);
            }
        }

        private void dgvYeuCau_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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


        /*private void SetStatus()
		{
			if(status == 1)
			{
				panelToDo.BackColor = Color.Black;
				panelToDo.ForeColor = Color.White;

				panelDoing.BackColor = SystemColors.GradientActiveCaption;
				panelDoing.ForeColor = Color.Black;

				panelDone.BackColor = SystemColors.GradientActiveCaption;
				panelDone.ForeColor = Color.Black;
			} 
			else if(status == 2)
			{
				panelDoing.BackColor = Color.Black;
				panelDoing.ForeColor = Color.White;

				panelDone.BackColor = SystemColors.GradientActiveCaption;
				panelDone.ForeColor = Color.Black;

				panelToDo.BackColor = SystemColors.GradientActiveCaption;
				panelToDo.ForeColor = Color.Black;
			}
			else if(status == 3)
			{
				panelDone.BackColor = Color.Black;
				panelDone.ForeColor = Color.White;

				panelToDo.BackColor = SystemColors.GradientActiveCaption;
				panelToDo.ForeColor = Color.Black;

				panelDoing.BackColor = SystemColors.GradientActiveCaption;
				panelDoing.ForeColor = Color.Black;
			}
		}*/

        private async Task AnimateDataGridView(Point targetPosition, int targetHeight)
        {
            int steps = 20;
            int stepX = (targetPosition.X - dgvYeuCau.Location.X) / steps;
            int stepY = (targetPosition.Y - dgvYeuCau.Location.Y) / steps;
            int stepHeight = (targetHeight - dgvYeuCau.Height) / steps;

            for (int i = 0; i < steps; i++)
            {
                dgvYeuCau.Location = new Point(dgvYeuCau.Location.X + stepX, dgvYeuCau.Location.Y + stepY);

                dgvYeuCau.Height += stepHeight;

                await Task.Delay(5);
            }

            dgvYeuCau.Location = targetPosition;
            dgvYeuCau.Height = targetHeight;

            btnAddNew.Enabled = true;
        }

        private async Task AnimateDataGridView2(int targerWidth)
        {
            int steps = 10;
            int stepWidth = (dgvYeuCau.Width - targerWidth) / steps;

            for (int i = 0; i < steps; i++)
            {
                dgvYeuCau.Width -= stepWidth;
                panelFooter.Width -= stepWidth;

                Application.DoEvents();

                await Task.Delay(5);
            }

            dgvYeuCau.Width = targerWidth;
            panelFooter.Width = targerWidth;
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = false;

            ClearAddNewPanel();

            isAddNew = true;
            btnAdd.Text = "Thêm";
            lbBienSo.Text = "Biển số";
            txtMaXe.Enabled = true;
            dtpNgaySua.Enabled = true;
            txtNgaySua.Enabled = true;


            if (addNewClicked)
            {
                await ToggleAddNew();

                addNewClicked = false;
            }
            else
            {
                if (!updateClicked)
                {
                    btnAddNew.Enabled = false;

                    panelThongTin.Visible = false;
                    thongTinReveal = false;
                    await AnimateDataGridView2(defaultDGVSize.Width);

                    await ToggleAddNew();
                }
                else
                {
                    updateClicked = false;
                }

                addNewClicked = true;
            }

            btnAddNew.Enabled = true;
        }

        private async void Update_Click(object sender, EventArgs e)
        {
            ClearAddNewPanel();

            isAddNew = false;
            btnAdd.Text = "Sửa";

            lbBienSo.Text = "Mã Xe";
            txtMaXe.Enabled = false;
            dtpNgaySua.Enabled = false;
            txtNgaySua.Enabled = false;

            if (updateClicked)
            {
                /*updateClicked = false;
				btnAddNew.Enabled = false;
				await ToggleAddNew();*/
            }
            else
            {
                if (!addNewClicked)
                {
                    btnAddNew.Enabled = false;
                    await ToggleAddNew();
                }
                else
                {
                    addNewClicked = false;
                }
                updateClicked = true;
            }

            if (rowIndex >= 0)
            {
                //rowIndex
                txtTenKH.Text = dgvYeuCau.Rows[rowIndex].Cells["TenKH"].Value.ToString();
                //txtSDT.Text = dgvYeuCau.Rows[rowIndex].Cells["TenKH"].Value.ToString();
                txtMaXe.Text = dgvYeuCau.Rows[rowIndex].Cells["MaXe"].Value.ToString();
                txtNguyenNhan.Text = dgvYeuCau.Rows[rowIndex].Cells["NguyenNhan"].Value.ToString();
                txtNgaySua.Text = dgvYeuCau.Rows[rowIndex].Cells["NgaySua"].Value.ToString();
                txtDiaChi.Text = dgvYeuCau.Rows[rowIndex].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvYeuCau.Rows[rowIndex].Cells["SoDienThoai"].Value.ToString();
            }
        }

        private async Task ToggleAddNew()
        {
            if (addNewClicked || updateClicked)
            {
                if (thongTinReveal)
                {
                    await ToggleThongTin();
                    thongTinReveal = false;
                }

                await AnimateDataGridView(posAy, dgvYeuCau.Height + (227 - 80));
                panelAddNew.Visible = false;
            }
            else if (!addNewClicked && !updateClicked)
            {
                if (thongTinReveal)
                {
                    await ToggleThongTin();
                    thongTinReveal = false;
                }

                panelAddNew.Visible = true;
                await AnimateDataGridView(posBy, dgvYeuCau.Height - (227 - 80));
            }
        }

        private async Task ToggleThongTin()
        {
            if (!thongTinReveal)
            {
                if (addNewClicked || updateClicked)
                {
                    await ToggleAddNew();
                    addNewClicked = false;
                    updateClicked = false;
                }

                try
                {
                    imgXe.Image = (Image)Properties.Resources.ResourceManager.GetObject(maXeChon);

                    if (imgXe.Image == null)
                    {
                        imgXe.Image = Properties.Resources.bike;
                    }
                }
                catch
                {
                    imgXe.Image = Properties.Resources.bike;
                }

                panelThongTin.Visible = true;

                await AnimateDataGridView2(smallerDGVSize.Width);
                thongTinReveal = true;
            }
            else
            {
                try
                {
                    imgXe.Image = (Image)Properties.Resources.ResourceManager.GetObject(maXeChon);

                    if (imgXe.Image == null)
                    {
                        imgXe.Image = Properties.Resources.bike;
                    }
                }
                catch
                {
                    imgXe.Image = Properties.Resources.bike;
                }

            }
            lblMaXe.Text = maXeChon;
            XeMayDTO xemay = _xeMayBLL.LayXeTheoMa(maXeChon);
            txtTenXe.Text = xemay.TenXe;
            txtSoKhung.Text = xemay.SoKhung;
            txtSoMay.Text = xemay.SoMay;
            txtBienSo.Text = xemay.BienSo;
        }


        string maXeChon, maSuaChuaChon, maKhachHangChon, tenKhachHangChon;
        private async void dgvYeuCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dgvYeuCau.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.White;
                }

                dgvYeuCau.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                dgvYeuCau.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightBlue;

                if (e.ColumnIndex == dgvYeuCau.Columns["Actions"].Index)
                {
                    var cellRectangle = dgvYeuCau.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    rowIndex = e.RowIndex;
                    cmsYeuCau.Show(dgvYeuCau, cellRectangle.Left, cellRectangle.Bottom - 20);
                }
                else if (e.ColumnIndex != dgvYeuCau.Columns["Actions"].Index)
                {
                    dgvYeuCau.BringToFront();
                    maXeChon = dgvYeuCau.Rows[e.RowIndex].Cells["MaXe"].Value.ToString();
                    maSuaChuaChon = dgvYeuCau.Rows[e.RowIndex].Cells["MaBooking"].Value.ToString();
                    maKhachHangChon = dgvYeuCau.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
                    tenKhachHangChon = dgvYeuCau.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();

                    await ToggleThongTin();
                }
            }
        }



        private void Delete_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string MaSuaChua = dgvYeuCau.Rows[rowIndex].Cells["MaBooking"].Value.ToString();
                    string MaXe = dgvYeuCau.Rows[rowIndex].Cells["MaXe"].Value.ToString();
                    _datYeuCauBLL.DeleteYeuCau(MaSuaChua, MaXe);
                    ListYeuCau();
                    dgvYeuCau.Refresh();
                }
            }
        }

        private void ClearAddNewPanel()
        {
            txtTenKH.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtMaXe.Text = String.Empty;
            txtNguyenNhan.Text = "Nguyên nhân sửa chữa";
            txtNgaySua.Text = String.Empty;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panelYeuCau, 15, BorderColor, BorderThickness, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel2, 15, BorderColor, BorderThickness, e);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel4, 15, BorderColor, BorderThickness, e);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel5, 15, BorderColor, BorderThickness, e);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel6, 15, BorderColor, BorderThickness, e);
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel3, 15, BorderColor, BorderThickness, e);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel14, 15, BorderColor, BorderThickness, e);
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel16, 15, BorderColor, BorderThickness, e);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel15, 15, BorderColor, BorderThickness, e);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel1, 15, BorderColor, BorderThickness, e);
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel27, 15, BorderColor, BorderThickness, e);
        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel28, 15, BorderColor, BorderThickness, e);
        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel29, 15, BorderColor, BorderThickness, e);
        }

        /*private void panel17_Paint(object sender, PaintEventArgs e)
		{
			DrawRoundedPanel(panel17, 15, BorderColor, BorderThickness, e);
		}*/

        private void txtNguyenNhan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNguyenNhan.Text))
            {
                txtNguyenNhan.Text = "Nguyên nhân sửa chữa";
            }
        }

        private void txtNguyenNhan_Enter(object sender, EventArgs e)
        {
            if (txtNguyenNhan.Text == "Nguyên nhân sửa chữa")
            {
                txtNguyenNhan.Text = string.Empty;
            }
        }

        private void cmsYeuCau_Opening(object sender, CancelEventArgs e)
        {

        }


        private void txtSearchBar_Enter(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == "Search by name, email, or orthers ...")
            {
                txtSearchBar.Text = String.Empty;
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            panelYeuCau.Visible = false;
            panelHoaDon.Visible = true;
            txtNgayIn.Text = DateTime.Today.ToString();
            txtMaSuaChua.Text = maSuaChuaChon;
            txtTen.Text = tenKhachHangChon;
            txtMaKH.Text = maKhachHangChon;
            txtMaNV.Text = idLogin;
        }

        private async void btnExitPanel_Click(object sender, EventArgs e)
        {
            if (panelThongTin.Visible)
            {
                panelThongTin.Visible = false;
                thongTinReveal = false;
                await AnimateDataGridView2(defaultDGVSize.Width);
            }
            else
            {
                await ToggleThongTin();
            }
        }

        private void txtTenXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPhuTung_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvPhuTung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPhuTung.Rows[e.RowIndex];
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
                    dgvPhuTung.FirstDisplayedScrollingRowIndex = backIndex;
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

                dgvPhuTung.FirstDisplayedScrollingRowIndex = backIndex;
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

        private void txtSearchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBar.Text))
            {
                txtSearchBar.Text = "Search by name, email, or orthers ...";
            }
            if (string.IsNullOrWhiteSpace(txtSearchBar.Text) || txtSearchBar.Text == "Search by name, email, or orthers ...")
            {
                ListYeuCau();
            }
        }
        #region
        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {

            string searchText = txtSearchBar.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(searchText) || searchText == "Search by name, email, or orthers ...")
            {
                foreach (DataGridViewRow row in dgvYeuCau.Rows)
                {
                    row.Visible = true;
                }
                ListYeuCau();

            }
            else
            {
                string[] searchKeywords = searchText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (DataGridViewRow row in dgvYeuCau.Rows)
                {
                    bool isVisible = true;
                    foreach (string keyword in searchKeywords)
                    {
                        bool keywordInRow = row.Cells["TenKH"].Value.ToString().ToLower().Contains(keyword) ||
                                            row.Cells["SoDienThoai"].Value.ToString().ToLower().Contains(keyword) ||
                                            row.Cells["MaXe"].Value.ToString().ToLower().Contains(keyword);

                        if (!keywordInRow)
                        {
                            isVisible = false;
                            break;
                        }
                    }
                    row.Visible = isVisible;
                }
            }

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (isAddNew)
            {
                if (CheckTextBox(panelAddNew))
                {
                    string tenKhachHang = txtTenKH.Text;
                    string maXe = txtMaXe.Text;
                    string nguyenNhan = txtNguyenNhan.Text;
                    DateTime ngaySua = dtpNgaySua.Value;
                    string diaChi = txtDiaChi.Text;
                    string soDienThoai = txtSDT.Text;

                    if (soDienThoai.Length != 10 || !soDienThoai.All(char.IsDigit))
                    {
                        MessageBox.Show("Số điện thoại phải là 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    bool success = _datYeuCauBLL.AddYeuCau(tenKhachHang, maXe, nguyenNhan, ngaySua, diaChi, soDienThoai);
                    if (success)
                    {
                        MessageBox.Show("Thêm yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvYeuCau.Rows.Clear();
                        ListYeuCau();
                    }
                    else
                    {
                        MessageBox.Show("Thêm yêu cầu thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                string tenKhachHang = txtTenKH.Text;
                string nguyenNhan = txtNguyenNhan.Text;
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSDT.Text;
                string maKhachHang = dgvYeuCau.Rows[rowIndex].Cells["MaKhachHang"].Value.ToString();
                string maSuaChua = dgvYeuCau.Rows[rowIndex].Cells["MaBooking"].Value.ToString();

                bool success = _datYeuCauBLL.UpdateYeuCau(tenKhachHang, nguyenNhan, diaChi, soDienThoai, maKhachHang, maSuaChua);
                if (success)
                {
                    MessageBox.Show("Sửa yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListYeuCau();
                    rowIndex = -1;
                }
                else
                {
                    MessageBox.Show("Thêm yêu cầu thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rowIndex = -1;
                }


            }
        }
        private bool CheckTextBox(Panel panel)
        {
            bool allFill = true;

            foreach (Control control in panel.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        allFill = false;
                        break;
                    }
                }
            }

            if (!allFill)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào tất cả các ô.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return allFill;
        }

        #endregion
    }
}
