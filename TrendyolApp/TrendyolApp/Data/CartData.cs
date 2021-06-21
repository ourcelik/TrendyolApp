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
        public static ObservableCollection<Cart> Products { get { return products; } }
        public static ObservableCollection<Cart> products;

        public static ObservableCollection<Cart> CreateCart()
        {
            if (products == null)
            {
                products = new ObservableCollection<Cart>();
            }
            return Products;
        }

        public static void AddProduct(Product product)
        {
            var data = Products.Where(c => c.Product.ProductId == product.ProductId).SingleOrDefault();
            var count = 0;
            if (AlreadyExists(data))
            {
                count = 1 + data.Count;
                Products.Remove(data);
                Products.Add(new Cart()
                {
                    Product = product,
                    Count = count
                });
                count = 0;
                return;
            }
            Products.Add(new Cart()
            {
                Product = product
            });

        }

        public static void Clear()
        {
            products.Clear();
        }

        public static bool AlreadyExists(Cart cartModel)
        {

            return cartModel != null;
        }
        public static bool IsNotEmpty()
        {
            return Products.Count != 0;
        }
        public static void RemoveProduct(Product product)
        {
            var count = 0;
            var data = Products.Where(p => p.Product.ProductId == product.ProductId).SingleOrDefault();
            if (data.Count == 1)
            {
                Products.Remove(data);
                return;
            }
            else
            {
                count = data.Count - 1;
                Products.Remove(data);
                Products.Add(new Cart()
                {
                    Product = product,
                    Count = count
                });
            }


        }


    }

}
