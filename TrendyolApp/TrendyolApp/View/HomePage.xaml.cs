using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendyolApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public ICommand ScrollListCommand { get; set; }
        public HomePage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new LoginPage());
        }

    }
}