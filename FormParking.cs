using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBulldozer
{
    public partial class FormParking : Form
    {
        /// Объект от класса-парковки
        public readonly Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(pictureBoxParking.Width,
            pictureBoxParking.Height);
            Draw();
        }
        /// Метод отрисовки парковки
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width,
            pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// Обработка нажатия кнопки "Припарковать бульдозер"
        private void ButtonSetBulldozer_Click(object sender, EventArgs e)
        {
            Random colorRand = new Random();
            ColorDialog dialog = new ColorDialog();
            dialog.Color = Color.FromArgb(100, colorRand.Next(0, 255), colorRand.Next(0, 255), colorRand.Next(0, 255));
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AddToParking(new Bulldozer(100, 1000, dialog.Color));
            }
        }
        /// Обработка нажатия кнопки "Припарковать супер бульдозер"
        private void ButtonSetSuperBulldozer_Click(object sender, EventArgs e)
        {
            Random colorRand = new Random();
            ColorDialog dialog = new ColorDialog();
            dialog.Color = Color.FromArgb(255, colorRand.Next(0, 255), colorRand.Next(0, 255), colorRand.Next(0, 255));
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Random colorRandD = new Random();
                ColorDialog dialogDop = new ColorDialog();
                dialogDop.Color = Color.FromArgb(255, colorRandD.Next(0, 255), colorRandD.Next(0, 255), colorRandD.Next(0, 255));
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    AddToParking(new SuperBulldozer(100, 1000, dialog.Color,
                    dialogDop.Color, true, true, true, true));
                }
            }
        }
        /// Обработка нажатия кнопки "Забрать"
        private void ButtonTakeBulldozer_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "" && Convert.ToInt32(maskedTextBox.Text) < parking._places.Length)
            {
                var bulldozer = parking - Convert.ToInt32(maskedTextBox.Text);
                if (bulldozer != null)
                {
                    FormBulldozer form = new FormBulldozer();
                    bulldozer.SetObject(17, 10, form.Width - 80, form.Height - 50);
                    form.SetBulldozer(bulldozer);
                    form.ShowDialog();
                    parking.NotStaticIndexOfPlace--;
                }
                Draw();
            }
        }
        /// Добавление объекта в класс-хранилище
        private void AddToParking(Bulldozer bulldozer)
        {
            if (parking + bulldozer)
            {
                parking.NotStaticIndexOfPlace++;
                Draw();
            }
            else
            {
                MessageBox.Show("Парковка переполнена");
            }
        }
    }
}