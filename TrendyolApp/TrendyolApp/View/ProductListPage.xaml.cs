using Rg.Plugins.Popup.Extensions;
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
    public partial class ProductListPage : ContentPage
    {

        public ProductListPage(SubSubCategory subSubCategory)
        {
            InitializeComponent();
            var context =  new ProductListViewModel(subSubCategory);
            this.BindingContext = context;
            MessagingCenter.Subscribe<OrderingPopupPage, ObservableCollection<ProductModel>>(this, "Ordering", (sender, value) =>
             {
                 context.ListProducts = value;
             });


        }

        private void OrderingPopup(object sender, EventArgs e)
        {
            var pop = new OrderingPopupPage();
            App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
            
        }
    }
}