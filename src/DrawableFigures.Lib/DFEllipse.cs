namespace DrawableFigures.Lib;

/// <summary>
/// Эллипс
/// </summary>
/// <param name="radiusX">Ширина</param>
/// <param name="radiusY">Высота</param>
public class DFEllipse(int radiusX, int radiusY) : DFDrawableFigure
{
    public DFPoint Center { get; set; }
    public int RadiusX { get; set; } = radiusX;
    public int RadiusY { get; set; } = radiusY;

    public override void Draw(IDFRender render)
        => render.DrawEllipse(this);
}
