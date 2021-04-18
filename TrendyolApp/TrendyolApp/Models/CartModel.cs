using System;
using System.Collections.Generic;
using System.Text;

namespace TrendyolApp.Models
{
    public class CartModel
    {
        public CartModel()
        {
            Count = 1;
        }
        public ProductModel Product { get; set; }
        public int Count { get; set; }
    }
}
