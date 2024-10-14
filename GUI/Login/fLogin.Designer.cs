namespace GUI
{
    partial class fLogin
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
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lbPasswordWarning = new System.Windows.Forms.Label();
            this.lbUsernameWarning = new System.Windows.Forms.Label();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnUsername = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.linkLbSignup = new System.Windows.Forms.LinkLabel();
            this.lbFooter = new System.Windows.Forms.Label();
            this.chkBoxShowpassword = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerUsername = new System.Windows.Forms.Timer(this.components);
            this.timerPassword = new System.Windows.Forms.Timer(this.components);
            this.pnLogin.SuspendLayout();
            this.pnPassword.SuspendLayout();
            this.pnUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnLogin.BackgroundImage = global::GUI.Properties.Resources.WhileFramePanel;
            this.pnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnLogin.Controls.Add(this.lbPasswordWarning);
            this.pnLogin.Controls.Add(this.lbUsernameWarning);
            this.pnLogin.Controls.Add(this.pnPassword);
            this.pnLogin.Controls.Add(this.pnUsername);
            this.pnLogin.Controls.Add(this.lbHeader);
            this.pnLogin.Controls.Add(this.linkLbSignup);
            this.pnLogin.Controls.Add(this.lbFooter);
            this.pnLogin.Controls.Add(this.chkBoxShowpassword);
            this.pnLogin.Controls.Add(this.loginButton);
            this.pnLogin.Location = new System.Drawing.Point(225, 150);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(350, 400);
            this.pnLogin.TabIndex = 1;
            // 
            // lbPasswordWarning
            // 
            this.lbPasswordWarning.AutoSize = true;
            this.lbPasswordWarning.Font = new System.Drawing.Font("Arial", 9F);
            this.lbPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.lbPasswordWarning.Location = new System.Drawing.Point(30, 201);
            this.lbPasswordWarning.Name = "lbPasswordWarning";
            this.lbPasswordWarning.Size = new System.Drawing.Size(119, 15);
            this.lbPasswordWarning.TabIndex = 36;
            this.lbPasswordWarning.Text = "lbPasswordWarning";
            // 
            // lbUsernameWarning
            // 
            this.lbUsernameWarning.AutoSize = true;
            this.lbUsernameWarning.Font = new System.Drawing.Font("Arial", 9F);
            this.lbUsernameWarning.ForeColor = System.Drawing.Color.Red;
            this.lbUsernameWarning.Location = new System.Drawing.Point(30, 141);
            this.lbUsernameWarning.Name = "lbUsernameWarning";
            this.lbUsernameWarning.Size = new System.Drawing.Size(122, 15);
            this.lbUsernameWarning.TabIndex = 35;
            this.lbUsernameWarning.Text = "lbUsernameWarning";
            // 
            // pnPassword
            // 
            this.pnPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPassword.Controls.Add(this.lbPassword);
            this.pnPassword.Controls.Add(this.txtPassword);
            this.pnPassword.Location = new System.Drawing.Point(25, 160);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(300, 40);
            this.pnPassword.TabIndex = 34;
            this.pnPassword.Leave += new System.EventHandler(this.pnPassword_Leave);
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(9, 8);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(280, 22);
            this.lbPassword.TabIndex = 37;
            this.lbPassword.Text = "Password";
            this.lbPassword.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(9, 9);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 17);
            this.txtPassword.TabIndex = 31;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // pnUsername
            // 
            this.pnUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnUsername.Controls.Add(this.lbUsername);
            this.pnUsername.Controls.Add(this.txtUsername);
            this.pnUsername.Location = new System.Drawing.Point(25, 100);
            this.pnUsername.Name = "pnUsername";
            this.pnUsername.Size = new System.Drawing.Size(300, 40);
            this.pnUsername.TabIndex = 33;
            this.pnUsername.Leave += new System.EventHandler(this.pnUsername_Leave);
            // 
            // lbUsername
            // 
            this.lbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbUsername.Font = new System.Drawing.Font("Arial", 11F);
            this.lbUsername.Location = new System.Drawing.Point(9, 8);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(280, 22);
            this.lbUsername.TabIndex = 31;
            this.lbUsername.Text = "Username";
            this.lbUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(9, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(280, 17);
            this.txtUsername.TabIndex = 30;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbHeader.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.lbHeader.ForeColor = System.Drawing.Color.Black;
            this.lbHeader.Location = new System.Drawing.Point(101, 40);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(155, 55);
            this.lbHeader.TabIndex = 32;
            this.lbHeader.Text = "Login";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLbSignup
            // 
            this.linkLbSignup.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLbSignup.DisabledLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLbSignup.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbSignup.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLbSignup.LinkColor = System.Drawing.Color.Blue;
            this.linkLbSignup.Location = new System.Drawing.Point(217, 340);
            this.linkLbSignup.Name = "linkLbSignup";
            this.linkLbSignup.Size = new System.Drawing.Size(70, 25);
            this.linkLbSignup.TabIndex = 13;
            this.linkLbSignup.TabStop = true;
            this.linkLbSignup.Text = "Signup";
            this.linkLbSignup.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(120)))));
            this.linkLbSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // lbFooter
            // 
            this.lbFooter.AutoSize = true;
            this.lbFooter.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFooter.Location = new System.Drawing.Point(63, 340);
            this.lbFooter.Name = "lbFooter";
            this.lbFooter.Size = new System.Drawing.Size(157, 16);
            this.lbFooter.TabIndex = 12;
            this.lbFooter.Text = "Don\'t have an account?";
            // 
            // chkBoxShowpassword
            // 
            this.chkBoxShowpassword.AutoSize = true;
            this.chkBoxShowpassword.Font = new System.Drawing.Font("Arial", 10F);
            this.chkBoxShowpassword.Location = new System.Drawing.Point(30, 220);
            this.chkBoxShowpassword.Name = "chkBoxShowpassword";
            this.chkBoxShowpassword.Size = new System.Drawing.Size(125, 20);
            this.chkBoxShowpassword.TabIndex = 11;
            this.chkBoxShowpassword.TabStop = false;
            this.chkBoxShowpassword.Text = "Show Password";
            this.chkBoxShowpassword.UseVisualStyleBackColor = true;
            this.chkBoxShowpassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(25, 260);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(300, 40);
            this.loginButton.TabIndex = 4;
            this.loginButton.TabStop = false;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.dangNhapBtn_Click);
            this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.minimize_button;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(740, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.exit_button;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(770, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // timerUsername
            // 
            this.timerUsername.Interval = 10;
            this.timerUsername.Tick += new System.EventHandler(this.timerUsername_Tick);
            // 
            // timerPassword
            // 
            this.timerPassword.Interval = 10;
            this.timerPassword.Tick += new System.EventHandler(this.timerPassword_Tick);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(172)))), ((int)(((byte)(205)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnLogin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnPassword.ResumeLayout(false);
            this.pnPassword.PerformLayout();
            this.pnUsername.ResumeLayout(false);
            this.pnUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Panel pnUsername;
        private System.Windows.Forms.Panel pnPassword;



        private System.Windows.Forms.CheckBox chkBoxShowpassword;

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbFooter;
        private System.Windows.Forms.Label lbUsernameWarning;
        private System.Windows.Forms.Label lbPasswordWarning;
        private System.Windows.Forms.Label lbUsername;

        private System.Windows.Forms.LinkLabel linkLbSignup;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Timer timerUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Timer timerPassword;
    }
}