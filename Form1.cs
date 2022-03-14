using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBulldozer
{
    partial class FormBulldozer : Form
    {
        private Bulldozer _bulldozer;
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
        /// Изменение размеров формы отрисовки
        private void PictureBoxCars_Resize(object sender, EventArgs e)
        {
            _bulldozer.ChangeBorders(pictureBoxForBulldozer.Width, pictureBoxForBulldozer.Height);
            Draw();
        }
        /// Обработка нажатия кнопки "Создать"
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _bulldozer = new Bulldozer();
            _bulldozer.Init(rnd.Next(100, 300), rnd.Next(1000, 2000),
            Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            _bulldozer.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100),
            pictureBoxForBulldozer.Width, pictureBoxForBulldozer.Height);
            toolStripStatusLabel1.Text = "Скорость:" + _bulldozer.Speed;
            toolStripStatusLabel2.Text = "Вес: " + _bulldozer.Weight;
            toolStripStatusLabel3.Text = "Цвет: " + _bulldozer.BodyColor.Name;
            Draw();
        }
        /// Обработка нажатия кнопок управления
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    _bulldozer.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    _bulldozer.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    _bulldozer.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    _bulldozer.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}