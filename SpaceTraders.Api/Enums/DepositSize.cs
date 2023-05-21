using System.Runtime.Serialization;

namespace SpaceTraders.Api.Enums;

public enum DepositSize
{
    [EnumMember(Value = "SMALL")] Small,
    [EnumMember(Value = "MODERATE")] Moderate,
    [EnumMember(Value = "LARGE")] Large
}