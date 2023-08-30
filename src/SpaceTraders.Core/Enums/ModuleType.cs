using System.Runtime.Serialization;

namespace SpaceTraders.Core.Enums;

/// <summary>
/// Represents the types of modules a ship can have.
/// </summary>
public enum ModuleType
{
    [EnumMember(Value = "MODULE_MINERAL_PROCESSOR_I")]
    MineralProcessor1,

    [EnumMember(Value = "MODULE_CARGO_HOLD_I")]
    CargoHold1,

    [EnumMember(Value = "MODULE_CREW_QUARTERS_I")]
    CrewQuarters1,

    [EnumMember(Value = "MODULE_ENVOY_QUARTERS_I")]
    EnvoyQuarters1,

    [EnumMember(Value = "MODULE_PASSENGER_CABIN_I")]
    PassengerCabin1,

    [EnumMember(Value = "MODULE_MICRO_REFINERY_I")]
    MicroRefinery1,

    [EnumMember(Value = "MODULE_ORE_REFINERY_I")]
    OreRefinery1,

    [EnumMember(Value = "MODULE_FUEL_REFINERY_I")]
    FuelRefinery1,

    [EnumMember(Value = "MODULE_SCIENCE_LAB_I")]
    ScienceLab1,

    [EnumMember(Value = "MODULE_JUMP_DRIVE_I")]
    JumpDrive1,

    [EnumMember(Value = "MODULE_JUMP_DRIVE_II")]
    JumpDrive2,

    [EnumMember(Value = "MODULE_JUMP_DRIVE_III")]
    JumpDrive3,

    [EnumMember(Value = "MODULE_WARP_DRIVE_I")]
    WarpDrive1,

    [EnumMember(Value = "MODULE_WARP_DRIVE_II")]
    WarpDrive2,

    [EnumMember(Value = "MODULE_WARP_DRIVE_III")]
    WarpDrive3,

    [EnumMember(Value = "MODULE_SHIELD_GENERATOR_I")]
    ShieldGenerator1,

    [EnumMember(Value = "MODULE_SHIELD_GENERATOR_II")]
    ShieldGenerator2
}
