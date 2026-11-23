namespace DrawableFigures.Lib;

/// <summary>
/// Интерфейс для отрисовки
/// </summary>
// Отрисовка реализуется через паттерн Посетитель и двойную диспетчирезацию
public interface IDFRender
{
    void DrawEllipse(DFEllipse ellipse);
    void DrawCircle(DFCircle circle);

    void DrawRectangle(DFRectangle rectangle);
    void DrawSquare(DFSquare square);
}
