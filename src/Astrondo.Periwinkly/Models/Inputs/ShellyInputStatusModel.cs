using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models.Inputs
{
    public class ShellyInputStatusModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("state")]
        public bool State { get; set; }
    }
}
