using SpaceTraders.Api.Enums;

namespace SpaceTraders.Api.Models.Interfaces.Surveying;

/// <summary>
///     A resource survey of a waypoint, detailing a specific extraction location and the types of resources that can be
///     found there.
/// </summary>
public interface ISurvey : ISymbolModel
{
    /// <summary>
    ///     A unique signature for the location of this survey.
    ///     This signature is verified when attempting an extraction using this survey.
    /// </summary>
    string Signature { get; set; }

    /// <summary>
    ///     A list of deposits that can be found at this location.
    /// </summary>
    IEnumerable<ISurveyDeposit> Deposits { get; set; }

    /// <summary>
    ///     The date and time when the survey expires.
    ///     After this date and time, the survey will no longer be available for extraction.
    /// </summary>
    DateTime Expiration { get; set; }

    /// <summary>
    ///     The size of the deposit.
    ///     This value indicates how much can be extracted from the survey before it is exhausted.
    /// </summary>
    DepositSize Size { get; set; }
}