using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TrendyolApp.Models;

namespace TrendyolApp.ViewModels
{
    public class CartPageViewModel : INotifyPropertyChanged
    {
        ObservableCollection<ProductModel> products;
        public ObservableCollection<ProductModel> Products { get { return products; } }
        public CartPageViewModel()
        {

            products = new ObservableCollection<ProductModel>
            {
                new ProductModel{
                    ProductName = "Hummel hml",
                    Description = "Güzel bir ayakkabı dosta gider",
                    Category = new Category(){ CategoryId=1,CategoryName = "ayakkabı"},
                    Brand = "Hummel",
                    Photos = new List<PhotoModel>(){
                        new PhotoModel{ Id =0,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty79/product/media/images/20210304/14/68692988/70765176/1/1_org_zoom.jpg" },
                        new PhotoModel{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                    },
                    Price = 999,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 0,
                    TopPhoto = new PhotoModel(){Url = "https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                },
                new ProductModel{
                    ProductName = "Hummel hml",
                    Description = "Güzel bir ayakkabı dosta gider",
                    Category = new Category(){ CategoryId=1,CategoryName = "ayakkabı"},
                    Brand = "Hummel",
                    Photos = new List<PhotoModel>(){
                        new PhotoModel{ Id =0,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty79/product/media/images/20210304/14/68692988/70765176/1/1_org_zoom.jpg" },
                        new PhotoModel{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                    },
                    Price = 999,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 0,
                    TopPhoto = new PhotoModel(){Url = "https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                },
                new ProductModel{
                    ProductName = "Hummel hml",
                    Description = "Güzel bir ayakkabı dosta gider",
                    Category = new Category(){ CategoryId=1,CategoryName = "ayakkabı"},
                    Brand = "Hummel",
                    Photos = new List<PhotoModel>(){
                        new PhotoModel{ Id =0,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty79/product/media/images/20210304/14/68692988/70765176/1/1_org_zoom.jpg" },
                        new PhotoModel{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                    },
                    Price = 999,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 0,
                    TopPhoto = new PhotoModel(){Url = "https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                },
                new ProductModel{
                    ProductName = "Hummel hml",
                    Description = "Güzel bir ayakkabı dosta gider",
                    Category = new Category(){ CategoryId=1,CategoryName = "ayakkabı"},
                    Brand = "Hummel",
                    Photos = new List<PhotoModel>(){
                        new PhotoModel{ Id =0,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty79/product/media/images/20210304/14/68692988/70765176/1/1_org_zoom.jpg" },
                        new PhotoModel{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                    },
                    Price = 999,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 0,
                    TopPhoto = new PhotoModel(){Url = "https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                },
                new ProductModel{
                    ProductName = "Hummel hml",
                    Description = "Güzel bir ayakkabı dosta gider",
                    Category = new Category(){ CategoryId=1,CategoryName = "ayakkabı"},
                    Brand = "Hummel",
                    Photos = new List<PhotoModel>(){
                        new PhotoModel{ Id =0,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty79/product/media/images/20210304/14/68692988/70765176/1/1_org_zoom.jpg" },
                        new PhotoModel{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                    },
                    Price = 999,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 0,
                    TopPhoto = new PhotoModel(){Url = "https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                },
            };
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
