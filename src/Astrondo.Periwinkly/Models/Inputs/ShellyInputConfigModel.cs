using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Models.Inputs
{
    public class ShellyInputConfigModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public ShellyInputType Type { get; set; }

        [JsonPropertyName("invert")]
        public bool Invert { get; set; }
    }
    public enum ShellyInputType { Switch, Button }
}
