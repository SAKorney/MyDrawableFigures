namespace DrawableFigures.Lib;

/// <summary>
/// Фигура, которую можно отрисовать
/// </summary>
public abstract class DFDrawableFigure : IDFDrawable
{
    public DFFigureStyle Style { get; set; }

    public DFDrawableFigure()
    {
        Style = new(
            FillColor: DFColor.White,
            StrokeColor: DFColor.Black,
            StrokeThickness: 1.0
        );
    }

    public abstract void Draw(IDFRender render);
}

// TODO: Треугольник - частный случай полигона (замкнутого контура).
// Его реализацию, как и реализацию полигона пропущу для краткости.
// Реализовал бы их с помощью дополнительной фигуры "Прямая" (отношение композиции)
