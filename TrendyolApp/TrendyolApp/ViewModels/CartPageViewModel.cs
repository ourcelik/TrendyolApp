using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TrendyolApp.Models;
using System.Linq;
using TrendyolApp.Data;
using TrendyolApp.Extensions;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class CartPageViewModel : BaseViewModel
    {
        ObservableCollection<CartModel> cartProducts;


        public ObservableCollection<CartModel> CartProducts
        {
            get { return cartProducts; }
        }
        ObservableCollection<ProductModel> randomProducts;

        public ObservableCollection<ProductModel> RandomProducts { get { return randomProducts; } }
        public CartPageViewModel()
        {
            GetShuffleProducts();
            GetCartProduct();
            AddProduct = new Command(
                (product) =>
                {
                    CartData.AddProduct((ProductModel)product);
                    OnPropertyChanged(nameof(CartProducts));
                }

                );
            RemoveProduct = new Command(
                (Product) =>
                {
                    CartData.RemoveProduct((ProductModel)Product);
                    OnPropertyChanged(nameof(CartProducts));

                }

                );

        }

        private void GetShuffleProducts()
        {
            var data = ProductData.GetProducts();
            data.Shuffle();
            randomProducts = data;
        }
        private void GetCartProduct()
        {
            cartProducts = CartData.CreateCart();

        }

        public Command AddProduct { get; set; }
        public Command RemoveProduct { get; set; }

    }
}
