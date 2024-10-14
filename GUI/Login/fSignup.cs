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
    public partial class fSignup : Form
    {
        private AccountBLL _accountBLL;
        private bool isCheckBoxTicking = false;
        private bool isUsernameUp = false;
        private bool isPasswordUp = false;
        private bool isConfirmUp = false;

        public fSignup()
        {
            InitializeComponent();
            _accountBLL = new AccountBLL();
        }
        private void fSignup_Load(object sender, EventArgs e)
        {
            lbUsernameWarning.Visible = false;
            lbPasswordWarning.Visible = false;
            lbConfirmWarning.Visible = false;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length == 0)
                timerUsername.Start();  
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length == 0)
                timerPassword.Start();
        }
        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if(txtConfirm.Text.Length == 0)
                timerConfirm.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isCheckBoxTicking = !isCheckBoxTicking;

            if (txtPassword.Text == "Create password" && txtConfirm.Text == "Confirm password") return;

            if (txtPassword.Text == "MatKhau" && txtConfirm.Text != "Confirm password")
            {
                txtConfirm.UseSystemPasswordChar = !txtConfirm.UseSystemPasswordChar;
                return;
            }
            else if (txtPassword.Text != "Create password" && txtConfirm.Text == "Confirm password")
            {
                txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
                return;
            }
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            txtConfirm.UseSystemPasswordChar = !txtConfirm.UseSystemPasswordChar;
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fLogin login = new fLogin();
            this.Dispose();
            await Task.Delay(100);
            login.Visible = true;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string password2 = txtConfirm.Text;

            AccountDTO newAccount = new AccountDTO(username, password); 

            string validationResult = _accountBLL.ValidateLogin(newAccount);

            if(username == "" || username == "Username")
            {
                //MessageBox.Show("Enter a Username.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbUsernameWarning.Text = "Enter a Username";
                lbUsernameWarning.Visible = true;
                timerUsername.Start();
                //txtUsername.Focus();
                return;
            }

            if (password == "" || password == "Create password")
            {
                //MessageBox.Show("Enter a Password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbPasswordWarning.Text = "Enter a Password";
                lbPasswordWarning.Visible = true; 
                timerPassword.Start();  
                //txtPassword.Focus();
                return;
            }

            if(password2 == "" || password2 == "Confirm password")
            {
                //MessageBox.Show("Confirm your password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbConfirmWarning.Text = "Confirm your password";
                lbConfirmWarning.Visible = true;
                timerConfirm.Start();
                //txtConfirm.Focus(); 
                return; 
            }

            if (validationResult != "Incorrect")
            {
                MessageBox.Show(validationResult);
                return;
            }

            if (password2 != password)
            {
                MessageBox.Show("Passwords do not match.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirm.Focus();
                return;
            }

            if (_accountBLL.CheckUsernameInDatabase(username) == true)
            {
                MessageBox.Show("That username is taken.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            AccountDTO user = new AccountDTO(username, password);
            bool isInserted = _accountBLL.InsertAccountInDatabase(user);

            if (isInserted)
            {
                MessageBox.Show("Registration successful!", "Notification", MessageBoxButtons.OK);
                fLogin login = new fLogin();
                this.Close();
                login.Visible = true;
            }
            else
            {
                //MessageBox.Show("Lưu tài khoản thất bại.");
            }

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

        private void signupButton_MouseEnter(object sender, EventArgs e)
        {
            signupButton.ForeColor = Color.FromArgb(70, 116, 244);
            signupButton.BackColor = Color.White;
        }


        private void signupButton_MouseLeave(object sender, EventArgs e)
        {
            signupButton.ForeColor = Color.White;
            signupButton.BackColor = Color.FromArgb(70, 116, 244);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            timerUsername.Start();
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
                    lbUsername.Location = new Point(35, 110);
                    lbUsername.BringToFront();
                    lbUsername.AutoSize = true;
                    txtUsername.Focus();
                    isUsernameUp = true;
                }
            }
            else
            {
                if (lbUsername.Location.Y < 130)
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

        private void timerConfirm_Tick(object sender, EventArgs e)
        {
            if (!isConfirmUp)
            {
                if (lbConfirm.Location.Y > -8)
                {
                    lbConfirm.Location = new Point(lbConfirm.Location.X, lbConfirm.Location.Y - 1);
                }
                else
                {
                    timerConfirm.Stop();
                    pnConfirm.Controls.Remove(lbConfirm);
                    pnLogin.Controls.Add(lbConfirm);
                    lbConfirm.Location = new Point(35, 230);
                    lbConfirm.BringToFront();
                    lbConfirm.AutoSize = true;
                    txtConfirm.Focus();
                    isConfirmUp = true;
                }
            }
            else
            {
                if (lbConfirm.Location.Y < 250)
                {
                    lbConfirm.Location = new Point(lbConfirm.Location.X, lbConfirm.Location.Y + 1);

                }
                else
                {
                    timerConfirm.Stop();
                    pnLogin.Controls.Remove(lbConfirm);
                    pnConfirm.Controls.Add(lbConfirm);
                    lbConfirm.Location = new Point(9, 8);
                    lbConfirm.BringToFront();
                    isConfirmUp = false;
                }
            }
        }

        private void lbPassword_Click(object sender, EventArgs e)
        {
            timerPassword.Start();
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
                    lbPassword.Location = new Point(35, 170);
                    lbPassword.BringToFront();
                    lbPassword.AutoSize = true;
                    txtPassword.Focus();
                    isPasswordUp = true;
                }
            }
            else
            {
                if (lbPassword.Location.Y < 190)
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                lbPasswordWarning.Visible = false;
            }
        }

        private void lbConfirm_Click(object sender, EventArgs e)
        {
            timerConfirm.Start();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                lbUsernameWarning.Visible = false;
            }
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConfirm.Text))
            {
                lbConfirmWarning.Visible = false;
            }
        }

        private void pnUsername_Leave(object sender, EventArgs e)
        {
            lbUsernameWarning.Visible=false;
        }

        private void pnPassword_Leave(object sender, EventArgs e)
        {
            lbPasswordWarning.Visible=false;
        }

        private void pnConfirm_Leave(object sender, EventArgs e)
        {
            lbConfirmWarning.Visible=false;
        }

        private void pnConfirm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
