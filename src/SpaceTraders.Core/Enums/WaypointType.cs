using System.Runtime.Serialization;

namespace SpaceTraders.Core.Enums;

/// <summary>
/// Describes the type of waypoint.
/// </summary>
public enum WaypointType
{
    [EnumMember(Value = "PLANET")] Planet,
    [EnumMember(Value = "GAS_GIANT")] GasGiant,
    [EnumMember(Value = "MOON")] Moon,
    [EnumMember(Value = "ORBITAL_STATION")] OrbitalStation,
    [EnumMember(Value = "JUMP_GATE")] JumpGate,
    [EnumMember(Value = "ASTEROID_FIELD")] AsteroidField,
    [EnumMember(Value = "NEBULA")] Nebula,
    [EnumMember(Value = "DEBRIS_FIELD")] DebrisField,
    [EnumMember(Value = "GRAVITY_WELL")] GravityWell
}
