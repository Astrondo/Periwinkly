using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models.WiFi
{
    public class ShellyWifiScanModel
    {

        [JsonPropertyName("results")]
        public List<ShellyWifiScanResultModel> Results { get; set; }
    }
    public class ShellyWifiScanResultModel
    {
        [JsonPropertyName("ssid")]
        public string Ssid { get; set; }

        [JsonPropertyName("bssid")]
        public string Bssid { get; set; }

        [JsonPropertyName("auth")]
        public int Auth { get; set; }

        [JsonPropertyName("channel")]
        public int Channel { get; set; }

        [JsonPropertyName("rssi")]
        public int Rssi { get; set; }
    }
}
