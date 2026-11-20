using System;

namespace DrawableFigures.Lib;

/// <summary>
/// Квадрат (частный случай прямоугольника)
/// </summary>
/// <param name="size">Длина стороны</param>
public class Square(int size) : DFRectangle(size, size)
{
}
