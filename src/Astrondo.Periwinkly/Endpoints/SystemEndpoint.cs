using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Models.System;

namespace Astrondo.Periwinkly.Endpoints
{
    public class SystemEndpoint : _BaseShellyEndpoint
    {
        public SystemEndpoint(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient)
        {

        }

        public async Task<ShellyConfigModel> GetConfigAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyConfigModel>("Sys.GetConfig");
        }

        public async Task<ShellyStatusModel> GetStatusAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyStatusModel>("Sys.GetStatus");
        }

        //Sys.SetConfig
    }
}
