using System;
using System.Collections.Generic;
using System.Text;

namespace TrendyolApp.Models
{
    public class Cart
    {
        public Cart()
        {
            Count = 1;
        }
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}
