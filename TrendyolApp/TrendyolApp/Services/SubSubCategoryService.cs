using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services
{
    public class SubSubCategoryService
    {
        HttpClient client;
        public SubSubCategoryService()
        {
        }

        public async Task<DataModel<SubSubCategoryModel>> GetSubSubCategoriesAsync()
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
                      subSubCategory
                      {
                        id
                        categoryName
                        subCategoryId
                        categoryId
                        url
    
                      }
                    }",
                variables = new { }
            };
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                Content = new StringContent(JsonConvert.SerializeObject(queryObject, Formatting.Indented), Encoding.UTF8, "application/json")
            };
            DataModel<SubSubCategoryModel> responseObj;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();
                responseObj = JsonConvert.DeserializeObject<DataModel<SubSubCategoryModel>>(responseString);
            };

            return responseObj;
        }
    }


}
