using System.Runtime.Serialization;

namespace SpaceTraders.Api.Enums;

/// <summary>
///     Represents the different types of ship engines.
/// </summary>
public enum EngineType
{
    [EnumMember(Value = "ENGINE_IMPULSE_DRIVE_I")]
    ImpulseDrive1,

    [EnumMember(Value = "ENGINE_ION_DRIVE_I")]
    IonDrive1,

    [EnumMember(Value = "ENGINE_ION_DRIVE_II")]
    IonDrive2,

    [EnumMember(Value = "ENGINE_HYPER_DRIVE_I")]
    HyperDrive1
}