using Avalonia.Controls;
using Avalonia.Interactivity;
using CustomHMIBuilder.Editor.View;

namespace CustomHMIBuilder.Views;

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
                var homeView = new HomeView();
                MainGrid.Children.Clear();
                MainGrid.Children.Add(homeView);
            }
                break;
        }
    }
    
}
    
