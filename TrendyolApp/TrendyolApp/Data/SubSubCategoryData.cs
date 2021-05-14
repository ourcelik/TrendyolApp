using System.Collections.ObjectModel;
using TrendyolApp.Models;

namespace TrendyolApp.Data
{
    public static class SubSubCategoryData
    {
        public static ObservableCollection<SubSubCategory> SubSubCategories { get { return subsubCategories; } }
        private static ObservableCollection<SubSubCategory> subsubCategories;
        static SubSubCategoryData()
        {
            CreateSubCategories();
        }
        public static void CreateSubCategories()
        {
            subsubCategories = new ObservableCollection<SubSubCategory>
            {
                new SubSubCategory { SubSubCategoryId = 1, CategoryName = "Sweatshirt",CategoryId=1,SubCategoryId=1,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg" },
                new SubSubCategory { SubSubCategoryId = 2, CategoryName = "T-Shirt",CategoryId=1,SubCategoryId=1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty39/product/media/images/20201225/9/41891116/122943240/1/1_org_zoom.jpg"  },
                new SubSubCategory { SubSubCategoryId = 3, CategoryName = "Mont" ,CategoryId=1,SubCategoryId=1,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg" },
                new SubSubCategory { SubSubCategoryId = 4, CategoryName = "Yazlık" ,CategoryId=1,SubCategoryId=1,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg" },
                new SubSubCategory { SubSubCategoryId = 5, CategoryName = "Kazak",CategoryId=1,SubCategoryId=1,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg"  },
                new SubSubCategory { SubSubCategoryId = 6, CategoryName = "Pijama" ,CategoryId=1,SubCategoryId=1,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg" },
                new SubSubCategory { SubSubCategoryId = 7, CategoryName = "Hırka",CategoryId=1,SubCategoryId=1 ,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg" },
                new SubSubCategory { SubSubCategoryId = 8, CategoryName = "Ceket & Yelek",CategoryId=1,SubCategoryId=1,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg" },
                new SubSubCategory { SubSubCategoryId = 9, CategoryName = "Gömlek" ,CategoryId=1,SubCategoryId=1,Url="https://cdn.dsmcdn.com/mnresize/415/622/ty87/product/media/images/20210403/9/77379840/160135516/1/1_org_zoom.jpg" },
                new SubSubCategory { SubSubCategoryId = 10, CategoryName = "Jean & \n pantolon",CategoryId=1,SubCategoryId=1,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg"  },
                new SubSubCategory { SubSubCategoryId = 11, CategoryName = "Büyük Beden",CategoryId=1,SubCategoryId=1,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg" },
                new SubSubCategory { SubSubCategoryId = 12, CategoryName = "Elbise",CategoryId=1,SubCategoryId=1 ,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg" },
                new SubSubCategory { SubSubCategoryId = 13, CategoryName = "Eşofman",CategoryId=1,SubCategoryId=1,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg"  },
                new SubSubCategory { SubSubCategoryId = 14, CategoryName = "Tesettür Giyim",CategoryId=1,SubCategoryId=1,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg"  },
                new SubSubCategory { SubSubCategoryId = 15, CategoryName = "Tam Ürünler",CategoryId=1,SubCategoryId=1,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg"  },
                new SubSubCategory { SubSubCategoryId = 16, CategoryName = "Bot & Bootie",CategoryId=1,SubCategoryId=2 ,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg" },
                new SubSubCategory { SubSubCategoryId = 17, CategoryName = "Sneaker",CategoryId=1,SubCategoryId=2 ,Url="https://productimages.hepsiburada.net/l/51/600-800/11073368784946.jpg" },
            };
        }
    }
}
