using System.Runtime.Serialization;

namespace SpaceTraders.Core.Enums;

public enum DepositSize
{
    [EnumMember(Value = "SMALL")] Small,
    [EnumMember(Value = "MODERATE")] Moderate,
    [EnumMember(Value = "LARGE")] Large
}
