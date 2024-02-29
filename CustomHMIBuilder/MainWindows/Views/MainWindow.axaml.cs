using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using CustomHMIBuilder.Editor.View;
using CustomHMIBuilder.Widgets.View;

namespace CustomHMIBuilder.MainWindows.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
     
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var button = (sender as Button)!;
        switch (button.Name)
        {
            case "Editor":
            {
                var editorView = new EditorView();
                MainGrid.Children.Clear();
                MainGrid.Children.Add(editorView);
            }
                break;
            case "Home":
            {
                var homeView = new HomeWidgetsView();
                MainGrid.Children.Clear();
                MainGrid.Children.Add(homeView);
            }
                break;
        }
    }

    private void ConnectDevice_OnClick(object? sender, RoutedEventArgs e)
    {
        Window deviceConnectionWindow = new DeviсeConnection();

        // Открываем новое окно
        deviceConnectionWindow.Show();
    }
}
    
