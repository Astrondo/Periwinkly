using Astrondo.Periwinkly.Capabilities;
using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly
{
    public class ShellyPro1PM : BaseShellyDevice, IHasInputs, IHasSwitches, IHasEthernet
    {
        public ShellyPro1PM(string ipAddress, string? password = null, string? proxyUrl = null) : this(new ShellyHttpClient(ipAddress, password, proxyUrl))
        {
        }
        public ShellyPro1PM(IShellyHttpClient shellyHttpClient) : base(shellyHttpClient)
        {
            Ethernet = new EthernetEndpoint(shellyHttpClient);
            Inputs = new InputsEndpoint(shellyHttpClient, 2);
            Switches = new SwitchesEndpoint(shellyHttpClient, 1);

        }
        public EthernetEndpoint Ethernet { get; internal set; }
        public InputsEndpoint Inputs { get; internal set; }
        public SwitchesEndpoint Switches { get; internal set; }

    }
}