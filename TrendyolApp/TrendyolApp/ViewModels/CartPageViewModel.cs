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
using TrendyolApp.LocalService;
using TrendyolApp.SqlLiteModels;
using System.Threading.Tasks;

namespace TrendyolApp.ViewModels
{

    public class CartPageViewModel : BaseViewModel
    {
        ObservableCollection<Cart> cartProducts;
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

        public ObservableCollection<Cart> CartProducts
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
            cartProducts = new ObservableCollection<Cart>();
            GetShuffleProducts();
            GetCartProduct();
            AddProduct = new Command(
                async (product) =>
                {
                    ProductModel _product = (ProductModel)product;
                    await CartService.Add(new SqlLiteCart() { ProductId = _product.ProductId, Count = 1 });
                    await GetCartProduct();
                    UpdateCartCost();
                    OnPropertyChanged(nameof(sumOfCart));
                    OnPropertyChanged(nameof(CartProducts));

                }

                );
            RemoveProduct = new Command(
                async (product) =>
                {
                    ProductModel _product = (ProductModel)product;
                    var cart = await CartService.GetByProductId(_product.ProductId);
                    await CartService.Delete(cart.Id);
                    await GetCartProduct();
                    UpdateCartCost();
                    OnPropertyChanged(nameof(sumOfCart));
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
        public async Task GetCartProduct()
        {
            var data = await CartService.GetAll();
            CartProducts.Clear();
            data.ForEach(c => CartProducts.Add(new Cart { Product = ProductData.Products.Where(p => p.ProductId == c.ProductId).FirstOrDefault(), Count = c.Count }));
            UpdateCartCost();
            OnPropertyChanged(nameof(sumOfCart));
            OnPropertyChanged(nameof(CartProducts));

        }
        public void UpdateCartCost()
        {
            SumOfCart = 0;
            foreach (var item in CartProducts)
            {

                SumOfCart += item.Product.Price * item.Count;
            }
        }
        public async Task CleanToCart()
        {
            await CartService.DeleteAllCartData();
        }

        public Command AddProduct { get; set; }
        public Command RemoveProduct { get; set; }
        public Command ExecuteAsync { get; set; }

    }
}
