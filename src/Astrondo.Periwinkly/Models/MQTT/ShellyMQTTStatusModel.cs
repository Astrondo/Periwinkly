using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Models.MQTT
{
    public class ShellyMQTTStatusModel
    {
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        [JsonPropertyName("server")]
        public string Server { get; set; }

        [JsonPropertyName("user")]
        public string User { get; set; }

        [JsonPropertyName("ssl_ca")]
        public string SslCa { get; set; }

        [JsonPropertyName("topic_prefix")]
        public string TopicPrefix { get; set; }

        [JsonPropertyName("rpc_ntf")]
        public bool RpcNtf { get; set; }

        [JsonPropertyName("status_ntf")]
        public bool StatusNtf { get; set; }
    }
}
