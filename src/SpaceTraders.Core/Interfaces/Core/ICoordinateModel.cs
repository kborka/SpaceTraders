namespace SpaceTraders.Core.Interfaces.Core;

/// <summary>
/// An interface representing a model that contains XY coordinates.
/// </summary>
public interface ICoordinateModel
{
    /// <summary>
    /// Gets or sets the position in the universe on the X axis.
    /// </summary>
    int X { get; set; }

    /// <summary>
    /// Gets or sets the position in the universe on the Y axis.
    /// </summary>
    int Y { get; set; }
}
