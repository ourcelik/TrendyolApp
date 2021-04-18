using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TrendyolApp.Data;
using TrendyolApp.Models;
using System.Linq;
using TrendyolApp.Extensions;

namespace TrendyolApp.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<CarouselAdModel> Ads
        {
            get
            {
                return ads;
            }
        }
        ObservableCollection<ProductModel> randomProducts;
        ObservableCollection<ProductModel> randomProductsMan;
        public ObservableCollection<ProductModel> RandomProducts { get { return randomProducts; } }
        public ObservableCollection<ProductModel> RandomProductsMan { get { return randomProductsMan; } }
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
            randomProducts = new ObservableCollection<ProductModel>();
            randomProductsMan = new ObservableCollection<ProductModel>();
            GetRandomProducts(randomProducts);
            GetRandomProducts(RandomProductsMan);
        }
        readonly ObservableCollection<CarouselAdModel> ads;

        public void GetRandomProducts(ObservableCollection<ProductModel> _randomProducts)
        {
            var data = ProductData.GetProducts();
            data.Shuffle();
            var data2 = data.Where(p => p.ProductId > 0 && p.ProductId < 20);
            foreach (var item in data2)
            {
                _randomProducts.Add(item);
            }

        }

    }
}
