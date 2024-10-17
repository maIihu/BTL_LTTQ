using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class fTaiKhoan : Form
    {
        public event Action<Image> ImageChanged; 

        private void UpdateImage(Image newImage)
        {
            pictureBoxAvt.Image = newImage;
            // Kích hoạt sự kiện để thông báo hình ảnh đã thay đổi
            ImageChanged?.Invoke(newImage);
            SaveImageToProjectResources(newImage);
        }
        public void LoadUserImage(string userId)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserImages"); 
            string imagePath = Path.Combine(folderPath, $"UserImage_{userId}.png"); 

            if (File.Exists(imagePath))
            {
                pictureBoxAvt.Image = Image.FromFile(imagePath); // Hiển thị ảnh
            }
            else
            {
                // Hiển thị ảnh mặc định nếu không có ảnh
                pictureBoxAvt.Image = Properties.Resources.defaultImage;
            }
        }



        string idLogin;
        NhanVienBLL _nhanVienBLL;
        bool _isAdmin;

        OpenFileDialog openFileDialog;
        string[] filePaths;
        string[] fileNames;

        public fTaiKhoan(string idLogin)
        {
            InitializeComponent();
            this.idLogin = idLogin;
            _nhanVienBLL = new NhanVienBLL();
            LoadUserImage(idLogin);
        }
        private void ChangeBackgroundColor(Button btn, Panel pn,  Color cl)
        {
            btn.BackColor = cl;
            pn.BackColor = cl;
        }
        private void MakePictureBoxRound(PictureBox pictureBox)
        {
            // Tạo một hình ellipse (hình tròn) với kích thước của PictureBox
            System.Drawing.Drawing2D.GraphicsPath circle = new System.Drawing.Drawing2D.GraphicsPath();
            circle.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

            // Đặt vùng cắt cho PictureBox
            pictureBox.Region = new Region(circle);
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            RoundedControlHelper.SetRoundedCorners(pnXemHoSo, 20, true, true, true, true);
            RoundedControlHelper.SetRoundedCorners(pnSuaHoSo, 20, true, true, true, true);
            RoundedControlHelper.SetRoundedCorners(pnDoiMatKhau, 20, true, true, true, true);

            pnSua.Visible = false;
            pnButton.Visible = false;   
            pnDoiMK.Visible = false;
            MakePictureBoxRound(pictureBoxAvt);
            MakePanelRounded(panel7, 22);
            MakePanelRounded(panel8, 22);
            MakePanelRounded(panel9, 22);
            MakePanelRounded(panel10, 22);
            MakePanelRounded(panel12, 22);
            MakePanelRounded(panel13, 22);
            MakePanelRounded(panel14, 22);
            MakePanelRounded(panel15, 22);
            MakePanelRounded(panel16, 22);
            MakePanelRounded(panel11, 22);
            MakePanelRounded(panel17, 22);

            txtHoTen.Text = lblTen.Text = _nhanVienBLL.TimNhanVienTheoMa(idLogin);
            txtTrinhDo.Text = lblTrinhDo.Text = _nhanVienBLL.TimTrinhDoTheoMa(idLogin);
            txtSoDienThoai.Text = lblDienThoai.Text = _nhanVienBLL.TimSoDienThoai(idLogin);
            txtDiaChi.Text = lblDiaChi.Text = _nhanVienBLL.TimDiaChi(idLogin);
            txtNgayBatDau.Text = lblNgayBd.Text = _nhanVienBLL.TimNgayBatDau(idLogin);
            txtNgaySinh.Text = lblNgaySinh.Text = _nhanVienBLL.TimNgaySinh(idLogin);   
            txtGioiTinh.Text = lblGioiTinh.Text = _nhanVienBLL.TimGioiTinh(idLogin);

            if (idLogin.Contains("MNV")) { 
                lblChucVu.Text = "Nhân viên"; 
                _isAdmin = false; 
            }
            if (idLogin.Contains("QL")){ 
                lblChucVu.Text = "Quản lý"; 
                _isAdmin = true; 
            }
            txtChucVu.Text = lblChucVu1.Text = lblChucVu.Text;

            if (!_isAdmin)
            {
                txtChucVu.Enabled = false;
                txtTrinhDo.Enabled = false;
            }
            btnXem_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChangeBackgroundColor(btnXemHoSo, pnXemHoSo, Color.White);
            ChangeBackgroundColor(btnSuaHoSo, pnSuaHoSo, Color.FromArgb(217, 217, 217));
            ChangeBackgroundColor(btnDoiMK, pnDoiMatKhau, Color.White);
            pnDoiMK.Visible = false;
            pnHoSo.Visible = true;
            pnSua.Visible = true;
            pnThongTin.Visible = false;
            pnXem.Visible = false;
            pnButton.Visible = true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ChangeBackgroundColor(btnXemHoSo, pnXemHoSo, Color.FromArgb(217, 217, 217));
            ChangeBackgroundColor(btnSuaHoSo, pnSuaHoSo, Color.White);
            ChangeBackgroundColor(btnDoiMK, pnDoiMatKhau, Color.White);
            pnDoiMK.Visible = false;
            pnHoSo.Visible = true;
            pnSua.Visible = false;
            pnXem.Visible = true;
            pnButton.Visible = false;
            pnThongTin.Visible = true;
            
        }
        private void MakePanelRounded(Panel panel, int borderRadius)
        {
            // Tạo GraphicsPath để bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);
            int radius = borderRadius;

            // Thêm các góc bo tròn vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Góc trên trái
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Góc trên phải
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Góc dưới phải
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Góc dưới trái
            path.CloseFigure();

            // Đặt vùng cắt cho Panel
            panel.Region = new Region(path);
        }

        private void DrawRoundedBorderPanel(Panel panel, PaintEventArgs e, int borderRadius, int thickness)
        {
            Color borderColor = Color.Black;
            // Chống hiện tượng nhòe khi vẽ
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Tạo GraphicsPath để vẽ bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, panel.ClientSize.Width - 1, panel.ClientSize.Height - 1);
            int radius = borderRadius;

            // Thêm các góc bo tròn vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Góc trên trái
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Góc trên phải
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Góc dưới phải
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Góc dưới trái
            path.CloseFigure();

            // Tô màu nền cho panel nếu cần
            e.Graphics.FillPath(new SolidBrush(panel.BackColor), path);

            // Vẽ viền với độ dày và màu sắc đã chọn
            using (Pen pen = new Pen(borderColor, thickness))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorderPanel(panel8, e, 30, 2);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorderPanel(panel9, e, 30, 2);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorderPanel(panel10, e, 30, 2);
        }



        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorderPanel(panel12, e, 30, 2);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorderPanel(panel13, e, 30, 2);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorderPanel(panel14, e, 30, 2);
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorderPanel(panel16, e, 30, 2);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorderPanel(panel15, e, 30, 2);
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            ChangeBackgroundColor(btnXemHoSo, pnXemHoSo, Color.White);
            ChangeBackgroundColor(btnSuaHoSo, pnSuaHoSo, Color.White);
            ChangeBackgroundColor(btnDoiMK, pnDoiMatKhau, Color.FromArgb(217, 217, 217));
            pnHoSo.Visible = false;
            pnDoiMK.Visible = true;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorderPanel(panel7, e, 30, 2);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorderPanel(panel11, e, 30, 2);
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedBorderPanel(panel17, e, 30, 2);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string mkCu = txtMkCu.Text; 
            string mkMoi = txtMkMoi.Text;
            string nhapLai = txtNhapLaiMk.Text;
            if(mkCu == "")
            {
                MessageBox.Show("Nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(mkMoi == "")
            {
                MessageBox.Show("Nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nhapLai == "") {
                MessageBox.Show("Nhập lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(mkMoi != nhapLai)
            {
                MessageBox.Show("Mật khẩu nhập lại không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // update table o day
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Chỉ lọc các định dạng ảnh
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames;
                fileNames = openFileDialog.SafeFileNames;

                // Hiển thị ảnh đầu tiên trong PictureBox
                pictureBoxAvt.Image = System.Drawing.Image.FromFile(filePaths[0]);

                UpdateImage(Image.FromFile(openFileDialog.FileName));

            }
        }
        private void SaveImageToProjectResources(Image image)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserImages"); 
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath); 
            }

            string filePath = Path.Combine(folderPath, $"UserImage_{idLogin}.png"); 

            if (File.Exists(filePath))
            {
                File.Delete(filePath); 
            }

            image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png); 
        }


    }
}
