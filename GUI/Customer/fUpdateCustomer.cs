using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class fUpdateCustomer : Form
    {
        string maKh, hoTen, diaChi, sdt;
        private KhachHangBLL _khachHangBLL;

        public fUpdateCustomer(string maKh, string hoTen, string diaChi, string sdt)
        {
            InitializeComponent();
            this.maKh = maKh;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.sdt = sdt;
            _khachHangBLL = new KhachHangBLL();
        }
        private void fSuaKhachHang_Load(object sender, EventArgs e)
        {
            label1.Text = "Mã Khách Hàng: " + maKh;
            textBox2.Text = hoTen;
            textBox3.Text = diaChi;
            textBox4.Text = sdt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hoTen = textBox2.Text;
            diaChi = textBox3.Text;
            sdt = textBox4.Text;
            KhachHangDTO khachHang = new KhachHangDTO
            {
                MaKhachHang = maKh,
                TenKhachHang = hoTen,
                DiaChi = diaChi,
                SoDienThoai = sdt
            };
            bool result = _khachHangBLL.UpdateCustomer(khachHang);
            
            if (result)
            {
                MessageBox.Show("Customer information updated successfully!", "Notification", MessageBoxButtons.OK);
                this.Dispose();
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            await Task.Delay(100);
            this.Dispose();
        }
    }
}
