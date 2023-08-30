using System.Runtime.Serialization;

namespace SpaceTraders.Core.Enums;

public enum TradeSymbol
{
    [EnumMember(Value = "PRECIOUS_STONES")]
    PreciousStones,
    [EnumMember(Value = "QUARTZ_SAND")] QuartzSand,

    [EnumMember(Value = "SILICON_CRYSTALS")]
    SiliconCrystals,
    [EnumMember(Value = "AMMONIA_ICE")] AmmoniaIce,

    [EnumMember(Value = "LIQUID_HYDROGEN")]
    LiquidHydrogen,

    [EnumMember(Value = "LIQUID_NITROGEN")]
    LiquidNitrogen,
    [EnumMember(Value = "ICE_WATER")] IceWater,
    [EnumMember(Value = "EXOTIC_MATTER")] ExoticMatter,

    [EnumMember(Value = "ADVANCED_CIRCUITRY")]
    AdvancedCircuitry,

    [EnumMember(Value = "GRAVITON_EMITTERS")]
    GravitonEmitters,
    [EnumMember(Value = "IRON")] Iron,
    [EnumMember(Value = "IRON_ORE")] IronOre,
    [EnumMember(Value = "COPPER")] Copper,
    [EnumMember(Value = "COPPER_ORE")] CopperOre,
    [EnumMember(Value = "ALUMINUM")] Aluminum,
    [EnumMember(Value = "ALUMINUM_ORE")] AluminumOre,
    [EnumMember(Value = "SILVER")] Silver,
    [EnumMember(Value = "Silver_ORE")] SilverOre,
    [EnumMember(Value = "GOLD")] Gold,
    [EnumMember(Value = "GOLD_ORE")] GoldOre,
    [EnumMember(Value = "PLATINUM")] Platinum,
    [EnumMember(Value = "PLATINUM_ORE")] PlatinumOre,
    [EnumMember(Value = "DIAMONDS")] Diamonds,
    [EnumMember(Value = "URANITE")] Uranite,
    [EnumMember(Value = "URANTIE_ORE")] UraniteOre,
    [EnumMember(Value = "MERITIUM")] Meritium,
    [EnumMember(Value = "MERITIUM_ORE")] MeritiumOre,
    [EnumMember(Value = "HYDROCARBON")] Hydrocarbon,
    [EnumMember(Value = "ANTIMATTER")] Antimatter,
    [EnumMember(Value = "FERTILIZERS")] Fertilizers,
    [EnumMember(Value = "FABRICS")] Fabrics,
    [EnumMember(Value = "FOOD")] Food,
    [EnumMember(Value = "JEWELRY")] Jewelry,
    [EnumMember(Value = "MACHINERY")] Machinery,
    [EnumMember(Value = "FIREARMS")] Firearms,
    [EnumMember(Value = "ASSAULT_RIFLES")] AssaultRifles,

    [EnumMember(Value = "MILITARY_EQUIPMENT")]
    MilitaryEquipment,
    [EnumMember(Value = "EXPLOSIVES")] Explosives,

    [EnumMember(Value = "LAB_INSTRUMENTS")]
    LabInstruments,
    [EnumMember(Value = "AMMUNITION")] Ammunition,
    [EnumMember(Value = "ELECTRONICS")] Electronics,
    [EnumMember(Value = "SHIP_PLATING")] ShipPlating,
    [EnumMember(Value = "EQUIPMENT")] Equipment,
    [EnumMember(Value = "FUEL")] Fuel,
    [EnumMember(Value = "MEDICINE")] Medicine,
    [EnumMember(Value = "DRUGS")] Drugs,
    [EnumMember(Value = "CLOTHING")] Clothing,

    [EnumMember(Value = "MICROPROCESSORS")]
    Microprocessors,
    [EnumMember(Value = "PLASTICS")] Plastics,

    [EnumMember(Value = "POLYNUCLEOTIDES")]
    Polynucleotides,
    [EnumMember(Value = "BIOCOMPOSITES")] Biocomposites,
    [EnumMember(Value = "NANOBOTS")] Nanobots,
    [EnumMember(Value = "AI_MAINFRAMES")] AiMainframes,
    [EnumMember(Value = "QUANTUM_DRIVES")] QuantumDrives,
    [EnumMember(Value = "ROBOTIC_DRONES")] RoboticDrones,
    [EnumMember(Value = "CYBER_IMPLANTS")] CyberImplants,

    [EnumMember(Value = "GENE_THERAPEUTICS")]
    GeneTherapeutics,
    [EnumMember(Value = "NEURAL_CHIPS")] NeuralChips,

    [EnumMember(Value = "MOOD_REGULATORS")]
    MoodRegulators,
    [EnumMember(Value = "VIRAL_AGENTS")] ViralAgents,

    [EnumMember(Value = "MICRO_FUSION_GENERATORS")]
    MicroFusionGenerators,
    [EnumMember(Value = "SUPERGRAINS")] SuperGrains,
    [EnumMember(Value = "LASER_RIFLES")] LaserRifles,
    [EnumMember(Value = "HOLOGRAPHICS")] Holographics,
    [EnumMember(Value = "SHIP_SALVAGE")] ShipSalvage,
    [EnumMember(Value = "RELIC_TECH")] RelicTech,

