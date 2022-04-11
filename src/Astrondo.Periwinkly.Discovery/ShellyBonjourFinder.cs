using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zeroconf;
namespace Astrondo.Periwinkly.Discovery
{

    public static class ShellyBonjourFinder
    {
        public static async Task<IEnumerable<IShellyDevice>> FindShellyDevices()
        {
            IReadOnlyList<IZeroconfHost> results = await ZeroconfResolver.ResolveAsync("_shelly._tcp.local.");

            List<IShellyDevice> devices = new List<IShellyDevice>();

            foreach (IZeroconfHost host in results)
            {
                var app = host.Services.FirstOrDefault().Value.Properties.FirstOrDefault().FirstOrDefault(x => x.Key == "app").Value;
                devices.Add(ShellyClientFactory.Build(host.IPAddress, app));
            }

            return devices;
        }
    }
}