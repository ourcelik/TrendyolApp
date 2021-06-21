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
    public class ProductService : BaseService<ProductModel>,IProductService
    {
        public ProductService()
        {
        }

        public async Task<DataModel<ProductModel>> GetProductsAsync()
        {
            return await GetDataAsync(new QueryObject
            {
                Query = @"query{
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
                        "
            });
        }
    }


}
