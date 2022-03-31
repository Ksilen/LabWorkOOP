using System.Collections.Generic;

namespace WindowsFormsBulldozer
{
    public class CarComparer : IComparer<ITransport>   //Сравнение машин для Sort
    {
        public int Compare(ITransport x, ITransport y)
        {
            // Реализовать метод сравнения для объектов
            if (x != null && y != null)
            {
                if (x.GetType() == typeof(Bulldozer) && y.GetType() == typeof(Bulldozer))
                {
                    return ComparerCar((Bulldozer)x, (Bulldozer)y);
                }
                if (x.GetType() == typeof(SuperBulldozer) && y.GetType() == typeof(SuperBulldozer))
                {
                    return ComparerSportCar((SuperBulldozer)x, (SuperBulldozer)y);
                }
                if (x.GetType() == typeof(Bulldozer) && y.GetType() == typeof(SuperBulldozer)) return -1;
                else return 1;
            }
            return 0;
        }
        private int ComparerCar(Bulldozer x, Bulldozer y)
        {
            // Продумать логику сравнения
            if (x.BodyColor.ToArgb() >= y.BodyColor.ToArgb()) return 1;
            return -1;
        }
        private int ComparerSportCar(SuperBulldozer x, SuperBulldozer y)
        {
            // Продумать логику сравнения
            string xString = "";
            string yString = "";
            for (int i = 4; i < 8; ++i)
            {
                xString += x.ToString().Split(';')[i];
                yString += y.ToString().Split(';')[i];
            }
            if (xString.Length < yString.Length) return -1;//количество навесов
            if (xString.Length < yString.Length) return 1;
            if (xString.Length == yString.Length)//если количество навесов равное, сравнение цвета 
            {
                if (x.BodyColor.ToArgb() > y.BodyColor.ToArgb()) return 1;
                if (x.BodyColor.ToArgb() < y.BodyColor.ToArgb()) return -1;
                if (x.BodyColor.ToArgb() == y.BodyColor.ToArgb())  //если основной цвет совпал, проверяем доп.цвет
                    if (x.DopColor.ToArgb() >= y.DopColor.ToArgb()) return 1;
                return -1;
            }
            return 0;
        }
    }
}
