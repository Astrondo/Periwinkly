using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models.HttpClient
{
    public class ShellyRPCModel
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("method")]
        public string Method { get; set; }

        [JsonPropertyName("params")]
        public Dictionary<string, object> Params { get; set; }

        [JsonPropertyName("auth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ShellyRPCAuthModel Auth { get; set; }
    }

}
