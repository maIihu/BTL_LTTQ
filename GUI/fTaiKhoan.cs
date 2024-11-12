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
using Microsoft.VisualBasic.ApplicationServices;

namespace GUI
{
    public partial class fTaiKhoan : Form
    {
        public event Action<Image> ImageChanged; 

        string idLogin;
        NhanVienBLL _nhanVienBLL;
        bool _isAdmin;
        AccountBLL _accountBLL;

        public fTaiKhoan(string idLogin)
        {
            InitializeComponent();
            this.idLogin = idLogin;
            _nhanVienBLL = new NhanVienBLL();
            _accountBLL = new AccountBLL();
		}

		private void ChangeBackgroundColor(Button btn, Panel pn,  Color cl)
        {
            btn.BackColor = cl;
            pn.BackColor = cl;
        }
        private void MakePictureBoxRound(PictureBox pictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath circle = new System.Drawing.Drawing2D.GraphicsPath();
            circle.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Region = new Region(circle);
        }
        private void FillData()
        {
			txtHoTen.Text = lblTen.Text = _nhanVienBLL.TimTenNhanVienTheoMa(idLogin);
			txtTrinhDo.Text = lblTrinhDo.Text = _nhanVienBLL.TimTrinhDoTheoMa(idLogin);
			txtSoDienThoai.Text = lblDienThoai.Text = _nhanVienBLL.TimSoDienThoai(idLogin);
			txtDiaChi.Text = lblDiaChi.Text = _nhanVienBLL.TimDiaChi(idLogin);
			txtNgayBatDau.Text = lblNgayBd.Text = _nhanVienBLL.TimNgayBatDau(idLogin);
			txtNgaySinh.Text = lblNgaySinh.Text = _nhanVienBLL.TimNgaySinh(idLogin);
			txtGioiTinh.Text = lblGioiTinh.Text = _nhanVienBLL.TimGioiTinh(idLogin);
			if (idLogin.Contains("MNV"))
            {
                lblChucVu.Text = "Nhân viên";
                _isAdmin = false;
            }
            if (idLogin.Contains("QL"))
            {
                lblChucVu.Text = "Quản lý";
                _isAdmin = true;
            }
            txtChucVu.Text = lblChucVu1.Text = lblChucVu.Text;
        }
        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            RoundedControlHelper.SetRoundedCorners(pnXemHoSo, 20, true, true, true, true);
            RoundedControlHelper.SetRoundedCorners(pnSuaHoSo, 20, true, true, true, true);
            RoundedControlHelper.SetRoundedCorners(pnDoiMatKhau, 20, true, true, true, true);
            pnSua.Visible = false;
            pnButton.Visible = false;   
            pnDoiMK.Visible = false;
            MakePictureBoxRound(pictureBox1);
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
            LoadImage(idLogin);
            FillData();

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
			txtHoTen.Text = lblTen.Text = _nhanVienBLL.TimTenNhanVienTheoMa(idLogin);
			txtTrinhDo.Text = lblTrinhDo.Text = _nhanVienBLL.TimTrinhDoTheoMa(idLogin);
			txtSoDienThoai.Text = lblDienThoai.Text = _nhanVienBLL.TimSoDienThoai(idLogin);
			txtDiaChi.Text = lblDiaChi.Text = _nhanVienBLL.TimDiaChi(idLogin);
			txtNgayBatDau.Text = lblNgayBd.Text = _nhanVienBLL.TimNgayBatDau(idLogin);
			txtNgaySinh.Text = lblNgaySinh.Text = _nhanVienBLL.TimNgaySinh(idLogin);
			txtGioiTinh.Text = lblGioiTinh.Text = _nhanVienBLL.TimGioiTinh(idLogin);
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
            txtMkCu.Clear();
            txtMkMoi.Clear();
            txtNhapLaiMk.Clear();   
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
            bool changepassword = _accountBLL.ChangePassword(idLogin, mkMoi);
            if (changepassword)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDangXuat_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Hi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ht = txtHoTen.Text;
            string ns = txtNgaySinh.Text;   
            string gt = txtGioiTinh.Text;
            string dc = txtDiaChi.Text; 
            string sdt = txtSoDienThoai.Text;   
            bool capnhat = _nhanVienBLL.CapNhatThongTin(idLogin, ht, ns, gt, dc, sdt);
            if (capnhat)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FillData();
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    string resourcePath = $@"..\..\Resources\ImageAvatar\";
                    string destinationPath = Path.Combine(resourcePath, $"{idLogin}.jpg");

                    if (!Directory.Exists(resourcePath))
                    {
                        Directory.CreateDirectory(resourcePath);
                    }
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }

                    try
                    {
                        File.Copy(selectedImagePath, destinationPath, true);

                        LoadImage(idLogin);
                    }
                    catch (IOException ioEx)
                    {
                        MessageBox.Show($"Error copying file: {ioEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }
        private void LoadImage(string foodID)
        {
            string resourcePath = $@"..\..\Resources\ImageAvatar\";
            string imagePath = Path.Combine(resourcePath, $"{foodID}.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if (File.Exists(imagePath))
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                    ImageChanged?.Invoke(pictureBox1.Image);
                    // pictureBox1.Image = Resize(originalImage, pictureBox1.Width, pictureBox1.Height);
                }
            }
            else
            {

                string defaultImagePath = Path.Combine(resourcePath, "default.jpg");
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                using (FileStream stream = new FileStream(defaultImagePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                    ImageChanged?.Invoke(pictureBox1.Image);
                    //pictureBox1.Image = Resize(originalImage, pictureBox1.Width, pictureBox1.Height);
                }
            }
        }
		public event EventHandler CloseFormEvent;
		private void btnDangXuat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				fLoad fLoad = new fLoad("Login");
				this.Close();
				CloseFormEvent?.Invoke(this, EventArgs.Empty);
				fLoad.Show();
			}
		}


		private void btnCapTK_Click(object sender, EventArgs e)
		{

		}
	}
}
