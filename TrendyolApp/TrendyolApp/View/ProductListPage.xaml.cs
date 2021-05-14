using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using TrendyolApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductListPage : ContentPage
    {

        public ProductListPage(SubSubCategory subSubCategory)
        {
            InitializeComponent();
            this.BindingContext = new ProductListViewModel(subSubCategory);


        }
    }
}