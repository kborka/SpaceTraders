using System.Windows;
using Prism.DryIoc;
using Prism.Ioc;

namespace SpaceTraders.Utilities;

public static class AppNexus
{
    public static PrismApplication PrismApplication => (PrismApplication)Application.Current;

    public static IContainerProvider ApplicationContainer => PrismApplication.Container;
}