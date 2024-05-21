using System.IO;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;

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
        var stackPanel = (StackPanel)button.Content;
        var textBlock = (TextBlock)stackPanel.Children[1];
        var image = (Image)stackPanel.Children[0];

        if (textBlock.Text == "Настройка окна")
        {
            WidgetListGrid.IsVisible = true;
            textBlock.Text = "Сохранить";
            using var stream = Application.Current.FindResource("disk.png") as Stream;
            if (stream != null)
            {
                image.Source = new Bitmap(stream);
            }
        }
        else
        {
            WidgetListGrid.IsVisible = false;
            textBlock.Text = "Настройка окна";
            using var stream = Application.Current.FindResource("menu-burger.png") as Stream;
            if (stream != null)
            {
                image.Source = new Bitmap(stream);
            }
        }
    }
}