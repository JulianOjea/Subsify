using SubsifyFrontend.Util.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SubsifyFrontend.Design.Forms.Admin
{
    public partial class AdminAddPlanForm : Form
    {   
        public Request request { get; set; }
        List<RequestObject> platfList;
        int plat_id;
        List<RequestObject> freqList;
        int freq_id;
        public AdminAddPlanForm(Request request)
        {
            this.request = request;
            InitializeComponent();

            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.cb_platform.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_freq.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void AdminAddPlanForm_Load(object sender, EventArgs e)
        {
            platfList = await request.PostAsync("platforms/platform/search",
            "\"PLATF_ID\",\"PLATF_NAME\"",
                "");

            foreach (RequestObject responseRow in platfList)
            {
                cb_platform.Items.Add(responseRow.PLATF_NAME);
            }

            freqList = await request.PostAsync("frequencies/frequency/search",
            "\"FR_ID\",\"FR_NAME\"",
                "");

            foreach (RequestObject responseRow in freqList)
            {
                cb_freq.Items.Add(responseRow.FR_NAME);
            }
        }

        private async void bttn_ok_Click(object sender, EventArgs e)
        {
            string plan_name = this.tb_plan_name.Text;
            DateTime selectedDate = cal_start_date.SelectionRange.Start;
            //DateTime utcSelectedDate = selectedDate.ToUniversalTime();
            long milFromEpoch = (long)(selectedDate - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

            string data = $"{{\"PLATF_ID\": {plat_id}, " +
                $"\"PLAN_NAME\": \"{plan_name}\", " +
                $"\"PLAN_PRICE_VALUE\": {tb_price.Text}, " +
                $"\"PLAN_PRICE_START\": {milFromEpoch}," +
                $"\"FR_ID\": {freq_id}}}";

            string types = "\"PLAN_PRICE_VALUE\": 6, \"PLAN_PRICE_START\": 91";
            await request.PostInsertAsync(
                "plans/plan",
                data,
                types
                );
            this.Close();
        }

        private void cb_platform_SelectedIndexChanged(object sender, EventArgs e)
        {
            plat_id = platfList[cb_platform.SelectedIndex].PLATF_ID;
        }

        private void cb_freq_SelectedIndexChanged(object sender, EventArgs e)
        {
            freq_id = freqList[cb_freq.SelectedIndex].FR_ID;
        }
    }
}
