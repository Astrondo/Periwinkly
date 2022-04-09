using Astrondo.Periwinkly.Capabilities;
using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly
{
    public class ShellyPlusI4 : BaseShellyDevice, IHasInputs
    {
        public ShellyPlusI4(string ipAddress, string? password = null, string? proxyUrl = null) : this(new ShellyHttpClient(ipAddress, password, proxyUrl))
        {
        }
        public ShellyPlusI4(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient)
        {
            Inputs = new InputsEndpoint(shellyHttpClient, 4);
        }

        public InputsEndpoint Inputs { get; internal set; }
    }
}