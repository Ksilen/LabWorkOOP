using System;
using System.Windows.Forms;

namespace WindowsFormsBulldozer
{
    /// Класс-ошибка "Если на парковке уже есть автомобиль с такими же характеристиками"
    public class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException()
            : base("На парковке уже есть такая машина")
        {
        }
    }
}
