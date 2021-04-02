using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        NavigationPage _nav;
        RegisterPage _registerPage;
        AccountPage _accountPage;
        CartPage _cartPage;
        FavouritePage _favouritePage;
        HomePage _homePage;
        CategoryPage _categoryPage;

        public TabPage()
        {
            InitializeComponent();
            this.CurrentPageChanged += TabPage_CurrentPageChanged;
            AddPages();
        }
        public void AddPages()
        {
            _accountPage = new AccountPage();
            _accountPage.Title = "Hesabım";
            _accountPage.IconImageSource = "user.png";
            _categoryPage = new CategoryPage();
            _categoryPage.Title = "Kategoriler";
            _categoryPage.IconImageSource = "loupe.png";
            _registerPage = new RegisterPage();
            _nav = new NavigationBar(_accountPage);
            _nav.Title = "Hesabım";
            _nav.IconImageSource = "user.png";
            _cartPage = new CartPage();
            _cartPage.IconImageSource = "cart.png";
            _cartPage.Title = "Sepetim";
            _favouritePage = new FavouritePage();
            _favouritePage.Title = "Favoriler";
            _favouritePage.IconImageSource = "heart.png";
            _homePage = new HomePage();
            _homePage.Title = "Anasayfa";
            _homePage.IconImageSource = "home.png";
            this.Children.Add(_homePage);
            this.Children.Add(_categoryPage);
            this.Children.Add(_favouritePage);
            this.Children.Add(_cartPage);
            this.Children.Add(_nav);
            
        }

        private void TabPage_CurrentPageChanged(object sender, EventArgs e)
        {
            if (this.CurrentPage is NavigationBar)
            {
                _accountPage.Navigation.PushModalAsync(_registerPage);

            }
        }
    }
}