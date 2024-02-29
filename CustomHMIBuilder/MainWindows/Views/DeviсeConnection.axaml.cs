using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;

namespace CustomHMIBuilder.MainWindows.Views;

public partial class DeviсeConnection : Window
{
    public DeviсeConnection()
    {
        InitializeComponent();
    }

    private void CancelConnection_OnClick(object? sender, RoutedEventArgs e)
    {
        if (sender is InputElement inputElement)
        {
            Window currentWindow = inputElement.GetVisualRoot() as Window;  
            currentWindow?.Hide(); 
        }
    }
}