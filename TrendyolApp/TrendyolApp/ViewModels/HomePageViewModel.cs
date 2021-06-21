using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TrendyolApp.Data;
using TrendyolApp.Models;
using System.Linq;
using TrendyolApp.Extensions;
using TrendyolApp.Services;
using System.Threading.Tasks;
using TrendyolApp.Services.abstracts;

namespace TrendyolApp.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        #region Services
        readonly IProductService _productService; 
        #endregion
        #region Variables
        ObservableCollection<Product> products;
        ObservableCollection<Product> randomProducts;
        ObservableCollection<Product> randomProductsMan; 
        #endregion

        #region Props
        public ObservableCollection<CarouselAd> Ads
        {
            get
            {
                return ads;
            }
        }

        public ObservableCollection<Product> RandomProducts
        {
            get
            {
                return randomProducts;
            }
        }
        public ObservableCollection<Product> RandomProductsMan
        {
            get
            {
                return randomProductsMan;
            }
        } 
        #endregion
        public HomePageViewModel(IProductService productService)
        {
            _productService = productService;
            ads = new ObservableCollection<CarouselAd>
            {
                new CarouselAd{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAd{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAd{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAd{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAd{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAd{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},
                new CarouselAd{ Id = 0,Url = "https://cdn.dsmcdn.com/marketing/datascience/automation/2021/4/10/Ceptelefonuaksesuarlari_Erkek_Webbig_202104101607.jpg"},

            };
            randomProducts = new ObservableCollection<Product>();
            randomProductsMan = new ObservableCollection<Product>();
            GetProducts().Await();
        }
        readonly ObservableCollection<CarouselAd> ads;

        public void GetRandomProducts(ObservableCollection<Product> _randomProducts)
        {

            products.Shuffle();
            var data2 = products.Where(p => p.ProductId > 0 && p.ProductId < 20);
            foreach (var item in data2)
            {
                _randomProducts.Add(item);
            }

        }
        public async Task GetProducts()
        {
            var data = await _productService.GetProductsAsync();
            products = data.model.Products;
            GetRandomProducts(randomProducts);
            GetRandomProducts(randomProductsMan);

        }

    }
}
