using Astrondo.Periwinkly.Client;

namespace Astrondo.Periwinkly.Endpoints
{
    public class ScriptEndpoint : _BaseShellyEndpointWithIterator
    {
        public ScriptEndpoint(IShellyHttpClient shellyHttpClient, int count) : base(shellyHttpClient, count)
        {
        }
    }
}
