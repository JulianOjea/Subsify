using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.tb_user.Text.Equals("demo")){
                AdminForm adminForm = new AdminForm(this);
                adminForm.ShowDialog();
            }
            else
            {
                MainForm mainForm = new MainForm(this, this.tb_user.Text, this.tb_pass.Text);
                mainForm.ShowDialog();
            }
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                bttn_login_Click(sender, e);
            }
        }
    }
}
