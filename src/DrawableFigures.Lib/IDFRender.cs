namespace DrawableFigures.Lib;

/// <summary>
/// Интерфейс для отрисовки
/// </summary>
// Отрисовка реализуется через паттерн Посетитель и двойную диспетчирезацию
public interface IDFRender
{
    void Draw(IDFDrawable drawableObject);
}
