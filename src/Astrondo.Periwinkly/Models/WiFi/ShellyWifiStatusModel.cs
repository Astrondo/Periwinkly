using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models.WiFi
{
    public class ShellyWifiStatusModel
    {
        [JsonPropertyName("sta_ip")]
        public string StaIp { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("ssid")]
        public string Ssid { get; set; }

        [JsonPropertyName("rssi")]
        public int Rssi { get; set; }
    }

}
