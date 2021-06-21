using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TrendyolApp.Extensions
{
    public static class ListExtensions
    {
        public static void Shuffle<T>(this ObservableCollection<T> list)
        {
            Random random = new();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
