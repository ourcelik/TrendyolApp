using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TrendyolApp.Models;
using Xamarin.Forms.Internals;

namespace TrendyolApp.Data
{
    public static class ProductData
    {
        public static ObservableCollection<Product> Products { get { return products; } }
        public static ObservableCollection<Product> products;
        public static ObservableCollection<Product> GetProducts()
        {
            if (products == null)
            {
                products = new ObservableCollection<Product>
            {
                new Product{

                    ProductName = "Hummel hml",
                    Description = "Güzel bir ayakkabı dosta gider",
                    Category = CategoryData.Categories.Where((ctr) => ctr.CategoryId == 1).FirstOrDefault(),
                    SubCategory = SubCategoryData.SubCategories.Where((ctr) => ctr.SubCategoryId == 2).FirstOrDefault(),
                    SubSubCategory = SubSubCategoryData.SubSubCategories.Where((ctr) => ctr.SubSubCategoryId == 16 ).FirstOrDefault(),
                    Brand = "Nixe",
                    Photos = new List<Photo>(){
                        new Photo{ Id =0,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty79/product/media/images/20210304/14/68692988/70765176/1/1_org_zoom.jpg" },
                        new Photo{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty73/product/media/images/20210218/22/65072997/62732748/1/1_org_zoom.jpg" },
                    },
                    Price = 999,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 1,
                    TopPhoto = new Photo(){Url = "https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                },
                new Product{
                    ProductName = "Hummel hml",
                    Description = "Güzel bir ayakkabı dosta gider",
                   Category = CategoryData.Categories.Where((ctr) => ctr.CategoryId == 1).FirstOrDefault(),
                    SubCategory = SubCategoryData.SubCategories.Where((ctr) => ctr.SubCategoryId == 2).FirstOrDefault(),
                    SubSubCategory = SubSubCategoryData.SubSubCategories.Where((ctr) => ctr.SubSubCategoryId == 16 ).FirstOrDefault(),
                    Brand = "Hummel",
                    Photos = new List<Photo>(){
                        new Photo{ Id =0,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty79/product/media/images/20210304/14/68692988/70765176/1/1_org_zoom.jpg" },
                        new Photo{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                    },
                    Price = 850,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 2,
                    TopPhoto = new Photo(){Url = "https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                },
                new Product{
                    ProductName = "Hummel hml",
                    Description = "Güzel bir ayakkabı dosta gider",
                    Category = CategoryData.Categories.Where((ctr) => ctr.CategoryId == 1).FirstOrDefault(),
                    SubCategory = SubCategoryData.SubCategories.Where((ctr) => ctr.SubCategoryId == 2).FirstOrDefault(),
                    SubSubCategory = SubSubCategoryData.SubSubCategories.Where((ctr) => ctr.SubSubCategoryId == 16 ).FirstOrDefault(),
                    Brand = "Hummel",
                    Photos = new List<Photo>(){
                        new Photo{ Id =0,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty79/product/media/images/20210304/14/68692988/70765176/1/1_org_zoom.jpg" },
                        new Photo{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                    },
                    Price = 800,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 3,
                    TopPhoto = new Photo(){Url = "https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                },
                new Product{
                    ProductName = "Hummel hml",
                    Description = "Güzel bir ayakkabı dosta gider",
                    Category = CategoryData.Categories.Where((ctr) => ctr.CategoryId == 1).FirstOrDefault(),
                    SubCategory = SubCategoryData.SubCategories.Where((ctr) => ctr.SubCategoryId == 2).FirstOrDefault(),
                    SubSubCategory = SubSubCategoryData.SubSubCategories.Where((ctr) => ctr.SubSubCategoryId == 16 ).FirstOrDefault(),
                    Brand = "Hummel",
                    Photos = new List<Photo>(){
                        new Photo{ Id =0,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty79/product/media/images/20210304/14/68692988/70765176/1/1_org_zoom.jpg" },
                        new Photo{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                    },
                    Price = 740,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 4,
                    TopPhoto = new Photo(){Url = "https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                },
                new Product{
                    ProductName = "Hummel hml",
                    Description = "Güzel bir ayakkabı dosta gider",
                    Category = CategoryData.Categories.Where((ctr) => ctr.CategoryId == 1).FirstOrDefault(),
                    SubCategory = SubCategoryData.SubCategories.Where((ctr) => ctr.SubCategoryId == 2).FirstOrDefault(),
                    SubSubCategory = SubSubCategoryData.SubSubCategories.Where((ctr) => ctr.SubSubCategoryId == 16 ).FirstOrDefault(),
                    Brand = "Hummel",
                    Photos = new List<Photo>(){
                        new Photo{ Id =0,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty79/product/media/images/20210304/14/68692988/70765176/1/1_org_zoom.jpg" },
                        new Photo{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                    },
                    Price = 650,
                    ProductInfo = "Info aga",
                    Seller = "Babamm",
                    ProductId = 5,
                    TopPhoto = new Photo(){Url = "https://cdn.dsmcdn.com/mnresize/415/622/ty77/product/media/images/20210304/14/68692988/70765176/2/2_org_zoom.jpg" },
                },
            };
            }
            return products;

        }
    }
}
