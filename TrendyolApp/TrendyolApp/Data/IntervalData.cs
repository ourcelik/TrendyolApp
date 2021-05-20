using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrendyolApp.Models;

namespace TrendyolApp.Data
{
    public static class IntervalData
    {
        public static ObservableCollection<Interval> Intervals;
        static IntervalData()
        {
            setData();
        }
        private static void setData()
        {
            Intervals = new ObservableCollection<Interval>()
            {
                new Interval{ LowPrice = 0,HighPrice = 40},
                new Interval{ LowPrice = 40,HighPrice = 70},
                new Interval{ LowPrice = 70,HighPrice = 80},
                new Interval{ LowPrice = 80,HighPrice = 100},
                new Interval{ LowPrice = 100,HighPrice = 200},
                new Interval{ LowPrice = 200,HighPrice = 10000},
            };
        }
        
    }
}
