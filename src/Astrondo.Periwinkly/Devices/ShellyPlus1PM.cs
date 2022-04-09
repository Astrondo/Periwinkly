using Astrondo.Periwinkly.Capabilities;
using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly
{
    public class ShellyPlus1PM : BaseShellyDevice, IHasInputs, IHasSwitches
    {
        public ShellyPlus1PM(string ipAddress, string? password = null, string? proxyUrl = null) : this(new ShellyHttpClient(ipAddress, password, proxyUrl))
        {
        }
        public ShellyPlus1PM(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient)
        {
            Inputs = new InputsEndpoint(shellyHttpClient, 1);
            Switches = new SwitchesEndpoint(shellyHttpClient, 1);

        }
        public InputsEndpoint Inputs { get; internal set; }
        public SwitchesEndpoint Switches { get; internal set; }

    }
}