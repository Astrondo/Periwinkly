using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Models.MQTT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Endpoints
{
    public class MQTTEndpoint : _BaseShellyEndpoint
    {
        public MQTTEndpoint(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient) { }
        public async Task<ShellyMQTTConfigModel> GetConfigAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyMQTTConfigModel>("MQTT.GetConfig");
        }

        public async Task<ShellyMQTTStatusModel> GetStatusAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyMQTTStatusModel>("MQTT.GetStatus");
        }
    }
}
