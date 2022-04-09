using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Endpoints;

namespace Astrondo.Periwinkly
{
    public interface IShellyDevice { }
    public abstract class BaseShellyDevice : IShellyDevice
    {
        protected readonly IShellyHttpClient Periwinkly;

        public BaseShellyDevice(IShellyHttpClient shellyHttpClient)
        {
            System = new SystemEndpoint(shellyHttpClient);
            WiFi = new WiFiEndpoint(shellyHttpClient);
            BLE = new BLEEndpoint(shellyHttpClient);
            Cloud = new CloudEndpoint(shellyHttpClient);
            MQTT = new MQTTEndpoint(shellyHttpClient);
            ScriptEndpoint = new ScriptEndpoint(shellyHttpClient, 10);
            this.Periwinkly = shellyHttpClient;
        }

        public void SetPassword(string password)
        {
            Periwinkly.SetPassword(password);
        }

        public SystemEndpoint System { get; internal set; }
        public WiFiEndpoint WiFi { get; internal set; }
        public BLEEndpoint BLE { get; internal set; }
        public CloudEndpoint Cloud { get; internal set; }
        public MQTTEndpoint MQTT { get; internal set; }
        public ScriptEndpoint ScriptEndpoint { get; internal set; }
    }
}