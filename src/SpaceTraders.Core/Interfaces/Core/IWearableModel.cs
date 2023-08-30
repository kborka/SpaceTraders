namespace SpaceTraders.Core.Interfaces.Core;

/// <summary>
/// An interface representing an object that has a wearable condition.
/// </summary>
public interface IWearableModel
{
    /// <summary>
    /// Gets or sets the condition of the object.
    /// </summary>
    /// <remarks>
    /// Condition is a range from 0 to 100 where 0 is completely worn out and 100 is brand new.
    /// </remarks>
    byte? Condition { get; set; }
}
