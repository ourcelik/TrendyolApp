using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using TrendyolApp.Services.abstracts;

namespace TrendyolApp.Services
{
    public class PhotoService : BaseService<PhotoModel>,IPhotoService
    {
        public PhotoService()
        {
        }

        public async Task<DataModel<PhotoModel>> GetPhotosAsync()
        {
            return await GetDataAsync(new QueryObject
            {
                Query = @"query{
                      photo{
                        id
                        url
                        productId
                      }
                    }"
            });
        }
    }


}
