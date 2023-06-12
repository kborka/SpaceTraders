using SpaceTraders.Api.Models.Interfaces;

namespace SpaceTraders.Api.Models;

public class CoordinateModelBase : ICoordinateModel
{
    public int X { get; set; }

    public int Y { get; set; }
}