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

namespace TrendyolApp.ViewModels
{
    class ProductListViewModel : BaseViewModel
    {
        ObservableCollection<Product> Products;
        ProductService ProductService;
        ObservableCollection<Product> listProducts;
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

        public ProductListViewModel(SubSubCategory category)
        {
            listProducts = new ObservableCollection<Product>();
            ProductService = new ProductService();
            GetCategories(category).Await();
        }
        public ProductListViewModel()
        {

        }
        public async Task GetCategories(SubSubCategory category)
        {
            var products = await GetProducts(category);
            List<Product> data = products.Where(p => p.Category.CategoryId == category.CategoryId
            && p.SubCategory.SubCategoryId == category.SubCategoryId
            && p.SubSubCategory.SubSubCategoryId == category.SubSubCategoryId).ToList();

            data.ForEach(p => ListProducts.Add(p));
            Thread.Sleep(450);
        }
        public async Task<ObservableCollection<Product>> GetProducts(SubSubCategory category)
        {
            var data = await ProductService.GetProductsAsync();
            Products = data.model.Products;
            return Products;
        }
    }
}
