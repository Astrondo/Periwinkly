using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Models.Cover;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Astrondo.Periwinkly.Endpoints
{
    public class CoversEndpoint : _BaseShellyEndpointWithIterator
    {

        public CoversEndpoint(IShellyHttpClient shellyHttpClient, int count) : base(shellyHttpClient, count)
        {
        }
        public async Task<ShellyCoverConfigModel> GetConfigAsync(int id)
        {
            ValidateIterator(id);
            return await _ShellyHttpClient.CallMethodAsync<ShellyCoverConfigModel>("Cover.GetConfig", new Dictionary<string, object>() { { "id", id } });
        }

        public async Task<ShellyCoverStatusModel> GetStatusAsync(int id)
        {
            ValidateIterator(id);
            return await _ShellyHttpClient.CallMethodAsync<ShellyCoverStatusModel>("Cover.GetStatus", new Dictionary<string, object>() { { "id", id } });
        }
        public async Task OpenAsync(int id, int? durationSeconds = null)
        {
            ValidateIterator(id);
            await _ShellyHttpClient.CallMethodAsync("Cover.Open", new Dictionary<string, object>() { { "id", id }, { "duration", durationSeconds } });
        }
        public async Task StopAsync(int id)
        {
            ValidateIterator(id);
            await _ShellyHttpClient.CallMethodAsync("Cover.Stop", new Dictionary<string, object>() { { "id", id } });
        }
    }
}
