using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class fLoad : Form
    {
        private string formName;
        public fLoad(string formName)
        {
            InitializeComponent();
            this.formName = formName;
        }
        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            try
            {
                string imagePath = @"C:\Users\ADMIN\Downloads\download (1).gif";
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            catch (Exception em)
            {
                Console.WriteLine(em.Message);
            }

            timer1.Start();
        }


        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 20;
               // label2.Text = progressBar1.Value.ToString() + "%";
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                //System.Threading.Thread.Sleep(400); // Dừng mà treo giao diện
                await Task.Delay(1000); // Dừng lại một giây mà không treo giao diện
                TheNextForm();
            }
        }

        private void TheNextForm()
        {
            switch (formName)
            {
                case "Login":
                    fLogin login = new fLogin();
                    this.Visible = false;
                    login.ShowDialog();
                    break;

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
