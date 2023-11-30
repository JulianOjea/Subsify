using SubsifyFrontend.Design.Assets;
using SubsifyFrontend.Design.UserControls.User;
using SubsifyFrontend.Util.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SubsifyFrontend.Design.Forms
{
    public partial class AdminForm : Form
    {
        private readonly Request _request;
        private readonly LoginForm loginForm;
        public AdminForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            _request = new Request("Admin", "demouser");
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            uc_plans.Visible = true;
            uc_platf.Visible = false;
            uc_platf.request = _request;
            uc_plans.request = _request;

            Bitmap subsify_round_logo = resources.subsify_favicon_logo;
            this.Icon = Icon.FromHandle(subsify_round_logo.GetHicon());

            setPlans();
            this.BackColor = this.BackColor = Color.FromArgb(0x98, 0xB9, 0xCA);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void adminPlanControl1_Load(object sender, EventArgs e)
        {

        }

        private void bttn_planes_Click(object sender, EventArgs e)
        {
            setPlans();
            uc_plans.Visible = true;
            uc_platf.Visible = false;
        }

        private async void setPlans()
        {
            List<RequestObject> subscriptionTable = await _request.PostAsync(
                "plans/adminPlan/search",
                "\"PLAN_NAME\",\"PLATF_NAME\",\"FR_NAME\",\"PLAN_PRICE_VALUE\",\"PLAN_ID\"",
                "");

            uc_plans.setListView(subscriptionTable);
        }

        private async void bttn_plataformas_Click(object sender, EventArgs e)
        {
            uc_plans.Visible = false;
            uc_platf.Visible = true;

            List<RequestObject> subscriptionTable = await _request.PostAsync(
                "platforms/platformAdmin/search",
                "\"PLATF_NAME\",\"CAT_NAME\",\"PLATF_ID\"",
                "");
            
            uc_platf.setListView(subscriptionTable);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }
    }
}
