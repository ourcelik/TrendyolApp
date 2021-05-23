using Newtonsoft.Json;

namespace TrendyolApp.Models
{
    public class SubCategory
    {
        [JsonProperty("id")]
        public int SubCategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
    }
}