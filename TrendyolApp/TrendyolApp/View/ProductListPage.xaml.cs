﻿using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using TrendyolApp.View.NavigationPages;
using TrendyolApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductListPage : ContentPage
    {
        ProductListViewModel _context;

        public ProductListPage(SubSubCategory subSubCategory)
        {
            InitializeComponent();
            _context = new ProductListViewModel(subSubCategory);
            this.BindingContext = _context;
            MessagingCenter.Subscribe<OrderingPopupPage, ObservableCollection<ProductModel>>(this, "Ordering", (sender, value) =>
            {
                _context.ListProducts = value;
            });


        }

        private void OrderingPopup(object sender, EventArgs e)
        {
            var pop = new OrderingPopupPage();
            App.Current.MainPage.Navigation.PushPopupAsync(pop, true);

        }
        private void FilteringPopup(object sender, EventArgs e)
        {



        }

        private void SearchBar_Focused(object sender, FocusEventArgs e)
        {
            App.Current.MainPage.Navigation.PushModalAsync(new HomeNavigationPage(new SearchProductPage()), false);
        }

        private async void OpenProduct(object sender, EventArgs e)
        {
            StackLayout data = (StackLayout)sender;
            var gesture = data.GestureRecognizers[0] as TapGestureRecognizer;
            var product = gesture.CommandParameter;
            await this.Navigation.PushModalAsync(new ProductNavigationPage(new ProductDetailPage(product)), false);

        }

        //private void SearchProducts(object sender, TextChangedEventArgs e)
        //{
        //    _context.ListProducts.Where(p => p.ProductName.Contains(e.NewTextValue));
        //}
    }
}