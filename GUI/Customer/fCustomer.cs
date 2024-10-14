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
using DAL;
using DTO;

namespace GUI
{
    public partial class fCustomer : Form
    {
        private string maKhach1 = "", hoTen1, diaChi1, sdt1;
        private KhachHangBLL _khachHangBLL;
        private bool isChoosing;

        public fCustomer()
        {
            InitializeComponent();
            _khachHangBLL = new KhachHangBLL();

        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            ShowCustomersList();
        }

        private void ShowCustomersList()
        {
            List<KhachHangDTO> dsKhachHang = _khachHangBLL.GetCustomerList();
            this.dsKhachHang.DataSource = dsKhachHang;

            if (this.dsKhachHang.Columns["MaKhachHang"] != null)
            {
                this.dsKhachHang.Columns["MaKhachHang"].HeaderText = "CustomerID";
            }

            if (this.dsKhachHang.Columns["TenKhachHang"] != null)
            {
                this.dsKhachHang.Columns["TenKhachHang"].HeaderText = "Full Name";
            }

            if (this.dsKhachHang.Columns["DiaChi"] != null)
            {
                this.dsKhachHang.Columns["DiaChi"].HeaderText = "Address";
            }

            if (this.dsKhachHang.Columns["SoDienThoai"] != null)
            {
                this.dsKhachHang.Columns["SoDienThoai"].HeaderText = "Phone";
            }
        }


        // thêm khách hàng
        private void button1_Click(object sender, EventArgs e)
        {
            fAddCustomer _fAddCustomer = new fAddCustomer();
            _fAddCustomer.ShowDialog();
            ShowCustomersList();
        }

        // Xóa khách hàng theo mã Khách
        private void button4_Click(object sender, EventArgs e)
        {
            if (maKhach1 != "")
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    _khachHangBLL.DeleteCustomer(maKhach1);  
                    maKhach1 = "";
                    ShowCustomersList(); 
                }
            }
            else
            {
                MessageBox.Show("Please choose the customer you want to Delete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Chọn khách 
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isChoosing = true;
                DataGridViewRow row = dsKhachHang.Rows[e.RowIndex];
                maKhach1 = row.Cells[0].Value.ToString();
                hoTen1 = row.Cells[1].Value.ToString();
                diaChi1 = row.Cells[2].Value.ToString();
                sdt1 = row.Cells[3].Value.ToString();
            }
            else
            {
                isChoosing = false;
            }
        }
        // 
        // Cập nhật thông tin khách hàng theo khách hàng đang chọn
        private void btnFix_Click(object sender, EventArgs e)
        {
            if (isChoosing)
            {
                fUpdateCustomer _fSuaKhachHang = new fUpdateCustomer(maKhach1, hoTen1, diaChi1, sdt1);
                _fSuaKhachHang.ShowDialog();
                ShowCustomersList();
                isChoosing = false;
            }
            else
            {
                MessageBox.Show("Please choose the customer you want to Update!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "Search...")
            {
                txtTim.Text = "";
            }
        }

        private void dsKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dsKhachHang.ClearSelection();
            dsKhachHang.CurrentCell = null;
        }

        private void txtTim_Leave(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                txtTim.Text = "Search...";
            }
            ShowCustomersList();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

            if (txtTim.Text != "")
            {
                dsKhachHang.DataSource = _khachHangBLL.SearchCustomerByName(txtTim.Text);
                dsKhachHang.Columns["MaKhach"].HeaderText = "CustomerID";
            }
            else
            {
                ShowCustomersList();
            }
        }
    }
}