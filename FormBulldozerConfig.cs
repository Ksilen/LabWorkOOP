using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBulldozer
{
    public partial class FormBulldozerConfig : Form
    {
        /// Переменная-выбранная машина
        Bulldozer _car = null;
        /// Событие
        private event BulldozerDelegate EventAddCar;
        //Объект базы данных
        DataBase dateBaseBulldozer;
        /// Конструктор
        public FormBulldozerConfig()
        {
            InitializeComponent();
            dateBaseBulldozer = new DataBase();
            if (!dateBaseBulldozer.IsOpen())
                dateBaseBulldozer.OpenConnection();
        }
        /// Отрисовать машину
        private void DrawCar()
        {
            if (_car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxBulldozer.Width,
                pictureBoxBulldozer.Height);
                Graphics gr = Graphics.FromImage(bmp);
                _car.SetObject(17, 5, pictureBoxBulldozer.Width,
                pictureBoxBulldozer.Height);
                _car.DrawTransport(gr);
                pictureBoxBulldozer.Image = bmp;
            }
        }
        /// Добавление события
        public void AddEvent(BulldozerDelegate ev)
        {
            if (EventAddCar == null)
            {
                EventAddCar = new BulldozerDelegate(ev);
            }
            else
            {
                EventAddCar += ev;
            }
        }
        /// Передаем информацию при нажатии на Label
        private void LabelObject_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).DoDragDrop((sender as Label).Name,
            DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        private void PanelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// Действия при приеме перетаскиваемой информации
        private void PanelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "SimpleBulldozer":
                    _car = new Bulldozer((int)numeriсMaxSpeed.Value,
                    (int)numericWeight.Value, Color.Green);
                    break;
                case "labelSuperBulldozer":
                    _car = new
                    SuperBulldozer((int)numeriсMaxSpeed.Value, (int)numericWeight.Value, Color.White,
                    Color.Black,
                    frontBucket.Checked,
                    sportLine.Checked, backBucket.Checked, flasher.Checked);
                    break;
            }
            DrawCar();
        }
        /// Отправляем цвет с панели
        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Panel).DoDragDrop((sender as Panel).BackColor,
            DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        private void LabelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// Принимаем основной цвет
        private void LabelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (_car is Bulldozer || _car is SuperBulldozer)  //Чтоб не вылетала, когда нет объекта
                _car.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawCar();
        }
        /// Принимаем дополнительный цвет
        private void LabelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (_car is SuperBulldozer)
                (_car as SuperBulldozer).SetDopColor((Color)e.Data.GetData(typeof(Color)));
            DrawCar();
        }
        //Кнопка Отмена
        private void buttonCloseConfig_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Кнопка добавить объект на парковку
        private void buttonAddCarFromConfig_Click(object sender, EventArgs e)
        {
            if (EventAddCar != null)
            {
                EventAddCar.Invoke(_car);
                string ParkingNow = ValueSelectedParking.SelectedParking.ToString();
            }
            Close();
        }
    }
}
