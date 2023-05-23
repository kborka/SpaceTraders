using SpaceTraders.Api.Models.Interfaces.Data;

namespace SpaceTraders.Api.Models.Data;

public class Error : IError
{
    public string Message { get; set; } = null!;

    public int Code { get; set; }
}