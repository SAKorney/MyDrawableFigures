using System;

namespace DrawableFigures.Lib;

/// <summary>
/// Круг
/// </summary>
/// <param name="radius">Радиус</param>
public class DFCircle(int radius) : DFDrawableFigure
{
    public DFPoint Center { get; set; }
    public int Radius { get; set; } = radius;

    public override void Draw(IDFRender render)
     => render.DrawCircle(this);
}
