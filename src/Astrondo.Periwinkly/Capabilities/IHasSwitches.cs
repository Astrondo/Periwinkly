using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly.Capabilities
{
    public interface IHasSwitches
    {
        public SwitchesEndpoint Switches { get; }
    }
}