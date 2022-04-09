using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Models.WiFi;

namespace Astrondo.Periwinkly.Endpoints
{
    public class WiFiEndpoint : _BaseShellyEndpoint
    {
        public WiFiEndpoint(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient) { }
        public async Task<ShellyWifiConfigModel> GetConfigAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyWifiConfigModel>("Wifi.GetConfig");
        }

        public async Task<ShellyWifiStatusModel> GetStatusAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyWifiStatusModel>("Wifi.GetStatus");
        }

        public async Task<ShellyWifiScanModel> ScanAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyWifiScanModel>("Wifi.Scan");
        }
        //Wifi.SetConfig 
    }
}
