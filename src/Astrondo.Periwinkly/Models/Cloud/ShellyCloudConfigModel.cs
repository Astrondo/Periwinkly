using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Models.Cloud
{
    public class ShellyCloudConfigModel
    {
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        [JsonPropertyName("server")]
        public string Server { get; set; }
    }
    public class ShellyCloudStatusModel
    {
        [JsonPropertyName("connected")]
        public bool Connected { get; set; }
    }
}
