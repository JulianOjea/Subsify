using SubsifyFrontend.Design.Assets;
using SubsifyFrontend.Util.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubsifyFrontend.Design.Forms.User
{
    public partial class UserShareForm : Form
    {
        private Request request;
        private List<RequestObject> userList;
        private String user_;
        private int sub_lapse_id;
        public UserShareForm(Request request, int sub_lapse_id)
        {
            this.request = request;
            this.sub_lapse_id = sub_lapse_id;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.BackColor = Color.FromArgb(0x98, 0xB9, 0xCA);
            Bitmap subsify_round_logo = resources.subsify_favicon_logo;
            this.Icon = Icon.FromHandle(subsify_round_logo.GetHicon());

            InitializeComponent();
        }

        private async void UserShareForm_Load(object sender, EventArgs e)
        {
            this.userList = await request.PostAsync("users/userToShare/search",
                "\"USER_\",\"NAME\"", "");

            foreach (RequestObject item in userList)
            {
                cb_users.Items.Add(item.USER_);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int sub_lapse_id = this.sub_lapse_id;
            string user_ = this.user_;
            string data = $"{{\"SUB_LAPSE_ID\": \"{sub_lapse_id}\", \"USER_\": \"{user_}\"}}";

            await request.PostInsertAsync(
                "userSubs/userSub",
                data,
                ""
                );
            this.Close();
        }

        private void cb_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.user_ = this.userList[cb_users.SelectedIndex].USER_;
        }
    }
}
