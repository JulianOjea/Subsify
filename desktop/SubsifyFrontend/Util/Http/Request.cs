using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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

    public class Request
    {
        public static string IP_PORT_ENDPOINT = "http://localhost:33333/";
        private static HttpClient _client;
        private string username;
        private string password;

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

        public async Task<List<RequestObject>> PostAsync(string uriString, string columns, string filter) {

            _client = initClientCredentials();
            _client.BaseAddress = new Uri(Request.IP_PORT_ENDPOINT + uriString);
            string bodyFilter = "";
            if (!filter.Equals(""))
            {
                bodyFilter += $"\"filter\": {filter},";
            }
            string body = $"{{{bodyFilter}\"columns\": [{columns}]}}";
            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync("", content);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    ApiResponse apiResponse = await response.Content.ReadAsAsync<ApiResponse>();
                    List<object> responseData = apiResponse.data;

                    List<RequestObject> subscriptionTable = new List<RequestObject>();

                    foreach (var item in responseData)
                    {
                        RequestObject subscriptionRow = JsonConvert.DeserializeObject<RequestObject>(item.ToString());

                        subscriptionTable.Add(subscriptionRow);
                    }

                    return subscriptionTable;

                }
            }
            catch (JsonSerializationException)
            {
                return new List<RequestObject> { };
            }
            throw new HttpRequestException($"Failed to fetch data. Status code: {response.StatusCode}");
        }

        public async Task<bool> PostInsertAsync(string uriString, string filter, string sqlTypes)
        {

            _client = initClientCredentials();
            _client.BaseAddress = new Uri(Request.IP_PORT_ENDPOINT + uriString);

            string body = $"{{\"data\": {filter}, \"sqltypes\": {{{sqlTypes}}}}}";
            HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync("", content);

            if (response.IsSuccessStatusCode)
            {
                return response.IsSuccessStatusCode;

            }
            throw new HttpRequestException($"Failed to fetch data. Status code: {response.StatusCode}");
        }

        public async Task<bool> PutAsync(string uriString, string filter, string data)
        {

            _client = initClientCredentials();
            _client.BaseAddress = new Uri(Request.IP_PORT_ENDPOINT + uriString);
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
