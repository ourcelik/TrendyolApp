using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services
{
    public abstract class BaseService<T>
    {
        HttpClient _client;
        public BaseService()
        {
        }

        public async Task<DataModel<T>> GetDataAsync(QueryObject queryObject)
        {
            var EndPoint = ConnectionHelper.url;
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };
            _client = new HttpClient(httpClientHandler) { BaseAddress = new Uri(EndPoint) };
            var QueryObject = new
            {
                query = queryObject.Query,
                
            };
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                Content = new StringContent(JsonConvert.SerializeObject(QueryObject, Formatting.Indented), Encoding.UTF8, "application/json")
            };
            DataModel<T> responseObj;
            using (var response = await _client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();
                responseObj = JsonConvert.DeserializeObject<DataModel<T>>(responseString);
            };

            return responseObj;
        }
    }
}
