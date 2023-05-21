using System.Runtime.Serialization;

namespace SpaceTraders.Api.Enums;

public enum CrewRotationType
{
    [EnumMember(Value = "STRICT")] Strict,
    [EnumMember(Value = "RELAXED")] Relaxed
}