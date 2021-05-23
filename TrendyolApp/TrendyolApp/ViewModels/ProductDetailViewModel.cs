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
                var Product = (Product)product;
                try
                {
                    await CartService.Add(new SqlLiteCart() { ProductId = Product.ProductId, Count = 1 });
                }
                catch (Exception)
                {
                }


            });
        }
        public Command AddProductToCart { get; }
    }
}
