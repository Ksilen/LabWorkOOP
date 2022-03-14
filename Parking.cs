using System.Drawing;

namespace WindowsFormsBulldozer
{
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    public class Parking<T> where T : class , ITransport
    {
        /// Массив объектов, которые храним
        public T[] _places;
        /// Ширина окна отрисовки
        private readonly int _pictureWidth;
        /// Высота окна отрисовки
        private readonly int _pictureHeight;
        /// Размер парковочного места (ширина)
        private readonly int _placeSizeWidth = 270;
        /// Размер парковочного места (высота)
        private readonly int _placeSizeHeight = 80;
        //кколичество бульдозеров
        public static int indexOfPlace = 0;
        //количество ячеек парковки
        public static int widthN = 0;
        public static int heightN = 0;
        public static int countOfHeight = 1;
        public static int countOfWeight = 0;
        public int NotStaticIndexOfPlace = 0;
        /// Конструктор
        public Parking(int picWidth, int picHeight)
        {
            widthN = picWidth / _placeSizeWidth;
            heightN = picHeight / _placeSizeHeight;
            _places = new T[widthN * heightN];
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
        }
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется автомобиль
        public static bool operator +(Parking<T> p, T bulldozer)
        {
            if (indexOfPlace < widthN * heightN)
            {
                for (int i = 0; i <= indexOfPlace; i++)
                {
                    if (p._places[i] == null)
                    {
                        ParkingPlaceIsEmpty(i, p, bulldozer);
                        return true;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        //добавление бульдозеров на пустые места парковки
        public static void ParkingPlaceIsEmpty(int i, Parking<T> p, T bulldozer)
        {
            int countOfHeightN = 1;
            int countOfWeightN = 0;
            for (int j = 0; j < i; j++)
            {
                countOfWeightN++;
                if (j + 1 > heightN * countOfHeightN - 1) { countOfHeightN++; countOfWeightN = 0; }
            }
            bulldozer.SetObject(
          (p._placeSizeWidth * (countOfHeightN - 1)) + 19, (p._placeSizeHeight * countOfWeightN) + 7, p._placeSizeWidth, p._placeSizeHeight);
            p._places[i] = bulldozer;
            indexOfPlace++;
        }
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем автомобиль     
        public static T operator -(Parking<T> p, int index)
        {
            indexOfPlace--;
            var buldozer = p._places[index];
            p._places[index] = null;
            return buldozer;
        }
        /// Метод отрисовки парковки
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                if (_places[i] != null)
                {
                    _places[i].DrawTransport(g);
                }
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

