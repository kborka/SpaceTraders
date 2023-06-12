using System.Runtime.Serialization;

namespace SpaceTraders.Api.Enums;

public enum StartingFactionType
{
    [EnumMember(Value = "COSMIC")]
    Cosmic,
    [EnumMember(Value = "VOID")]
    Void,
    [EnumMember(Value = "GALACTIC")]
    Galactic,
    [EnumMember(Value = "QUANTUM")]
    Quantum,
    [EnumMember(Value = "DOMINION")]
    Dominion
}