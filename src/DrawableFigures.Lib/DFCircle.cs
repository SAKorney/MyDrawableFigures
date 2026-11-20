using System;

namespace DrawableFigures.Lib;

/// <summary>
/// Круг (частный случай эллипса)
/// </summary>
/// <param name="radius">Радиус</param>
public class DFCircle(int radius) : DFEllipse(radius, radius)
{
}
