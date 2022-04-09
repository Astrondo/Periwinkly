using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Models.BLE
{
    public class ShellyBLEConfigModel
    {
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }
    }
}
