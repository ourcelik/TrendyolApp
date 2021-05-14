using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TrendyolApp.Data;
using TrendyolApp.Models;

namespace TrendyolApp.ViewModels
{
    class ProductListViewModel : BaseViewModel
    {
        ObservableCollection<ProductModel> listProducts;
        public ObservableCollection<ProductModel> ListProducts
        {
            get
            {
                return listProducts;
            }
            set
            {
                listProducts = value;
                OnPropertyChanged(nameof(ListProducts));
            }

        }

        public ProductListViewModel(SubSubCategory category)
        {
            listProducts = new ObservableCollection<ProductModel>();
            GetCategories(category);
        }
        public ProductListViewModel()
        {

        }
        public ObservableCollection<ProductModel> GetCategories(SubSubCategory category)
        {
            List<ProductModel> data = ProductData.GetProducts().Where(p => p.Category.CategoryId == category.CategoryId
            && p.SubCategory.SubCategoryId == category.SubCategoryId
            && p.SubSubCategory.SubSubCategoryId == category.SubSubCategoryId).ToList();

            data.ForEach(p => ListProducts.Add(p));
            return ListProducts;

        }
    }
}
