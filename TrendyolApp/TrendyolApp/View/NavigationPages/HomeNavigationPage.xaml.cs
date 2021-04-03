using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View.NavigationPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeNavigationPage : NavigationPage
    {
        public HomeNavigationPage(Page page) : base(page)
        {
            InitializeComponent();
        }
    }
}