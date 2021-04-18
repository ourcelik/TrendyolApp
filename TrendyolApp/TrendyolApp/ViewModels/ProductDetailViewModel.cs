using System;
using System.Collections.Generic;
using System.Text;
using TrendyolApp.Data;
using TrendyolApp.Models;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {
        public ProductDetailViewModel()
        {
            AddProductToCart = new Command((product) =>
            {
                CartData.AddProduct((ProductModel)product);

            });
        }
        public Command AddProductToCart { get; }
    }
}
