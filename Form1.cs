using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBulldozer
{
    partial class FormBulldozer : Form
    {
        private Bulldozer _bulldozer;
        /// Конструктор
        public FormBulldozer()
        {
            InitializeComponent();
        }
        // Метод отрисовки машины
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxForBulldozer.Width, pictureBoxForBulldozer.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _bulldozer.DrawTransport(gr);
            pictureBoxForBulldozer.Image = bmp;
        }
        /// Метод установки объекта на форме
        private void SetObject(Random rnd)
        {
            _bulldozer.SetObject(rnd.Next(16, 100), rnd.Next(10, 100),
            pictureBoxForBulldozer.Width, pictureBoxForBulldozer.Height);
            toolStripStatusLabel1.Text = "Скорость:" + _bulldozer.Speed;
            toolStripStatusLabel2.Text = "Вес: " + _bulldozer.Weight;
            toolStripStatusLabel3.Text = "Цвет: " + _bulldozer.BodyColor.Name;
            Draw();
        }
        /// Проведение теста
        private void RunTest(AbstractTestObject testObject)
        {
            testObject.Init(_bulldozer);
            testObject.SetPosition(pictureBoxForBulldozer.Width,
            pictureBoxForBulldozer.Height);
            MessageBox.Show(testObject.TestObject());
            if (testObject.TestObject() == "Объект не установлен") return;
            _bulldozer.SetObject(_bulldozer.CurrentPos.Left, _bulldozer.CurrentPos.Top,
                pictureBoxForBulldozer.Width, pictureBoxForBulldozer.Height);
        }
        /// Изменение размеров формы отрисовки
        private void pictureBoxForBulldozer_Resize(object sender, EventArgs e)
        {
            _bulldozer.ChangeBorders(pictureBoxForBulldozer.Width, pictureBoxForBulldozer.Height);
            Draw();
        }
        /// Обработка нажатия кнопки "Создать"
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _bulldozer = new Bulldozer(rnd.Next(100, 300), rnd.Next(1000, 2000),
            Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            SetObject(rnd);
        }
        /// Обработка нажатия кнопки "Модификация"
        private void buttonCreateModifer_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _bulldozer = new SportCar(rnd.Next(100, 300), rnd.Next(1000, 2000),
            Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
            Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256),
            rnd.Next(0, 256)), true, true, true, true);
            SetObject(rnd);
        }
        /// Обработка нажатия кнопок управления
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    _bulldozer.MoveObject(Direction.Up);
                    break;
                case "buttonDown":
                    _bulldozer.MoveObject(Direction.Down);
                    break;
                case "buttonLeft":
                    _bulldozer.MoveObject(Direction.Left);
                    break;
                case "buttonRight":
                    _bulldozer.MoveObject(Direction.Right);
                    break;
            }
            Draw();
        }
        /// Обработка нажатия кнопки "Провести тест по границам"
        private void ButtonRunBorderTest_Click(object sender, EventArgs e)
        {
            switch (comboBoxTest.SelectedIndex)
            {
                case 0:
                    RunTest(new BordersTestObject());
                    break;
            }
        }





    }
}