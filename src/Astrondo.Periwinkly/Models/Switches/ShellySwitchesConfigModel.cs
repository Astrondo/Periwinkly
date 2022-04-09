using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Models.Switches
{
    public class ShellySwitchesChangeResponseModel
    {
        [JsonPropertyName("was_on")]
        public bool WasOn { get; set; }
    }
    public class ShellySwitchesConfigModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("in_mode")]
        public ShellySwitchesMode InMode { get; set; }

        [JsonPropertyName("initial_state")]
        public string InitialState { get; set; }

        [JsonPropertyName("auto_on")]
        public bool AutoOn { get; set; }

        [JsonPropertyName("auto_on_delay")]
        public decimal AutoOnDelay { get; set; }

        [JsonPropertyName("auto_off")]
        public bool AutoOff { get; set; }

        [JsonPropertyName("auto_off_delay")]
        public decimal AutoOffDelay { get; set; }

        [JsonPropertyName("input_id")]
        public int InputId { get; set; }

        [JsonPropertyName("power_limit")]
        public int PowerLimit { get; set; }

        [JsonPropertyName("voltage_limit")]
        public int VoltageLimit { get; set; }

        [JsonPropertyName("current_limit")]
        public double CurrentLimit { get; set; }
    }
    public enum ShellySwitchesMode
    {
        Momentary, Follow, Flip, Detached
    }
    public enum ShellySwitchesInitialState
    {
        Off, On, Restore_Last, Match_Input
    }

}
