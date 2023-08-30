using System.Runtime.Serialization;

namespace SpaceTraders.Core.Enums;

/// <summary>
/// Represents the different type of ship frames.
/// </summary>
public enum FrameType
{
    [EnumMember(Value = "FRAME_PROBE")] Probe,
    [EnumMember(Value = "FRAME_DRONE")] Drone,

    [EnumMember(Value = "FRAME_INTERCEPTOR")]
    Interceptor,
    [EnumMember(Value = "FRAME_RACER")] Racer,
    [EnumMember(Value = "FRAME_FIGHTER")] Fighter,
    [EnumMember(Value = "FRAME_FRIGATE")] Frigate,
    [EnumMember(Value = "FRAME_SHUTTLE")] Shuttle,
    [EnumMember(Value = "FRAME_EXPLORER")] Explorer,
    [EnumMember(Value = "FRAME_MINER")] Miner,

    [EnumMember(Value = "FRAME_LIGHT_FREIGHTER")]
    LightFreighter,

    [EnumMember(Value = "FRAME_HEAVY_FREIGHTER")]
    HeavyFreighter,

    [EnumMember(Value = "FRAME_TRANSPORT")]
    Transport,

    [EnumMember(Value = "FRAME_DESTROYER")]
    Destroyer,
    [EnumMember(Value = "FRAME_CRUISER")] Cruiser,
    [EnumMember(Value = "FRAME_CARRIER")] Carrier
}
