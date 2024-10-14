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
    public partial class fAddCustomer : Form
    {
        private KhachHangBLL _khachHangBLL;
        public fAddCustomer()
        {
            InitializeComponent();
            _khachHangBLL = new KhachHangBLL(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maKhach = textBox1.Text;
            string tenKhachHang = textBox2.Text;
            string diaChi = textBox3.Text;
            string sdt = textBox4.Text;

            if (maKhach.Equals(""))
            {
                MessageBox.Show("Enter a ID", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return;
            }
            else if (tenKhachHang.Equals(""))
            {
                MessageBox.Show("Enter a Fullname", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return;
            }
            else if (diaChi.Equals(""))
            {
                MessageBox.Show("Enter a Address", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
                return;
            }
            else if (sdt.Equals(""))
            {
                MessageBox.Show("Enter a Phone", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Focus();
                return;
            }
            KhachHangDTO khachHang = new KhachHangDTO
            {
                MaKhachHang = maKhach,
                TenKhachHang = tenKhachHang,
                DiaChi = diaChi,
                SoDienThoai = sdt
            };
            bool result = _khachHangBLL.AddCustomer(khachHang);
            if (!result)
            {
                MessageBox.Show("Customer ID already exists!", "Notification",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("Customer has been added successfully!", "Notification", MessageBoxButtons.OK);
                this.Dispose();
            }
        }

        private void fThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            await Task.Delay(100);
            this.Dispose();
        }
    }
}
