using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrendyolApp.Models
{
    public class Product
    {
        public Product()
        {
            DeliveryDate = DateTime.Now;
            Currency = new Currency() { CurrencyType = "TL" };
        }

        [JsonProperty("id")]
        public int ProductId { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("photos")]
        public List<Photo> Photos { get; set; }


        [JsonProperty("seller")]
        public string Seller { get; set; }

        [JsonProperty("productInfo")]
        public string ProductInfo { get; set; }

        //[JsonProperty("photos")]
        //public List<CommentModel> Comments { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("subCategory")]
        public SubCategory SubCategory { get; set; }

        [JsonProperty("subSubCategory")]
        public SubSubCategory SubSubCategory { get; set; }

        [JsonProperty("topPhoto")]
        public Photo TopPhoto { get; set; }

        public DateTime DeliveryDate { get; set; }

        public Currency Currency { get; set; }

    }
}