    [EnumMember(Value = "NOVEL_LIFEFORMS")]
    NovelLifeforms,

    [EnumMember(Value = "BOTANICAL_SPECIMENS")]
    BotanicalSpecimens,

    [EnumMember(Value = "CULTURAL_ARTEFACTS")]
    CulturalArtefacts,

    [EnumMember(Value = "REACTOR_SOLAR_I")]
    ReactorSolar1,

    [EnumMember(Value = "REACTOR_FUSION_I")]
    ReactorFusion1,

    [EnumMember(Value = "REACTOR_FISSION_I")]
    ReactorFission1,

    [EnumMember(Value = "REACTOR_CHEMICAL_I")]
    ReactorChemical1,

    [EnumMember(Value = "REACTOR_ANTIMATTER_I")]
    ReactorAntimatter1,

    [EnumMember(Value = "ENGINE_IMPULSE_DRIVE_I")]
    EngineImpulseDrive1,

    [EnumMember(Value = "ENGINE_ION_DRIVE_I")]
    EngineIonDrive1,

    [EnumMember(Value = "ENGINE_ION_DRIVE_II")]
    EngineIonDrive2,

    [EnumMember(Value = "ENGINE_HYPER_DRIVE_I")]
    EngineHyperDrive1,

    [EnumMember(Value = "MODULE_MINERAL_PROCESSOR_I")]
    ModuleMineralProcessor1,

    [EnumMember(Value = "MODULE_CARGO_HOLD_I")]
    ModuleCargoHold1,

    [EnumMember(Value = "MODULE_CREW_QUARTERS_I")]
    ModuleCrewQuarters1,

    [EnumMember(Value = "MODULE_ENVOY_QUARTERS_I")]
    ModuleEnvoyQuarters1,

    [EnumMember(Value = "MODULE_PASSENGER_CABIN_I")]
    ModulePassengerCabin1,

    [EnumMember(Value = "MODULE_MICRO_REFINERY_I")]
    ModuleMicroRefinery1,

    [EnumMember(Value = "MODULE_ORE_REFINERY_I")]
    ModuleOreRefinery1,

    [EnumMember(Value = "MODULE_FUEL_REFINERY_I")]
    ModuleFuelRefinery1,

    [EnumMember(Value = "MODULE_SCIENCE_LAB_I")]
    ModuleScienceLab1,

    [EnumMember(Value = "MODULE_JUMP_DRIVE_I")]
    ModuleJumpDrive1,

    [EnumMember(Value = "MODULE_JUMP_DRIVE_II")]
    ModuleJumpDrive2,

    [EnumMember(Value = "MODULE_JUMP_DRIVE_III")]
    ModuleJumpDrive3,

    [EnumMember(Value = "MODULE_WARP_DRIVE_I")]
    ModuleWarpDrive1,

    [EnumMember(Value = "MODULE_WARP_DRIVE_II")]
    ModuleWarpDrive2,

    [EnumMember(Value = "MODULE_WARP_DRIVE_III")]
    ModuleWarpDrive3,

    [EnumMember(Value = "MODULE_SHIELD_GENERATOR_I")]
    ModuleShieldGenerator1,

    [EnumMember(Value = "MODULE_SHIELD_GENERATOR_II")]
    ModuleShieldGenerator2,

    [EnumMember(Value = "MOUNT_GAS_SIPHON_I")]
    MountGasSiphon1,

    [EnumMember(Value = "MOUNT_GAS_SIPHON_II")]
    MountGasSiphon2,

    [EnumMember(Value = "MOUNT_GAS_SIPHON_II")]
    MountGasSiphon3,

    [EnumMember(Value = "MOUNT_SURVEYOR_I")]
    MountSurveyor1,

    [EnumMember(Value = "MOUNT_SURVEYOR_II")]
    MountSurveyor2,

    [EnumMember(Value = "MOUNT_SURVEYOR_III")]
    MountSurveyor3,

    [EnumMember(Value = "MOUNT_SENSOR_ARRAY_I")]
    MountSensorArray1,

    [EnumMember(Value = "MOUNT_SENSOR_ARRAY_II")]
    MountSensorArray2,

    [EnumMember(Value = "MOUNT_SENSOR_ARRAY_III")]
    MountSensorArray3,

    [EnumMember(Value = "MOUNT_MINING_LASER_I")]
    MountMiningLaser1,

    [EnumMember(Value = "MOUNT_MINING_LASER_II")]
    MountMiningLaser2,

    [EnumMember(Value = "MOUNT_MINING_LASER_III")]
    MountMiningLaser3,

    [EnumMember(Value = "MOUNT_LASER_CANNON_I")]
    MountLaserCannon1,

    [EnumMember(Value = "MOUNT_MISSILE_LAUNCHER_I")]
    MountMissileLauncher1,
    [EnumMember(Value = "MOUNT_TURRET_I")] MountTurret1
}
