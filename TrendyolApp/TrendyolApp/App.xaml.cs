using Autofac;
using System;
using TrendyolApp.Services;
using TrendyolApp.Services.abstracts;
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
            ResolvePageDependencies(containerBuilder);

            ResolveServiceDependencies(containerBuilder);

            _container = containerBuilder.Build();
        }

        private static void ResolvePageDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<LoginPageViewModel>();
            containerBuilder.RegisterType<CartPageViewModel>();
            containerBuilder.RegisterType<CategoryPageViewModel>();
            containerBuilder.RegisterType<FilterByPricePopupViewModel>();
            containerBuilder.RegisterType<HomePageViewModel>();
            containerBuilder.RegisterType<OrderPageViewModel>();
            containerBuilder.RegisterType<ProductDetailViewModel>();
            containerBuilder.RegisterType<ProductListViewModel>();
            containerBuilder.RegisterType<SearchProductViewModel>();
        }

        private static void ResolveServiceDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<UserService>().As<IUserService>().SingleInstance();
            containerBuilder.RegisterType<CarouselAdService>().As<ICarouselAdService>().SingleInstance();
            containerBuilder.RegisterType<CategoryService>().As<ICategoryService>().SingleInstance();
            containerBuilder.RegisterType<PhotoService>().As<IPhotoService>().SingleInstance();
            containerBuilder.RegisterType<ProductService>().As<IProductService>().SingleInstance();
            containerBuilder.RegisterType<SubCategoryService>().As<ISubCategoryService>().SingleInstance();
            containerBuilder.RegisterType<SubSubCategoryService>().As<ISubSubCategoryService>().SingleInstance();
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
