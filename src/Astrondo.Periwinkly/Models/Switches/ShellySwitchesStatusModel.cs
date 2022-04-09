using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models.Switches
{
    public class ShellySwitchesStatusModel
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("output")]
        public bool Output { get; set; }

        [JsonPropertyName("timer_started_at")]
        public double TimerStartedAt { get; set; }

        [JsonPropertyName("timer_duration")]
        public int TimerDuration { get; set; }

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

        [JsonPropertyName("errors")]
        public List<string> Errors { get; set; }
    }
}
