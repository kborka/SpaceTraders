using System.Runtime.Serialization;

namespace SpaceTraders.Core.Enums;

public enum ShipType
{
    [EnumMember(Value = "SHIP_PROBE")] Probe,

    [EnumMember(Value = "SHIP_MINING_DRONE")]
    MiningDrone,

    [EnumMember(Value = "SHIP_INTERCEPTOR")]
    Interceptor,

    [EnumMember(Value = "SHIP_LIGHT_HAULER")]
    LightHauler,

    [EnumMember(Value = "SHIP_COMMAND_FRIGATE")]
    CommandFrigate,
    [EnumMember(Value = "SHIP_EXPLORER")] Explorer,

    [EnumMember(Value = "SHIP_HEAVY_FREIGHTER")]
    HeavyFreighter,

    [EnumMember(Value = "SHIP_LIGHT_SHUTTLE")]
    LightShuttle,
    [EnumMember(Value = "SHIP_ORE_HOUND")] OreHound,

    [EnumMember(Value = "SHIP_REFINING_FREIGHTER")]
    RefiningFreighter
}
