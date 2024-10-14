using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace GUI
{
    public partial class fMain : Form
    {
        private bool isSidebarHidden = true;
        private bool accountPanelExpand = false;
        private bool dashboardPanelExpand = false;

        private Form[] forms;

        private Button activeButton;

        public fMain()
        {
            InitializeComponent();
            forms = new Form[4];
            forms[1] = new fCustomer();

            this.DoubleBuffered = true;
        }

        private void ShowForm(int index)
        {
            foreach (var form in forms)
            {
                if (form != null && !form.IsDisposed)
                {
                    panelPage.Controls.Remove(form);
                    form.Close();
                }
            }

            if (forms[index] != null && forms[index].IsDisposed)
            {
                forms[index] = (Form)Activator.CreateInstance(forms[index].GetType());
            }

            if (forms[index] != null)
            {
                forms[index].TopLevel = false;
                panelPage.Controls.Add(forms[index]);
                forms[index].Dock = DockStyle.Fill;
                forms[index].Show();
                panelPage.Update();
            }
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            //timerSideBar.Start();
        }

        // BEGIN BUTTON HOME
        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(51, 142, 226);
        }
        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            if (activeButton != btnHome)
                btnHome.BackColor = Color.FromArgb(34, 55, 113);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (dashboardPanelExpand)
                btnDashboard_Click(sender, e);
            if(accountPanelExpand)
                btnAccount_Click(sender, e);

            activeButton = btnHome;
            
            btnCustomer.BackColor = Color.FromArgb(34, 55, 113);
            btnDashboard.BackColor = Color.FromArgb(34, 55, 113);
            btnStatistics.BackColor = Color.FromArgb(34, 55, 113);
            btnChangePW.BackColor = Color.FromArgb(34, 55, 113);
            ShowForm(0);
        }

        // END BUTTON HOME

        // BEGIN BUTTON DASHBOARD
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (accountPanelExpand)
                btnAccount_Click(sender, e);

            timerDashboard.Start();
            activeButton = btnDashboard;
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {

            btnCustomer.BackColor = Color.FromArgb(51, 142, 226);
            btnDashboard.BackColor = Color.FromArgb(51, 142, 226);

            btnHome.BackColor = Color.FromArgb(34, 55, 113);         
            btnStatistics.BackColor = Color.FromArgb(34, 55, 113);
            btnChangePW.BackColor = Color.FromArgb(34, 55, 113);
            ShowForm(1);
        }
        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(51, 142, 226);
        }
        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(34, 55, 113);

        }
        private void timerDashboard_Tick(object sender, EventArgs e)
        {
            if (!dashboardPanelExpand)
            {
                panelStatistics.Location = new Point(0, 490);
                panelAccount.Location = new Point(0, 550);
                // Mở rộng
                panelDashboard.Height += 20;
                if (panelDashboard.Height >= 390)
                {
                    dashboardPanelExpand = true;
                    timerDashboard.Stop();
                }
            }
            else
            {
                // Thu nhỏ 
                panelDashboard.Height -= 20;
                if (panelDashboard.Height <= 60)
                {
                    dashboardPanelExpand = false;
                    timerDashboard.Stop();
                    panelStatistics.Location = new Point(0, 230);
                    panelAccount.Location = new Point(0, 290);
                }
            }
        }
        // END BUTTON DASHBOARD

        // BEGIN BUTTON STATISTICS
        private void btnStatistics_MouseEnter(object sender, EventArgs e)
        {
            btnStatistics.BackColor = Color.FromArgb(51, 142, 226);
        }

        private void btnStatistics_MouseLeave(object sender, EventArgs e)
        {
            if (activeButton != btnStatistics)
                btnStatistics.BackColor = Color.FromArgb(34, 55, 113);
        }
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (dashboardPanelExpand)
                btnDashboard_Click(sender, e);
            if (accountPanelExpand)
                btnAccount_Click(sender, e);

            activeButton = btnStatistics;
            btnCustomer.BackColor = Color.FromArgb(34, 55, 113);
            btnHome.BackColor = Color.FromArgb(34, 55, 113);
            btnDashboard.BackColor = Color.FromArgb(34, 55, 113);
            btnChangePW.BackColor = Color.FromArgb(34, 55, 113);
            ShowForm(2);
        }
        // END BUTTON STATISTICS

        // BEGIN BUTTON ACCOUNT
        private void btnAccount_Click(object sender, EventArgs e)
        {
            timerAccount.Start();
            if (dashboardPanelExpand)
                btnDashboard_Click(sender, e);

            btnHome.BackColor = Color.FromArgb(34, 55, 113);
            btnStatistics.BackColor = Color.FromArgb(34, 55, 113);
        }
        private void btnAccount_MouseEnter(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.FromArgb(51, 142, 226);
        }
        private void btnAccount_MouseLeave(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.FromArgb(34, 55, 113);
        }
        private void btnChangePW_Click(object sender, EventArgs e)
        {
            activeButton = btnChangePW;
            btnDashboard.BackColor = Color.FromArgb(34, 55, 113);
            btnHome.BackColor = Color.FromArgb(34, 55, 113);
            btnStatistics.BackColor = Color.FromArgb(34, 55, 113);
            ShowForm(3);
        }
        private void btnSignoff_Click(object sender, EventArgs e)
        {
            //fLogin _fLogin = new fLogin();
            //this.Dispose();
            //_fLogin.ShowDialog();
        }
        // END BUTTON ACCOUNT


        private void timerAccount_Tick(object sender, EventArgs e)
        {
            if (!accountPanelExpand)
            {
                // Mở rộng menu
                panelAccount.Height += 10;
                if (panelAccount.Height >= 170)
                {
                    accountPanelExpand = true;
                    timerAccount.Stop();
                }
            }
            else
            {
                // Thu nhỏ lại menu
                panelAccount.Height -= 10;
                if (panelAccount.Height <= 50)
                {
                    accountPanelExpand = false;
                    timerAccount.Stop();
                }
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            btnChangePW.BackColor = Color.FromArgb(51, 142, 226);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnChangePW.BackColor = Color.FromArgb(34, 55, 113);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            btnSignoff.BackColor = Color.FromArgb(51, 142, 226);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnSignoff.BackColor = Color.FromArgb(34, 55, 113);
        }
    }
} 