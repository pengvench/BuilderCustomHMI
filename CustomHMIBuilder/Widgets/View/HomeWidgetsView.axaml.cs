using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CustomHMIBuilder.Widgets.View;

public partial class HomeWidgetsView : UserControl
{
    public HomeWidgetsView()
    {
        InitializeComponent();
    }

    private void WidgetsSettings_OnClick(object? sender, RoutedEventArgs e)
    {
        var homeEditorView = new HomeEditorView();
        HomeGrid.Children.Clear();
        HomeGrid.Children.Add(homeEditorView);
    }
}