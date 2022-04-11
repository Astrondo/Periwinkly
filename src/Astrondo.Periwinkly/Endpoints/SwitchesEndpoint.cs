using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Models.Switches;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Astrondo.Periwinkly.Endpoints
{
    public class SwitchesEndpoint : _BaseShellyEndpointWithIterator
    {

        public SwitchesEndpoint(IShellyHttpClient shellyHttpClient, int count) : base(shellyHttpClient, count)
        {
        }
        public async Task<ShellySwitchesConfigModel> GetConfigAsync(int id)
        {
            ValidateIterator(id);
            return await _ShellyHttpClient.CallMethodAsync<ShellySwitchesConfigModel>("Switch.GetConfig", new Dictionary<string, object>() { { "id", id } });
        }

        public async Task<ShellySwitchesStatusModel> GetStatusAsync(int id)
        {
            ValidateIterator(id);
            return await _ShellyHttpClient.CallMethodAsync<ShellySwitchesStatusModel>("Switch.GetStatus", new Dictionary<string, object>() { { "id", id } });
        }

        public async Task<ShellySwitchesChangeResponseModel> SetAsync(int id, bool turnOn, int? flipBackAfter = null)
        {
            ValidateIterator(id);
            return await _ShellyHttpClient.CallMethodAsync<ShellySwitchesChangeResponseModel>("Switch.Set", new Dictionary<string, object>() { { "id", id }, { "on", turnOn }, { "toggle_after", flipBackAfter } });
        }

        public async Task<ShellySwitchesChangeResponseModel> ToggleAsync(int id)
        {
            ValidateIterator(id);
            return await _ShellyHttpClient.CallMethodAsync<ShellySwitchesChangeResponseModel>("Switch.Toggle", new Dictionary<string, object>() { { "id", id } });
        }
    }
}
