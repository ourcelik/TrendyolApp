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
        ObservableCollection<ProductModel> Products;
        public SearchProductPage()
        {
            context = new SearchProductViewModel();
            Products = new ObservableCollection<ProductModel>();
            InitializeComponent();
            this.BindingContext = context;

            SearchResultList.ItemsSource = Products;


        }

        private void SearchProducts(object sender, TextChangedEventArgs e)
        {
            //Products
            Products.Clear();

            context.GetSearchData(p => p.Brand.ToLower().Contains(e.NewTextValue.ToLower()) ||
            p.Category.CategoryName.ToLower().Contains(e.NewTextValue.ToLower()) ||
            p.ProductName.ToLower().Contains(e.NewTextValue.ToLower())
            ).ForEach(p => Products.Add(p));
        }
    }
}