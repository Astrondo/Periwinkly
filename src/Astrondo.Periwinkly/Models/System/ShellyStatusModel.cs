using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models.System
{
    public class ShellyStatusModel
    {
        [JsonPropertyName("mac")]
        public string Mac { get; set; }

        [JsonPropertyName("restart_required")]
        public bool RestartRequired { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("unixtime")]
        public int Unixtime { get; set; }

        [JsonPropertyName("uptime")]
        public int Uptime { get; set; }

        [JsonPropertyName("ram_size")]
        public int RamSize { get; set; }

        [JsonPropertyName("ram_free")]
        public int RamFree { get; set; }

        [JsonPropertyName("fs_size")]
        public int FsSize { get; set; }

        [JsonPropertyName("fs_free")]
        public int FsFree { get; set; }

        [JsonPropertyName("available_updates")]
        public AvailableUpdates AvailableUpdates { get; set; }
    }
    public class AvailableUpdates
    {
    }

}
