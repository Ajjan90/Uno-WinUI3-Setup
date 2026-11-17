namespace WinuiUno.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

#if WINDOWS
        this.Loaded += (_, _) =>
        {
            var appWindow = App.CurrentWindow?.AppWindow;
            if (appWindow is null || AppTitleBar is null)
            {
                return;
            }

            var dragRect = new Windows.Graphics.RectInt32(
                0,
                0,
                (int)AppTitleBar.ActualWidth,
                (int)AppTitleBar.ActualHeight);

            appWindow.TitleBar.SetDragRectangles(new[] { dragRect });
        };
#endif

        NavViewMenu.SelectedItem = NavViewMenu.MenuItems[1];
    }

    private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        if (args.SelectedItemContainer is NavigationViewItem selectedItem)
        {
            switch (selectedItem.Content)
            {
                case "Audio":
                    ContentFrame.Navigate(typeof(Pages.Audio1));
                    break;
                case "Canvas":
                    ContentFrame.Navigate(typeof(Pages.CanPage));
                    break;
            }

            if (args.IsSettingsSelected)
            {
                ContentFrame.Navigate(typeof(Pages.SettingsPage));
            }
        }
    }
}
