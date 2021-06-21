using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using TrendyolApp.Services.abstracts;

namespace TrendyolApp.Services
{



    public class CarouselAdService : BaseService<CarouselModel>,ICarouselAdService
    {
        public CarouselAdService()
        {
        }

        public async Task<DataModel<CarouselModel>> GetAdsAsync()
        {
            return await GetDataAsync(new QueryObject
            {
                Query = @"query{
                      carouselAd
                      {
                        id
                        url
                      }
                    }"

            });
        }
    }




}
