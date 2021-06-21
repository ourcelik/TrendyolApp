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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            InitializeViewModel();
        }

        private void ChooseGender(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var text = button.Text;
            if (text == "Kadın")
            {
                Women.BackgroundColor = Color.FromHex("#ffffff");
                Women.BorderColor = Color.FromHex("#f27f26");
                button.TextColor = Color.FromHex("#f38836");
                SetDefault("Erkek");
            }
            else if (text == "Erkek")
            {
                Man.BackgroundColor = Color.FromHex("#ffffff");
                Man.BorderColor = Color.FromHex("#f27f26");
                button.TextColor = Color.FromHex("#f38836");
                SetDefault("Kadın");
            }
        }
        private void SetDefault(string gender)
        {
            if (gender == "Kadın")
            {
                Women.BackgroundColor = Color.FromHex("#f6f6f6");
                Women.BorderColor = Color.Transparent;
                WomenButton.TextColor = Color.FromHex("#8a8a8a");
            }
            else if (gender == "Erkek")
            {
                Man.BackgroundColor = Color.FromHex("#f6f6f6");
                Man.BorderColor = Color.Transparent;
                ManButton.TextColor = Color.FromHex("#8a8a8a");
            }
        }

        private void Campaign_checkbox(object sender, EventArgs e)
        {
            if (!campaignBox.IsChecked)
            {
                campaignBox.BoxBackgroundColor = Color.White;
            }
            else
            {
                campaignBox.Color = Color.FromHex("#f27a1c");
                campaignBox.IconColor = Color.White;

            }
        }

        private void RouteLoginPage(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
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