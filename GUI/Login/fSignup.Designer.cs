namespace GUI
{
    partial class fSignup
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lbConfirmWarning = new System.Windows.Forms.Label();
            this.lbPasswordWarning = new System.Windows.Forms.Label();
            this.lbUsernameWarning = new System.Windows.Forms.Label();
            this.pnConfirm = new System.Windows.Forms.Panel();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.pnUsername = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.timerUsername = new System.Windows.Forms.Timer(this.components);
            this.timerPassword = new System.Windows.Forms.Timer(this.components);
            this.timerConfirm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnLogin.SuspendLayout();
            this.pnConfirm.SuspendLayout();
            this.pnPassword.SuspendLayout();
            this.pnUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.minimize_button;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(740, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 27;
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
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(116)))), ((int)(((byte)(244)))));
            this.signupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Arial", 11F);
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.Location = new System.Drawing.Point(25, 350);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(300, 40);
            this.signupButton.TabIndex = 4;
            this.signupButton.TabStop = false;
            this.signupButton.Text = "Signup";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            this.signupButton.MouseEnter += new System.EventHandler(this.signupButton_MouseEnter);
            this.signupButton.MouseLeave += new System.EventHandler(this.signupButton_MouseLeave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.checkBox1.Location = new System.Drawing.Point(30, 300);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Already have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(120)))));
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(222, 420);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 25);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.txtUsername.TabIndex = 20;
            this.txtUsername.Tag = "";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(9, 8);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 17);
            this.txtPassword.TabIndex = 21;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.White;
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Arial", 11F);
            this.txtConfirm.ForeColor = System.Drawing.Color.Black;
            this.txtConfirm.Location = new System.Drawing.Point(9, 8);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(280, 17);
            this.txtConfirm.TabIndex = 22;
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            this.txtConfirm.Leave += new System.EventHandler(this.txtConfirm_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 60);
            this.label1.TabIndex = 33;
            this.label1.Text = "Signup";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnLogin.BackgroundImage = global::GUI.Properties.Resources.FramePanel2;
            this.pnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnLogin.Controls.Add(this.lbConfirmWarning);
            this.pnLogin.Controls.Add(this.lbPasswordWarning);
            this.pnLogin.Controls.Add(this.lbUsernameWarning);
            this.pnLogin.Controls.Add(this.pnConfirm);
            this.pnLogin.Controls.Add(this.pnPassword);
            this.pnLogin.Controls.Add(this.pnUsername);
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Controls.Add(this.linkLabel1);
            this.pnLogin.Controls.Add(this.label3);
            this.pnLogin.Controls.Add(this.checkBox1);
            this.pnLogin.Controls.Add(this.signupButton);
            this.pnLogin.Location = new System.Drawing.Point(225, 100);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(350, 500);
            this.pnLogin.TabIndex = 2;
            this.pnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbConfirmWarning
            // 
            this.lbConfirmWarning.AutoSize = true;
            this.lbConfirmWarning.Font = new System.Drawing.Font("Arial", 9F);
            this.lbConfirmWarning.ForeColor = System.Drawing.Color.Red;
            this.lbConfirmWarning.Location = new System.Drawing.Point(30, 281);
            this.lbConfirmWarning.Name = "lbConfirmWarning";
            this.lbConfirmWarning.Size = new System.Drawing.Size(107, 15);
            this.lbConfirmWarning.TabIndex = 39;
            this.lbConfirmWarning.Text = "ConfirmPassword";
            // 
            // lbPasswordWarning
            // 
            this.lbPasswordWarning.AutoSize = true;
            this.lbPasswordWarning.Font = new System.Drawing.Font("Arial", 9F);
            this.lbPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.lbPasswordWarning.Location = new System.Drawing.Point(30, 221);
            this.lbPasswordWarning.Name = "lbPasswordWarning";
            this.lbPasswordWarning.Size = new System.Drawing.Size(63, 15);
            this.lbPasswordWarning.TabIndex = 38;
            this.lbPasswordWarning.Text = "Password";
            // 
            // lbUsernameWarning
            // 
            this.lbUsernameWarning.AutoSize = true;
            this.lbUsernameWarning.Font = new System.Drawing.Font("Arial", 9F);
            this.lbUsernameWarning.ForeColor = System.Drawing.Color.Red;
            this.lbUsernameWarning.Location = new System.Drawing.Point(30, 161);
            this.lbUsernameWarning.Name = "lbUsernameWarning";
            this.lbUsernameWarning.Size = new System.Drawing.Size(66, 15);
            this.lbUsernameWarning.TabIndex = 37;
            this.lbUsernameWarning.Text = "Username";
            // 
            // pnConfirm
            // 
            this.pnConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnConfirm.Controls.Add(this.lbConfirm);
            this.pnConfirm.Controls.Add(this.txtConfirm);
            this.pnConfirm.Location = new System.Drawing.Point(25, 240);
            this.pnConfirm.Name = "pnConfirm";
            this.pnConfirm.Size = new System.Drawing.Size(300, 40);
            this.pnConfirm.TabIndex = 36;
            this.pnConfirm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnConfirm_Paint);
            this.pnConfirm.Leave += new System.EventHandler(this.pnConfirm_Leave);
            // 
            // lbConfirm
            // 
            this.lbConfirm.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirm.Location = new System.Drawing.Point(9, 8);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(280, 22);
            this.lbConfirm.TabIndex = 42;
            this.lbConfirm.Text = "Confirm Password";
            this.lbConfirm.Click += new System.EventHandler(this.lbConfirm_Click);
            // 
            // pnPassword
            // 
            this.pnPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPassword.Controls.Add(this.lbPassword);
            this.pnPassword.Controls.Add(this.txtPassword);
            this.pnPassword.Location = new System.Drawing.Point(25, 180);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(300, 40);
            this.pnPassword.TabIndex = 35;
            this.pnPassword.Leave += new System.EventHandler(this.pnPassword_Leave);
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(9, 8);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(280, 22);
            this.lbPassword.TabIndex = 41;
            this.lbPassword.Text = "Create Password";
            this.lbPassword.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // pnUsername
            // 
            this.pnUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnUsername.Controls.Add(this.lbUsername);
            this.pnUsername.Controls.Add(this.txtUsername);
            this.pnUsername.Location = new System.Drawing.Point(25, 120);
            this.pnUsername.Name = "pnUsername";
            this.pnUsername.Size = new System.Drawing.Size(300, 40);
            this.pnUsername.TabIndex = 34;
            this.pnUsername.Leave += new System.EventHandler(this.pnUsername_Leave);
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(9, 8);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(280, 22);
            this.lbUsername.TabIndex = 40;
            this.lbUsername.Text = "Username";
            this.lbUsername.Click += new System.EventHandler(this.label2_Click);
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
            // timerConfirm
            // 
            this.timerConfirm.Interval = 10;
            this.timerConfirm.Tick += new System.EventHandler(this.timerConfirm_Tick);
            // 
            // fSignup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(172)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.fSignup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnConfirm.ResumeLayout(false);
            this.pnConfirm.PerformLayout();
            this.pnPassword.ResumeLayout(false);
            this.pnPassword.PerformLayout();
            this.pnUsername.ResumeLayout(false);
            this.pnUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Panel pnUsername;
        private System.Windows.Forms.Panel pnConfirm;
        private System.Windows.Forms.Panel pnPassword;
        private System.Windows.Forms.Label lbUsernameWarning;
        private System.Windows.Forms.Label lbPasswordWarning;
        private System.Windows.Forms.Label lbConfirmWarning;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Timer timerUsername;
        private System.Windows.Forms.Timer timerPassword;
        private System.Windows.Forms.Timer timerConfirm;
        private System.Windows.Forms.Label lbConfirm;
    }
}