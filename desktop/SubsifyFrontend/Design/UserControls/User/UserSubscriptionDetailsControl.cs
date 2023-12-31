﻿using SubsifyFrontend.Design.Forms.User;
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

namespace SubsifyFrontend
{
    public partial class UserSubscriptionDetailsControl : UserControl
    {

        public Request request;
        public RequestObject subscription { get; set; }
        public List<RequestObject> userList { get; set; }
        public UserSubscriptionDetailsControl()
        {
            InitializeComponent();
            this.tb_end.ReadOnly = true;
            this.tb_start.ReadOnly = true;
            this.tb_freq_name.ReadOnly = true;
            this.bttn_save.Visible = false;

            lv_share.Visible = false;
            lv_share.View = View.Details;
            lv_share.Columns.Add("Usuarios", 100);
            
        }

        private void lvShare_visibility()
        {
            if (this.lv_share.Items.Count == 0)
            {
                lv_share.Visible = false;
            }
            else
            {
                lv_share.Visible = true;
            }
        }

        public void hideCancel()
        {
            this.bttn_save.Visible = false;
        }

        public async void setSubscription(RequestObject subscriptionRow)
        {
            this.tb_freq_name.Text = subscriptionRow.FR_NAME.ToString();
            this.tb_start.Text = subscriptionRow.SUB_LAPSE_START.AddDays(1).ToString();
            this.tb_end.Text = subscriptionRow.SUB_LAPSE_END.AddDays(1).ToString();
            this.cb_renew.Checked = subscriptionRow.SUBS_AUTORENEWAL;
            this.subscription = subscriptionRow;

            await getSharedUsers();
            lvShare_visibility();
        }

        private async Task getSharedUsers()
        {
            if (this.subscription != null)
            {
                this.lv_share.Items.Clear();   
                string filter = $"{{\"SUB_LAPSE_ID\": \"{this.subscription.SUB_LAPSE_ID}\"}}";
                string columns = "\"USER_\"";

                userList = await request.PostAsync(
                    "userSubs/userSub/search",
                    columns,
                    filter);

                foreach (RequestObject ro in userList)
                {
                    ListViewItem item = new ListViewItem(ro.USER_);
                    this.lv_share.Items.Add(item);
                }

                Console.WriteLine($"Número de elementos en lv_share: {this.lv_share.Items.Count}");
            }           
        }

        private void UserSubscriptionDetailsControl_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tb_freq_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_start_TextChanged(object sender, EventArgs e)
        {

        }

        private async void bttn_save_Click(object sender, EventArgs e)
        {
            string autorenewal = this.cb_renew.Checked.ToString().ToLower();
            int sub_lapse_id = this.subscription.SUB_LAPSE_ID;
            int subs_id = this.subscription.SUBS_ID;
            int fr_id = this.subscription.FR_ID;

            await this.request.PutAsync(
                "subLapses/subLapse",
                $"\"SUB_LAPSE_ID\": {sub_lapse_id},\"SUBS_ID\": {subs_id},\"FR_ID\": {fr_id}",
                $"\"SUBS_AUTORENEWAL\": {autorenewal}"
                );

            MessageBox.Show("Suscripcion actualizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.bttn_save.Visible = false;
        }

        private void cb_renew_Click(object sender, EventArgs e)
        {
            this.bttn_save.Visible = true;
        }

        private void bttn_share_Click(object sender, EventArgs e)
        {
            UserShareForm userShareForm = new UserShareForm(request, this.subscription.SUB_LAPSE_ID);
            userShareForm.ShowDialog();
        }
    }
}
