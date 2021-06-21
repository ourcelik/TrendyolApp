using Autofac;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class FilterByPricePopupPage : PopupPage
    {


        public Interval _priceInterval { get; set; }

        public FilterByPricePopupPage()
        {
            InitializeComponent();
            InitializeViewModel();
        }



        private async void SendIntervalPriceToMainFilterPopup(object sender, EventArgs e)
        {
            if (CustomHighPrice.Text != null && CustomLowPrice.Text != null)
            {
                _priceInterval = new Interval
                {
                    LowPrice = Convert.ToDecimal(CustomLowPrice.Text),
                    HighPrice = Convert.ToDecimal(CustomHighPrice.Text)
                };
            }
            await App.Current.MainPage.Navigation.PopPopupAsync();
            MessagingCenter.Send<FilterByPricePopupPage, Interval>(this, "IntervalFilter", _priceInterval);
        }


        private void ClosePopup(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopPopupAsync();
        }

        private void SelectPrice(object sender, EventArgs e)
        {
            var data = (StackLayout)sender;
            var gesture = (TapGestureRecognizer)data.GestureRecognizers[0];
            _priceInterval = (Interval)gesture.CommandParameter;

        }
        private void InitializeViewModel()
        {
            using (var scope = App._container.BeginLifetimeScope())
            {
                var viewModel = scope.Resolve<FilterByPricePopupViewModel>();
                BindingContext = viewModel;
            }
        }
    }


}