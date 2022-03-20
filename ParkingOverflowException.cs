using System;
using System.Windows.Forms;

namespace WindowsFormsBulldozer
{   /// Класс-ошибка "Если на парковке уже заняты все места"
    class ParkingOverflowException : Exception
    {
        public ParkingOverflowException()
            : base("На парковке нет свободных мест")
        {
            MessageBox.Show(base.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
