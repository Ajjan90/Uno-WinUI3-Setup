namespace DevManUno.Presentation;

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
                0, 0, // Set the position of the Titlebar
                (int)AppTitleBar.ActualWidth, 48); // Set the size of the Titlebar

            appWindow.TitleBar.SetDragRectangles(new[] { dragRect }); // Apply the dragable function into the titlebar
        };
#endif

        NavViewMenu.SelectedItem = NavViewMenu.MenuItems[0];
    }

    private void NavViewMenu_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        if (args.SelectedItemContainer is NavigationViewItem selectedItem)
        {
            switch (selectedItem.Content) // or you can use selectedItem.Tag
            {
                case "Home":
                    ContentFrame.Navigate(typeof(Presentation.ProList));
                    break;
                case "Settings":
                    ContentFrame.Navigate(typeof(Presentation.SettingsPage));
                    break;
            }
        }
    }
}
