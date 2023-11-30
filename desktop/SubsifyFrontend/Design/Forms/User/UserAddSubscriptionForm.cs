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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SubsifyFrontend.Design.Forms.User
{
  
    public partial class UserAddSubscriptionForm : Form
    {
        public Request request { get; set; }
        List<RequestObject> platfList;
        List<RequestObject> planList;
        int plat_id;
        int plan_price_id;
        double sub_lapse_price;
        public  UserAddSubscriptionForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //cb_platf_name
            this.cb_platf_name.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_plan_name.DropDownStyle = ComboBoxStyle.DropDownList;
            this.tb_price.ReadOnly = true;

            this.BackColor = Color.FromArgb(0x98, 0xB9, 0xCA);
            Bitmap subsify_round_logo = resources.subsify_favicon_logo;
            this.Icon = Icon.FromHandle(subsify_round_logo.GetHicon());
        }

        private async void UserAddSubscriptionForm_Load(object sender, EventArgs e)
        {
            platfList = await request.PostAsync("platforms/platform/search",
                "\"PLATF_ID\",\"PLATF_NAME\"",
                "");

            foreach (RequestObject responseRow in platfList)
            {
                cb_platf_name.Items.Add(responseRow.PLATF_NAME);
            }
        }

        private async void cb_platf_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_price.Text = string.Empty;
            cb_plan_name.Items.Clear();
            plat_id = platfList[cb_platf_name.SelectedIndex].PLATF_ID;
            string filter = $"{{\"PLATF_ID\": {plat_id}}}";
            planList = await request.PostAsync(
                "plans/planActive/search",
                "\"PLAN_ID\",\"PLAN_NAME\",\"PLAN_PRICE_VALUE\",\"FR_NAME\",\"PLAN_PRICE_ID\"",
                filter);

            foreach (RequestObject responseRow in planList)
            {
                cb_plan_name.Items.Add(responseRow.PLAN_NAME + " (" +responseRow.FR_NAME + ")");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cb_plan_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub_lapse_price = planList[cb_plan_name.SelectedIndex].PLAN_PRICE_VALUE;
            tb_price.Text = $"{sub_lapse_price:C}";
            
            plan_price_id = planList[cb_plan_name.SelectedIndex].PLAN_PRICE_ID;
        }

        /*
            String fechaToString = fechaSeleccionada.ToString("ddd MMM dd HH:mm:ss 'CET' yyyy");
            Console.WriteLine("Fecha seleccionada: " + fechaToString);
            Console.WriteLine("Fecha seleccionada: " + fechaSeleccionada.ToString("yyyy-MM-dd"));
            //cal_startDate*/
        private async void bttn_ok_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = cal_startDate.SelectionRange.Start;
            long milisegundosDesdeEpoca = (long)(fechaSeleccionada - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            string subLapsePriceFormatted = sub_lapse_price.ToString("F2", cultureInfo);
            string data = $"{{\"PLATF_iD\": {plat_id}, \"PLAN_PRICE_ID\": {plan_price_id}, \"SUB_LAPSE_PRICE\": " +
                $"{subLapsePriceFormatted}, \"SUB_LAPSE_START\": {milisegundosDesdeEpoca}}}";
            string types = "\"SUB_LAPSE_PRICE\": 6,\"SUB_LAPSE_START\": 91,\"SLC_END\": 91";
            await request.PostInsertAsync(
                "subscriptions/subscription",
                data,
                types
                );
            this.Close();
        }
    }
}
