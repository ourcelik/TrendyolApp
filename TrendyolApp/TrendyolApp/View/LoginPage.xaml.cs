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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            InitializeViewModel();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new ForgetPassPage());
        }
        private void Register(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new RegisterPage());
        }
        private void InitializeViewModel()
        {
            using (var scope = App._container.BeginLifetimeScope())
            {
                var viewModel = scope.Resolve<LoginPageViewModel>();
                BindingContext = viewModel;
            }
        }

    }
}