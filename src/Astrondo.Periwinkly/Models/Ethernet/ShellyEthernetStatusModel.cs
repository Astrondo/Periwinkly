using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models.Ethernet
{
    public class ShellyEthernetStatusModel
    {
        [JsonPropertyName("ip")]
        public string Ip { get; set; }
    }
}
