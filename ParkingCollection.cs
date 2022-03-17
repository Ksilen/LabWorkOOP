using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsBulldozer
{
    class ParkingCollection
    {
        /// Словарь (хранилище) с парковками
        readonly Dictionary<string, Parking<Bulldozer>> _parkingStages;
        /// Возвращение списка названий парковок
        public List<string> Keys;
        /// Ширина окна отрисовки
        private readonly int _pictureWidth;
        /// Высота окна отрисовки
        private readonly int _pictureHeight;
        /// Конструктор
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            _parkingStages = new Dictionary<string, Parking<Bulldozer>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }
        /// Добавление парковки
        public void AddParking(string name)
        {
            if (Keys != null)
            {
                for (int i = 0; i < Keys.Count; i++)
                {
                    if (Keys[i] == name) return;
                }
            }
            _parkingStages.Add(name, new Parking<Bulldozer>(_pictureWidth, _pictureHeight));
            Keys = _parkingStages.Keys.ToList();
        }
        /// Удаление парковки
        public void DelParking(string name)
        {
            _parkingStages.Remove(name);
            Keys.Remove(name);
        }
        /// Доступ к парковке
        public Parking<Bulldozer> this[string ind]
        {
            get
            {
                return _parkingStages[ind];
            }
        }
    }
}
