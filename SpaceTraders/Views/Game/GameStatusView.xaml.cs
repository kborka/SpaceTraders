using System.Diagnostics;
using System.Windows.Navigation;

namespace SpaceTraders.Views.Game;

public partial class GameStatusView
{
    public GameStatusView()
    {
        InitializeComponent();
    }

    private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
        e.Handled = true;
    }
}