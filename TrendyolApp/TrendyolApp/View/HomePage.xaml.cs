using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrendyolApp.View.NavigationPages;
using TrendyolApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public ICommand ScrollListCommand { get; set; }
        public HomePage()
        {
            InitializeComponent();
            InitializeViewModel();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new LoginPage());
        }
        async private void StackLayoutProductClick(object sender, EventArgs e)
        {
            StackLayout data = (StackLayout)sender;
            var gesture = data.GestureRecognizers[0] as TapGestureRecognizer;
            var product = gesture.CommandParameter;
            await this.Navigation.PushModalAsync(new ProductNavigationPage(new ProductDetailPage(product)), false);


        }
        private void InitializeViewModel()
        {
            using (var scope = App._container.BeginLifetimeScope())
            {
                var viewModel = scope.Resolve<HomePageViewModel>();
                BindingContext = viewModel;
            }
        }


    }
}