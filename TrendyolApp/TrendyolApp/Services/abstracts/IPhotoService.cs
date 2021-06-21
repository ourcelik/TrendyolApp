using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services.abstracts
{
    interface IPhotoService
    {
        public Task<DataModel<PhotoModel>> GetPhotosAsync();
    }
}
