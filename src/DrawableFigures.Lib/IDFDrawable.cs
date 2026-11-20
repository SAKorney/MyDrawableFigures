namespace DrawableFigures.Lib;

/// <summary>
/// Отрисовываемый объект
/// </summary>
public interface IDFDrawable
{
    public DFFigureStyle Style { get; set; }
    void Draw(IDFRender render);
}
