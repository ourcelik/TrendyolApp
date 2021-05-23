using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Extensions;
using TrendyolApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilterByBrandPopupPage : PopupPage
    {
        private ObservableCollection<Product> _products;
        public List<string> _selectedBrands { get; set; }


        public FilterByBrandPopupPage(ObservableCollection<Product> products)
        {
            _products = products;
            InitializeComponent();
            ProductBrandList.ItemsSource = _products.DistinctBy(p => p.Brand);
            _selectedBrands = new List<string>();

        }

        private void BrandSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var view = (ListView)sender;
            var data = (Product)view.SelectedItem;
            if (!_selectedBrands.Contains(data.Brand))
            {
                _selectedBrands.Add(data.Brand);
            }
        }

        private async void SendBrandsToMainFilterPopup(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PopPopupAsync();
            MessagingCenter.Send<FilterByBrandPopupPage, List<string>>(this, "BrandFilter", _selectedBrands);

        }

        private async void ClosePopup(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PopPopupAsync();
        }
    }
}