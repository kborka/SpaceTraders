using System.Runtime.Serialization;

namespace SpaceTraders.Api.Enums;

/// <summary>
///     Defines the different deposit types.
/// </summary>
public enum DepositTypes
{
    [EnumMember(Value = "QUARTZ_SAND")] QuartzSand,

    [EnumMember(Value = "SILICON_CRYSTALS")]
    SiliconCrystals,
    [EnumMember(Value = "ICE_WATER")] IceWater,
    [EnumMember(Value = "AMMONIA_ICE")] AmmoniaIce,
    [EnumMember(Value = "IRON_ORE")] IronOre,
    [EnumMember(Value = "COPPER_ORE")] CopperOre,
    [EnumMember(Value = "SILVER_ORE")] SilverOre,
    [EnumMember(Value = "ALUMINUM_ORE")] AluminumOre,
    [EnumMember(Value = "GOLD_ORE")] GoldOre,
    [EnumMember(Value = "PLATINUM_ORE")] PlatinumOre,
    [EnumMember(Value = "DIAMONDS")] Diamonds,
    [EnumMember(Value = "URANITE_ORE")] UraniteOre,
    [EnumMember(Value = "MERITIUM_ORE")] MeritiumOre
}