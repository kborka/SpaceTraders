using System.Diagnostics;
using System.Windows.Navigation;

namespace SpaceTraders.Views;

public partial class StartView
{
    public StartView()
    {
        InitializeComponent();
    }

    private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
        e.Handled = true;
    }
}