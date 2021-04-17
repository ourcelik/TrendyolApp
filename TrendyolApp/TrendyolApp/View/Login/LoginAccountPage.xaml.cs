using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginAccountPage : ContentPage
    {
        public LoginAccountPage()
        {
            InitializeComponent();
        }
        private void LogOutClick(object sender, EventArgs e)
        {
            Preferences.Set("Registered",false);
            Application.Current.MainPage = new TabPage();
        }
    }
}