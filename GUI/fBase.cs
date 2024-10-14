using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class fBase : Form
    {
        private string idLogin;

        private NhanVienBLL _nhanVienBLL;
        private Form[] forms;
        private Button activeBtn;
        public fBase(string tenDangNhap)
        {
            InitializeComponent();
            this.idLogin = tenDangNhap;
            _nhanVienBLL = new NhanVienBLL();
        }

        private void fBase_Load(object sender, EventArgs e)
        {
            RoundedControlHelper.SetRoundedCorners(pnTrangChu, 20, true, true, true, true);
            RoundedControlHelper.SetRoundedCorners(pnKho, 20, true, true, true, true);
            RoundedControlHelper.SetRoundedCorners(pnXe, 20, true, true, true, true);
            RoundedControlHelper.SetRoundedCorners(pnKhach, 20, true, true, true, true);
            RoundedControlHelper.SetRoundedCorners(pnYeuCau, 20, true, true, true, true);
            RoundedControlHelper.SetRoundedCorners(pnHoaDon, 20, true, true, true, true);
            RoundedControlHelper.SetRoundedCorners(pnNhanVien, 20, true, true, true, true);

            picTrangChu.Image = Properties.Resources.grid1;
            picKho.Image = Properties.Resources.box1;
            picXe.Image = Properties.Resources.tool1;
            picKhach.Image = Properties.Resources.user1;
            picYeuCau.Image = Properties.Resources.cal1;
            picNhanVien.Image = Properties.Resources.alt1;


            forms = new Form[7];
            forms[0] = new fTrangChu(idLogin);
            forms[1] = new fKhoPhuTung(idLogin);
            forms[2] = new fXeMay(idLogin);
            forms[3] = new fKhachHang(idLogin);
            forms[4] = new fYeuCau(idLogin);
            forms[5] = new fHoaDon(idLogin);    
            forms[6] = new fNhanVien(idLogin);

            btnTrangChu_Click(sender, e);
            changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu, Color.FromArgb(210, 224, 251), Properties.Resources.grid2, FontStyle.Bold);

            lbTen.Text = _nhanVienBLL.TimNhanVienTheoMa(idLogin);
            if (idLogin.Contains("MNV")) lbChucVu.Text = "Nhân viên";
        }
        private async void ShowForm(int index)
        {
            foreach (var form in forms)
            {
                if (form != null && !form.IsDisposed)
                {
                    pnPage.Controls.Remove(form);
                    form.Close();
                }
            }

            await Task.Delay(100);

            if (forms[index] != null && forms[index].IsDisposed)
            {
                forms[index] = (Form)Activator.CreateInstance(forms[index].GetType(), new object[] { idLogin });
            }

            if (forms[index] != null)
            {
                forms[index].TopLevel = false;
                pnPage.Controls.Add(forms[index]);
                forms[index].Dock = DockStyle.Fill;
                forms[index].Show();
                pnPage.Update();
            }
        }


        private void changeBackgroundColor(Button btn, Panel pn, PictureBox pic, Color cl, Image img, FontStyle fs)
        {
            btn.BackColor = cl;
            btn.Font = new Font("Arial", 11, fs);
            pn.BackColor = cl;
            pic.Image = img;
        }
        // BEGIN TRANGCHU
        private void pnTrangChu_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu,
                Color.FromArgb(210, 224, 251), Properties.Resources.grid2, FontStyle.Bold);
        }

        private void pnTrangChu_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnTrangChu)
                changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu,
                    Color.White, Properties.Resources.grid1, FontStyle.Regular);
        }

        private void btnTrangChu_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu,
                Color.FromArgb(210, 224, 251), Properties.Resources.grid2, FontStyle.Bold);
        }

        private void btnTrangChu_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnTrangChu)
                changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu,
                Color.White, Properties.Resources.grid1, FontStyle.Regular);
        }

        private void picTrangChu_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu,
                Color.FromArgb(210, 224, 251), Properties.Resources.grid2, FontStyle.Bold);
        }

        private void picTrangChu_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnTrangChu)
                changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu,
                Color.White, Properties.Resources.grid1, FontStyle.Regular);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (activeBtn == btnTrangChu) return;
            ShowForm(0);
            lbTitle.Text = "Trang chủ";
            activeBtn = btnTrangChu;

            changeBackgroundColor(btnKho, pnKho, picKho, Color.White, Properties.Resources.box1, FontStyle.Regular);
            changeBackgroundColor(btnXe, pnXe, picXe, Color.White, Properties.Resources.tool1, FontStyle.Regular);
            changeBackgroundColor(btnKhach, pnKhach, picKhach, Color.White, Properties.Resources.user1, FontStyle.Regular);
            changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau, Color.White, Properties.Resources.cal1, FontStyle.Regular);
            changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon, Color.White, Properties.Resources.card1, FontStyle.Regular);
            changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien, Color.White, Properties.Resources.alt1, FontStyle.Regular);
        }

        // END TRANGCHU

        // BEGIN KHO
        private void btnKho_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnKho, pnKho, picKho,
                Color.FromArgb(210, 224, 251), Properties.Resources.box2, FontStyle.Bold);
        }

        private void btnKho_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnKho)
                changeBackgroundColor(btnKho, pnKho, picKho,
                Color.White, Properties.Resources.box1, FontStyle.Regular);
        }

        private void pnKho_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnKho, pnKho, picKho,
                Color.FromArgb(210, 224, 251), Properties.Resources.box2, FontStyle.Bold);
        }

        private void pnKho_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnKho)
                changeBackgroundColor(btnKho, pnKho, picKho,
                Color.White, Properties.Resources.box1, FontStyle.Regular);
        }

        private void picKho_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnKho, pnKho, picKho,
                Color.FromArgb(210, 224, 251), Properties.Resources.box2, FontStyle.Bold);
        }

        private void picKho_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnKho)
                changeBackgroundColor(btnKho, pnKho, picKho,
                Color.White, Properties.Resources.box1, FontStyle.Regular);
        }
        private void btnKho_Click(object sender, EventArgs e)
        {
            if (activeBtn == btnKho) return;
            ShowForm(1);
            lbTitle.Text = "Kho phụ tùng";
            activeBtn = btnKho;

            changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu, Color.White, Properties.Resources.grid1, FontStyle.Regular);
            changeBackgroundColor(btnXe, pnXe, picXe, Color.White, Properties.Resources.tool1, FontStyle.Regular);
            changeBackgroundColor(btnKhach, pnKhach, picKhach, Color.White, Properties.Resources.user1, FontStyle.Regular);
            changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau, Color.White, Properties.Resources.cal1, FontStyle.Regular);
            changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon, Color.White, Properties.Resources.card1, FontStyle.Regular);
            changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien, Color.White, Properties.Resources.alt1, FontStyle.Regular);
        }
        // END KHO

        // BEGIN XE

        private void btnXe_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnXe, pnXe, picXe,
                Color.FromArgb(210, 224, 251), Properties.Resources.tool2, FontStyle.Bold);
        }

        private void btnXe_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnXe)
                changeBackgroundColor(btnXe, pnXe, picXe,
                Color.White, Properties.Resources.tool1, FontStyle.Regular);
        }

        private void picXe_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnXe, pnXe, picXe,
                Color.FromArgb(210, 224, 251), Properties.Resources.tool2, FontStyle.Bold);
        }

        private void picXe_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnXe)
                changeBackgroundColor(btnXe, pnXe, picXe,
                Color.White, Properties.Resources.tool1, FontStyle.Regular);
        }

        private void pnXe_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnXe, pnXe, picXe,
                Color.FromArgb(210, 224, 251), Properties.Resources.tool2, FontStyle.Bold);
        }

        private void pnXe_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnXe)
                changeBackgroundColor(btnXe, pnXe, picXe,
                Color.White, Properties.Resources.tool1, FontStyle.Regular);
        }
        private void btnXe_Click(object sender, EventArgs e)
        {
            if (activeBtn == btnXe) return;
            ShowForm(2);
            lbTitle.Text = "Xe máy";
            activeBtn = btnXe;

            changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu, Color.White, Properties.Resources.grid1, FontStyle.Regular);
            changeBackgroundColor(btnKho, pnKho, picKho, Color.White, Properties.Resources.box1, FontStyle.Regular);
            changeBackgroundColor(btnKhach, pnKhach, picKhach, Color.White, Properties.Resources.user1, FontStyle.Regular);
            changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau, Color.White, Properties.Resources.cal1, FontStyle.Regular);
            changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon, Color.White, Properties.Resources.card1, FontStyle.Regular);
            changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien, Color.White, Properties.Resources.alt1, FontStyle.Regular);
        }

        // END XE

        // BEGIN KHACH

        private void btnKhach_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnKhach, pnKhach, picKhach,
                Color.FromArgb(210, 224, 251), Properties.Resources.user2, FontStyle.Bold);
        }

        private void btnKhach_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnKhach)
                changeBackgroundColor(btnKhach, pnKhach, picKhach,
                Color.White, Properties.Resources.user1, FontStyle.Regular);
        }

        private void picKhach_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnKhach, pnKhach, picKhach,
                Color.FromArgb(210, 224, 251), Properties.Resources.user2, FontStyle.Bold);
        }

        private void picKhach_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnKhach)
                changeBackgroundColor(btnKhach, pnKhach, picKhach,
                Color.White, Properties.Resources.user1, FontStyle.Regular);
        }

        private void pnKhach_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnKhach, pnKhach, picKhach,
                Color.FromArgb(210, 224, 251), Properties.Resources.user2, FontStyle.Bold);
        }

        private void pnKhach_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnKhach)
                changeBackgroundColor(btnKhach, pnKhach, picKhach,
                Color.White, Properties.Resources.user1, FontStyle.Regular);
        }
        private void btnKhach_Click(object sender, EventArgs e)
        {
            if (activeBtn == btnKhach) return;
            ShowForm(3);
            lbTitle.Text = "Khách hàng";
            activeBtn = btnKhach;

            changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu, Color.White, Properties.Resources.grid1, FontStyle.Regular);
            changeBackgroundColor(btnKho, pnKho, picKho, Color.White, Properties.Resources.box1, FontStyle.Regular);
            changeBackgroundColor(btnXe, pnXe, picXe, Color.White, Properties.Resources.tool1, FontStyle.Regular);
            changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau, Color.White, Properties.Resources.cal1, FontStyle.Regular);
            changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon, Color.White, Properties.Resources.card1, FontStyle.Regular);
            changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien, Color.White, Properties.Resources.alt1, FontStyle.Regular);
        }
        // END KHACH

        // BEGIN YEUCAU
        private void btnYeuCau_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau,
                Color.FromArgb(210, 224, 251), Properties.Resources.cal2, FontStyle.Bold);
        }

        private void btnYeuCau_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnYeuCau)
                changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau,
                    Color.White, Properties.Resources.cal1, FontStyle.Regular);
        }

        private void picYeuCau_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau,
                Color.FromArgb(210, 224, 251), Properties.Resources.cal2, FontStyle.Bold);
        }

        private void picYeuCau_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnYeuCau)
                changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau,
                    Color.White, Properties.Resources.cal1, FontStyle.Regular);
        }

        private void pnYeuCau_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau,
                Color.FromArgb(210, 224, 251), Properties.Resources.cal2, FontStyle.Bold);
        }

        private void pnYeuCau_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnYeuCau)
                changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau,
                    Color.White, Properties.Resources.cal1, FontStyle.Regular);
        }

        public void btnYeuCau_Click(object sender, EventArgs e)
        {
            if (activeBtn == btnYeuCau) return;
            ShowForm(4);
            lbTitle.Text = "Yêu cầu sửa chữa";
            activeBtn = btnYeuCau;

            changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu, Color.White, Properties.Resources.grid1, FontStyle.Regular);
            changeBackgroundColor(btnKho, pnKho, picKho, Color.White, Properties.Resources.box1, FontStyle.Regular);
            changeBackgroundColor(btnXe, pnXe, picXe, Color.White, Properties.Resources.tool1, FontStyle.Regular);
            changeBackgroundColor(btnKhach, pnKhach, picKhach, Color.White, Properties.Resources.user1, FontStyle.Regular);
            changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon, Color.White, Properties.Resources.card1, FontStyle.Regular);
            changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien, Color.White, Properties.Resources.alt1, FontStyle.Regular);
        }

        // END YEUCAU

        // BEGIN HOADON


        private void btnHoaDon_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon,
                Color.FromArgb(210, 224, 251), Properties.Resources.card2, FontStyle.Bold);
        }

        private void btnHoaDon_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnHoaDon)
                changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon,
                    Color.White, Properties.Resources.card1, FontStyle.Regular);
        }

        private void picHoaDon_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon,
                Color.FromArgb(210, 224, 251), Properties.Resources.card2, FontStyle.Bold);
        }

        private void picHoaDon_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnHoaDon)
                changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon,
                    Color.White, Properties.Resources.card1, FontStyle.Regular);
        }

        private void pnHoaDon_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon,
                Color.FromArgb(210, 224, 251), Properties.Resources.card2, FontStyle.Bold);
        }

        private void pnHoaDon_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnHoaDon)
                changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon,
                    Color.White, Properties.Resources.card1, FontStyle.Regular);
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (activeBtn == btnHoaDon) return;
            ShowForm(5);
            lbTitle.Text = "Hoá đơn";
            activeBtn = btnHoaDon;

            changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu, Color.White, Properties.Resources.grid1, FontStyle.Regular);
            changeBackgroundColor(btnKho, pnKho, picKho, Color.White, Properties.Resources.box1, FontStyle.Regular);
            changeBackgroundColor(btnXe, pnXe, picXe, Color.White, Properties.Resources.tool1, FontStyle.Regular);
            changeBackgroundColor(btnKhach, pnKhach, picKhach, Color.White, Properties.Resources.user1, FontStyle.Regular);
            changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau, Color.White, Properties.Resources.cal1, FontStyle.Regular);
            changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien, Color.White, Properties.Resources.alt1, FontStyle.Regular);
        }
        // END HOADON


        // BEGIN NHANVIEN
        private void pnNhanVien_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien,
                Color.FromArgb(210, 224, 251), Properties.Resources.alt2, FontStyle.Bold);
        }
        private void pnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnNhanVien)
                changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien,
                Color.White, Properties.Resources.alt1, FontStyle.Regular);
        }

        private void btnNhanVien_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien,
                Color.FromArgb(210, 224, 251), Properties.Resources.alt2, FontStyle.Bold);
        }

        private void btnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnNhanVien)
                changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien,
                Color.White, Properties.Resources.alt1, FontStyle.Regular);
        }

        private void picNhanVien_MouseEnter(object sender, EventArgs e)
        {
            changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien,
                Color.FromArgb(210, 224, 251), Properties.Resources.alt2, FontStyle.Bold);
        }

        private void picNhanVien_MouseLeave(object sender, EventArgs e)
        {
            if (activeBtn != btnNhanVien)
                changeBackgroundColor(btnNhanVien, pnNhanVien, picNhanVien,
                Color.White, Properties.Resources.alt1, FontStyle.Regular);
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (activeBtn == btnNhanVien) return;
            ShowForm(6);
            lbTitle.Text = "Nhân viên";
            activeBtn = btnNhanVien;

            changeBackgroundColor(btnTrangChu, pnTrangChu, picTrangChu, Color.White, Properties.Resources.grid1, FontStyle.Regular);
            changeBackgroundColor(btnKho, pnKho, picKho, Color.White, Properties.Resources.box1, FontStyle.Regular);
            changeBackgroundColor(btnXe, pnXe, picXe, Color.White, Properties.Resources.tool1, FontStyle.Regular);
            changeBackgroundColor(btnKhach, pnKhach, picKhach, Color.White, Properties.Resources.user1, FontStyle.Regular);
            changeBackgroundColor(btnHoaDon, pnHoaDon, picHoaDon, Color.White, Properties.Resources.card1, FontStyle.Regular);
            changeBackgroundColor(btnYeuCau, pnYeuCau, picYeuCau, Color.White, Properties.Resources.cal1, FontStyle.Regular);
        }

        // END NHANVIEN
    }
}
