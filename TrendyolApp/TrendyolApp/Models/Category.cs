using Newtonsoft.Json;

namespace TrendyolApp.Models
{
    public class Category
    {

        [JsonProperty("id")]
        public int CategoryId { get; set; }
        
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}