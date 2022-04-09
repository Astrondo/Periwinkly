using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models.HttpClient
{
    public class ShellyRPCAuthModel
    {
        [JsonPropertyName("realm")]
        public string Realm { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }

        [JsonPropertyName("cnonce")]
        public long Cnonce { get; set; }

        [JsonPropertyName("response")]
        public string Response { get; set; }

        [JsonPropertyName("algorithm")]
        public string Algorithm { get; set; }
    }
}