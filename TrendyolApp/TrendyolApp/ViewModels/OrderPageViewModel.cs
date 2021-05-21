using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Data;
using TrendyolApp.LocalService;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class OrderPageViewModel : BaseViewModel
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
            UpdateCartCostAsync();
        }
        private async void UpdateCartCostAsync()
        {
            SumOfCart = 0;
            var data = await CartService.GetAll();
            foreach (var item in data)
            {
                var product = ProductData.GetProducts().Where(p => p.ProductId == item.ProductId).FirstOrDefault();
                SumOfCart += product.Price * item.Count;
            }
        }

    }
}
