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

namespace TrendyolApp.ViewModels
{
    class SearchProductViewModel : BaseViewModel
    {
        ObservableCollection<Product> Products;
        ProductService ProductService;
        public SearchProductViewModel()
        {
            ProductService = new ProductService();
        }

        public async Task<List<Product>> GetSearchData(Expression<Func<Product, bool>> filter = null)
        {
            await GetProducts();
            return filter == null ? Products.ToList()
                   : Products.Where(filter.Compile()).ToList();
        }
        public async Task GetProducts()
        {
            var data = await ProductService.GetProductsAsync();
            Products = data.model.Products;
        }

    }
}
