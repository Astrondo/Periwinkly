using System.Text.Json.Serialization;

namespace Astrondo.Periwinkly.Models.MQTT
{
    public class ShellyMQTTConfigModel
    {

        [JsonPropertyName("connected")]
        public bool Connected { get; set; }
    }
}
