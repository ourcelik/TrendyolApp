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
        ObservableCollection<ProductModel> products;
        public OrderingPopupPage()
        {
            InitializeComponent();
            products = new ObservableCollection<ProductModel>();
        }

        private void SuggestionFilter(object sender, EventArgs e)
        {
            products.Clear();
            OrderingPopupViewModel.GetFilterData().OrderBy(p => p.ProductName).ToList().ForEach(p => products.Add(p));
            MessagingCenter.Send<OrderingPopupPage, ObservableCollection<ProductModel>>(this, "Ordering", products);
        }
        private void LowtoHighPriceFilter(object sender, EventArgs e)
        {
            products.Clear();
            OrderingPopupViewModel.GetFilterData().OrderBy(p => p.Price).ToList().ForEach(p => products.Add(p));
            MessagingCenter.Send<OrderingPopupPage, ObservableCollection<ProductModel>>(this, "Ordering", products);
        }
        private void HighToLowPriceFilter(object sender, EventArgs e)
        {
            products.Clear();
            OrderingPopupViewModel.GetFilterData().OrderByDescending(p => p.Price).ToList().ForEach(p => products.Add(p));

            MessagingCenter.Send<OrderingPopupPage, ObservableCollection<ProductModel>>(this, "Ordering", products);
        }
        private void BestSellerFilter(object sender, EventArgs e)
        {
            products.Clear();
            OrderingPopupViewModel.GetFilterData().OrderBy(p => p.ProductName).ToList().ForEach(p => products.Add(p));
            MessagingCenter.Send<OrderingPopupPage, ObservableCollection<ProductModel>>(this, "Ordering", products);
        }
        private void MostFavouriteFilter(object sender, EventArgs e)
        {
            products.Clear();
            OrderingPopupViewModel.GetFilterData().OrderBy(p => p.ProductName).ToList().ForEach(p => products.Add(p));
            MessagingCenter.Send<OrderingPopupPage, ObservableCollection<ProductModel>>(this, "Ordering", products);
        }
        private void NewestFilter(object sender, EventArgs e)
        {
            products.Clear();
            OrderingPopupViewModel.GetFilterData().OrderBy(p => p.ProductName).ToList().ForEach(p => products.Add(p));
            MessagingCenter.Send<OrderingPopupPage, ObservableCollection<ProductModel>>(this, "Ordering", products);
        }
        private void MostEvaluatedFilter(object sender, EventArgs e)
        {
            products.Clear();
            OrderingPopupViewModel.GetFilterData().OrderBy(p => p.ProductName).ToList().ForEach(p => products.Add(p));
            MessagingCenter.Send<OrderingPopupPage, ObservableCollection<ProductModel>>(this, "Ordering", products);
        }
    }
}