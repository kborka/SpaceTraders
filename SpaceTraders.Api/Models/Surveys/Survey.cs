using SpaceTraders.Api.Enums;
using SpaceTraders.Api.Models.Interfaces.Surveying;

namespace SpaceTraders.Api.Models.Surveys;

/// <summary>
///     A resource survey of a waypoint, detailing a specific extraction location and the types of resources that can be
///     found there.
/// </summary>
public class Survey : SymbolModelBase, ISurvey
{
    /// <summary>
    ///     A unique signature for the location of this survey.
    ///     This signature is verified when attempting an extraction using this survey.
    /// </summary>
    public string Signature { get; set; } = null!;

    /// <summary>
    ///     A list of deposits that can be found at this location.
    /// </summary>
    public IEnumerable<ISurveyDeposit> Deposits { get; set; } = null!;

    /// <summary>
    ///     The date and time when the survey expires.
    ///     After this date and time, the survey will no longer be available for extraction.
    /// </summary>
    public DateTime Expiration { get; set; }

    /// <summary>
    ///     The size of the deposit.
    ///     This value indicates how much can be extracted from the survey before it is exhausted.
    /// </summary>
    public DepositSize Size { get; set; }
}