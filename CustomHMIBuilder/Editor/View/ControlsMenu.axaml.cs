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
    //         case "BtnLabel": mainCanvas.AddElement<HmiLabel>(); break;
    //         case "BtnButton": mainCanvas.AddElement<HmiButton>(); break;
    //         case "BtnSlider": mainCanvas.AddElement<HmiSlider>(); break;
    //         case "BtnDropdownList": mainCanvas.AddElement<HmiDropdownList>(); break;
    //         case "BtnTextBox": mainCanvas.AddElement<HmiTextBox>(); break;
    //         case "BtnNumeric": mainCanvas.AddElement<HmiNumeric>(); break;
    //         case "BtnComboBox": mainCanvas.AddElement<HmiComboBox>(); break;
    //         case "BtnTrend": mainCanvas.AddElement<HmiTrend>(); break;
    //         case "BtnIndicator": mainCanvas.AddElement<HmiIndicator>(); break;
    //     }
    // }
}