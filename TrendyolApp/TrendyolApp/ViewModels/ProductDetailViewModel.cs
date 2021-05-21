using System;
using System.Collections.Generic;
using System.Text;
using TrendyolApp.Data;
using TrendyolApp.LocalService;
using TrendyolApp.Models;
using TrendyolApp.SqlLiteModels;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {
        public ProductDetailViewModel()
        {
            AddProductToCart = new Command(async (product) =>
            {
                var Product = (ProductModel)product;
                await CartService.Add(new SqlLiteCart() { ProductId = Product.ProductId, Count = 1 });


            });
        }
        public Command AddProductToCart { get; }
    }
}
