namespace SpaceTraders.Core.Interfaces.Core;

/// <summary>
/// Interface representing models that contain a description.
/// </summary>
public interface IDescriptableModel
{
    /// <summary>
    /// Gets or sets the description of the object.
    /// </summary>
    string Description { get; set; }
}
