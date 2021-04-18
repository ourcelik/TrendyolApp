using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<ProductDetailPage, bool>(this, "MakeVisible", (sender, value) => {
                CartList.IsVisible = value;
                EmptyList.IsVisible = !value;
            });
            if (CartData.IsNotEmpty())
            {
                ChangeCartVisibilty();
            }

        }
        private void VisibilityClick(object sender, EventArgs e)
        {
            ChangeCartVisibilty();
        }

        private void ChangeCartVisibilty()
        {
            EmptyList.IsVisible = false;
            CartList.IsVisible = true;
        }
    }
}