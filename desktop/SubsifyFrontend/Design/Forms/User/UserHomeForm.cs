using SubsifyFrontend.Design.Assets;
using SubsifyFrontend.Design.Forms;
using SubsifyFrontend.Design.UserControls.User;
using SubsifyFrontend.Util.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubsifyFrontend
{
    public partial class UserHomeForm : Form
    {
        private readonly Request _request;
        private LoginForm loginForm;

        public UserHomeForm(LoginForm loginForm, String username, String password)
        {
            _request = new Request(username, password);
            this.loginForm = loginForm;

            InitializeComponent();

            userSubscriptionControl1.request = _request;
            userSubscriptionControl1.detailsControl = userSubscriptionDetailsControl1;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            userSubscriptionControl1.Visible = false;
            userSubscriptionDetailsControl1.Visible = false;
            this.MaximizeBox = false;

            setHomeView();
            this.BackColor = this.BackColor = Color.FromArgb(0x98, 0xB9, 0xCA);
            Bitmap subsify_round_logo = resources.subsify_favicon_logo;
            this.Icon = Icon.FromHandle(subsify_round_logo.GetHicon());
        }

        private void Form1_LoadAsync(object sender, EventArgs e)
        {
        }

        private void lb_subscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userHomeControl1.Visible = true;
            userSubscriptionControl1.Visible = false;
            userSubscriptionDetailsControl1.Visible = false;
            setHomeView();
        }

        private async void setHomeView()
        {
            List<RequestObject> subscriptionTable = await _request.PostAsync(
                "subLapses/subLapseToRenew/search",
                "\"PLATF_NAME\",\"SUBS_ID\",\"PLAN_ID\",\"SUB_LAPSE_END\",\"PLATF_IMAGE\",\"SUBS_AUTORENEWAL\",\"PLATF_LINK\"",
                "");

            userHomeControl1.clearCards();
            foreach (var subscriptionRow in subscriptionTable)
            {
                UserHomeCardControl card = new UserHomeCardControl();
                card.setContent(subscriptionRow);
                userHomeControl1.setCard(card);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            userHomeControl1.Visible = false;
            userSubscriptionControl1.Visible = true;
            userSubscriptionDetailsControl1.Visible = false;

            userSubscriptionControl1.reloadList();
        }

        private void userHomeControl1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void userSubscriptionControl1_Load(object sender, EventArgs e)
        {

        }

        private void userSubscriptionDetailsControl1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }
    }
}
