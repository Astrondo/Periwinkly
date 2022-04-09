using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models.Cover
{
    public class ShellyCoverStatusModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("apower")]
        public double Apower { get; set; }

        [JsonPropertyName("voltage")]
        public double Voltage { get; set; }

        [JsonPropertyName("current")]
        public double Current { get; set; }

        [JsonPropertyName("pf")]
        public double Pf { get; set; }

        [JsonPropertyName("aenergy")]
        public ShellyAenergyModel Aenergy { get; set; }

        [JsonPropertyName("temperature")]
        public ShellyTemperatureModel Temperature { get; set; }

        [JsonPropertyName("pos_control")]
        public bool PosControl { get; set; }

        [JsonPropertyName("current_pos")]
        public int CurrentPos { get; set; }
    }
}
