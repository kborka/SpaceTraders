using System.Runtime.Serialization;

namespace SpaceTraders.Core.Enums;

/// <summary>
/// Describes a trait of a waypoint.
/// </summary>
public enum WaypointTraitType
{
    [EnumMember(Value = "UNCHARTED")] Uncharted,
    [EnumMember(Value = "MARKETPLACE")] Marketplace,
    [EnumMember(Value = "SHIPYARD")] Shipyard,
    [EnumMember(Value = "OUTPOST")] Outpost,

    [EnumMember(Value = "SCATTERED_SETTLEMENTS")]
    ScatteredSettlements,

    [EnumMember(Value = "SPRAWLING_CITIES")]
    SprawlingCities,

    [EnumMember(Value = "MEGA_STRUCTURES")]
    MegaStructures,
    [EnumMember(Value = "OVERCROWDED")] Overcrowded,
    [EnumMember(Value = "HIGH_TECH")] HighTech,
    [EnumMember(Value = "CORRUPT")] Corrupt,
    [EnumMember(Value = "BUREAUCRATIC")] Bureaucratic,
    [EnumMember(Value = "TRADING_HUB")] TradingHub,
    [EnumMember(Value = "INDUSTRIAL")] Industrial,
    [EnumMember(Value = "BLACK_MARKET")] BlackMarket,

    [EnumMember(Value = "RESEARCH_FACILITY")]
    ResearchFacility,
    [EnumMember(Value = "MILITARY_BASE")] MilitaryBase,

    [EnumMember(Value = "SURVEILLANCE_OUTPOST")]
    SurveillanceOutpost,

    [EnumMember(Value = "EXPLORATION_OUTPOST")]
    ExplorationOutpost,

    [EnumMember(Value = "MINERAL_DEPOSITS")]
    MineralDeposits,

    [EnumMember(Value = "COMMON_METAL_DEPOSITS")]
    CommonMetalDeposits,

    [EnumMember(Value = "PRECIOUS_METAL_DEPOSITS")]
    PreciousMetalDeposits,

    [EnumMember(Value = "RARE_METAL_DEPOSITS")]
    RareMetalDeposits,
    [EnumMember(Value = "METHANE_POOLS")] MethanePools,
    [EnumMember(Value = "ICE_CRYSTALS")] IceCrystals,

    [EnumMember(Value = "EXPLOSIVE_GASES")]
    ExplosiveGases,

    [EnumMember(Value = "STRONG_MAGNETOSPHERE")]
    StrongMagnetosphere,

    [EnumMember(Value = "VIBRANT_AURORAS")]
    VibrantAuroras,
    [EnumMember(Value = "SALT_FLATS")] SaltFlats,
    [EnumMember(Value = "CANYONS")] Canyons,

    [EnumMember(Value = "PERPETUAL_DAYLIGHT")]
    PerpetualDaylight,

    [EnumMember(Value = "PERPETUAL_OVERCAST")]
    PerpetualOvercast,
    [EnumMember(Value = "DRY_SEABEDS")] DrySeabeds,
    [EnumMember(Value = "MAGMA_SEAS")] MagmaSeas,
    [EnumMember(Value = "SUPERVOLCANOES")] SuperVolcanoes,
    [EnumMember(Value = "ASH_CLOUDS")] AshClouds,
    [EnumMember(Value = "VAST_RUINS")] VastRuins,
    [EnumMember(Value = "MUTATED_FLORA")] MutatedFlora,
    [EnumMember(Value = "TERRAFORMED")] Terraformed,

    [EnumMember(Value = "EXTREME_TEMPERATURES")]
    ExtremeTemperatures,

    [EnumMember(Value = "EXTREME_PRESSURE")]
    ExtremePressure,
    [EnumMember(Value = "DIVERSE_LIFE")] DiverseLife,
    [EnumMember(Value = "SCARCE_LIFE")] ScarceLife,
    [EnumMember(Value = "FOSSILS")] Fossils,
    [EnumMember(Value = "WEAK_GRAVITY")] WeakGravity,
    [EnumMember(Value = "STRONG_GRAVITY")] StrongGravity,

    [EnumMember(Value = "CRUSHING_GRAVITY")]
    CrushingGravity,

    [EnumMember(Value = "TOXIC_ATMOSPHERE")]
    ToxicAtmosphere,

    [EnumMember(Value = "CORROSIVE_ATMOSPHERE")]
    CorrosiveAtmosphere,

    [EnumMember(Value = "BREATHABLE_ATMOSPHERE")]
    BreathableAtmosphere,
    [EnumMember(Value = "JOVIAN")] Jovian,
    [EnumMember(Value = "ROCKY")] Rocky,
    [EnumMember(Value = "VOLCANIC")] Volcanic,
    [EnumMember(Value = "FROZEN")] Frozen,
    [EnumMember(Value = "SWAMP")] Swamp,
    [EnumMember(Value = "BARREN")] Barren,
    [EnumMember(Value = "Temperate")] Temperate,
    [EnumMember(Value = "Jungle")] Jungle,
    [EnumMember(Value = "OCEAN")] Ocean,
    [EnumMember(Value = "STRIPPED")] Stripped
}
