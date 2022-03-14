using System.Drawing;
//using class GetCurrentPos;

namespace WindowsFormsBulldozer
{
    /// Интерфейс для работы с объектом, отрисовываемым на форме
    public interface IDrawObject
    {
        /// Шаг объекта
        float Step { get; }
        /// Цвет объекта
        Color BodyColor { get; }
        /// Установка позиции объекта
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина полотна</param>
        /// <param name="height">Высота полотна</param>
        void SetObject(float x, float y, int width, int height);
        /// Изменение направления пермещения объекта
        bool MoveObject(Direction direction);
        /// Отрисовка объекта
        void DrawObject(Graphics g);
        /// Получение текущей позиции объекта
        void GetPosition();
        float GetRight();
        float GetLeft();
        float GetTop();
        float GetBottom();
    }
}
