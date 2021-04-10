using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TrendyolApp.Models;

namespace TrendyolApp.ViewModels
{
    class HomePageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CarouselAdModel> Ads
        {
            get
            {
                return ads;
            }
        }
        public HomePageViewModel()
        {
            ads = new ObservableCollection<CarouselAdModel>
            {
                new CarouselAdModel{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAdModel{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAdModel{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAdModel{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAdModel{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAdModel{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAdModel{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},

            };
        }
        readonly ObservableCollection<CarouselAdModel> ads;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
