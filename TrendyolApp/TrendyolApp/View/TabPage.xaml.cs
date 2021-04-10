using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.View.NavigationPages;
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
        RegisterPage _registerPage;
        AccountPage _accountPage;
        CartPage _cartPage;
        FavouritePage _favouritePage;
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
            _loginPage = new LoginPage();
            _loginPage.Title = "Giriş Yap";
            _accountPage = new AccountPage();
            _accountPage.Title = "Hesabım";
            _accountPage.IconImageSource = "user.png";
            _categoryPage = new CategoryPage();
            _categoryPage.Title = "Kategoriler";
            _categoryPage.IconImageSource = "loupe.png";
            _registerPage = new RegisterPage();
            _accountNav = new NavigationBar(_accountPage);
            _accountNav.Title = "Hesabım";
            _accountNav.IconImageSource = "user.png";
            _cartPage = new CartPage();
            _cartPage.IconImageSource = "cart.png";
            _cartPage.Title = "Sepetim";
            _cartNavigationPage = new HomeNavigationPage(_cartPage);
            _cartNavigationPage.Title = "Sepetim";
            _cartNavigationPage.IconImageSource = "cart.png";
            _cartNavigationPage.BarTextColor = Color.Black;
            _cartNavigationPage.BarBackgroundColor = Color.FromHex("#ffffff");
            _favouritePage = new FavouritePage();
            _favouritePage.Title = "Favoriler";
            _favouritePage.IconImageSource = "heart.png";
            _favouriteNavigationPage = new HomeNavigationPage(_favouritePage);
            _favouriteNavigationPage.BarBackgroundColor = Color.White;
            _favouriteNavigationPage.BarTextColor = Color.Black;
            _favouriteNavigationPage.Title = "Favoriler";
            _favouriteNavigationPage.IconImageSource = "heart.png";
            _homePage = new HomePage();
            _homeNavigationPage = new HomeNavigationPage(_homePage);

            _homeNavigationPage.Title = "Anasayfa";
            _homeNavigationPage.IconImageSource = "home.png";

            this.Children.Add(_homeNavigationPage);
            this.Children.Add(_categoryPage);
            this.Children.Add(_favouriteNavigationPage);
            this.Children.Add(_cartNavigationPage);
            this.Children.Add(_accountNav);

        }

        private void TabPage_CurrentPageChanged(object sender, EventArgs e)
        {
            if (this.CurrentPage is NavigationBar)
            {
                _accountPage.Navigation.PushModalAsync(_loginPage);

            }
        }
    }
}