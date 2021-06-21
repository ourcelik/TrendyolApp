using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TrendyolApp.Data;
using TrendyolApp.LocalService;
using TrendyolApp.Models;
using TrendyolApp.SqlLiteModels;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {
        #region Commands
        public ICommand AddProductToCart { get; set; } 
        #endregion

        public ProductDetailViewModel()
        {
            DefineCommands();
        }

        private void DefineCommands()
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
    }
}
