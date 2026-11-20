using System.ComponentModel.Design;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using DrawableFigures.Lib;

namespace DrawableFigures.AvaloniaApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Background = Brushes.Transparent;
    }

    public override void Render(DrawingContext context)
    {
        base.Render(context);
        context.FillRectangle(Brushes.White, new Rect(Bounds.Size));
        AvaloniaRender render = new(context);
        var rect = new DFRectangle(100, 100)
        {
            LeftCorner = new DFPoint(10, 10)
        };
        var circle = new DFCircle(10)
        {
            Center = new DFPoint(150, 150)
        };
        var ellipse = new DFEllipse(50, 15)
        {
            Center = new DFPoint(250, 100)
        };
        rect.Draw(render);
        circle.Draw(render);
        ellipse.Draw(render);
    }
}