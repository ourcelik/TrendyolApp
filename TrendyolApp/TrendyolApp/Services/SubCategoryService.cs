using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services
{
    public class SubCategoryService
    {
        HttpClient client;
        public SubCategoryService()
        {
        }

        public async Task<DataModel<SubCategoryModel>> GetSubCategoriesAsync()
        {
            var EndPoint = ConnectionHelper.url;
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };
            client = new HttpClient(httpClientHandler) { BaseAddress = new Uri(EndPoint) };
            var queryObject = new
            {
                query = @"query{
                  subCategory{
                    id
                    categoryName
                    categoryId
                  }
                }",
                variables = new { }
            };
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                Content = new StringContent(JsonConvert.SerializeObject(queryObject, Formatting.Indented), Encoding.UTF8, "application/json")
            };
            DataModel<SubCategoryModel> responseObj;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();
                responseObj = JsonConvert.DeserializeObject<DataModel<SubCategoryModel>>(responseString);
            };

            return responseObj;
        }
       
    }


}
