using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace GUI
{
    partial class fLogin : Form
    {
        private AccountBLL _accountBLL;
        public string tenDangNhap;
        private bool isCheckBoxTicking = false;
        private bool isUsernameUp = false;
        private bool isPasswordUp = false;

        public fLogin()
        {
            InitializeComponent();
            _accountBLL = new AccountBLL();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            lbUsernameWarning.Visible = false;
            lbPasswordWarning.Visible = false; 
        }

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
                lbUsernameWarning.Text = "Enter a Username";
                lbUsernameWarning.Visible = true;
                timerUsername.Start();
                //txtUsername.Focus();              
                return;
            }

            if (thongTinMk == "" || thongTinMk == "Password")
            {
                //MessageBox.Show("Enter a Password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbPasswordWarning.Text = "Enter a Password";
                lbPasswordWarning.Visible = true;
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
            if(txtUsername.Text.Length == 0)
                timerUsername.Start();
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length == 0)
                timerPassword.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isCheckBoxTicking = !isCheckBoxTicking;

            if (txtPassword.Text == "Password") return;

            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private async void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            fSignup signUp = new fSignup();
            await Task.Delay(100);
            signUp.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(142, 172, 205);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Silver;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(142, 172, 205);
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
            timerUsername.Start();
            //label5.Location = new Point(25, 100);
        }

        private void timerUsername_Tick(object sender, EventArgs e)
        {
            if (!isUsernameUp)
            {
                if (lbUsername.Location.Y > -8)
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
                    lbUsername.AutoSize = true;
                    txtUsername.Focus();
                    isUsernameUp = true;                   
                }
            }
            else
            {
                if(lbUsername.Location.Y < 110)
                {
                    lbUsername.Location = new Point(lbUsername.Location.X, lbUsername.Location.Y + 1);

                }
                else
                {
                    timerUsername.Stop();
                    pnLogin.Controls.Remove(lbUsername);
                    pnUsername.Controls.Add(lbUsername);
                    lbUsername.Location = new Point(9, 8);
                    lbUsername.BringToFront();
                    isUsernameUp = false;
                }
            }
        }

        private void timerPassword_Tick(object sender, EventArgs e)
        {
            if (!isPasswordUp)
            {
                if (lbPassword.Location.Y > -8)
                {
                    lbPassword.Location = new Point(lbPassword.Location.X, lbPassword.Location.Y - 1);
                }
                else
                {
                    timerPassword.Stop();
                    pnPassword.Controls.Remove(lbPassword);
                    pnLogin.Controls.Add(lbPassword);
                    lbPassword.Location = new Point(35, 150);
                    lbPassword.BringToFront();
                    lbPassword.AutoSize = true;
                    txtPassword.Focus();
                    isPasswordUp = true;
                }
            }
            else
            {
                if (lbPassword.Location.Y < 170)
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
                }
            }
        }

        private void lbPassword_Click(object sender, EventArgs e)
        {
            timerPassword.Start();
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                lbUsernameWarning.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                lbPasswordWarning.Visible = false;
            }
        }

        private void pnUsername_Leave(object sender, EventArgs e)
        {
            lbUsernameWarning.Visible = false;
        }

        private void pnPassword_Leave(object sender, EventArgs e)
        {
            lbPasswordWarning.Visible = false;
        }
    }
}
