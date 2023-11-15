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
        public UserSubscriptionControl()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.ListView GetListView()
        {
            return lv_subscriptions;
        }

        public void AddSubscriptionRow(SubscriptionRow subscriptionRow)
        {
            ListViewItem item = new ListViewItem();
            //item.Add(subscriptionRow.PLATF_NAME);
            /*
            item.SubItems.Add(subscriptionRow.SUB_LAPSE_PRICE.ToString("C"));
            item.SubItems.Add(subscriptionRow.PLAN_NAME);
            item.SubItems.Add(subscriptionRow.CAT_NAME);*/

            lv_subscriptions.Items.Add(subscriptionRow.PLATF_NAME);
        }

        private void UserSubscriptionControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lv_subscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
