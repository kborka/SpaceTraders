using System.Runtime.Serialization;

namespace SpaceTraders.Core.Enums;

/// <summary>
/// Defines the different ship mount types.
/// </summary>
public enum MountType
{
    [EnumMember(Value = "MOUNT_GAS_SIPHON_I")]
    GasSiphon1,

    [EnumMember(Value = "MOUNT_GAS_SIPHON_II")]
    GasSiphon2,

    [EnumMember(Value = "MOUNT_GAS_SIPHON_III")]
    GasSiphon3,

    [EnumMember(Value = "MOUNT_SURVEYOR_I")]
    Surveyor1,

    [EnumMember(Value = "MOUNT_SURVEYOR_II")]
    Surveyor2,

    [EnumMember(Value = "MOUNT_SURVEYOR_III")]
    Surveyor3,

    [EnumMember(Value = "MOUNT_SENSOR_ARRAY_I")]
    SensorArray1,

    [EnumMember(Value = "MOUNT_SENSOR_ARRAY_II")]
    SensorArray2,

    [EnumMember(Value = "MOUNT_SENSOR_ARRAY_III")]
    SensorArray3,

    [EnumMember(Value = "MOUNT_MINING_LASER_I")]
    MiningLaser1,

    [EnumMember(Value = "MOUNT_MINING_LASER_II")]
    MiningLaser2,

    [EnumMember(Value = "MOUNT_MINING_LASER_III")]
    MiningLaser3,

    [EnumMember(Value = "MOUNT_LASER_CANNON_I")]
    LaserCannon1,

    [EnumMember(Value = "MOUNT_MISSILE_LAUNCHER_I")]
    MissileLauncher1,
    [EnumMember(Value = "MOUNT_TURRET_I")] Turret1
}
