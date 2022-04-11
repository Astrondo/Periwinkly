using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Models.Ethernet;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Endpoints
{
    public class EthernetEndpoint : _BaseShellyEndpoint
    {
        public EthernetEndpoint(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient)
        {
        }
        public async Task<ShellyEthernetConfigModel> GetConfigAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyEthernetConfigModel>("Eth.GetConfig");
        }

        public async Task<ShellyEthernetStatusModel> GetStatusAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyEthernetStatusModel>("Eth.GetStatus");
        }
    }
}
