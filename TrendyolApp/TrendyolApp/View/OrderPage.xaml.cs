using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            InitializeComponent();
            InitializeViewModel();
        }

        private void ClickBackButton(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopModalAsync(false);
        }

        private async void  Click_Continue_to_Order(object sender, EventArgs e)
        {
            await DisplayAlert("Sipariş Durumu", "Sipariş Alınmıştır", "Bitir");
            await App.Current.MainPage.Navigation.PopModalAsync();
            MessagingCenter.Send<OrderPage, bool>(this, "OrderCompleted", true);


        }
        private void InitializeViewModel()
        {
            using (var scope = App._container.BeginLifetimeScope())
            {
                var viewModel = scope.Resolve<OrderPageViewModel>();
                BindingContext = viewModel;
            }
        }
    }
}