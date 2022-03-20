using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBulldozer
{
    public partial class FormParking : Form
    {
        /// Объект от класса-коллекции парковок
        private readonly ParkingCollection _parkingCollection;
        ///логгер
        public MyLogger logger;
        /// Конструктор
        public FormParking()
        {
            InitializeComponent();
            _parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            logger = new MyLogger();
        }
        /// Заполнение listBoxLevels
        private void ReloadLevels(ParkingCollection _parkingCollection)
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
            logger.Info(String.Format("Добавили парковку {0}", textBoxNewLevelName.Text));
            _parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels(_parkingCollection);
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
                    logger.Info(String.Format("Удалили парковку {0}", listBoxParkings.SelectedItem));
                    ReloadLevels(_parkingCollection);
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
            if (maskedTextBox.Text != "" && listBoxParkings.SelectedItem != null)
            {
                var bulldozer = _parkingCollection[listBoxParkings.SelectedItem.ToString()] -
Convert.ToInt32(maskedTextBox.Text);
                if (bulldozer != null)
                {
                    FormBulldozer form = new FormBulldozer();
                    bulldozer.SetObject(17, 10, form.Width - 80, form.Height - 50);
                    form.SetBulldozer(bulldozer);
                    form.ShowDialog();
                    logger.Info(String.Format("Изъят автомобиль {0} с места {1}", bulldozer, maskedTextBox.Text));
                }
                else
                {
                    logger.Warning("Не найден автомобиль по месту " + maskedTextBox.Text);
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
                logger.Warning("На парковке нет свободных мест");
            }
        }
        /// Метод обработки выбора элемента на listBoxLevels(выбор парковки)
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info(String.Format("Перешли на парковку " + listBoxParkings.SelectedItem));
            Draw();
        }
        // Нажатие "Добавить автомобиль"
        private void AddBulldozer_Click(object sender, EventArgs e)
        {
            FormBulldozerConfig FormConfig = new FormBulldozerConfig();
            FormConfig.AddEvent(AddCar);
            FormConfig.ShowDialog();
        }
        /// Метод добавления машины
        private void AddCar(Bulldozer car)
        {
            if (car != null && listBoxParkings.SelectedIndex > -1)
            {
                if
                ((_parkingCollection[listBoxParkings.SelectedItem.ToString()]) + car)
                {
                    Draw();
                    logger.Info("Добавлен автомобиль " + car);
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }
        /// Обработка нажатия пункта меню "Сохранить"
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_parkingCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// Обработка нажатия пункта меню "Загрузить"
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_parkingCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels(_parkingCollection);
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

