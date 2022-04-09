using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Client
{
    public class ShellyRPCResponseModel<T>
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("src")]
        public string Src { get; set; }

        [JsonPropertyName("result")]
        public T Result { get; set; }
    }

}
