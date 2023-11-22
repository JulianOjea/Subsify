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

    public class ImageData
    {
        public long serializationStartTime { get; set; }
        public long serializationFinalTime { get; set; }
        public byte[] bytes { get; set; }
    }

    public class SubscriptionRow
    {
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime SUB_LAPSE_END { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime SUB_LAPSE_START { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime PLAN_PRICE_START { get; set; }
        public String PLATF_NAME { get; set; }
        public int SUB_LAPSE_ID { get; set; }
        public double SUB_LAPSE_PRICE { get; set; }
        public String PLAN_NAME { get; set; }
        public String CAT_NAME { get; set; }
        public String FR_NAME { get; set; }
        public double FR_VALUE { get; set; }
        public double shared_price { get; set; }
        public int PLATF_ID { get; set; }
        public double PLAN_PRICE_VALUE { get; set; }
        public int PLAN_ID { get; set; }
        public int FR_ID { get; set; }
        public int CAT_ID { get; set; }
        public int PLAN_PRICE_ID { get; set; }
        public int SUBS_ID { get; set; }
        public ImageData PLATF_IMAGE { get; set; }
        public bool SUBS_AUTORENEWAL { get; set; }
        public string PLATF_LINK { get; set; }
    }

    public class Request
    {
        static HttpClient _client;
        string username;
        string password;

        public Request(string username, string password) {
            this.username = username;
            this.password = password;
        }

        private HttpClient initClientCredentials()
        {
            HttpClient client = new HttpClient();

            string username = this.username;
            string password = this.password;
            string base64Credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Credentials);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        public async Task<List<SubscriptionRow>> PostAsync(string uriString, string columns, string filter) {

            _client = initClientCredentials();
            _client.BaseAddress = new Uri("http://localhost:33333/" + uriString);
            string bodyFilter = "";
            if (!filter.Equals(""))
            {
                bodyFilter += $"\"filter\": {filter},";
            }
            string body = $"{{{bodyFilter}\"columns\": [{columns}]}}";
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

        public async Task<bool> PostInsertAsync(string uriString, string filter, string sqlTypes)
        {

            _client = initClientCredentials();
            _client.BaseAddress = new Uri("http://localhost:33333/" + uriString);

            string body = $"{{\"data\": {filter}, \"sqltypes\": {{{sqlTypes}}}}}";
            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync("", content);

            if (response.IsSuccessStatusCode)
            {
                return response.IsSuccessStatusCode;

            }
            throw new HttpRequestException($"Failed to fetch data. Status code: {response.StatusCode}");
        }

        public async Task<bool> PutInsertAsync(string uriString, string filter, string data)
        {

            _client = initClientCredentials();
            _client.BaseAddress = new Uri("http://localhost:33333/" + uriString);
            string bodyFilter = $"\"filter\": {{{filter}}}";
            string bodyData = $"\"data\": {{{data}}}";
            string body = $"{{{bodyFilter},{bodyData}}}";
            //string body = $"{{\"data\": {filter}, \"sqltypes\": {{{sqlTypes}}}}}";
            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PutAsync("", content);

            if (response.IsSuccessStatusCode)
            {
                return response.IsSuccessStatusCode;

            }
            throw new HttpRequestException($"Failed to fetch data. Status code: {response.StatusCode}");
        }
    }
}
