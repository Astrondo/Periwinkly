using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly.Capabilities
{
    public interface IHasEthernet
    {
        public EthernetEndpoint Ethernet { get; }
    }
}