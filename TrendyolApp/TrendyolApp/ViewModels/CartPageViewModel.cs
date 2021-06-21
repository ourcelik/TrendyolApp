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
using TrendyolApp.Services;
using TrendyolApp.Services.abstracts;
using System.Windows.Input;

namespace TrendyolApp.ViewModels
{

    public class CartPageViewModel : BaseViewModel
    {
        #region Services
        readonly IProductService _productService;
        #endregion
        #region Commands
        public ICommand AddProduct { get; set; }
        public ICommand RemoveProduct { get; set; }
        #endregion
        #region Variables
        ObservableCollection<Cart> cartProducts;
        ObservableCollection<Product> Products;
        ObservableCollection<Product> randomProducts;
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

        public ObservableCollection<Product> RandomProducts
        {
            get
            {
                return randomProducts;
            }
            set
            {
                randomProducts = value;
                OnPropertyChanged(nameof(RandomProducts));
            }
        }
        #endregion
        public CartPageViewModel(IProductService productService)
        {
            _productService = productService;
            cartProducts = new ObservableCollection<Cart>();
            GetProductData().Await();
            DefineCommands();
        }

        private void DefineCommands()
        {
            AddProduct = new Command(
                async (product) =>
                {
                    try
                    {
                        Product _product = (Product)product;
                        await CartService.Add(new SqlLiteCart() { ProductId = _product.ProductId, Count = 1 });
                        await GetCartProduct();
                        UpdateCartCost();
                        OnPropertyChanged(nameof(SumOfCart));
                        OnPropertyChanged(nameof(CartProducts));
                    }
                    catch (Exception)
                    {

                    }

                }

                );
            RemoveProduct = new Command(
                async (product) =>
                {
                    try
                    {
                        Product _product = (Product)product;
                        var cart = await CartService.GetByProductId(_product.ProductId);
                        await CartService.Delete(cart.Id);
                        await GetCartProduct();
                        UpdateCartCost();
                        OnPropertyChanged(nameof(SumOfCart));
                        OnPropertyChanged(nameof(CartProducts));
                    }
                    catch (Exception)
                    {


                    }

                }

                );
        }

        private void GetShuffleProducts()
        {
            Products.Shuffle();
            RandomProducts = Products;
        }

        private async Task GetProductData()
        {
            var data = await _productService.GetProductsAsync();
            Products = data.model.Products;
            GetShuffleProducts();
            await GetCartProduct();
        }

        public async Task GetCartProduct()
        {
            var data = await CartService.GetAll();
            CartProducts.Clear();
            data.ForEach(c => CartProducts.Add(new Cart { Product = Products.Where(p => p.ProductId == c.ProductId).FirstOrDefault(), Count = c.Count }));
            UpdateCartCost();
            OnPropertyChanged(nameof(SumOfCart));
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



    }
}
