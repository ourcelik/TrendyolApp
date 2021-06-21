using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Data;
using TrendyolApp.LocalService;
using TrendyolApp.View.NavigationPages;
using TrendyolApp.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            InitializeViewModel();
            SetCartButton();
            InitiliazeMessagingCenters();
            if (CartService.GetAll() != null)
            {
                ChangeCartVisibilty();
            }

        }

        private void InitiliazeMessagingCenters()
        {
            MessagingCenter.Subscribe<ProductDetailPage, bool>(this, "MakeVisible", async (sender, value) =>
            {
                CartList.IsVisible = value;
                EmptyList.IsVisible = !value;
                var context = (CartPageViewModel)BindingContext;
                await context.GetCartProduct();
                context.UpdateCartCost();

            });
            MessagingCenter.Subscribe<OrderPage, bool>(this, "OrderCompleted", async (sender, value) =>
            {
                var context = (CartPageViewModel)BindingContext;
                await context.CleanToCart();
                context.UpdateCartCost();
                CartList.IsVisible = false;
                CostFlexLayout.IsVisible = false;
                EmptyList.IsVisible = true;

            });
        }

        private void VisibilityClick(object sender, EventArgs e)
        {
            ChangeCartVisibilty();
        }

        private void ChangeCartVisibilty()
        {
            EmptyList.IsVisible = false;
            CartList.IsVisible = true;
            CostFlexLayout.IsVisible = true;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var data = (CartPageViewModel)BindingContext;
            if (data.SumOfCart == 0)
            {
                CartList.IsVisible = false;
                CostFlexLayout.IsVisible = false;
                EmptyList.IsVisible = true;
            }
        }

        private void Click_Continue_to_Order(object sender, EventArgs e)
        {
            if (!Preferences.Get("Registered", false))
            {
                App.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
            }
            else
            {
                App.Current.MainPage.Navigation.PushModalAsync(new ProductNavigationPage(new OrderPage()));
            }
        }
        private void SetCartButton()
        {
            if (!Preferences.Get("Registered", false))
            {
                CartPageButton.Text = "Giriş Yap";
            }
            else
            {
                CartPageButton.Text = "Alışverişe Devam Et";
            }
        }
        private void InitializeViewModel()
        {
            using (var scope = App._container.BeginLifetimeScope())
            {
                var viewModel = scope.Resolve<CartPageViewModel>();
                BindingContext = viewModel;
            }
        }
    }
}