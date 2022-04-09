using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models
{
    public class ShellyTemperatureModel
    {
        [JsonPropertyName("tC")]
        public double TC { get; set; }

        [JsonPropertyName("tF")]
        public double TF { get; set; }
    }
}
