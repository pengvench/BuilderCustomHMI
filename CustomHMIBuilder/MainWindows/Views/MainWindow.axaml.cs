using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;
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
    
    // Окно подключения устройства
    private Window? _deviceConnectionWindow;
    
    private void ConnectDevice_OnClick(object? sender, RoutedEventArgs e)
    {
        if (_deviceConnectionWindow == null)
        {
            _deviceConnectionWindow = new DeviсeConnection();
            _deviceConnectionWindow.Closed += DeviceConnectionWindow_Closed;
            _deviceConnectionWindow.Show();
        }
        else
        {
            _deviceConnectionWindow.Show();
        }

    }
    
    private void DeviceConnectionWindow_Closed(object sender, EventArgs e)
    {
        _deviceConnectionWindow = null;
    }

    //Кнопка ссылки на сайт
    private void WebSite_OnClick(object? sender, RoutedEventArgs e)
    {
        string url = "https://mechatronica-pro.com/ru";
        Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
    }
    
    //Всплывающая справка
    private void ToggleVisibility_Click(object sender, RoutedEventArgs e)
    {
        if (this.FindControl<Border>("HelpInfo") is Border border)
        {
            border.IsVisible = !border.IsVisible;
        }
    }

    private void Close_Click(object sender, RoutedEventArgs e)
    {
        if (this.FindControl<Border>("HelpInfo") is Border border)
        {
            border.IsVisible = false; // Чтобы гарантированно скрыть элемент
        }
    }
    
}
    
