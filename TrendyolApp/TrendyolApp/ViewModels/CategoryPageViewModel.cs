using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolApp.Data;
using TrendyolApp.Extensions;
using TrendyolApp.Models;
using TrendyolApp.Services;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class CategoryPageViewModel : BaseViewModel
    {
        CategoryService _categoryService;
        SubCategoryService _subCategoryService;
        SubSubCategoryService _subSubCategoryService;

        public ObservableCollection<Category> Categories
        {
            get { return categories; }
            set
            {
                categories = value;
                OnPropertyChanged(nameof(Categories));
            }
        }
        public ObservableCollection<Category> categories;
        public ObservableCollection<SubCategory> SubCategories
        {
            get { return subCategories; }
            set
            {
                subCategories = value;
                OnPropertyChanged(nameof(SubCategories));
            }
        }
        public ObservableCollection<SubCategory> subCategories;
        public ObservableCollection<SubSubCategory> SubSubCategories
        {
            get { return subSubCategories; }
            set
            {
                subSubCategories = value;
                OnPropertyChanged(nameof(SubSubCategories));
            }
    }
        private ObservableCollection<SubSubCategory> subSubCategories;
        public CategoryPageViewModel()
        {
            _categoryService = new CategoryService();
            _subCategoryService = new SubCategoryService();
            _subSubCategoryService = new SubSubCategoryService();
            GetCategories().Await();
            subCategories = new ObservableCollection<SubCategory>();
            subSubCategories = new ObservableCollection<SubSubCategory>();
            OnPropertyChanged(nameof(SubSubCategories));
            GetSubCategories = new Command(async (id) =>
            {
                subCategories.Clear();
                var data = await _subCategoryService.GetSubCategoriesAsync();
                data.model.SubCategories.Where(sc => sc.CategoryId == (int)id).ToList().ForEach((sc) => SubCategories.Add(sc));
            });
            GetSubSubCategories = new Command(async (id) =>
            {
                subSubCategories.Clear();
                var data = await _subSubCategoryService.GetSubSubCategoriesAsync();
                data.model.subSubCategories.Where(sc => sc.SubCategoryId == (int)id).ToList().ForEach((sc) => SubSubCategories.Add(sc));
            });
        }
        private async Task GetCategories()
        {
            var data = await _categoryService.GetCategoriesAsync();

            Categories = data.model.Categories;
        }

        public Command GetSubCategories { get; }
        public Command GetSubSubCategories { get; }
    }
}
