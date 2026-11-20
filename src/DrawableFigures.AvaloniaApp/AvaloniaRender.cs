using Avalonia;
using Avalonia.Media;
using DrawableFigures.Avalonia.App;
using DrawableFigures.Lib;

namespace DrawableFigures.AvaloniaApp;

public class AvaloniaRender(DrawingContext context) : IDFRender
{
    public void Draw(IDFDrawable drawableObject)
    {
        // Да, это стоит кэшировать, но для примера полагаю достаточно
        // просто указать на данный момент
        Pen pen = drawableObject.Style.ToAvaloniaPen();
        Brush brush = drawableObject.Style.FillColor.ToAvaloniaBrush();

        if (drawableObject is DFEllipse ellipse)
        {
            context.DrawEllipse(
                brush: brush,
                pen: pen,
                center: ellipse.Center.ToAvaloniaPoint(),
                radiusX: ellipse.RadiusX,
                radiusY: ellipse.RadiusY);
        }

        if (drawableObject is DFRectangle rectangle)
        {
            var rect = new Rect(
                rectangle.LeftCorner.X, rectangle.LeftCorner.Y,
                rectangle.Width, rectangle.Height);

            context.DrawRectangle(
                brush: brush,
                pen: pen,
                rect: rect
            );
        }
    }
}
