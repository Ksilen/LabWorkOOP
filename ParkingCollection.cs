using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsBulldozer
{
    class ParkingCollection
    {
        /// Словарь (хранилище) с парковками
        public Dictionary<string, Parking<Bulldozer>> _parkingStages;
        /// Возвращение списка названий парковок
        public List<string> Keys;
        /// Ширина окна отрисовки
        private readonly int _pictureWidth;
        /// Высота окна отрисовки
        private readonly int _pictureHeight;
        /// Разделитель
        protected readonly char _separator = ':';
        /// Конструктор
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            _parkingStages = new Dictionary<string, Parking<Bulldozer>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }
        /// Сохранение информации по автомобилям на парковках в файл
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename))
            {
                fs.WriteLine("ParkingCollection");
                foreach (var level in _parkingStages)
                {
                    //Начинаем парковку
                    String str = String.Format("Parking:{0}", level.Key);
                    fs.WriteLine(str);
                    foreach (var car in level.Value.GetNext())
                    {
                        //если место не пустое
                        if (car != null)
                        {
                            String carSet = String.Format("{0}:{1}", car.GetType().Name.ToString(), car);
                            fs.WriteLine(carSet);
                        }
                    }
                }
            }
            return true;
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
        /// Загрузка нформации по автомобилям на парковках из файла
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader fs = new StreamReader(filename))
            {
                string line = "";
                _parkingStages.Clear();
                Bulldozer car = null;
                string key = string.Empty;
                bool isParking = true;
                while ((line = fs.ReadLine()) != null)
                {
                    if (isParking)
                    {
                        if (!line.Contains("ParkingCollection")) //если нет такой записи, то это не те данные
                        {
                            return false;
                        }
                        isParking = false;
                        continue;
                    }
                    //идем по считанным записям
                    if (line.Contains("Parking"))
                    {
                        //начинаем новую парковку
                        key = line.Split(':')[1];
                        _parkingStages.Add(key, new
                        Parking<Bulldozer>(_pictureWidth, _pictureHeight));
                        Keys = _parkingStages.Keys.ToList();
                        continue;
                    }
                    if (line.Split(_separator)[0] == "Bulldozer")
                    {
                        car = new Bulldozer(line.Split(_separator)[1]);
                    }
                    else if (line.Split(_separator)[0] == "SuperBulldozer")
                    {
                        car = new SuperBulldozer(line.Split(_separator)[1]);
                    }
                    var result = _parkingStages[key] + car;
                    if (!result)
                    {
                        return false;
                    }
                }
                return true;
            }
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