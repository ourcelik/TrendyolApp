using Autofac;
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
    public partial class SearchProductPage : ContentPage
    {
        SearchProductViewModel context;
        ObservableCollection<Product> Products;
        public SearchProductPage()
        {
            Products = new ObservableCollection<Product>();
            InitializeComponent();
            InitializeViewModel();
            SearchResultList.ItemsSource = Products;


        }

        private async void SearchProducts(object sender, TextChangedEventArgs e)
        {
            //Products
            Products.Clear();

            var data = await context.GetSearchData(p => p.Brand.ToLower().Contains(e.NewTextValue.ToLower()) ||
            p.Category.CategoryName.ToLower().Contains(e.NewTextValue.ToLower()) ||
            p.ProductName.ToLower().Contains(e.NewTextValue.ToLower())
            );
            data.ForEach(p => Products.Add(p));
        }
        private void InitializeViewModel()
        {
            using (var scope = App._container.BeginLifetimeScope())
            {
                var viewModel = scope.Resolve<SearchProductViewModel>();
                context = viewModel;
                BindingContext = viewModel;
            }
        }
    }
}