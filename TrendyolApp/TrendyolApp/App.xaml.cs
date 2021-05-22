using Autofac;
using System;
using TrendyolApp.Services;
using TrendyolApp.View;
using TrendyolApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp
{
    public partial class App : Application
    {
        public static IContainer _container;
        public App()
        {
            InitializeComponent();
            RegisterDependencies();
            MainPage = new TabPage();
        }

        public static void RegisterDependencies()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<LoginPageViewModel>();
            
            containerBuilder.RegisterType<UserService>().As<IUserService>().SingleInstance();
            
            _container = containerBuilder.Build();
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
