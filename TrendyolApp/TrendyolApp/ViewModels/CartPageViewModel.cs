using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TrendyolApp.Models;
using System.Linq;
using TrendyolApp.Data;
using TrendyolApp.Extensions;

namespace TrendyolApp.ViewModels
{
    public class CartPageViewModel : INotifyPropertyChanged
    {
        ObservableCollection<ProductModel> products;

        public ObservableCollection<ProductModel> Products { get { return products; } }
        public CartPageViewModel()
        {
            GetShuffleProducts();

        }

        private void GetShuffleProducts()
        {
            var data = ProductData.GetProducts();
            data.Shuffle();
            products = data;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
