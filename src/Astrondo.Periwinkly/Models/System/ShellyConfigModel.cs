using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Models.System
{
    /*{"id":1,"src":"shellypro1-30c6f7849da4","result":{"device":{"name":"Ancilliary Power","mac":"30C6F7849DA4","fw_id":"20220330-150137/0.10.1-g8d603a2","eco_mode":false},"location":{"tz":"Europe/London","lat":51.421360,"lon":-0.992820},"debug":{"mqtt":{"enable":false},"websocket":{"enable":false},"udp":{"addr":null}},"ui_data":{"consumption_types":["socket"]},"rpc_udp":{"dst_addr":null,"listen_port":null},"sntp":{"server":"time.google.com"},"cfg_rev":17}}*/
    public class ShellyConfigModel
    {
        [JsonPropertyName("device")]
        public ShellyConfigDeviceModel Device { get; set; }

        [JsonPropertyName("location")]
        public ShellyConfigLocationModel Location { get; set; }

        [JsonPropertyName("debug")]
        public ShellyConfigDebugModel Debug { get; set; }

        [JsonPropertyName("ui_data")]
        public ShellyConfigUiDataModel UiData { get; set; }

        [JsonPropertyName("rpc_udp")]
        public ShellyConfigRpcUdpModel RpcUdp { get; set; }

        [JsonPropertyName("cfg_rev")]
        public int CfgRev { get; set; }

        [JsonPropertyName("sntp")]
        public ShellyConfigSntpModel Sntp { get; set; }
    }

    public class ShellyConfigDeviceModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("mac")]
        public string Mac { get; set; }

        [JsonPropertyName("fw_id")]
        public string FwId { get; set; }

        [JsonPropertyName("profile")]
        public string Profile { get; set; }
    }

    public class ShellyConfigLocationModel
    {
        [JsonPropertyName("tz")]
        public string Tz { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }
    }

    public class ShellyConfigMqttModel
    {
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }
    }

    public class ShellyConfigWebsocketModel
    {
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }
    }

    public class ShellyConfigUdpModel
    {
        [JsonPropertyName("addr")]
        public string Addr { get; set; }
    }

    public class ShellyConfigDebugModel
    {
        [JsonPropertyName("mqtt")]
        public ShellyConfigMqttModel Mqtt { get; set; }

        [JsonPropertyName("websocket")]
        public ShellyConfigWebsocketModel Websocket { get; set; }

        [JsonPropertyName("udp")]
        public ShellyConfigUdpModel Udp { get; set; }
    }

    public class ShellyConfigUiDataModel
    {
    }

    public class ShellyConfigRpcUdpModel
    {
        [JsonPropertyName("dst_addr")]
        public string DstAddr { get; set; }

        [JsonPropertyName("listen_port")]
        public string ListenPort { get; set; }
    }

    public class ShellyConfigSntpModel
    {
        [JsonPropertyName("server")]
        public string Server { get; set; }
    }



}
