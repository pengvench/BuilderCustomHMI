using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CustomHMIBuilder.Widgets.View;

public partial class HomeEditorView : UserControl
{
    public HomeEditorView()
    {
        InitializeComponent();
    }

    private void SaveWidgetsSettings_OnClick(object? sender, RoutedEventArgs e)
    {
        var homeWidgetsView = new HomeWidgetsView();
        HomeGrid.Children.Clear();
        HomeGrid.Children.Add(homeWidgetsView);
    }
}