using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrendyolApp.Data;
using TrendyolApp.Extensions;
using TrendyolApp.Models;
using TrendyolApp.Services;
using TrendyolApp.Services.abstracts;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class CategoryPageViewModel : BaseViewModel
    {
        #region Services
        readonly ICategoryService _categoryService;
        readonly ISubCategoryService _subCategoryService;
        readonly ISubSubCategoryService _subSubCategoryService;
        #endregion
        #region Commands
        public ICommand GetSubCategories { get; set; }
        public ICommand GetSubSubCategories { get; set; }
        #endregion
        #region Variables
        public ObservableCollection<Category> categories;
        public ObservableCollection<SubCategory> subCategories;
        private ObservableCollection<SubSubCategory> subSubCategories;
        #endregion
        #region Props
        public ObservableCollection<Category> Categories
        {

            get { return categories; }
            set
            {
                categories = value;
                OnPropertyChanged(nameof(Categories));
            }
        }
        public ObservableCollection<SubCategory> SubCategories
        {
            get { return subCategories; }
            set
            {
                subCategories = value;
                OnPropertyChanged(nameof(SubCategories));
            }
        }
        public ObservableCollection<SubSubCategory> SubSubCategories
        {
            get { return subSubCategories; }
            set
            {
                subSubCategories = value;
                OnPropertyChanged(nameof(SubSubCategories));
            }
        }
        #endregion
        public CategoryPageViewModel(ICategoryService categoryService, ISubCategoryService subCategoryService, ISubSubCategoryService subSubCategoryService)
        {
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
            _subSubCategoryService = subSubCategoryService;
            subCategories = new ObservableCollection<SubCategory>();
            subSubCategories = new ObservableCollection<SubSubCategory>();
            GetCategories().Await();
            OnPropertyChanged(nameof(SubSubCategories));
            DefineCommands();

        }

        private void DefineCommands()
        {
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

  
    }
}
