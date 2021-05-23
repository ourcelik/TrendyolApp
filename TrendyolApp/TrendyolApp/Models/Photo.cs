using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrendyolApp.Models
{
    public class Photo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("productId")]
        public int ProductId { get; set; }

    }
}
