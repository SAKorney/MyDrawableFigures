using Avalonia;
using Avalonia.Media;
using DrawableFigures.Lib;

namespace DrawableFigures.AvaloniaApp;

public class AvaloniaRender(DrawingContext context) : IDFRender
{
    private readonly Pen _pen = new Pen(Brushes.Black, 2);

    public void Draw(IDFDrawable drawableObject)
    {
        if (drawableObject is DFEllipse ellipse)
        {
            context.DrawEllipse(
                brush: Brushes.DodgerBlue,
                pen: _pen,
                center: new Point(
                    ellipse.Center.X,
                    ellipse.Center.Y),
                radiusX: ellipse.RadiusX,
                radiusY: ellipse.RadiusY);
        }

        if (drawableObject is DFRectangle rectangle)
        {
            var rect = new Rect(
                rectangle.LeftCorner.X, rectangle.LeftCorner.Y,
                rectangle.Width, rectangle.Height);

            context.DrawRectangle(
                brush: Brushes.MediumSeaGreen,
                pen: _pen,
                rect: rect
            );
        }
    }
}
