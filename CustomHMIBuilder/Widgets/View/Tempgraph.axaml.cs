using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace CustomHMIBuilder.Widgets;

public partial class Tempgraph : UserControl
{
    public Tempgraph()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
}