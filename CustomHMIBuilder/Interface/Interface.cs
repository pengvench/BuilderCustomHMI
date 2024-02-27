using System;
using System.Drawing;
using System.Text;
using Avalonia.Controls;
using CustomHMIBuilder.Editor.View;

namespace CustomHMIBuilder

{
    [Flags]
    public enum ECtrlFlags
    {
        None = 0x00,
        ResizeWidth = 0x01,  // false for labels, text displays, etc
        ResizeHeight = 0x02, // false for labels, text entries, etc
        Resize = 0x03,       // composite of width and height
        IsGroup = 0x04,      // Border and GroupBox
    }
    
    

    public interface IHmiControl
    {
        Avalonia.Layout.Layoutable fe { get; }     // this as FrameworkElement
        string Name { get; set; }         // FrameworkElement.Name
        CanvasView OwnerPage { get; set; }
        string NamePrefix { get; }        // "button", etc for default names
        Size InitialSize { get; }         // design size for new controls
        ECtrlFlags Flags { get; }
        UserControl PropertyPage { get; }
        bool IsEmpty { get; }             // empty TextBlock, etc
        string ToXaml(int indentLevel, bool eventHandlers, bool vs);
        void AppendCodeBehind(StringBuilder sb);
    }
}