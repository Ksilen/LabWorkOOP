using System;
using System.Windows.Forms;
namespace WindowsFormsBulldozer
{/// Класс-ошибка "Если не найден автомобиль по определенному месту"
    class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i)
            : base("Не найден автомобиль по месту")
        {
            MessageBox.Show(base.Message + " " + i, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
