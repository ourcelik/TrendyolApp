using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrendyolApp.Models
{
    public class CarouselAd
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

    }
}
