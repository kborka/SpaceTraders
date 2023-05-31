namespace SpaceTraders.Api.Models.Interfaces.Data;

public interface IErrorData
{
    IEnumerable<string> Symbol { get; set; }
}