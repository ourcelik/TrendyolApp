using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services
{
    public class ProductService
    {
        HttpClient client;
        public ProductService()
        {
        }

        public async Task<DataModel<ProductModel>> GetProductsAsync()
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
                  product{
                    id
                    brand
                    description
                    productName
                    photos{
                      url
                    }
                    seller
                    productInfo
                    price
                    category{
                      id
                      categoryName
                      url
                    }
                    subCategory{
                    id
                    categoryName
                    categoryId
                  }
                    subSubCategory
                  {
                    id
                    categoryName
                    subCategoryId
                    categoryId
                    url
    
                  }
                    topPhoto
                    {
                      url
                    }
                    photos{
                      id
                    }
    
                  }
                }
                        ",
                variables = new { }
            };
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                Content = new StringContent(JsonConvert.SerializeObject(queryObject, Formatting.Indented), Encoding.UTF8, "application/json")
            };
            DataModel<ProductModel> responseObj;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();
                responseObj = JsonConvert.DeserializeObject<DataModel<ProductModel>>(responseString);
            };

            return responseObj;
        }
    }


}
