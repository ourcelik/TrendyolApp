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
        private decimal sumOfCart = 0;
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

        public ObservableCollection<CartModel> CartProducts
        {
            get
            {
                return cartProducts;
            }
            set
            {
                cartProducts = value;
                UpdateCartCost();
                OnPropertyChanged(nameof(CartProducts));
            }
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
                    ProductModel _product = (ProductModel)product;
                    CartData.AddProduct(_product);
                    UpdateCartCost();
                    OnPropertyChanged(nameof(sumOfCart));
                    OnPropertyChanged(nameof(CartProducts));

                }

                );
            RemoveProduct = new Command(
                (product) =>
                {
                    ProductModel _product = (ProductModel)product;
                    CartData.RemoveProduct((ProductModel)product);
                    UpdateCartCost();
                    OnPropertyChanged(nameof(sumOfCart));
                    OnPropertyChanged(nameof(CartProducts));

                }

                );
            UpdateCartCost();

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
        public void UpdateCartCost()
        {
            SumOfCart = 0;
            foreach (var item in cartProducts)
            {
                SumOfCart += item.Product.Price * item.Count;
            }
        }
        public void CleanToCart()
        {
            CartData.Clear();
        }

        public Command AddProduct { get; set; }
        public Command RemoveProduct { get; set; }

    }
}
