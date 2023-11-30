using SubsifyFrontend.Design.Assets;
using SubsifyFrontend.Util.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubsifyFrontend.Design.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.tb_pass.UseSystemPasswordChar = true;

            this.KeyPreview = true; 
            this.BackColor = Color.FromArgb(0xb9, 0xd7, 0xe4);

            Bitmap subsify_round_logo = resources.subsify_favicon_logo;
            this.Icon = Icon.FromHandle(subsify_round_logo.GetHicon());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void bttn_login_Click(object sender, EventArgs e)
        {
            string user = this.tb_user.Text;
            string password = this.tb_pass.Text;

            try
            {
                Request r = new Request(user, password);
                await r.PostAsync("frequencies/frequency/search", "\"FR_ID\"", "");

                this.Hide();
                if (this.tb_user.Text.Equals("Admin"))
                {
                    AdminForm adminForm = new AdminForm(this);
                    adminForm.ShowDialog();
                }
                else
                {
                    UserHomeForm mainForm = new UserHomeForm(this, user, password);
                    mainForm.ShowDialog();
                }

                this.tb_user.Text = "";
                this.tb_pass.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error de inicio de sesión", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                bttn_login_Click(sender, e);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
