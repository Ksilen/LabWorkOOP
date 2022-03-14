using System.Drawing;
namespace WindowsFormsBulldozer
{
    public interface ITransport
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
        void DrawTransport(Graphics g);
        /// Смена границ формы отрисовки
        void ChangeBorders(int width, int height);
    }
}
