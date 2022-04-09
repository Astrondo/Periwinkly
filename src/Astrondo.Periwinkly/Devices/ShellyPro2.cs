using Astrondo.Periwinkly.Capabilities;
using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly
{
    public class ShellyPro2 : BaseShellyDevice, IHasInputs, IHasSwitches, IHasEthernet
    {
        public ShellyPro2(string ipAddress, string? password = null, string? proxyUrl = null) : this(new ShellyHttpClient(ipAddress, password, proxyUrl))
        {
        }
        public ShellyPro2(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient)
        {
            Ethernet = new EthernetEndpoint(shellyHttpClient);
            Inputs = new InputsEndpoint(shellyHttpClient, 2);
            Switches = new SwitchesEndpoint(shellyHttpClient, 2);

        }

        public EthernetEndpoint Ethernet { get; internal set; }
        public InputsEndpoint Inputs { get; internal set; }
        public SwitchesEndpoint Switches { get; internal set; }

    }
}