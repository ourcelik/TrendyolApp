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
        #region Variables
        ObservableCollection<Interval> intervals; 
        #endregion
        #region Props
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
        #endregion
        public FilterByPricePopupViewModel()
        {
            Intervals = IntervalData.Intervals;
            OnPropertyChanged(nameof(Intervals));
        }
    }
}
