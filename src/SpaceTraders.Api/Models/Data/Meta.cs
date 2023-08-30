using SpaceTraders.Core.Interfaces.Data;

namespace SpaceTraders.Api.Models.Data;

public class Meta : IMeta
{
    /// <inheritdoc />
    public uint Total { get; set; }

    /// <inheritdoc />
    public uint Page { get; set; }

    /// <inheritdoc />
    public uint Limit { get; set; }
}
