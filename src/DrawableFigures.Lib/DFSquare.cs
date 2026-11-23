namespace DrawableFigures.Lib;

/// <summary>
/// Квадрат
/// </summary>
/// <param name="size">Длина стороны</param>
public class DFSquare(int size) : DFDrawableFigure
{
    public DFPoint LeftCorner { get; set; }
    public int Size { get; set; } = size;

    public override void Draw(IDFRender render)
        => render.DrawSquare(this);
}
