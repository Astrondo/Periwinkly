using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly.Capabilities
{
    public interface IHasCover
    {
        public CoversEndpoint Covers { get; }
    }
}