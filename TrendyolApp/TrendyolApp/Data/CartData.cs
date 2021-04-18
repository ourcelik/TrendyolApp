using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TrendyolApp.Models;

namespace TrendyolApp.Data
{
    public static class CartData
    {
        public static ObservableCollection<CartModel> Products { get { return products; } }
        public static ObservableCollection<CartModel> products;

        public static ObservableCollection<CartModel> CreateCart()
        {
            if (products == null)
            {
                products = new ObservableCollection<CartModel>();
            }
            return Products;
        }

        public static void AddProduct(ProductModel product)
        {
            var data = Products.Where(c => c.Product.ProductId == product.ProductId).SingleOrDefault();
            if (!AlreadyExists(data))
            {
                data.Count += 1;
                return;
            }
            Products.Add(new CartModel()
            {
                Product = product
            });

        }
        public static bool AlreadyExists(CartModel cartModel)
        {

            return cartModel != null ? false : true;
        }
        public static bool IsNotEmpty()
        {
            return Products.Count != 0 ? true : false;
        }

    }

}
