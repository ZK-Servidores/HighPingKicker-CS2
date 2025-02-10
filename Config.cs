using CounterStrikeSharp.API.Core;
using System.Text.Json.Serialization;

namespace HighPingKicker;

public class BaseConfigs : BasePluginConfig
{ 
    [JsonPropertyName("max_ping")] public int MaxPing { get; set; } = 150;
    [JsonPropertyName("max_warnings")] public int MaxWarnings { get; set; } = 5;
    [JsonPropertyName("check_interval")] public float CheckInterval { get; set; } = 20;
    [JsonPropertyName("show_warnings")] public bool ShowWarnings { get; set; } = true; 
    [JsonPropertyName("show_public_kick_message")] public bool ShowPublicKickMessage { get; set; } = true; 
    [JsonPropertyName("warning_message")] public string WarningMessage { get; set; } = "You will be kicked for excessive ping. You have {WARN} out of {MAXWARN} warnings.";
    [JsonPropertyName("kick_message")] public string KickMessage { get; set; } = "{NAME} has been kicked due to excessive ping.";
    [JsonPropertyName("grace_period_seconds")] public float GracePeriod { get; set; } = 90;
    [JsonPropertyName("EnableDebug")] public bool EnableDebug { get; set; } = false;
}