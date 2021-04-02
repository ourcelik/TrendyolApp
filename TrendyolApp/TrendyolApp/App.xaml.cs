using System;
using TrendyolApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
