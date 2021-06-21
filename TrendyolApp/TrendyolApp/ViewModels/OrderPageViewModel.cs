using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Data;
using TrendyolApp.Extensions;
using TrendyolApp.LocalService;
using TrendyolApp.Models;
using TrendyolApp.Services;
using TrendyolApp.Services.abstracts;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class OrderPageViewModel : BaseViewModel
    {
        #region Services
        readonly IProductService _productService;
        #endregion
        #region Variables
        ObservableCollection<Product> Products;
        private decimal sumOfCart = 0;
        #endregion
        #region Props
        public decimal SumOfCart
        {
            get
            {
                return sumOfCart;
            }
            set
            {
                sumOfCart = value;
                OnPropertyChanged(nameof(SumOfCart));
            }
        } 
        #endregion
        public OrderPageViewModel(IProductService productService)
        {
            _productService = productService;
            GetProducts().Await();
        }
        private async Task UpdateCartCostAsync()
        {
            SumOfCart = 0;
            var data = await CartService.GetAll();
            foreach (var item in data)
            {
                var product = Products.Where(p => p.ProductId == item.ProductId).FirstOrDefault();
                SumOfCart += product.Price * item.Count;
            }
        }
        private async Task GetProducts()
        {
            var data = await _productService.GetProductsAsync();
            Products = data.model.Products;
            await UpdateCartCostAsync();
        }

    }
}
