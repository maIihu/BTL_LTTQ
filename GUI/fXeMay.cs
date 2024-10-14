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
using DTO;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class fXeMay : Form
    {
        private int pageSize = 10; 
        private int currentPage = 1;
        private int totalPages = 1;

        string idLogin;
        private XeMayBLL _xeMayBLL;
        private Font font = new Font("Segoe UI", 12, FontStyle.Bold);
        private Font fontSub = new Font("Segoe UI", 10, FontStyle.Regular);
        public int CornerRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
        public float BorderThickness { get; set; } = 0.5f;
        private bool addNewClicked = false, thongTinReveal = false, updateClicked = false;
        private Point posA = new Point(19, 80), posB = new Point(19, 227);

        private Size defaultDGVSize = new Size(1060, 402 + 227 - 80), smallerDGVSize = new Size(738, 402 + 227 - 80);
        private int rowIndex = -1;
        public fXeMay(string idLogin)
        {
            InitializeComponent();

            panelThongTin.Visible = false;

            panelThongTin.Location = new Point(763, posA.Y);

            _xeMayBLL = new XeMayBLL();

            panelAddNew.Visible = false;
            dgvXeMay.Location = posA;

            SetupAddPanel();
            dgvXeMay.Height += (227 - 80);

            cmbOrder.SelectedIndex = 0;
            this.idLogin = idLogin;
            SetupDataGridView();

            DoubleBuffering();
        }
        

        private void fXeMay_Load(object sender, EventArgs e)
        {
            ShowXeMayList();
        }
        private List<XeMayDTO> allXeMayList;
        private void ShowXeMayList()
        {
            allXeMayList = _xeMayBLL.LayDanhSachXeMay();
            totalPages = (int)Math.Ceiling((double)allXeMayList.Count / pageSize);
            currentPage = 1;

            DisplayCurrentPage();
        }

        private void DoubleBuffering()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dgvXeMay, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, panelFooter, new object[] { true });
        }

        private void DisplayCurrentPage()
        {
            var itemsToShow = allXeMayList.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            SetUpListXeMay(itemsToShow);

            lblShowResult.Text = $"Page {currentPage}/{totalPages}";
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBar.Text))
            {
                allXeMayList = _xeMayBLL.LayDanhSachXeMay(); 
            }
            else
            {
                allXeMayList = _xeMayBLL.TimXeMayTheoTen(txtSearchBar.Text);
            }

            currentPage = 1;

            totalPages = (int)Math.Ceiling((double)allXeMayList.Count / pageSize);

            DisplayCurrentPage();
        }

        private void SetupAddPanel()
        {

            dtpNgaySua.ValueChanged += (s, ev) =>
            {
                txtNgaySua.Text = dtpNgaySua.Value.ToString("dddd, dd/MM/yyyy");
            };
        }
        private void SetUpListXeMay(List<XeMayDTO> dsXeMay)
        {
            dgvXeMay.Rows.Clear();
            int i = (currentPage - 1) * pageSize + 1;
            foreach (var xe in dsXeMay)
            {
                dgvXeMay.Rows.Add(i++, xe.TenXe, xe.MaXe, xe.LoaiXe, xe.SoKhung, xe.SoMay, xe.BienSo, xe.MaMau);
            }
        }
        private void SetupDataGridView()
        {
            dgvXeMay.Size = defaultDGVSize;
            panelFooter.Width = defaultDGVSize.Width;
            thongTinReveal = false;

            dgvXeMay.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvXeMay.EnableHeadersVisualStyles = false;
            dgvXeMay.GridColor = Color.LightGray;
            dgvXeMay.ColumnHeadersDefaultCellStyle.BackColor = dgvXeMay.BackColor;
            dgvXeMay.ColumnHeadersDefaultCellStyle.ForeColor = dgvXeMay.ForeColor;

            dgvXeMay.DefaultCellStyle.SelectionBackColor = dgvXeMay.DefaultCellStyle.BackColor;
            dgvXeMay.DefaultCellStyle.SelectionForeColor = dgvXeMay.DefaultCellStyle.ForeColor;

            dgvXeMay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
            actionsColumn.Name = "Actions";
            actionsColumn.HeaderText = "";
            actionsColumn.Text = "...";
            actionsColumn.UseColumnTextForButtonValue = true;
            dgvXeMay.Columns.Add(actionsColumn);

            dgvXeMay.Columns["No"].FillWeight = 5;
            dgvXeMay.Columns["TenXe"].FillWeight = 20;
            dgvXeMay.Columns["MaXe"].FillWeight = 10;
            dgvXeMay.Columns["MaLoai"].FillWeight = 10;
            dgvXeMay.Columns["SoKhung"].FillWeight = 15;
            dgvXeMay.Columns["SoMay"].FillWeight = 15;
            dgvXeMay.Columns["BienSo"].FillWeight = 15;
            dgvXeMay.Columns["MaMau"].FillWeight = 10;
            dgvXeMay.Columns["Actions"].FillWeight = 5;

            dgvXeMay.RowTemplate.Height = 60;
            dgvXeMay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvXeMay.ColumnHeadersHeight = 60;

        }

        private void dgvXeMay_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private async Task ToggleAddNew()
        {
            if (!addNewClicked)
            {
                panelAddNew.Visible = true;
                await AnimateDataGridView(posB, dgvXeMay.Height - (227 - 80));
                
                addNewClicked = true;
            }
            else
            {
                
                await AnimateDataGridView(posA, dgvXeMay.Height + (227 - 80));
                panelAddNew.Visible = false;
                addNewClicked = false;
            }
        }

        private async Task AnimateDataGridView(Point targetPosition, int targetHeight)
        {
            int steps = 20;
            int stepX = (targetPosition.X - dgvXeMay.Location.X) / steps;
            int stepY = (targetPosition.Y - dgvXeMay.Location.Y) / steps;
            int stepHeight = (targetHeight - dgvXeMay.Height) / steps;

            for (int i = 0; i < steps; i++)
            {
                dgvXeMay.Location = new Point(dgvXeMay.Location.X + stepX, dgvXeMay.Location.Y + stepY);

                dgvXeMay.Height += stepHeight;

                await Task.Delay(5);
            }

            dgvXeMay.Location = targetPosition;
            dgvXeMay.Height = targetHeight;

			btnAddNew.Enabled = true;
		}

        private async Task AnimateDataGridView2(int targerWidth)
        {
            int steps = 10;
            int stepWidth = (dgvXeMay.Width - targerWidth) / steps;

            for (int i = 0; i < steps; i++)
            {
                dgvXeMay.Width -= stepWidth;
                panelFooter.Width -= stepWidth;

                Application.DoEvents();

                await Task.Delay(5);
            }

            dgvXeMay.Width = targerWidth;
            panelFooter.Width = targerWidth;
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

                panelThongTin.Visible = true;
                await AnimateDataGridView2(smallerDGVSize.Width);
                thongTinReveal = true;
            }
            else
            {
                
            }
        }


        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = false;

            ClearAddNewPanel();

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

        private void ClearAddNewPanel()
        {
            txtTenKH.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtMaXe.Text = String.Empty;
            txtNguyenNhan.Text = "Nguyên nhân sửa chữa";
            txtNgaySua.Text = String.Empty;
        }

        private void dtpNgaySua_DropDown(object sender, EventArgs e)
        {

        }

        private async void dgvXeMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in dgvXeMay.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.White;
                }

                dgvXeMay.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                dgvXeMay.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightBlue;

                if (e.ColumnIndex == dgvXeMay.Columns["Actions"].Index)
                {
                    var cellRectangle = dgvXeMay.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    rowIndex = e.RowIndex;
                    cmsXeMay.Show(dgvXeMay, cellRectangle.Left, cellRectangle.Bottom - 20);
                }
                else if (e.ColumnIndex != dgvXeMay.Columns["Actions"].Index)
                {
                    dgvXeMay.BringToFront();
                    await ToggleThongTin();
                }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel1, 15, BorderColor, BorderThickness, e);
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
            DrawRoundedPanel(pnRes, 15, BorderColor, BorderThickness, e);
        }

        private void panel16_Paint_1(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel16, 15, BorderColor, BorderThickness, e);
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

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedPanel(panel17, 15, BorderColor, BorderThickness, e);
        }

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

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == "Search by name, email, or orthers ...")
            {
                txtSearchBar.Text = string.Empty;
            }
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

        private async void btnXong_Click(object sender, EventArgs e)
        {
            panelThongTin.Visible = false;
            thongTinReveal = false;
            await AnimateDataGridView2(defaultDGVSize.Width);
        }

        private void txtSearchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBar.Text))
            {
                txtSearchBar.Text = "Search by name, email, or orthers ...";
            }
            if(string.IsNullOrWhiteSpace(txtSearchBar.Text) || txtSearchBar.Text == "Search by name, email, or orthers ...")
            {
                allXeMayList = _xeMayBLL.LayDanhSachXeMay();
                currentPage = 1; 
                totalPages = (int)Math.Ceiling((double)allXeMayList.Count / pageSize); 

                DisplayCurrentPage();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayCurrentPage();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayCurrentPage(); 
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            //format
            txtTenKH.Text = string.Empty;
            txtMaXe.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtNgaySua.Text = string.Empty;
            txtNguyenNhan.Text= "Nguyên nhân sửa chữa";
            txtSDT.Text = string.Empty;
            //

        }
    }
}
