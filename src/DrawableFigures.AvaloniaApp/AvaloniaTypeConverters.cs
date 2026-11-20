using System;
using Avalonia;
using Avalonia.Media;
using DrawableFigures.Lib;

namespace DrawableFigures.Avalonia.App;

public static class AvaloniaTypeConverters
{
    public static Brush ToAvaloniaBrush(this DFColor color)
        => new SolidColorBrush(Color.FromRgb(color.R, color.G, color.B));

    public static Point ToAvaloniaPoint(this DFPoint point)
        => new(point.X, point.Y);

    public static Pen ToAvaloniaPen(this DFFigureStyle style)
        => new(
            style.StrokeColor.ToAvaloniaBrush(),
            style.StrokeThickness);
}
