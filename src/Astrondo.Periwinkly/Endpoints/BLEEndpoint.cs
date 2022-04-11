using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Models;
using Astrondo.Periwinkly.Models.BLE;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Endpoints
{
    public class BLEEndpoint : _BaseShellyEndpoint
    {

        public BLEEndpoint(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient) { }
        public async Task<ShellyBLEConfigModel> GetConfigAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyBLEConfigModel>("BLE.GetConfig");
        }
    }
}
