namespace DrawableFigures.Lib;

/// <summary>
/// Прямоугольник
/// </summary>
/// <param name="width">Ширина</param>
/// <param name="height">Высота</param>
public class DFRectangle(int width, int height) : DFDrawableFigure
{
    public DFPoint LeftCorner { get; set; }
    public int Width { get; set; } = width;
    public int Height { get; set; } = height;
}
