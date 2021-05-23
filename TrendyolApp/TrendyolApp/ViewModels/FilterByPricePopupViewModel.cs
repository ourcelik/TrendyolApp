using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrendyolApp.Data;
using TrendyolApp.Models;

namespace TrendyolApp.ViewModels
{
    class FilterByPricePopupViewModel : BaseViewModel
    {
        ObservableCollection<Interval> intervals;
        public ObservableCollection<Interval> Intervals
        {
            get
            {
                return intervals;
            }
            set
            {
                intervals = value;
                OnPropertyChanged(nameof(Intervals));
            }
        }
        public FilterByPricePopupViewModel()
        {
            Intervals = IntervalData.Intervals;
            OnPropertyChanged(nameof(Intervals));
        }
    }
}
