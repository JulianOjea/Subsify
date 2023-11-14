using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SubsifyFrontend
{
    public class Category
    {
        public string CAT_ID { get; set; }
        public string CAT_NAME { get; set; }
    }

    public class ApiResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<Category> Data { get; set; }
    }

    public class PruebaHttp
    {
        static HttpClient client = new HttpClient();

        static async Task<List<Category>> GetProductAsync(string path)
        {
            List<Category> categories = null;
            HttpResponseMessage response = await client.GetAsync(path);
            Console.WriteLine("ey");
            Console.WriteLine(response.Content);
            if (response.IsSuccessStatusCode)
            {
                ApiResponse apiResponse = await response.Content.ReadAsAsync<ApiResponse>();
                categories = apiResponse.Data;
                foreach (var category in categories)
                {
                    Console.WriteLine("Category ID: " + category.CAT_ID + ", Category Name: " + category.CAT_NAME);
                }
            }
            return categories;
        }

        public static async Task RunAsync()
        {
            Console.WriteLine("pues ha entrado al final");
            client.BaseAddress = new Uri("http://localhost:33333/categories/category?columns=CAT_ID,CAT_NAME");
            string username = "demo";
            string password = "demouser";
            string base64Credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Credentials);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                List<Category> categories = null;
                categories = await GetProductAsync("");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
