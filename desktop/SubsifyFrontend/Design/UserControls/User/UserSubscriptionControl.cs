using SubsifyFrontend.Design.Forms.User;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SubsifyFrontend
{
    public partial class UserSubscriptionControl : UserControl
    {
        public Request request { get; set; }
        public UserSubscriptionDetailsControl detailsControl { get; set; }
        public double total_price { get; set; }
        public UserSubscriptionControl()
        {
            InitializeComponent();

            lv_subscriptions.View = View.Details;
            lv_subscriptions.FullRowSelect = true;

            //lv_subscriptions.Columns.Add("Subscription End Date", 150);
            lv_subscriptions.Columns.Add("SUB_LAPSE_ID", 0);
            lv_subscriptions.Columns.Add("Plataforma", 150);
            //lv_subscriptions.Columns.Add("Subscription ID", 100);
            lv_subscriptions.Columns.Add("Plan", 150);
            lv_subscriptions.Columns.Add("Precio mensual", 120);
            //lv_subscriptions.Columns.Add("Category Name", 150);
        }

        public System.Windows.Forms.ListView GetListView()
        {
            return lv_subscriptions;
        }

        public void AddSubscriptionRow(SubscriptionRow subscriptionRow)
        {
            ListViewItem item = new ListViewItem(subscriptionRow.SUB_LAPSE_ID.ToString());
            item.SubItems.Add(subscriptionRow.PLATF_NAME);
            item.SubItems.Add(subscriptionRow.PLAN_NAME);
            item.SubItems.Add(subscriptionRow.SUB_LAPSE_PRICE.ToString("C"));
            item.SubItems.Add(subscriptionRow.CAT_NAME);

            lv_subscriptions.Items.Add(item);
        }

        private void UserSubscriptionControl_Load(object sender, EventArgs e)
        {
            setTotalPriceText();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void setTotalPriceText()
        {
            this.lbl_total_price.Text = $"Gasto mensual total: {total_price:C}";
        }
        private async void lv_subscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_subscriptions.SelectedItems.Count > 0)
            {
                this.detailsControl.Visible = true;
                ListViewItem selectedItem = lv_subscriptions.SelectedItems[0];

                int sub_lapse_id = int.Parse(selectedItem.SubItems[0].Text);
                string filter = $"{{\"SUB_LAPSE_ID\": {sub_lapse_id}}}";

                //,\"SUB_LAPSE_END\",\"PLATF_NAME\",\"SUB_LAPSE_PRICE\",\"PLAN_NAME\", \"FR_VALUE\",\"CAT_NAME\",\"FR_NAME\"
                //,\"SUB_LAPSE_END\"
                List<SubscriptionRow> sr = await request.PostAsync(
                    "subLapses/subLapse/search",
                    "\"SUB_LAPSE_ID\",\"FR_NAME\",\"SUB_LAPSE_START\",\"SUB_LAPSE_END\", \"SUBS_AUTORENEWAL\", \"SUBS_ID\"," +
                    "\"FR_ID\"",
                    filter
                    );

                this.detailsControl.setSubscription(sr[0]);
                this.detailsControl.request = this.request;
                this.detailsControl.hideCancel();
            }
        }

        public void clearList()
        {
            this.lv_subscriptions.Items.Clear();
        }

        private void lbl_total_price_Click(object sender, EventArgs e)
        {

        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
            UserAddSubscriptionForm userAddSubscriptionForm = new UserAddSubscriptionForm();
            userAddSubscriptionForm.request = request;
            DialogResult result = userAddSubscriptionForm.ShowDialog();

        }
    }
}
