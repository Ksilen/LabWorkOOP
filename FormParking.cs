using System;
using System.Drawing;
using System.Windows.Forms;
using log4net;
using log4net.Config;
namespace WindowsFormsBulldozer
{
    public partial class FormParking : Form
    {
        /// Объект от класса-коллекции парковок
        private readonly ParkingCollection _parkingCollection;
        //объект базы данных
        DataBase dateBaseParking;
        //Использовать БД
        public static bool ActiveBD = false;
        /// Конструктор
        public FormParking()
        {
            InitializeComponent();
            Logger.InitLogger();
            _parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            dateBaseParking = new DataBase();
            if (!dateBaseParking.IsOpen())
                dateBaseParking.OpenConnection();
            WorkWithBD.PerformClick();
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
            Logger.Log.Info(String.Format("Добавили парковку {0}", textBoxNewLevelName.Text));
            _parkingCollection.AddParking(textBoxNewLevelName.Text);
            if (ActiveBD) dateBaseParking.setParking(textBoxNewLevelName.Text);
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
                    if (ActiveBD) dateBaseParking.deleteParking(listBoxParkings.SelectedItem.ToString());
                    Logger.Log.Info(String.Format("Удалили парковку {0}", listBoxParkings.SelectedItem));
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
                    if (ActiveBD)
                        dateBaseParking.deleteBulldozer(listBoxParkings.SelectedItem.ToString(), bulldozer.ToString(), maskedTextBox.Text);
                    Logger.Log.Info(String.Format("Изъят автомобиль {0} с места {1}", bulldozer, maskedTextBox.Text));
                }
                else
                {
                    Logger.Log.Error(String.Format("Не найден автомобиль по месту " + maskedTextBox.Text));

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
        }
        /// Метод обработки выбора элемента на listBoxLevels(выбор парковки)
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Log.Info(String.Format("Перешли на парковку " + listBoxParkings.SelectedItem));
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
                try
                {
                    if
                    ((_parkingCollection[listBoxParkings.SelectedItem.ToString()]) + car)
                    {
                        Draw();
                        Logger.Log.Info(String.Format("Добавлен автомобиль {0}", car));
                        if (FormParking.ActiveBD) dateBaseParking.setBulldozer(car.ToString(), listBoxParkings.SelectedItem.ToString());
                        ValueSelectedParking.SelectedParking = listBoxParkings.SelectedItem.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Машину не удалось поставить");
                        Logger.Log.Error(String.Format("Парковка {0} переполнена. Машину не удалось поставить.",listBoxParkings.SelectedItem.ToString()));
                    }
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                foreach (var parking in _parkingCollection)
                {
                    _parkingCollection[parking.ToString()].Sort();
                }
                _parkingCollection.Reset();
                Draw();
                Logger.Log.Info("Сортировка уровней");
            }
        }
        //Меню Включить работу с Базой Данных
        private void WorkWithBD_Click(object sender, EventArgs e)
        {
            if (!ActiveBD)
            {
                this.WorkWithBD.Text = "Выкл. работу с БД";
                ActiveBD = true;  // Включает добавление, удаление записей в БД
                dateBaseParking.NewDataBase(); //Если БД пуста создать 5 парковок
                dateBaseParking.loadFromDB();
                _parkingCollection.LoadData("tempDataBase.txt");
                ReloadLevels(_parkingCollection);
                Draw();
            }
            else
            {
                this.WorkWithBD.Text = "Вкл. работу с БД";
                ActiveBD = false;
            }
        }
        public void reloadPark()
        {
            WorkWithBD.PerformClick();
            WorkWithBD.PerformClick();
        }
        //Меню Сформировать отчет
        private void Report_Click(object sender, EventArgs e)
        {
            DataBaseForm DBForm = new DataBaseForm(new MyDelegate(reloadPark));
            DBForm.ShowDialog();
        }
        /// Обработка нажатия пункта меню "Сохранить"
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_parkingCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.Log.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// Обработка нажатия пункта меню "Загрузить"
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_parkingCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.Log.Info("Загружено из файла " + openFileDialog.FileName);
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

        private void button1_Click(object sender, EventArgs e)
        {
            dateBaseParking.DeleteAllFromBD();
        }
    }
}

