using System.Runtime.Serialization;

namespace SpaceTraders.Api.Enums;

public enum NavFlightMode
{
    [EnumMember(Value = "DRIFT")] Drift,
    [EnumMember(Value = "STEALTH")] Stealth,
    [EnumMember(Value = "CRUISE")] Cruise,
    [EnumMember(Value = "BURN")] Burn
}