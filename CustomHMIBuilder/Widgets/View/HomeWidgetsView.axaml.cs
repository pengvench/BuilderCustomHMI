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
        var button = (Button)sender!;
        if (button?.Content?.ToString() == "Настроить окно")
        {
            WidgetListGrid.IsVisible = true;
            button.Content = "Сохранить";
        }
        else
        {
            WidgetListGrid.IsVisible = false;
            if (button != null) button.Content = "Настроить окно";
        }
    }
}