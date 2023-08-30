using System.Runtime.Serialization;

namespace SpaceTraders.Core.Enums;

public enum CrewRotationType
{
    [EnumMember(Value = "STRICT")] Strict,
    [EnumMember(Value = "RELAXED")] Relaxed
}
