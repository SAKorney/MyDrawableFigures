using System;
using Avalonia;
using Avalonia.Media;
using DrawableFigures.Avalonia.App;
using DrawableFigures.Lib;

namespace DrawableFigures.AvaloniaApp;

public class AvaloniaRender(DrawingContext context) : IDFRender
{
    public void DrawCircle(DFCircle circle)
    {
        DrawInternal(circle,
            (pen, brush) => context.DrawEllipse(
                brush: brush,
                pen: pen,
                center: circle.Center.ToAvaloniaPoint(),
                radiusX: circle.Radius,
                radiusY: circle.Radius));
    }

    public void DrawEllipse(DFEllipse ellipse)
    {
        DrawInternal(ellipse,
            (pen, brush) => context.DrawEllipse(
                brush: brush,
                pen: pen,
                center: ellipse.Center.ToAvaloniaPoint(),
                radiusX: ellipse.RadiusX,
                radiusY: ellipse.RadiusY));
    }

    public void DrawRectangle(DFRectangle rectangle)
    {
        var rect = new Rect(
                rectangle.LeftCorner.X, rectangle.LeftCorner.Y,
                rectangle.Width, rectangle.Height);

        DrawInternal(rectangle,
            (pen, brush) => context.DrawRectangle(
                brush: brush,
                pen: pen,
                rect: rect));
    }

    public void DrawSquare(DFSquare square)
    {
        var rect = new Rect(
                square.LeftCorner.X, square.LeftCorner.Y,
                square.Size, square.Size);

        DrawInternal(square,
            (pen, brush) => context.DrawRectangle(
                brush: brush,
                pen: pen,
                rect: rect));
    }

    private void DrawInternal(IDFDrawable drawableObject, Action<Pen, Brush> draw)
    {
        // Да, это стоит кэшировать, но для примера полагаю достаточно
        // просто указать на данный момент
        Pen pen = drawableObject.Style.ToAvaloniaPen();
        Brush brush = drawableObject.Style.FillColor.ToAvaloniaBrush();

        draw(pen, brush);
    }
}
