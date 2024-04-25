using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.Extensions;
using ReactiveUI;
using SkiaSharp;

namespace CustomHMIBuilder.Widgets.ViewModels;

public class TemperatureViewModel : ReactiveObject
{
    // Это отвечает за температурный график
    public ISeries[] TempgraphSeries { get; set; } =
    {
        new LineSeries<int>
        {
            Values = new [] { 2, 1, 3, 5, 3, 4, 6 },
            Stroke = new SolidColorPaint(new SKColor(86, 184, 156)) {StrokeThickness = 4},
            Fill = new SolidColorPaint(new SKColor(137, 225, 200)), 
            GeometryStroke = new SolidColorPaint(new SKColor(86, 184, 156)) { StrokeThickness = 4 },
        }
    };

    public LabelVisual TempgraphLabel { get; set; } =
        new()
        {
            Text = "Температурный график",
            TextSize = 25,
            Padding = new LiveChartsCore.Drawing.Padding(15),
            Paint = new SolidColorPaint(SKColors.DarkSlateGray)
        };
    
    // Это отвечает за виджет управления температуры
    
    public IEnumerable<ISeries> TempControlSeries { get; set; } =
        GaugeGenerator.BuildSolidGauge(
            new GaugeItem(70, series =>
            {
                series.Fill = new SolidColorPaint(new SKColor(86, 184, 156));
                series.DataLabelsSize = 50;
                series.DataLabelsPaint = new SolidColorPaint(SKColors.Black);
                series.DataLabelsPosition = PolarLabelsPosition.ChartCenter;
                series.InnerRadius = 60;
            }),
            new GaugeItem(GaugeItem.Background, series =>
            {
                series.InnerRadius = 60;
                series.Fill = new SolidColorPaint(new SKColor(100, 181, 246, 90));
            }));
    
    public LabelVisual TempControlLabel { get; set; } =
        new()
        {
            Text = "Управление температурой",
            TextSize = 25,
            Padding = new LiveChartsCore.Drawing.Padding(15),
            Paint = new SolidColorPaint(SKColors.DarkSlateGray)
        };
    
}
