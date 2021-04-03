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
    public partial class NavigationBar : NavigationPage
    {
        public NavigationBar(Page page) : base(page)
        {
            InitializeComponent();
        }
    }
}