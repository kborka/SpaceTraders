using System.Windows;
using Prism.DryIoc;
using Prism.Ioc;
using SpaceTraders.Settings.Interfaces;

namespace SpaceTraders.Utilities;

public static class AppNexus
{
    private static IUserSettings? _userSettings;
    public static IUserSettings UserSettings => _userSettings ??= SpaceTraders.Settings.UserSettings.LoadUserSettings();

    public static PrismApplication PrismApplication => (PrismApplication)Application.Current;

    public static IContainerProvider ApplicationContainer => PrismApplication.Container;
}