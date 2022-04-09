using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Models.Ethernet
{
    public class ShellyEthernetConfigModel
    {
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        [JsonPropertyName("ipv4mode")]
        public ShellyIpv4Mode Ipv4mode { get; set; }

        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        [JsonPropertyName("netmask")]
        public string Netmask { get; set; }

        [JsonPropertyName("gw")]
        public string Gw { get; set; }

        [JsonPropertyName("nameserver")]
        public string Nameserver { get; set; }

    }
}
