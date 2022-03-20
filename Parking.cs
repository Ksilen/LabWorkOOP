using System.Drawing;
using System.Collections.Generic;

namespace WindowsFormsBulldozer
{
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    public class Parking<T> where T : class , ITransport
    {
        /// Список объектов, которые храним
        private readonly List<T> _places;
        /// Ширина окна отрисовки
        private readonly int _pictureWidth;
        /// Высота окна отрисовки
        private readonly int _pictureHeight;
        /// Размер парковочного места (ширина)
        private readonly int _placeSizeWidth = 275;
        /// Размер парковочного места (высота)
        private readonly int _placeSizeHeight = 80;
        //максимальное количество бульдозеров
        public static int _maxCount;
        //количество ячеек парковки
        public static int widthN = 0;
        public static int heightN = 0;
        /// Конструктор
        public Parking(int picWidth, int picHeight)
        {
            widthN = picWidth / _placeSizeWidth;
            heightN = picHeight / _placeSizeHeight;
            _maxCount = widthN * heightN;
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
            _places = new List<T>();
        }
        /// Функция получения элементов из списка
        public IEnumerable<T> GetNext()
        {
            foreach (var elem in _places)
            {
                yield return elem;
            }
        }
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется автомобиль
        public static bool operator +(Parking<T> p, T bulldozer)
        {
            if (p._places.Count < _maxCount)
            {
                p._places.Add(bulldozer);
                return true;
            }
            else
            {
                try
                {
                    throw new ParkingOverflowException();
                }
                catch
                {
                    return false;
                }
            }
        }
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем автомобиль     
        public static T operator -(Parking<T> p, int index)
        {
            if (index < p._places.Count)
            {
                var buldozer = p._places[index];
                p._places.RemoveAt(index);
                return buldozer;
            }
            else
            {
                try
                {
                    throw new ParkingNotFoundException(index);
                }
                catch
                {
                    return null;
                }
            }
        }
        /// Метод отрисовки парковки
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetObject(5 + i / 5 * _placeSizeWidth + 14, i % 5 * _placeSizeHeight + 15,
                    _pictureWidth, _pictureHeight);
                _places[i].DrawTransport(g);
            }
        }
        /// Метод отрисовки разметки парковочных мест
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight + 1;
                ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j *
                    _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i *
                _placeSizeWidth, (_pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}

