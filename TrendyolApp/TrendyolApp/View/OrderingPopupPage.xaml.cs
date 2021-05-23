using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using TrendyolApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderingPopupPage : PopupPage
    {
        ObservableCollection<Product> _products;
        public OrderingPopupPage(ObservableCollection<Product> products)
        {
            
            InitializeComponent();
            _products = products;
        }

        private async void SuggestionFilter(object sender, EventArgs e)
        {
            var data = _products.OrderBy(p => p.ProductName).ToList();
            _products.Clear();
            data.ForEach(p => _products.Add(p));
            await App.Current.MainPage.Navigation.PopPopupAsync();
        }
        private async void LowtoHighPriceFilter(object sender, EventArgs e)
        {
            var data = _products.OrderBy(p => p.Price).ToList();
            _products.Clear();
            data.ForEach(p => _products.Add(p));
            await App.Current.MainPage.Navigation.PopPopupAsync();


        }
        private async void HighToLowPriceFilter(object sender, EventArgs e)
        {
            var data = _products.OrderByDescending(p => p.Price).ToList();
            _products.Clear();
            data.ForEach(p => _products.Add(p));

            await App.Current.MainPage.Navigation.PopPopupAsync();

        }
        private async void BestSellerFilter(object sender, EventArgs e)
        {
            var data = _products.OrderBy(p => p.ProductName).ToList();
            _products.Clear();
            data.ForEach(p => _products.Add(p));
            await App.Current.MainPage.Navigation.PopPopupAsync();

        }
        private async void MostFavouriteFilter(object sender, EventArgs e)
        {
            var data = _products.OrderBy(p => p.ProductName).ToList();
            _products.Clear();
            data.ForEach(p => _products.Add(p));
            await App.Current.MainPage.Navigation.PopPopupAsync();

        }
        private async void NewestFilter(object sender, EventArgs e)
        {
            var data = _products.OrderBy(p => p.ProductName).ToList();
            _products.Clear();
            data.ForEach(p => _products.Add(p));
            await App.Current.MainPage.Navigation.PopPopupAsync();

        }
        private async void MostEvaluatedFilter(object sender, EventArgs e)
        {
            var data = _products.OrderBy(p => p.ProductName).ToList();
            _products.Clear();
            data.ForEach(p => _products.Add(p));
            await App.Current.MainPage.Navigation.PopPopupAsync();
        }
    }
}