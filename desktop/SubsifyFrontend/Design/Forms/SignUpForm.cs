﻿using SubsifyFrontend.Util.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubsifyFrontend.Design.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();

            this.bttn_sign_up.BackColor = Color.FromArgb(0x06, 0x54, 0x71);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.tb_pass.UseSystemPasswordChar = true;
        }

        private async void bttn_sign_up_Click(object sender, EventArgs e)
        {
            String username = this.tb_username.Text;
            String email = this.tb_email.Text;
            String password = this.tb_pass.Text;
            String password_confirm = this.tb_pass_confirm.Text;
            string data = $"{{\"USER_\": \"{username}\", " +
                $"\"EMAIL\": \"{email}\", " +
                $"\"PASSWORD\": \"{password}\", " +
                $"\"CONFIRM_PASS\": \"{password_confirm}\"}}";

            try
            {

                Request r = new Request("Admin", "demouser");
                await r.PostInsertAsync("signUps/signUp", data, "");
            }
            catch
            {
                Console.WriteLine("ey");
            }
            

            this.Close();
        }
    }
}
