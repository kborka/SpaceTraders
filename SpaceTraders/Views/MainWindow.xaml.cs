using System;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace SpaceTraders.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            IntPtr hwnd = new WindowInteropHelper(this).EnsureHandle();
            UserImmersiveDarkMode(hwnd, true);
        }

        [DllImport("dwmapi.dll", PreserveSig = true)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USER_IMERSIVE_DARK_MODE = 20;

        private static bool UserImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (!IsWindows10OrGreater(17763))
            {
                return false;
            }

            var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
            if (IsWindows10OrGreater(18985))
            {
                attribute = DWMWA_USER_IMERSIVE_DARK_MODE;
            }

            int useImmersiveDarkMode = enabled ? 1 : 0;
            return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
        }

        private static bool IsWindows10OrGreater(int build = -1) => Environment.OSVersion.Version.Major >= 10 &&
                                                                    Environment.OSVersion.Version.Build >= build;
    }
}