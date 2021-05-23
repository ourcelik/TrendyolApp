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
    public partial class FilterByCategoryPopupPage : PopupPage
    {
        private ObservableCollection<Product> _products;
        public List<string> _selectedCategories { get; set; }



        public FilterByCategoryPopupPage(ObservableCollection<Product> products)
        {
            _products = products;
            InitializeComponent();
            _selectedCategories = new List<string>();
            ProductCategoryList.ItemsSource = _products.DistinctBy(p=>p.SubCategory.CategoryName);
        }

        private async void ClosePopup(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PopPopupAsync();
        }

        private async void SendCategoriesToMainFilterPopup(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PopPopupAsync();
            MessagingCenter.Send<FilterByCategoryPopupPage, List<string>>(this, "CategoryFilter", _selectedCategories);
        }

        private void CategorySelected(object sender, SelectedItemChangedEventArgs e)
        {
            var view = (ListView)sender;
            var data = (Product)view.SelectedItem;
            if (!_selectedCategories.Contains(data.SubCategory.CategoryName))
            {
                _selectedCategories.Add(data.SubCategory.CategoryName);
            }
        }
    }
}