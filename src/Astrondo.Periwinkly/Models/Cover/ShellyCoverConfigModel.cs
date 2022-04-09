using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Astrondo.Periwinkly.Models.Cover
{
    public class ShellyCoverConfigModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("motor")]
        public ShellyCoverConfigMotorModel Motor { get; set; }

        [JsonPropertyName("maxtime_open")]
        public double MaxtimeOpen { get; set; }

        [JsonPropertyName("maxtime_close")]
        public double MaxtimeClose { get; set; }

        [JsonPropertyName("initial_state")]
        public string InitialState { get; set; }

        [JsonPropertyName("invert_directions")]
        public bool InvertDirections { get; set; }

        [JsonPropertyName("in_mode")]
        public string InMode { get; set; }

        [JsonPropertyName("swap_inputs")]
        public bool SwapInputs { get; set; }

        [JsonPropertyName("safety_switch")]
        public ShellyCoverConfigSafetySwitchModel SafetySwitch { get; set; }

        [JsonPropertyName("power_limit")]
        public int PowerLimit { get; set; }

        [JsonPropertyName("voltage_limit")]
        public int VoltageLimit { get; set; }

        [JsonPropertyName("current_limit")]
        public double CurrentLimit { get; set; }

        [JsonPropertyName("obstruction_detection")]
        public ShellyCoverConfigObstructionDetectionModel ObstructionDetection { get; set; }
    }
    public class ShellyCoverConfigMotorModel
    {
        [JsonPropertyName("idle_power_thr")]
        public double IdlePowerThr { get; set; }
    }

    public class ShellyCoverConfigSafetySwitchModel
    {
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("allowed_move")]
        public string AllowedMove { get; set; }
    }

    public class ShellyCoverConfigObstructionDetectionModel
    {
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("power_thr")]
        public int PowerThr { get; set; }

        [JsonPropertyName("holdoff")]
        public double Holdoff { get; set; }
    }
}
