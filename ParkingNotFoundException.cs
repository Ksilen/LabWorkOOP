using System;
using System.Windows.Forms;

namespace WindowsFormsBulldozer
{
    /// Класс-ошибка "Если не найден автомобиль по определенному месту"
    public class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i)
            : base("Не найден автомобиль по месту "+i)
        {
            MessageBox.Show(base.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
