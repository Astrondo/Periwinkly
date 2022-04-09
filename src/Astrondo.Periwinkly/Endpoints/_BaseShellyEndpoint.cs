using Astrondo.Periwinkly.Client;

namespace Astrondo.Periwinkly.Endpoints
{
    public abstract class _BaseShellyEndpoint
    {
        protected IShellyHttpClient _ShellyHttpClient;

        protected _BaseShellyEndpoint(IShellyHttpClient shellyHttpClient)
        {
            this._ShellyHttpClient = shellyHttpClient;
        }
    }
}
