using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailPage : ContentPage
    {
        readonly private ProductModel _product;

        public ProductDetailPage(object product)
        {
            InitializeComponent();
            _product = (ProductModel)product;
            ProductArea.BindingContext = _product;
        }

        private void ClickBackButton(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(false);
        }
    }
}