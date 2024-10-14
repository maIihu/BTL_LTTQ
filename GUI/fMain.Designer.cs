using System;

namespace GUI
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnSignoff = new System.Windows.Forms.Button();
            this.btnChangePW = new System.Windows.Forms.Button();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.timerAccount = new System.Windows.Forms.Timer(this.components);
            this.panelPage = new System.Windows.Forms.Panel();
            this.timerDashboard = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.panelStatistics.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.panelSidebar.Controls.Add(this.panelAccount);
            this.panelSidebar.Controls.Add(this.panelStatistics);
            this.panelSidebar.Controls.Add(this.panelHome);
            this.panelSidebar.Controls.Add(this.panelDashboard);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 900);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.btnAccount);
            this.panelAccount.Controls.Add(this.btnSignoff);
            this.panelAccount.Controls.Add(this.btnChangePW);
            this.panelAccount.Location = new System.Drawing.Point(0, 350);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(200, 60);
            this.panelAccount.TabIndex = 2;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::GUI.Properties.Resources.icons8_account_24;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 5);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(200, 50);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "          Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            this.btnAccount.MouseEnter += new System.EventHandler(this.btnAccount_MouseEnter);
            this.btnAccount.MouseLeave += new System.EventHandler(this.btnAccount_MouseLeave);
            // 
            // btnSignoff
            // 
            this.btnSignoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.btnSignoff.FlatAppearance.BorderSize = 0;
            this.btnSignoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignoff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSignoff.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignoff.Image = ((System.Drawing.Image)(resources.GetObject("btnSignoff.Image")));
            this.btnSignoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignoff.Location = new System.Drawing.Point(20, 115);
            this.btnSignoff.Name = "btnSignoff";
            this.btnSignoff.Size = new System.Drawing.Size(180, 50);
            this.btnSignoff.TabIndex = 5;
            this.btnSignoff.Text = "            Sign off";
            this.btnSignoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignoff.UseVisualStyleBackColor = false;
            this.btnSignoff.Click += new System.EventHandler(this.btnSignoff_Click);
            this.btnSignoff.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.btnSignoff.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // btnChangePW
            // 
            this.btnChangePW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.btnChangePW.FlatAppearance.BorderSize = 0;
            this.btnChangePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePW.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnChangePW.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChangePW.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePW.Image")));
            this.btnChangePW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePW.Location = new System.Drawing.Point(20, 60);
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.Size = new System.Drawing.Size(180, 50);
            this.btnChangePW.TabIndex = 4;
            this.btnChangePW.Text = "            More";
            this.btnChangePW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePW.UseVisualStyleBackColor = false;
            this.btnChangePW.Click += new System.EventHandler(this.btnChangePW_Click);
            this.btnChangePW.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.btnChangePW.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // panelStatistics
            // 
            this.panelStatistics.BackColor = System.Drawing.Color.Transparent;
            this.panelStatistics.Controls.Add(this.btnStatistics);
            this.panelStatistics.Location = new System.Drawing.Point(0, 280);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(200, 60);
            this.panelStatistics.TabIndex = 5;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Image = global::GUI.Properties.Resources.icons8_statistics_24;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(0, 5);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(200, 50);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "          Statistics";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            this.btnStatistics.MouseEnter += new System.EventHandler(this.btnStatistics_MouseEnter);
            this.btnStatistics.MouseLeave += new System.EventHandler(this.btnStatistics_MouseLeave);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Location = new System.Drawing.Point(0, 140);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(200, 60);
            this.panelHome.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::GUI.Properties.Resources.icons8_home_24;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 50);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.Transparent;
            this.panelDashboard.Controls.Add(this.button6);
            this.panelDashboard.Controls.Add(this.button1);
            this.panelDashboard.Controls.Add(this.button5);
            this.panelDashboard.Controls.Add(this.btnDashboard);
            this.panelDashboard.Controls.Add(this.button4);
            this.panelDashboard.Controls.Add(this.btnCustomer);
            this.panelDashboard.Controls.Add(this.button3);
            this.panelDashboard.Location = new System.Drawing.Point(0, 210);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(200, 60);
            this.panelDashboard.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::GUI.Properties.Resources.icons8_dot_16;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(20, 335);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 50);
            this.button6.TabIndex = 9;
            this.button6.Text = "          Sửa chữa";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::GUI.Properties.Resources.icons8_dot_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(20, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "          Nhân Viên";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::GUI.Properties.Resources.icons8_dot_16;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(20, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 50);
            this.button5.TabIndex = 8;
            this.button5.Text = "          Phụ Tùng";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::GUI.Properties.Resources.icons8_dashboard_24;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 50);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.btnDashboard_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btnDashboard_MouseLeave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::GUI.Properties.Resources.icons8_dot_16;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(20, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 50);
            this.button4.TabIndex = 7;
            this.button4.Text = "          Hóa Đơn";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::GUI.Properties.Resources.icons8_dot_16;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(20, 115);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(180, 50);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "          Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::GUI.Properties.Resources.icons8_dot_16;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(20, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "          Xe Máy";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.AutoSize = true;
            this.panelHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.Location = new System.Drawing.Point(719, 91);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(0, 0);
            this.panelHeader.TabIndex = 1;
            // 
            // timerAccount
            // 
            this.timerAccount.Interval = 10;
            this.timerAccount.Tick += new System.EventHandler(this.timerAccount_Tick);
            // 
            // panelPage
            // 
            this.panelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPage.BackColor = System.Drawing.Color.Transparent;
            this.panelPage.Controls.Add(this.panelHeader);
            this.panelPage.Location = new System.Drawing.Point(200, 0);
            this.panelPage.Margin = new System.Windows.Forms.Padding(0);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(1370, 850);
            this.panelPage.TabIndex = 2;
            // 
            // timerDashboard
            // 
            this.timerDashboard.Interval = 20;
            this.timerDashboard.Tick += new System.EventHandler(this.timerDashboard_Tick);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelPage);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelSidebar.ResumeLayout(false);
            this.panelAccount.ResumeLayout(false);
            this.panelStatistics.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelPage.ResumeLayout(false);
            this.panelPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Panel panelPage;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.Panel panelHome;


        private System.Windows.Forms.Timer timerAccount;
        private System.Windows.Forms.Timer timerDashboard;

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSignoff;
        private System.Windows.Forms.Button btnChangePW;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnStatistics;
    }
}