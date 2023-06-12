namespace SpaceTraders.Api.Models.Interfaces.Data;

public interface IMeta
{
    int Total { get; set; }

    int Page { get; set; }

    int Limit { get; set; }
}