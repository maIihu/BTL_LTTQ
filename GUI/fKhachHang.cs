using BLL;
using DAL;
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
    public partial class fKhachHang : Form
    {
        private int pageSize = 10;
        private int currentPage = 1;
        private int totalPages = 1;

        private string tenDangNhap;
        private Font font = new Font("Segoe UI", 12, FontStyle.Bold);
        private Font fontSub = new Font("Segoe UI", 10, FontStyle.Regular);
        public int CornerRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
        public float BorderThickness { get; set; } = 0.5f;
        private bool addNewClicked = false;
        private Point posA = new Point(19, 80), posB = new Point(19, 227);
        private string maKhachUpdate = "";

        KhachHangBLL _khachHangBLL;
        private List<KhachHangDTO> khachHangList;
        public fKhachHang(string tenDangNhap)
        {
            InitializeComponent();

            panelAddNew.Visible = false;
            dgvKhachHang.Location = posA;

            SetupAddPanel();
            dgvKhachHang.Height += (227 - 80);

            SetupDataGridView();

            this.tenDangNhap = tenDangNhap;
            _khachHangBLL = new KhachHangBLL();
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

        }
        private void fKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
        }
        private void DisplayCurrentPage()
        {
            var itemsToShow = khachHangList.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            ThemDuLieuKhachHang(itemsToShow);
            lbPage.Text = $"{currentPage}/{totalPages}";
        }
        private void HienThiDSKhachHang()
        {
            khachHangList = _khachHangBLL.GetCustomerList();
            totalPages = (int)Math.Ceiling((double)khachHangList.Count / pageSize);
            currentPage = 1;

            DisplayCurrentPage();
        }

        public void ThemDuLieuKhachHang(List<KhachHangDTO> listKhachHang)
        {
            dgvKhachHang.Rows.Clear();
            foreach(var x in listKhachHang){
                dgvKhachHang.Rows.Add(x.MaKhachHang, x.TenKhachHang, x.DiaChi, x.SoDienThoai);
            }
        }

        private void SetupDataGridView()
        {

            dgvKhachHang.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvKhachHang.GridColor = Color.LightGray;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = dgvKhachHang.BackColor;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = dgvKhachHang.ForeColor;

            dgvKhachHang.DefaultCellStyle.SelectionBackColor = dgvKhachHang.DefaultCellStyle.BackColor;
            dgvKhachHang.DefaultCellStyle.SelectionForeColor = dgvKhachHang.DefaultCellStyle.ForeColor;

            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn();
            actionsColumn.Name = "Actions";
            actionsColumn.HeaderText = "";
            actionsColumn.Text = "...";
            actionsColumn.UseColumnTextForButtonValue = true;
            dgvKhachHang.Columns.Add(actionsColumn);


            dgvKhachHang.Columns["TenKH"].FillWeight = 25;
            dgvKhachHang.Columns["MaKH"].FillWeight = 15;
            dgvKhachHang.Columns["SDT"].FillWeight = 15;
            dgvKhachHang.Columns["DiaChi"].FillWeight = 40;
            dgvKhachHang.Columns["Actions"].FillWeight = 5;

            dgvKhachHang.RowTemplate.Height = 60;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKhachHang.ColumnHeadersHeight = 60;
        }

        private void dgvKhachHang_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private async void ToggleAddNew()
        {
            if (!addNewClicked)
            {
                panelAddNew.Visible = true;
                await AnimateDataGridView(posB, dgvKhachHang.Height - (227 - 80));
                addNewClicked = true;
            }
            else
            {
                await AnimateDataGridView(posA, dgvKhachHang.Height + (227 - 80));
                panelAddNew.Visible = false;
                addNewClicked = false;
            }
        }

        private async Task AnimateDataGridView(Point targetPosition, int targetHeight)
        {
            int steps = 20;
            int stepX = (targetPosition.X - dgvKhachHang.Location.X) / steps;
            int stepY = (targetPosition.Y - dgvKhachHang.Location.Y) / steps;
            int stepHeight = (targetHeight - dgvKhachHang.Height) / steps;

            for (int i = 0; i < steps; i++)
            {
                dgvKhachHang.Location = new Point(dgvKhachHang.Location.X + stepX, dgvKhachHang.Location.Y + stepY);

                dgvKhachHang.Height += stepHeight;

                await Task.Delay(5);
            }

            dgvKhachHang.Location = targetPosition;
            dgvKhachHang.Height = targetHeight;

        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ToggleAddNew();
        }


        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKhachHang.Columns["Actions"].Index && e.RowIndex >= 0)
            {
                var cellRectangle = dgvKhachHang.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmsKhachHang.Show(dgvKhachHang, cellRectangle.Left, cellRectangle.Bottom - 20);
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvKhachHang.Rows[e.RowIndex];

                txtTenKH.Text = selectedRow.Cells["TenKH"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["Diachi"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["SDT"].Value.ToString();
                maKhachUpdate = selectedRow.Cells["MaKH"].Value.ToString();
                
                btnUpdate.Tag = selectedRow;
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if(panelAddNew.Visible == false)
            {
                ToggleAddNew();
            }
            
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells["TenKH"].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["Diachi"].Value.ToString();
                txtSDT.Text = dgvKhachHang.CurrentRow.Cells["SDT"].Value.ToString();
           
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string mkh = dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("bạn đã xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            DrawRoundedPanel(panel9, 15, BorderColor, BorderThickness, e);
        }

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == "Search...")
            {
                txtSearchBar.Text = string.Empty;
            }
        }

        private void txtSearchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBar.Text))
            {
                txtSearchBar.Text = "Search...";
            }
            if (string.IsNullOrWhiteSpace(txtSearchBar.Text) || txtSearchBar.Text == "Search...")
            {
                khachHangList =  _khachHangBLL.GetCustomerList();
                currentPage = 1;
                totalPages = (int)Math.Ceiling((double)khachHangList.Count / pageSize);

                DisplayCurrentPage();
            }
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBar.Text))
            {
                khachHangList = _khachHangBLL.GetCustomerList();    
            }
            else
            {
                khachHangList = _khachHangBLL.SearchCustomerByName(txtSearchBar.Text, txtSearchBar.Text);
                
            }
            currentPage = 1;

            totalPages = (int)Math.Ceiling((double)khachHangList.Count / pageSize);

            DisplayCurrentPage();
        }


        private void lbPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayCurrentPage();
            }
        }

        private void lbNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayCurrentPage();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string tenkh = txtTenKH.Text;
            if (tenkh.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string diachi = txtDiaChi.Text;
            if (diachi.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            string sdt = txtSDT.Text;
            if (sdt.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            bool ktsdt = sdt.Any(char.IsDigit);
            if (!ktsdt)
            {
                MessageBox.Show("Số điện thoại chỉ gồm chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            bool addCustomer = _khachHangBLL.UpdateCustomer(new KhachHangDTO(maKhachUpdate, tenkh, diachi, sdt));

            if (addCustomer)
            {

                MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                HienThiDSKhachHang();
            }

            ToggleAddNew();
        }



        
    }
}
