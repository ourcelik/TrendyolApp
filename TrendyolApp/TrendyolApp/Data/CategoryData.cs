using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrendyolApp.Models;

namespace TrendyolApp.Data
{
    public static class CategoryData
    {
        public static ObservableCollection<Category> Categories { get { return categories; } }
        private static ObservableCollection<Category> categories;
        static CategoryData()
        {
            CreateCategories();
        }
        public static void CreateCategories()
        {
            categories = new ObservableCollection<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Kadın" , Url = "women.png"},
                new Category { CategoryId = 2, CategoryName = "Erkek",Url = "man.png" },
                new Category { CategoryId = 3, CategoryName = "Ev & Yaşam" ,Url = "phone.png"},
                new Category { CategoryId = 4, CategoryName = "Kozmetik & \n Kişisel Bakım" ,Url = "phone.png"},
                new Category { CategoryId = 5, CategoryName = "Anne & Çocuk",Url = "phone.png" },
                new Category { CategoryId = 6, CategoryName = "Elektronik",Url = "phone.png" },
                new Category { CategoryId = 7, CategoryName = "Ayakkabı & Çanta" ,Url = "phone.png"},
                new Category { CategoryId = 8, CategoryName = "SüperMarket",Url = "phone.png" },
                new Category { CategoryId = 9, CategoryName = "Spor & Outdoor",Url = "phone.png" },
                new Category { CategoryId = 10, CategoryName = "Mobilya",Url = "phone.png" },

            };
        }
    }
}
