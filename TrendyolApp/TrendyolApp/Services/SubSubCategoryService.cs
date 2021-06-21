using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using TrendyolApp.Services.abstracts;

namespace TrendyolApp.Services
{
    public class SubSubCategoryService : BaseService<SubSubCategoryModel>, ISubSubCategoryService
    {
        public SubSubCategoryService()
        {
        }

        public async Task<DataModel<SubSubCategoryModel>> GetSubSubCategoriesAsync()
        {
            return await GetDataAsync(new QueryObject
            {
                Query = @"query{
                      subSubCategory
                      {
                        id
                        categoryName
                        subCategoryId
                        categoryId
                        url
    
                      }
                    }"
            });

        }
    }


}
