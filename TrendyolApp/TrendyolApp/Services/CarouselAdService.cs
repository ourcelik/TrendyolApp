using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services
{



    public class CarouselAdService
    {
        HttpClient client;
        public CarouselAdService()
        {
        }

        public async Task<DataModel<CarouselModel>> GetAdsAsync()
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
                      carouselAd
                      {
                        id
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
            DataModel<CarouselModel> responseObj;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();
                responseObj = JsonConvert.DeserializeObject<DataModel<CarouselModel>>(responseString);
            };

            return responseObj;
        }
    }

   


}
