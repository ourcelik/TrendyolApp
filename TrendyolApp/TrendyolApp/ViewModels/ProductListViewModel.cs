using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using TrendyolApp.Data;
using TrendyolApp.Extensions;
using TrendyolApp.Models;
using TrendyolApp.Services;
using TrendyolApp.Services.abstracts;

namespace TrendyolApp.ViewModels
{
    class ProductListViewModel : BaseViewModel
    {
        #region Services
        readonly IProductService _productService;
        #endregion
        #region Variables
        ObservableCollection<Product> Products;
        ObservableCollection<Product> listProducts;
        #endregion
        #region Props
        public ObservableCollection<Product> ListProducts
        {
            get
            {
                return listProducts;
            }
            set
            {
                listProducts = value;
                OnPropertyChanged(nameof(ListProducts));
            }

        } 
        #endregion

        public ProductListViewModel(IProductService productService)
        {
            listProducts = new ObservableCollection<Product>();
            _productService = productService;
        }
     
        public async Task GetCategories(SubSubCategory category)
        {
            var products = await GetProducts(category);
            List<Product> data = products.Where(p => p.Category.CategoryId == category.CategoryId
            && p.SubCategory.SubCategoryId == category.SubCategoryId
            && p.SubSubCategory.SubSubCategoryId == category.SubSubCategoryId).ToList();

            data.ForEach(p => ListProducts.Add(p));
            OnPropertyChanged(nameof(listProducts));
        }
        public async Task<ObservableCollection<Product>> GetProducts(SubSubCategory category)
        {
            var data = await _productService.GetProductsAsync();
            Products = data.model.Products;
            return Products;
        }
    }
}
