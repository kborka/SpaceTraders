using System.Runtime.Serialization;

namespace SpaceTraders.Core.Enums;

public enum NavStatus
{
    [EnumMember(Value = "IN_TRANSIT")] InTransit,
    [EnumMember(Value = "IN_ORBIT")] InOrbit,
    [EnumMember(Value = "DOCKED")] Docked
}
