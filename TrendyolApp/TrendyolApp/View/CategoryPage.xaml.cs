using Autofac;
using Expandable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using TrendyolApp.View.NavigationPages;
using TrendyolApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        ExpandableView _oldSectionExpandableView;
        public CategoryPage()
        {
            InitializeComponent();
            InitializeViewModel();
        }



        private void AutoToggleForExpandableViews(object sender, EventArgs e)
        {
            var data = (StackLayout)sender;

            if (_oldSectionExpandableView != null && _oldSectionExpandableView != (ExpandableView)data.Parent)
            {
                _oldSectionExpandableView.IsExpanded = false;
            }
            _oldSectionExpandableView = (ExpandableView)data.Parent;
        }

        private void OpenSubSubCategory(object sender, EventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            var subSubCategory = (SubSubCategory)button.CommandParameter;
            Application.Current.MainPage.Navigation.PushModalAsync(new HomeNavigationPage(new ProductListPage(subSubCategory)));

        }
        private void InitializeViewModel()
        {
            using (var scope = App._container.BeginLifetimeScope())
            {
                var viewModel = scope.Resolve<CategoryPageViewModel>();
                BindingContext = viewModel;
            }
        }
    }
}