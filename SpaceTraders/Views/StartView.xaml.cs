using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using SpaceTraders.ViewModels.Game;

namespace SpaceTraders.Views;

public partial class StartView
{
    public StartView()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        var url = ((GameLinkViewModel)(((Button)sender).DataContext)).Url;
        var uri = new Uri(url);
        var processStartInfo = new ProcessStartInfo(uri.AbsoluteUri)
        {
            UseShellExecute = true
        };

        Process.Start(processStartInfo);

        e.Handled = true;
    }
}