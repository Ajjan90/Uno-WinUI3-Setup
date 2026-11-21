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
                0,
                0,
                (int)AppTitleBar.ActualWidth,
                48);

            appWindow.TitleBar.SetDragRectangles(new[] { dragRect });
        };
#endif

        NavViewMenu.SelectedItem = NavViewMenu.MenuItems[0];
    }

    private void NavViewMenu_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        if (args.SelectedItemContainer is NavigationViewItem selectedItem)
        {
            switch (selectedItem.Tag)
            {
                case "Processors":
                    ContentFrame.Navigate(typeof(Presentation.ProList));
                    break;
            }
        }
    }
}
