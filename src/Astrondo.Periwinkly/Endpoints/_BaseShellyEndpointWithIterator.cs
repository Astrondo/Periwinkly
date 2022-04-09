using Astrondo.Periwinkly.Client;

namespace Astrondo.Periwinkly.Endpoints
{
    public abstract class _BaseShellyEndpointWithIterator : _BaseShellyEndpoint
    {

        protected _BaseShellyEndpointWithIterator(IShellyHttpClient Periwinkly, int deviceCount) : base(Periwinkly)
        {
            DeviceCount = deviceCount;
        }

        protected void ValidateIterator(int i)
        {
            if (i < 0)
            {
                throw new ArgumentOutOfRangeException("deviceId", $"Device id {i} is below 0");
            }

            if (i + 1 > DeviceCount)
            {
                throw new ArgumentOutOfRangeException("deviceId", $"Device id {i} is out of range of this device.");
            }
        }
        public int DeviceCount { get; }
    }
}
