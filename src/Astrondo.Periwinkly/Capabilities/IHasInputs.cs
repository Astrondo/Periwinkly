using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly.Capabilities
{
    public interface IHasInputs
    {
        public InputsEndpoint Inputs { get; }
    }
}