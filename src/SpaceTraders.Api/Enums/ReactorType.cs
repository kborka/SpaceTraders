using System.Runtime.Serialization;

namespace SpaceTraders.Api.Enums;

public enum ReactorType
{
    [EnumMember(Value = "REACTOR_SOLAR_I")]
    Solar1,

    [EnumMember(Value = "REACTOR_FUSION_I")]
    Fusion1,

    [EnumMember(Value = "REACTOR_FISSION_I")]
    Fission1,

    [EnumMember(Value = "REACTOR_CHEMICAL_I")]
    Chemical1,

    [EnumMember(Value = "REACTOR_ANTIMATTER_I")]
    Antimatter1
}