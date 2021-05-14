using System.Collections.ObjectModel;
using TrendyolApp.Models;

namespace TrendyolApp.Data
{
    public static class SubCategoryData
    {
        public static ObservableCollection<SubCategory> SubCategories { get { return subCategories; } }
        private static ObservableCollection<SubCategory> subCategories;
        static SubCategoryData()
        {
            CreateSubCategories();
        }
        public static void CreateSubCategories()
        {
            subCategories = new ObservableCollection<SubCategory>
            {
               new SubCategory{CategoryId=1,CategoryName ="Giyim",SubCategoryId=1},
               new SubCategory{CategoryId=1,CategoryName ="Ayakkabı",SubCategoryId=2},
               new SubCategory{CategoryId=1,CategoryName ="Aksesuar",SubCategoryId=3},
               new SubCategory{CategoryId=1,CategoryName ="Çanta",SubCategoryId=4},
               new SubCategory{CategoryId=1,CategoryName ="Kozmetik & Kişisel Bakım",SubCategoryId=5},
               new SubCategory{CategoryId=1,CategoryName ="Spor & Outdoor",SubCategoryId=6},
               new SubCategory{CategoryId=1,CategoryName ="Lüks & Designer",SubCategoryId=7},
               new SubCategory{CategoryId=2,CategoryName ="Giyim",SubCategoryId=8},
               new SubCategory{CategoryId=2,CategoryName ="Saat & Gözlük & Aksesuar",SubCategoryId=9},
               new SubCategory{CategoryId=2,CategoryName ="Çanta",SubCategoryId=10},
               new SubCategory{CategoryId=2,CategoryName ="Kozmetik & Kişisel Bakım",SubCategoryId=11},
               new SubCategory{CategoryId=2,CategoryName ="Spor & Outdoor",SubCategoryId=12},
               new SubCategory{CategoryId=2,CategoryName ="Lüks & Designer",SubCategoryId=13},
            };
        }
    }
}
