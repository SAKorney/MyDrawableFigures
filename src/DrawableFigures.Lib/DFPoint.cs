using System;

namespace DrawableFigures.Lib;

public readonly struct DFPoint(int x, int y)
{
    public readonly int X = x;
    public readonly int Y = y;
}
