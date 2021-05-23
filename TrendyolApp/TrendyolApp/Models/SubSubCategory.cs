using Newtonsoft.Json;

namespace TrendyolApp.Models
{
    public class SubSubCategory
    {
        [JsonProperty("id")]
        public int SubSubCategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("subCategoryId")]
        public int SubCategoryId { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}