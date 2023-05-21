namespace SpaceTraders.Api.Models;

public class Error
{
    public string Message { get; set; } = null!;

    public int Code { get; set; }
}