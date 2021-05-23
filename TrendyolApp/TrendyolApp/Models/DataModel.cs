using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TrendyolApp.Models
{
    public class DataModel<TModel>
    {
        
        [JsonProperty("data")]
        public TModel model { get; set; }
    }
    public class CategoryModel
    {
       
        [JsonProperty("category")]
        public ObservableCollection<Category> Categories { get; set; }
    }

    public class ProductModel
    {

        [JsonProperty("product")]
        public ObservableCollection<Product> Products { get; set; }
    }

    public class CarouselModel
    {

        [JsonProperty("carouselAd")]
        public ObservableCollection<CarouselAd> CarouselAds { get; set; }

    }
    public class PhotoModel
    {
        [JsonProperty("photo")]
        public ObservableCollection<Photo> Photos { get; set; }
    }
    public class SubCategoryModel
    {
        [JsonProperty("subCategory")]
        public ObservableCollection<SubCategory> SubCategories { get; set; }
    }
    public class SubSubCategoryModel
    {
        [JsonProperty("subSubCategory")]
        public ObservableCollection<SubSubCategory> subSubCategories { get; set; }
    }

}
