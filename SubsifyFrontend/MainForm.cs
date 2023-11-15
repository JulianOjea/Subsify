using SubsifyFrontend.Model.Entity;
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
using static SubsifyFrontend.PruebaHttp;

namespace SubsifyFrontend
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _client;
        private readonly Request _request;

        public MainForm(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _request = new Request(_client);

            InitializeComponent();
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {

            List<SubscriptionRow> subscriptionTable = await _request.PostAsync(
                "http://localhost:33333/subLapses/subLapse/search", 
                "\"SUB_LAPSE_ID\",\"SUB_LAPSE_PRICE\",\"PLATF_NAME\",\"CAT_NAME\"");
            Console.WriteLine(subscriptionTable.Count);

            foreach (var subscriptionRow in subscriptionTable)
            { 
                userSubscriptionControl1.AddSubscriptionRow(subscriptionRow);
            }
        }

        private void lb_subscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userHomeControl1.Visible = true; 
            userSubscriptionControl1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userHomeControl1.Visible = false;
            userSubscriptionControl1.Visible = true;
        }

        private void userHomeControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
