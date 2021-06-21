using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using TrendyolApp.Services.abstracts;

namespace TrendyolApp.Services
{
    public class SubCategoryService : BaseService<SubCategoryModel>,ISubCategoryService
    {
        public SubCategoryService()
        {
        }

        public async Task<DataModel<SubCategoryModel>> GetSubCategoriesAsync()
        {
            return await GetDataAsync(new QueryObject
            {
                Query = @"query{
                  subCategory{
                    id
                    categoryName
                    categoryId
                  }
                }"
            });
        }

    }


}
