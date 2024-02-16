using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Input;
using Avalonia.Media;
using Avalonia.Animation;
using System.Diagnostics;
using Avalonia.Animation.Easings;
using Avalonia.Markup.Xaml;


namespace CustomHMIBuilder.Views;

public partial class MainView : UserControl
{

    public MainView()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        Button newButton = new Button
        {
            Content = "Новая кнопка",
            Width = 50,
            Height = 20,
            IsEnabled = false
        };

        double x = 100;
        double y = 100;

        MainCanvas.Children.Add(newButton);

        Canvas.SetLeft(newButton, x);
        Canvas.SetTop(newButton, y);
    }
}
