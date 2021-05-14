using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TrendyolApp.Data;
using TrendyolApp.Models;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class CategoryPageViewModel : BaseViewModel
    {
        public ObservableCollection<Category> Categories
        {
            get { return categories; }
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
            categories = new ObservableCollection<Category>(CategoryData.Categories);
            subCategories = new ObservableCollection<SubCategory>();
            subSubCategories = new ObservableCollection<SubSubCategory>();
            OnPropertyChanged(nameof(SubSubCategories));
            GetSubCategories = new Command((id) =>
            {
                subCategories.Clear();
                SubCategoryData.SubCategories.Where(sc => sc.CategoryId == (int)id).ToList().ForEach((sc) => subCategories.Add(sc));
                OnPropertyChanged(nameof(SubCategories));
            });
            GetSubSubCategories = new Command((id) =>
            {
                subSubCategories.Clear();
                SubSubCategoryData.SubSubCategories.Where(sc => sc.SubCategoryId == (int)id).ToList().ForEach((sc) => subSubCategories.Add(sc));
                OnPropertyChanged(nameof(SubCategories));
            });
        }
        public Command GetSubCategories { get; }
        public Command GetSubSubCategories { get; }
    }
}
