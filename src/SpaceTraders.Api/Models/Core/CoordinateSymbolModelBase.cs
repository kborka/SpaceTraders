using SpaceTraders.Core.Interfaces.Core;

namespace SpaceTraders.Api.Models.Core;

public class CoordinateSymbolModelBase : SymbolModelBase, ICoordinateModel
{
    /// <inheritdoc />
    public int X { get; set; }

    /// <inheritdoc />
    public int Y { get; set; }
}
