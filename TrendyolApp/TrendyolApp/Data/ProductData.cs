using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrendyolApp.Models;

namespace TrendyolApp.Data
{
    public static class ProductData
    {
        public static ObservableCollection<ProductModel> Products { get { return products; } }
        public static ObservableCollection<ProductModel> products;
        public static ObservableCollection<ProductModel> GetProducts()
        {
            if (products == null)
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
                        new PhotoModel{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty73/product/media/images/20210218/22/65072997/62732748/1/1_org_zoom.jpg" },
                    },
                    Price = 999,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 1,
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
                    Price = 850,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 2,
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
                    Price = 800,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 3,
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
                    Price = 740,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 4,
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
                    Price = 650,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 5,
                    TopPhoto = new PhotoModel(){Url = "https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                },
            };
            }
            return products;

        }
    }
}
