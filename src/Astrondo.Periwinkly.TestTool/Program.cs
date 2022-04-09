// See https://aka.ms/new-console-template for more information
using Astrondo.Periwinkly;
using Astrondo.Periwinkly.Capabilities;
using Astrondo.Periwinkly.Client;
using Astrondo.Periwinkly.Discovery;
using static Astrondo.Periwinkly.Client.ShellyHttpClient;

Console.WriteLine("Hello, World!");


var devices = await ShellyBonjourFinder.FindShellyDevices();
foreach (var device in devices)
{
    var asBase = device as BaseShellyDevice;
    asBase.SetPassword("password");

    var cfg = await asBase.System.GetConfigAsync();
    var status = await asBase.System.GetStatusAsync();

    var bleCfg = await asBase.BLE.GetConfigAsync();

    var cloudCfg = await asBase.Cloud.GetConfigAsync();
    var cloudStatus = await asBase.Cloud.GetStatusAsync();

    var mqttCfg = await asBase.MQTT.GetConfigAsync();
    var mqttStatus = await asBase.MQTT.GetStatusAsync();

    var wifiConfig = await asBase.WiFi.GetConfigAsync();
    var wifiStatus = await asBase.WiFi.GetStatusAsync();

    if (device is IHasCover)
    {
        var coverDevice = device as IHasCover;

    }
    if (device is IHasEthernet)
    {
        var ethDevice = device as IHasEthernet;

        var ethConfig = await ethDevice.Ethernet.GetConfigAsync();
        var ethStatus = await ethDevice.Ethernet.GetStatusAsync();

    }
    if (device is IHasInputs)
    {
        var inputDevice = device as IHasInputs;
        for (int i = 0; i < inputDevice.Inputs.DeviceCount; i++)
        {
            var inputConfig = await inputDevice.Inputs.GetConfigAsync(i);
            var ethStatus = await inputDevice.Inputs.GetStatusAsync(i);
        }
    }

    if (device is IHasSwitches)
    {
        var switchDevice = device as IHasSwitches;
        for (int i = 0; i < switchDevice.Switches.DeviceCount; i++)
        {
            var inputConfig = await switchDevice.Switches.GetConfigAsync(i);
            var ethStatus = await switchDevice.Switches.GetStatusAsync(i);

            await switchDevice.Switches.ToggleAsync(i);
            System.Threading.Thread.Sleep(1000);
            await switchDevice.Switches.ToggleAsync(i);

        }
    }
}