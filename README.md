# MyDrawableFigures

Демонстрационный проект, состоящий из простой библиотеки графических примитивов (`DrawableFigures.Lib`) и примера реализации их отрисовки средствами фреймворка **Avalonia UI** (`DrawableFigures.AvaloniaApp`).

## Структура решения

Решение `MyDrawableFigures.sln` расположено в корне репозитория, а исходный код проектов находится в директории `src/`:

```text
MyDrawableFigures/
├── src/
│   ├── DrawableFigures.Lib/         # Библиотека графических примитивов
│   └── DrawableFigures.AvaloniaApp/ # Приложение на Avalonia UI для отрисовки фигур
├── MyDrawableFigures.sln
└── .gitignore
```

### 1. `DrawableFigures.Lib`
Библиотека классов, содержащая базовые модели геометрических фигур и логику их представления без привязки к конкретному UI-фреймворку.

#### Иерархия классов фигур:
```text
DFDrawableFigure (abstract)
├── DFEllipse (эллипс)
├── DFCircle (круг)
├── DFRectangle (прямоугольник)
└── DFSquare (квадрат)
```

* **`DFDrawableFigure`** — абстрактный базовый класс для всех отрисовываемых фигур.
* **`DFEllipse`** — класс, описывающий эллипс.
* **`DFCircle`** — класс, описывающий круг.
* **`DFRectangle`** — класс, описывающий прямоугольник.
* **`DFSquare`** — класс, описывающий квадрат.

### 2. `DrawableFigures.AvaloniaApp`
Кроссплатформенное десктопное приложение на базе **Avalonia UI**, демонстрирующее работу с библиотекой `DrawableFigures.Lib` и визуализацию её примитивов на экране.

## Архитектура
* **LSP:** `DFCircle` и `DFSquare` отделены от эллипсов/прямоугольников для сохранения геометрических инвариантов.
* **Visitor:** отрисовка через `IDFRender` с двойной диспетчеризацией (`figure.Draw(render)`).

## Технологический стек и требования

* **Платформа:** .NET 8 (`net8.0`)
* **UI-фреймворк:** Avalonia UI `12.1.6`
* **Язык:** C#

## Сборка и запуск

Для сборки и запуска проекта убедитесь, что у вас установлен **.NET 8 SDK**.

1. Клонируйте репозиторий:
   ```bash
   git clone https://github.com/SAKorney/MyDrawableFigures.git
   cd MyDrawableFigures
   ```

2. Соберите решение:
   ```bash
   dotnet build MyDrawableFigures.sln
   ```

3. Запустите приложение Avalonia:
   ```bash
   dotnet run --project src/DrawableFigures.AvaloniaApp
   ```
