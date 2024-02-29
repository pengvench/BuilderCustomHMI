using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;


namespace CustomHMIBuilder.Editor.View;

public partial class ControlsMenu : UserControl
{
    // private CanvasView mainCanvas;
    
    public ControlsMenu()
    {
        // this.mainCanvas = mainCanvas;
        InitializeComponent();
    }

    // private void ButtonBase_Click(object sender, RoutedEventArgs e)
    // {
    //     Button button = e.Source as Button;
    //     if (button == null || e.Handled) return;
    //
    //     switch (button.Name)
    //     {
    //         // case "BtnButton": mainCanvas.AddElement<HmiButton>(); break;
    //         // case "BtnLabel": mainCanvas.AddElement<HmiTextBox>(); break;
    //     }
    // }
}