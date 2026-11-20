namespace DrawableFigures.Lib;

/// <summary>
/// Стиль отрисовки
/// </summary>
public record DFFigureStyle(
    DFColor FillColor,
    DFColor StrokeColor,
    double StrokeThickness
);
