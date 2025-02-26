using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Font = Microsoft.Maui.Font;

namespace TouchBehaviorIos
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            var currentTheme = Application.Current!.UserAppTheme;
        }
    }
}
