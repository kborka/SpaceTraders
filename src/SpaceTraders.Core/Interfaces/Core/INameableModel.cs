namespace SpaceTraders.Core.Interfaces.Core;

/// <summary>
/// Interface representing models that contain names.
/// </summary>
public interface INameableModel
{
    /// <summary>
    /// Gets or sets the name of this object.
    /// </summary>
    string Name { get; set; }
}
