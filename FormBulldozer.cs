using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBulldozer
{
    partial class FormBulldozer : Form
    {
        private ITransport _bulldozer;
        /// Конструктор
        public FormBulldozer()
        {
            InitializeComponent();
        }
        /// Передача машины на форму
        public void SetBulldozer(ITransport bulldozer)
        {
            _bulldozer = bulldozer;
            this.MinimumSize = new System.Drawing.Size(150 + ((int)bulldozer.Step), 0);
            Draw();
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
        private void pictureBoxForBulldozer_Resize(object sender, EventArgs e)
        {
            _bulldozer.ChangeBorders(pictureBoxForBulldozer.Width, pictureBoxForBulldozer.Height);
            Draw();
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
    }
}