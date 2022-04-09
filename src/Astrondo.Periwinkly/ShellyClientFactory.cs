using Astrondo.Periwinkly.Client;

namespace Astrondo.Periwinkly
{
    public class ShellyClientFactory
    {
        public static IShellyDevice Build(string ipAddress, string appName)
        {
            switch (appName)
            {
                case "Pro1":
                    return new ShellyPro1(BuildHttpClient(ipAddress));
                case "Pro4PM":
                    return new ShellyPro4PM(BuildHttpClient(ipAddress));
                default:
                    throw new ArgumentException($"Unknown device: {appName}");
            }
        }

        private static IShellyHttpClient BuildHttpClient(string iPAddress)
        {
            return new ShellyHttpClient(iPAddress);
        }
    }
}