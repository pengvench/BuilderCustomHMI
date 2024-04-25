using System;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using ReactiveUI;
using SkiaSharp;

namespace CustomHMIBuilder.Widgets.ViewModels;

public class TempgraphViewModel : ReactiveObject
{
    // Это отвечает за температурный график
    public ISeries[] Series { get; set; } =
    {
        new LineSeries<int>
        {
            Values = new [] { 2, 1, 3, 5, 3, 4, 6 },
            Stroke = new SolidColorPaint(new SKColor(86, 184, 156)) {StrokeThickness = 4},
            Fill = new SolidColorPaint(new SKColor(137, 225, 200)), 
            GeometryStroke = new SolidColorPaint(new SKColor(86, 184, 156)) { StrokeThickness = 4 },
        }
    };

    public LabelVisual Title { get; set; } =
        new()
        {
            Text = "Температурный график",
            TextSize = 25,
            Padding = new LiveChartsCore.Drawing.Padding(15),
            Paint = new SolidColorPaint(SKColors.DarkSlateGray)
        };
}
