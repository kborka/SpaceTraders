using System;
using System.Globalization;
using System.Reflection;
using System.Windows;
using DryIoc.Microsoft.DependencyInjection.Extension;
using Prism.DryIoc;
using Prism.Ioc;
using Microsoft.Extensions.DependencyInjection;
using Prism.Mvvm;
using SpaceTraders.Api.Services;
using SpaceTraders.Api.Services.Interfaces;
using SpaceTraders.Views;

namespace SpaceTraders
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.GetContainer().RegisterServices(services =>
            {
                services.AddHttpClient<IAgentService, AgentService>();
                services.AddHttpClient<IFactionService, FactionService>();
                services.AddHttpClient<IGameService, GameService>();
            });
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(viewType =>
            {
                var viewName = viewType.FullName;
                viewName = viewName?.Replace(".Views.", ".ViewModels.");
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                var suffix = viewName?.EndsWith("View") ?? false ? "Model" : "ViewModel";
                var viewModelName = String.Format(CultureInfo.InvariantCulture, "{0}{1}", viewName, suffix);

                var assembly = viewType.GetTypeInfo().Assembly;
                var type = assembly.GetType(viewModelName, true);

                return type;
            });
        }
    }
}