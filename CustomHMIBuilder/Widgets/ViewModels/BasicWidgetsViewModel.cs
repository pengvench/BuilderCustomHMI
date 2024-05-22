using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.VisualElements;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView.Drawing;
using ReactiveUI;
using SkiaSharp;
using System;

namespace CustomHMIBuilder.Widgets.ViewModels;

public class BasicWidgetsViewModel : ReactiveObject
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
    
    
    // Это отвечает за виджет управления температуры
    
    public IEnumerable<ISeries> TempControlSeries { get; set; } =
        GaugeGenerator.BuildSolidGauge(
            new GaugeItem(70, series =>
            {
                series.Fill = new SolidColorPaint(new SKColor(86, 184, 156));
                series.DataLabelsSize = 50;
                series.DataLabelsPaint = new SolidColorPaint(SKColors.WhiteSmoke);
                series.DataLabelsPosition = PolarLabelsPosition.ChartCenter;
                series.InnerRadius = 60;
            }),
            new GaugeItem(GaugeItem.Background, series =>
            {
                series.InnerRadius = 60;
                series.Fill = new SolidColorPaint(new SKColor(100, 181, 246, 90));
            })
            );
    
    
    // Это отвечает за давление в системе
    
    public BasicWidgetsViewModel()
    {
        var sectionsOuter = 130;
        var sectionsWidth = 20;
        
        Needle = new NeedleVisual
        {
            Value = 45,
            Fill = new SolidColorPaint(SKColors.WhiteSmoke)
        };
        
        PressureSeries = GaugeGenerator.BuildAngularGaugeSections(
            new GaugeItem(60, s => SetStyle(sectionsOuter, sectionsWidth,  s)),
            new GaugeItem(30,  s => SetStyle(sectionsOuter, sectionsWidth, s)),
            new GaugeItem(10, s => SetStyle(sectionsOuter, sectionsWidth, s)));

        PressureVisualElements = new VisualElement<SkiaSharpDrawingContext>[]
        {
            new AngularTicksVisual
            {
                LabelsSize = 16,
                LabelsOuterOffset = 15,
                OuterOffset = 65,
                TicksLength = 20,
                Stroke = new SolidColorPaint(SKColors.WhiteSmoke),
                LabelsPaint = new SolidColorPaint(SKColors.WhiteSmoke)
            },
            Needle
        };
    }

    public IEnumerable<ISeries> PressureSeries { get; set; }

    public IEnumerable<VisualElement<SkiaSharpDrawingContext>> PressureVisualElements { get; set; }
    
    public NeedleVisual Needle { get; set; }

    private static void SetStyle(
        double sectionsOuter, double sectionsWidth, PieSeries<ObservableValue> series)
    {
        series.OuterRadiusOffset = sectionsOuter;
        series.MaxRadialColumnWidth = sectionsWidth;
    }
    
}
