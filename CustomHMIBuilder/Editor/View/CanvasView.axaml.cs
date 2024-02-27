using System.Drawing;
using System.Text;
using Avalonia.Controls;

namespace CustomHMIBuilder.Editor.View;

public partial class CanvasView : UserControl
{
    
    public const int GridSize = 4;
    private const int pixelOffset = 12;
    public CanvasView()
    {
        InitializeComponent();
    }
    
    public void AddElement<T>(double leftShift = pixelOffset, double topShift = pixelOffset) where T : IHmiControl, new()
    {
 
    }
    


}

