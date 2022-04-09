using Astrondo.Periwinkly.Capabilities;
using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly
{
    public class ShellyPlus2PM : BaseShellyDevice, IHasInputs, IHasSwitches, IHasCover
    {
        public ShellyPlus2PM(string ipAddress, string? password = null, string? proxyUrl = null) : this(new ShellyHttpClient(ipAddress, password, proxyUrl))
        {
        }
        public ShellyPlus2PM(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient)
        {
            Inputs = new InputsEndpoint(shellyHttpClient, 2);
            Switches = new SwitchesEndpoint(shellyHttpClient, 2);
            Covers = new CoversEndpoint(shellyHttpClient, 1);
        }
        public InputsEndpoint Inputs { get; internal set; }
        public SwitchesEndpoint Switches { get; internal set; }
        public CoversEndpoint Covers { get; internal set; }

    }
}