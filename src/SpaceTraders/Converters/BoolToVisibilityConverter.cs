using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SpaceTraders.Converters;

/// <summary>
/// A value converter between <see cref="bool"/> and <see cref="Visibility"/>. Allows for tweaking of the false
/// visibility value via <see cref="HideInsteadOfCollapse"/>.
/// </summary>
[ValueConversion(typeof(bool), typeof(Visibility))]
public class BoolToVisibilityConverter : IValueConverter
{
    /// <summary>
    /// Gets or sets whether the default false value should be <see cref="Visibility.Hidden"/> instead
    /// of <see cref="Visibility.Collapsed"/>.
    /// </summary>
    public bool HideInsteadOfCollapse { get; set; }

    /// <inheritdoc/>
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not bool boolValue)
        {
            return null;
        }

        return boolValue
                   ? Visibility.Visible
                   : HideInsteadOfCollapse
                       ? Visibility.Hidden
                       : Visibility.Collapsed;
    }

    /// <inheritdoc/>
    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        value switch
        {
            Visibility.Visible => true,
            Visibility.Collapsed => !HideInsteadOfCollapse,
            Visibility.Hidden => HideInsteadOfCollapse,
            _ => null
        };
}
