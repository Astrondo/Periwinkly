using Astrondo.Periwinkly.Capabilities;
using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly
{
    public class ShellyPro2PM : BaseShellyDevice, IHasCover, IHasInputs, IHasSwitches, IHasEthernet
    {
        public ShellyPro2PM(string ipAddress, string? password = null, string? proxyUrl = null) : this(new ShellyHttpClient(ipAddress, password, proxyUrl))
        {
        }
        public ShellyPro2PM(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient)
        {
            Ethernet = new EthernetEndpoint(shellyHttpClient);
            Inputs = new InputsEndpoint(shellyHttpClient, 2);
            Switches = new SwitchesEndpoint(shellyHttpClient, 2);
            Covers = new CoversEndpoint(shellyHttpClient, 1);

        }

        public EthernetEndpoint Ethernet { get; internal set; }
        public InputsEndpoint Inputs { get; internal set; }
        public SwitchesEndpoint Switches { get; internal set; }
        public CoversEndpoint Covers { get; internal set; }

    }
}