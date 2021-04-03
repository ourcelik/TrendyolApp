using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TrendyolApp.ViewModels
{
    public class LoginPageViewModel: INotifyPropertyChanged
    {
        string facebook = "Facebook \nile bağlan";
        public string Facebook { get { return facebook; } 
            }
        string google = "Google \nile bağlan";
        public string Google
        {
            get { return google; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
