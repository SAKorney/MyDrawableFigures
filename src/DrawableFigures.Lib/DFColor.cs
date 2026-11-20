using System;

namespace DrawableFigures.Lib;

/// <summary>
/// Цвет в формате RGB
/// </summary>
/// <param name="R">Красный канал</param>
/// <param name="G">Зелёный канал</param>
/// <param name="B">Синий канал</param>
// Альфа-канал отсутствует для простоты
public record struct DFColor(byte R, byte G, byte B)
{
    public static DFColor Black => new(0, 0, 0);
    public static DFColor White => new(255, 255, 255);
    public static DFColor Red => new(255, 0, 0);
    public static DFColor Green => new(0, 255, 0);
    public static DFColor Blue => new(0, 0, 255);
}
