using System;
using System.Collections.Generic;
using System.Text;
using TrendyolApp.Data;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class OrderPageViewModel :BaseViewModel
    {
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
        public OrderPageViewModel()
        {
            UpdateCartCost();
        }
        private void UpdateCartCost()
        {
            SumOfCart = 0;
            foreach (var item in CartData.Products)
            {
                SumOfCart += item.Product.Price * item.Count;
            }
        }
       
    }
}
