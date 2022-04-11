using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Models.Cloud;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Endpoints
{
    public class CloudEndpoint : _BaseShellyEndpoint
    {

        public CloudEndpoint(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient)
        {
        }
        public async Task<ShellyCloudConfigModel> GetConfigAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyCloudConfigModel>("Cloud.GetConfig");
        }

        public async Task<ShellyCloudStatusModel> GetStatusAsync()
        {
            return await _ShellyHttpClient.CallMethodAsync<ShellyCloudStatusModel>("Cloud.GetStatus");
        }
    }
}
