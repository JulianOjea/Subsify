using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SubsifyFrontend.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SubsifyFrontend.Util.Http
{   
    public class SubscriptionRow
    {
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime SUB_LAPSE_END { get; set; }
        public String PLATF_NAME { get; set; }
        public int SUB_LAPSE_ID { get; set; }
        public double SUB_LAPSE_PRICE { get; set; }
        public String PLAN_NAME { get; set; }
        public String CAT_NAME { get; set; }
    }

    public class Request
    {
        static HttpClient _client;

        public Request(HttpClient client) {
            _client = client ?? throw new ArgumentNullException(nameof(client));

            string username = "Adam";
            string password = "1234";
            string base64Credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Credentials);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<SubscriptionRow>> PostAsync(string uriString, string columns) {

            _client.BaseAddress = new Uri("http://localhost:33333/subLapses/subLapse/search");
            
            string body = $"{{\"columns\": [{columns}]}}";
            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync("", content);

            if (response.IsSuccessStatusCode)
            {
                ApiResponse apiResponse = await response.Content.ReadAsAsync<ApiResponse>();
                List<object> responseData = apiResponse.data;

                List<SubscriptionRow> subscriptionTable = new List<SubscriptionRow>();

                foreach (var item in responseData)
                {
                    SubscriptionRow subscriptionRow = JsonConvert.DeserializeObject<SubscriptionRow>(item.ToString());
                    subscriptionTable.Add(subscriptionRow);
                }

                return subscriptionTable;

            }
            throw new HttpRequestException($"Failed to fetch data. Status code: {response.StatusCode}");
        }
    }
}
