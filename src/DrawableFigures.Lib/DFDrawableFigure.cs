namespace DrawableFigures.Lib;

public abstract class DFDrawableFigure : IDFDrawable
{
    public void Draw(IDFRender render)
    {
        render.Draw(this);
    }
}
