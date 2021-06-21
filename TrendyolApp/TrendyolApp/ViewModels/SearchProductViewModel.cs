using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Data;
using TrendyolApp.Extensions;
using TrendyolApp.Models;
using TrendyolApp.Services;
using TrendyolApp.Services.abstracts;

namespace TrendyolApp.ViewModels
{
    class SearchProductViewModel : BaseViewModel
    {
        #region Services
            readonly IProductService _productService;
        #endregion
        #region Variables
        ObservableCollection<Product> Products; 
        #endregion
        public SearchProductViewModel(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<List<Product>> GetSearchData(Expression<Func<Product, bool>> filter = null)
        {
            await GetProducts();
            return filter == null ? Products.ToList()
                   : Products.Where(filter.Compile()).ToList();
        }
        public async Task GetProducts()
        {
            var data = await _productService.GetProductsAsync();
            Products = data.model.Products;
        }

    }
}
