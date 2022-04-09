using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Models.Inputs;

namespace Astrondo.Periwinkly.Endpoints
{
    public class InputsEndpoint : _BaseShellyEndpointWithIterator
    {
        public InputsEndpoint(IShellyHttpClient shellyHttpClient, int count) : base(shellyHttpClient, count)
        {
        }
        public async Task<ShellyInputConfigModel> GetConfigAsync(int id)
        {
            ValidateIterator(id);
            return await _ShellyHttpClient.CallMethodAsync<ShellyInputConfigModel>("Input.GetConfig", new Dictionary<string, object>() { { "id", id } });
        }

        public async Task<ShellyInputStatusModel> GetStatusAsync(int id)
        {
            ValidateIterator(id);
            return await _ShellyHttpClient.CallMethodAsync<ShellyInputStatusModel>("Input.GetStatus", new Dictionary<string, object>() { { "id", id } });
        }
    }
}
