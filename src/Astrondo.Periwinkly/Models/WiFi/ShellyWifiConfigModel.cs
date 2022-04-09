using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models.WiFi
{
    public class ShellyWifiConfigModel
    {
        [JsonPropertyName("ap")]
        public Ap Ap { get; set; }

        [JsonPropertyName("sta")]
        public Sta Sta { get; set; }

        [JsonPropertyName("sta1")]
        public Sta Sta1 { get; set; }

        [JsonPropertyName("roam")]
        public Roam Roam { get; set; }
    }
    public class Ap
    {
        [JsonPropertyName("ssid")]
        public string Ssid { get; set; }

        [JsonPropertyName("is_open")]
        public bool IsOpen { get; set; }

        [JsonPropertyName("enable")]
        public bool Enable { get; set; }
    }

    public class Sta
    {
        [JsonPropertyName("ssid")]
        public string Ssid { get; set; }

        [JsonPropertyName("is_open")]
        public bool IsOpen { get; set; }

        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        [JsonPropertyName("ipv4mode")]
        public string Ipv4mode { get; set; }

        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        [JsonPropertyName("netmask")]
        public string Netmask { get; set; }

        [JsonPropertyName("gw")]
        public string Gw { get; set; }

        [JsonPropertyName("nameserver")]
        public string Nameserver { get; set; }
    }

    public class Roam
    {
        [JsonPropertyName("rssi_thr")]
        public int RssiThr { get; set; }

        [JsonPropertyName("interval")]
        public int Interval { get; set; }
    }
}
