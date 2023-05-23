using SpaceTraders.Api.Models.Interfaces.Data;

namespace SpaceTraders.Api.Models.Data;

public class Meta : IMeta
{
    public int Total { get; set; }

    public int Page { get; set; }

    public int Limit { get; set; }
}