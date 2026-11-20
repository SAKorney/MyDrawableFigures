namespace DrawableFigures.Lib;

/// <summary>
/// Стиль отрисовки
/// </summary>
public record DFFigureStyle(
    DFColor FillColor,
    bool IsFilled,
    DFColor StrokeColor,
    double StrokeThickness
);
