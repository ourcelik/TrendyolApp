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
        readonly private Product _product;

        public ProductDetailPage(object product)
        {
            InitializeComponent();
            _product = (Product)product;
            ProductArea.BindingContext = _product; 
        }

        private void ClickBackButton(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(false);
        }
        private void ClickCartButton(object sender, EventArgs e)
        {
            MessagingCenter.Send<ProductDetailPage, bool>(this, "MakeVisible", true);
        }
    }
}