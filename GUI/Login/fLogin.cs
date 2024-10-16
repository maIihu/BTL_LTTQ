using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;
using BorderStyle = System.Windows.Forms.BorderStyle;
using Panel = System.Web.UI.WebControls.Panel;

namespace GUI
{
    partial class fLogin : Form
    {
        private AccountBLL _accountBLL;
        public string tenDangNhap;
        private bool isCheckBoxTicking = false;
        private bool isUsernameUp = false;
        private bool isPasswordUp = false;
        private Color borderColor = Color.Black;

        public fLogin()
        {
            InitializeComponent();
            _accountBLL = new AccountBLL();
            RoundedControlHelper.SetRoundedCorners(pnLogin, 30, true, true, true, true);
            RoundedControlHelper.SetRoundedCorners(loginButton, 40, true, true, true, true);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {  

        }
        bool isWarningUsername = false;
        bool isWarningPassword = false;
        private void dangNhapBtn_Click(object sender, EventArgs e)
        {
            string thongTinTk = txtUsername.Text;
            string thongTinMk = txtPassword.Text;
            tenDangNhap = thongTinTk;
            AccountDTO user = new AccountDTO(thongTinTk, thongTinMk);
            bool isLoginSuccessful = _accountBLL.CheckAccountInDatabase(user);

            if(thongTinTk == "" || thongTinTk == "Username")
            {
                //MessageBox.Show("Enter a Username.", "Notification",  MessageBoxButtons.OK, MessageBoxIcon.Information);

                isWarningUsername = true;
                if (isWarningUsername)
                {
                    borderColor = Color.Red;

                    lbUsername.ForeColor = Color.Red;
                    pnUsername.Invalidate();
                    isWarningUsername = false;
                }


                timerUsername.Start();
                //txtUsername.Focus();              
                return;
            }

            if (thongTinMk == "" || thongTinMk == "Password")
            {
                //MessageBox.Show("Enter a Password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isWarningPassword = true;
                if (isWarningPassword)
                {
                    borderColor = Color.Red;

                    lbPassword.ForeColor = Color.Red;
                    pnPassword.Invalidate();
                    isWarningPassword = false;
                }
                timerPassword.Start();
                //txtPassword.Focus();
                return;
            }

            if (isLoginSuccessful)
            {
                //MessageBox.Show("Đăng nhập thành công!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length == 0){

                borderColor = Color.Black;
                lbUsername.ForeColor = Color.Black;
                pnUsername.Invalidate();
                timerUsername.Start();
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length == 0){
                borderColor = Color.Black;
                lbPassword.ForeColor = Color.Black;
                pnPassword.Invalidate();
                timerPassword.Start();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isCheckBoxTicking = !isCheckBoxTicking;

            if (txtPassword.Text == "Password") return;

            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }


  
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.White;
            loginButton.ForeColor = Color.FromArgb(70, 116, 244);
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.Black;
            loginButton.BackColor = Color.FromArgb(210, 224, 251);
        }



        private void lbUsername_Click(object sender, EventArgs e)
        {
            borderColor = Color.Blue;
            lbUsername.ForeColor = Color.Blue;
            pnUsername.Invalidate();
            timerUsername.Start();
        }

        private void pnUsername_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 20; // Độ bo tròn của góc
            int thickness = 2; // Độ dày của đường viền

            // Chống hiện tượng nhòe khi vẽ
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Tạo GraphicsPath để vẽ bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, pnUsername.ClientSize.Width - 1, pnUsername.ClientSize.Height - 1);
            int radius = borderRadius;

            // Thêm các góc bo tròn vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Góc trên trái
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Góc trên phải
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Góc dưới phải
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Góc dưới trái
            path.CloseFigure();

            // Tô màu nền cho panel nếu cần
            e.Graphics.FillPath(new SolidBrush(pnUsername.BackColor), path);

            // Vẽ viền với độ dày và màu sắc đã chọn
            using (Pen pen = new Pen(borderColor, thickness))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }


        private void timerUsername_Tick(object sender, EventArgs e)
        {
            if (!isUsernameUp)
            {
                lbUsername.AutoSize = true;
                if (lbUsername.Location.Y > -11)
                {
                    lbUsername.Location = new Point(lbUsername.Location.X, lbUsername.Location.Y - 1);
                }
                else
                {
                    timerUsername.Stop();
                    pnUsername.Controls.Remove(lbUsername);
                    pnLogin.Controls.Add(lbUsername);
                    lbUsername.Location = new Point(35, 90);
                    lbUsername.BringToFront();             
                    txtUsername.Focus();
                    isUsernameUp = true;                   
                }
            }
            else
            {
                
                if (lbUsername.Location.Y < 110)
                {
                    lbUsername.Location = new Point(lbUsername.Location.X, lbUsername.Location.Y + 1);
                }
                else
                {
                    timerUsername.Stop();
                    pnLogin.Controls.Remove(lbUsername);
                    pnUsername.Controls.Add(lbUsername);
                    lbUsername.Location = new Point(10, 9);
                    lbUsername.BringToFront();
                    isUsernameUp = false;
                    lbUsername.AutoSize = false;
                }
            }
        }

        private void timerPassword_Tick(object sender, EventArgs e)
        {
            if (!isPasswordUp)
            {
                lbPassword.AutoSize = true;
                if (lbPassword.Location.Y > -11)
                {
                    lbPassword.Location = new Point(lbPassword.Location.X, lbPassword.Location.Y - 1);
                }
                else
                {
                    timerPassword.Stop();
                    pnPassword.Controls.Remove(lbPassword);
                    pnLogin.Controls.Add(lbPassword);
                    lbPassword.Location = new Point(35, 140);
                    lbPassword.BringToFront();
                    txtPassword.Focus();
                    isPasswordUp = true;
                }
            }
            else
            {
                
                if (lbPassword.Location.Y < 160)
                {
                    lbPassword.Location = new Point(lbPassword.Location.X, lbPassword.Location.Y + 1);

                }
                else
                {
                    timerPassword.Stop();
                    pnLogin.Controls.Remove(lbPassword);
                    pnPassword.Controls.Add(lbPassword);
                    lbPassword.Location = new Point(9, 8);
                    lbPassword.BringToFront();
                    isPasswordUp = false;
                    lbPassword.AutoSize = false;
                }
            }
        }

        private void lbPassword_Click(object sender, EventArgs e)
        {
            borderColor = Color.Blue;
            lbPassword.ForeColor = Color.Blue;
            pnPassword.Invalidate();
            timerPassword.Start();
        }
        private void pnPassword_Paint(object sender, PaintEventArgs e)
        {
            int thickness = 1;

            using (Pen pen = new Pen(borderColor, thickness))
            {
                Rectangle rect = new Rectangle(0, 0, pnUsername.ClientSize.Width - 1, pnUsername.ClientSize.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
            }
        }

        private void pnUsername_Leave(object sender, EventArgs e)
        {
        }

        private void pnPassword_Leave(object sender, EventArgs e)
        {
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbPassword_Click(null, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangNhapBtn_Click(null, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
