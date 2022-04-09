using Astrondo.Periwinkly.Capabilities;
using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly
{
    public class ShellyPro4PM : BaseShellyDevice, IHasInputs, IHasSwitches, IHasEthernet
    {
        public ShellyPro4PM(string ipAddress, string? password = null, string? proxyUrl = null) : this(new ShellyHttpClient(ipAddress, password, proxyUrl))
        {
        }
        public ShellyPro4PM(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient)
        {
            Ethernet = new EthernetEndpoint(shellyHttpClient);
            Inputs = new InputsEndpoint(shellyHttpClient, 4);
            Switches = new SwitchesEndpoint(shellyHttpClient, 4);

        }
        public EthernetEndpoint Ethernet { get; internal set; }
        public InputsEndpoint Inputs { get; internal set; }
        public SwitchesEndpoint Switches { get; internal set; }

    }
}