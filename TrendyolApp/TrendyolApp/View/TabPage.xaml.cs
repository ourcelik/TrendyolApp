using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Services;
using TrendyolApp.View.Login;
using TrendyolApp.View.NavigationPages;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        NavigationBar _accountNav;
        HomeNavigationPage _homeNavigationPage;
        HomeNavigationPage _favouriteNavigationPage;
        HomeNavigationPage _cartNavigationPage;
        HomeNavigationPage _categoryNavigationPage;
        ContentPage _accountPage;
        ContentPage _cartPage;
        ContentPage _favouritePage;
        HomePage _homePage;
        CategoryPage _categoryPage;
        LoginPage _loginPage;

        public TabPage()
        {
            InitializeComponent();
            this.CurrentPageChanged += TabPage_CurrentPageChanged;
            AddPages();
        }
        public void AddPages()
        {
            if (!Preferences.Get("Registered", false))
            {
                _loginPage = new LoginPage();
                _accountPage = new AccountPage();
                _favouritePage = new FavouritePage();
                _loginPage.Title = "Giriş Yap";
            }
            else
            {
                _accountPage = new LoginAccountPage();
                _favouritePage = new LoginFavouritePage();
            }
            //Demo();
            _cartPage = new CartPage();
            _categoryPage = new CategoryPage();
            _categoryNavigationPage = new HomeNavigationPage(_categoryPage);
            _accountNav = new NavigationBar(_accountPage);
            _cartNavigationPage = new HomeNavigationPage(_cartPage);
            _favouriteNavigationPage = new HomeNavigationPage(_favouritePage);
            _homePage = new HomePage();
            _homeNavigationPage = new HomeNavigationPage(_homePage);

            _categoryNavigationPage.Title = "Kategoriler";
            _categoryNavigationPage.IconImageSource = "loupe.png";
            _categoryNavigationPage.HeightRequest = 100;
            _accountPage.Title = "Hesabım";
            _accountPage.IconImageSource = "user.png";
            _accountNav.Title = "Hesabım";
            _accountNav.IconImageSource = "user.png";
            _cartPage.IconImageSource = "cart.png";
            _cartPage.Title = "Sepetim";
            _cartNavigationPage.Title = "Sepetim";
            _cartNavigationPage.IconImageSource = "cart.png";
            _cartNavigationPage.BarTextColor = Color.Black;
            _cartNavigationPage.BarBackgroundColor = Color.FromHex("#ffffff");
            _favouritePage.Title = "Favoriler";
            _favouritePage.IconImageSource = "heart.png";
            _favouriteNavigationPage.BarBackgroundColor = Color.White;
            _favouriteNavigationPage.BarTextColor = Color.Black;
            _favouriteNavigationPage.Title = "Favoriler";
            _favouriteNavigationPage.IconImageSource = "heart.png";

            _homeNavigationPage.Title = "Anasayfa";
            _homeNavigationPage.IconImageSource = "home.png";

            this.Children.Add(_homeNavigationPage);
            this.Children.Add(_categoryNavigationPage);
            this.Children.Add(_favouriteNavigationPage);
            this.Children.Add(_cartNavigationPage);
            this.Children.Add(_accountNav);



        }

        //private async static void Demo()
        //{
        //    var CategoryService = new CategoryService();
        //    var data = await CategoryService.GetCategories();
        //    var ProductService = new ProductService();
        //    var products = await ProductService.GetProducts();
        //    var carouselAd = new CarouselAdService();
        //    var car = await carouselAd.GetAds();
        //    var photo = new PhotoService();
        //    var photos = await photo.GetPhotos();
        //    var subcat = new SubCategoryService();
        //    var datas = await subcat.GetSubCategories();
        //    var subsubcat = new SubSubCategoryService();
        //    var data2 = await subsubcat.GetSubSubCategories();
        //}

        private void TabPage_CurrentPageChanged(object sender, EventArgs e)
        {
            if (this.CurrentPage is NavigationBar && !(Preferences.Get("Registered", false)))
            {
                _accountPage.Navigation.PushModalAsync(_loginPage);

            }
        }
        public void LoadNotLoginPages()
        {


        }
    }
}