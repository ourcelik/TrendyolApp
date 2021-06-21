using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilteringPopupPage : PopupPage
    {
        ObservableCollection<Product> _products;
        List<Product> _filteredProducts;
        List<string> _brands;
        List<string> _categories;
        public Interval _priceInterval { get; set; }

        public FilteringPopupPage(ObservableCollection<Product> products)
        {
            InitializeComponent();
            _products = products;
            InitializeMessagingCenters();
        }

        private void InitializeMessagingCenters()
        {
            MessagingCenter.Subscribe<FilterByBrandPopupPage, List<string>>(this, "BrandFilter", (sender, value) =>
            {
                _brands = value;
            });
            MessagingCenter.Subscribe<FilterByCategoryPopupPage, List<string>>(this, "CategoryFilter", (sender, value) =>
            {
                _categories = value;
            });
            MessagingCenter.Subscribe<FilterByPricePopupPage, Interval>(this, "IntervalFilter", (sender, value) =>
            {
                _priceInterval = value;
            });
        }

        private void OpenPopupForBrand(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushPopupAsync(new FilterByBrandPopupPage(_products));
        }
        private void OpenPopupForCategory(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushPopupAsync(new FilterByCategoryPopupPage(_products));

        }
        private void OpenPopupForPrice(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushPopupAsync(new FilterByPricePopupPage());

        }

        private async void CompleteFiltering(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PopPopupAsync();
            _filteredProducts = _products.ToList();
            if (_brands != null)
            {
                _brands.ForEach(b =>
                {
                    _filteredProducts = _filteredProducts.Where(p => p.Brand == b).ToList();

                });
            }
            if (_categories != null)
            {
                _categories.ForEach(c =>
                {
                    _filteredProducts = _filteredProducts.Where(p => p.SubCategory.CategoryName == c).ToList();

                });
            }
            if (_priceInterval != null)
            {
                _filteredProducts = _filteredProducts.Where(p => p.Price >= _priceInterval.LowPrice && p.Price <= _priceInterval.HighPrice).ToList();
            }
            if (AnyNotNull(_brands, _categories,_priceInterval))
            {
                _products.Clear();
                _filteredProducts.ForEach(p => _products.Add(p));
            }

        }
        private bool AnyNotNull(params object[] objects)
        {
            foreach (var item in objects)
            {
                if (item != null)
                {
                    return true;
                }

            }
            return false;
        }
    }
}