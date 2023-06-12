using System.Runtime.Serialization;

namespace SpaceTraders.Api.Enums;

public enum SupplyType
{
    [EnumMember(Value = "SCARCE")] Scarce,
    [EnumMember(Value = "LIMITED")] Limited,
    [EnumMember(Value = "MODERATE")] Moderate,
    [EnumMember(Value = "ABUNDANT")] Abundant
}