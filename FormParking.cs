using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBulldozer
{
    public partial class FormParking : Form
    {
        /// Объект от класса-коллекции парковок
        private readonly ParkingCollection _parkingCollection;
        /// Конструктор
        public FormParking()
        {
            InitializeComponent();
            _parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
        }
        /// Заполнение listBoxLevels
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < _parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(_parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >=
            listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index <
            listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }
        /// Метод отрисовки парковки
        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                _parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        /// Обработка нажатия кнопки "Добавить парковку" 
        private void AddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        /// Обработка нажатия кнопки "Удалить парковку" 
        private void DelParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {

                if (MessageBox.Show(String.Format("Удалить парковку {0}", listBoxParkings.SelectedItem), 
                    "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                    if (_parkingCollection.Keys.Count == 0)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        pictureBoxParking.Image = bmp;
                    }
                }
            }
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
                Draw();
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
            if (maskedTextBox.Text != "")
            {
                var bulldozer = _parkingCollection[listBoxParkings.SelectedItem.ToString()] -
Convert.ToInt32(maskedTextBox.Text);
                if (bulldozer != null)
                {
                    FormBulldozer form = new FormBulldozer();
                    bulldozer.SetObject(17, 10, form.Width - 80, form.Height - 50);
                    form.SetBulldozer(bulldozer);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        /// Добавление объекта в класс-хранилище
        private void AddToParking(Bulldozer bulldozer)
        {
            if (_parkingCollection[listBoxParkings.SelectedItem.ToString()] + bulldozer)
            {
                Draw();
            }
            else
            {
                MessageBox.Show("Парковка переполнена");
            }
        }
        /// Метод обработки выбора элемента на listBoxLevels
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
