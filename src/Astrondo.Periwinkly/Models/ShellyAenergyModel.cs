using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models
{
    public class ShellyAenergyModel
    {
        [JsonPropertyName("total")]
        public double Total { get; set; }

        [JsonPropertyName("by_minute")]
        public List<double> ByMinute { get; set; }

        [JsonPropertyName("minute_ts")]
        public int MinuteTs { get; set; }
    }
}
