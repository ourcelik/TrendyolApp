using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using TrendyolApp.Services.abstracts;

namespace TrendyolApp.Services
{
    public class CategoryService : BaseService<CategoryModel>,ICategoryService
    {
        public CategoryService()
        {
        }

        public async Task<DataModel<CategoryModel>> GetCategoriesAsync()
        {
            return await GetDataAsync(new QueryObject
            {
                Query = @"query{
                          category{
                            id
                            categoryName
                            url
                          }
                        }
                        "
            });
        }
    }
}
