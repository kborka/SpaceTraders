using SpaceTraders.Core.Interfaces.Data;

namespace SpaceTraders.Api.Models.Data;

public class ErrorData : IErrorData
{
    public IEnumerable<string> Symbol { get; set; } = null!;
}
