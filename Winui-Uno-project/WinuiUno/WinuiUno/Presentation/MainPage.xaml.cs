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
                0, 0,
                (int)AppTitleBar.ActualWidth, (int)AppTitleBar.ActualHeight);

            appWindow.TitleBar.SetDragRectangles(new[] { dragRect });
        };
#endif
    }

}
