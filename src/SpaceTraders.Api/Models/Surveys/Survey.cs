using SpaceTraders.Api.Models.Core;
using SpaceTraders.Core.Enums;
using SpaceTraders.Core.Interfaces.Surveying;

namespace SpaceTraders.Api.Models.Surveys;

/// <summary>
/// A resource survey of a waypoint, detailing a specific extraction location and the types of resources that can be
/// found there.
/// </summary>
public class Survey : SymbolModelBase, ISurvey
{
    /// <inheritdoc />
    public string Signature { get; set; } = null!;

    /// <inheritdoc />
    public IEnumerable<ISurveyDeposit> Deposits { get; set; } = null!;

    /// <inheritdoc />
    public DateTime Expiration { get; set; }

    /// <inheritdoc />
    public DepositSize Size { get; set; }
}
