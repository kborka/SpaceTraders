namespace SpaceTraders.Core.Interfaces.Data;

/// <summary>
/// An interface representing meta details for pagination of data.
/// </summary>
public interface IMeta
{
    /// <summary>
    /// Gets or sets the total amount of items that exist.
    /// </summary>
    uint Total { get; set; }

    /// <summary>
    /// Gets or sets the amount of items offset from the first item.
    /// </summary>
    /// <remarks>
    /// Each page holds an amount of items equal to the value in <see cref="Limit"/>.
    /// </remarks>
    uint Page { get; set; }

    /// <summary>
    /// Gets or sets the amount of items in each page. Limits how many items can be fetched at once.
    /// </summary>
    /// <remarks>
    /// Minimum value: 1<br/>
    /// Maximum value: 20<br/>
    /// Default value: 10<br/>
    /// </remarks>
    uint Limit { get; set; }
}
