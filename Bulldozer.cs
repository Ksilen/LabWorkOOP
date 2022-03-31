using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBulldozer
{
    public class Bulldozer : ITransport, IEquatable<Bulldozer>
    {
        /// Разделитель для записи информации по объекту в файл
        protected readonly char _separator = ';';
        /// Скорость
        public int Speed { private set; get; }
        /// Вес автомобиля
        public float Weight { private set; get; }
        // Шаг автомобиля
        public float Step { private set; get; }
        /// Цвет кузова
        public Color BodyColor { private set; get; }
        /// Левая координата отрисовки автомобиля
        protected float? _startPosX = null;
        /// Верхняя кооридната отрисовки автомобиля
        protected float? _startPosY = null;
        /// Ширина окна отрисовк
        protected int? _pictureWidth = null;
        /// Высота окна отрисовки
        protected int? _pictureHeight = null;
        /// Ширина отрисовки автомобиля
        public readonly int _BulldozerWidth = 85;
        /// Высота отрисовки автомобиля
        public readonly int _BulldozerHeight = 65;
        /// Признак, что объект переместился
        protected bool _makeStep;
        /// Конструкторы
        public Bulldozer(int speed, float weight, Color bodyColor)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
            Step = Speed * 100 / Weight;
        }
        /// Конструктор для загрузки с файла
        public Bulldozer(string info)
        {
            string[] strs = info.Split(_separator);
            if (strs.Length >= 3)
            {
                Speed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                BodyColor = Color.FromName(strs[2]);
                Step = Speed * 100 / Weight;
            }
        }
        public override string ToString()
        {
            String str = String.Format("{0};{1};{2}", Speed, Weight, BodyColor.Name);
            return str;
        }
        public void SetMainColor(Color color)
        {
            BodyColor = color;
        }
        protected Bulldozer(int speed, float weight, Color bodyColor, int BulldozerWidth, int BulldozerHeight)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
            _BulldozerWidth = BulldozerWidth;
            _BulldozerHeight = BulldozerHeight;
            Step = Speed * 100 / Weight;
        }
        /// Изменение направления пермещения
        public virtual void MoveTransport(Direction direction, int leftIndent = 0, int topIndent = 0)
        {
            _makeStep = false;
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + _BulldozerWidth + Step < _pictureWidth)
                    {
                        _startPosX += Step;
                        _makeStep = true;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - Step > leftIndent)
                    {
                        _startPosX -= Step;
                        _makeStep = true;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - Step > topIndent)
                    {
                        _startPosY -= Step;
                        _makeStep = true;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + _BulldozerHeight + Step < _pictureHeight)
                    {
                        _startPosY += Step;
                        _makeStep = true;
                    }
                    break;
            }
        }
        /// Отрисовка трактора
        public virtual void DrawTransport(Graphics g)
        {
            if (!_startPosX.HasValue || !_startPosX.HasValue)
            {
                return;
            }
            Pen pen = new Pen(Color.Black);
            Brush brBrown = new SolidBrush(Color.SaddleBrown);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBrown, _startPosX.Value + 10, _startPosY.Value, 24, 20);//кабина
            g.DrawRectangle(pen, _startPosX.Value + 10, _startPosY.Value, 24, 20);
            g.FillRectangle(brBlue, _startPosX.Value + 14, _startPosY.Value + 4, 16, 15);//стекло
            g.DrawRectangle(pen, _startPosX.Value + 14, _startPosY.Value + 4, 16, 15);
            g.FillRectangle(brBrown, _startPosX.Value + 10, _startPosY.Value + 20, 60, 20);//корпус
            g.DrawRectangle(pen, _startPosX.Value + 10, _startPosY.Value + 20, 60, 20);
            g.FillRectangle(brBrown, _startPosX.Value + 55, _startPosY.Value + 2, 7, 18);//труба
            g.DrawRectangle(pen, _startPosX.Value + 55, _startPosY.Value + 2, 7, 18);
            Pen penBlack = new Pen(Color.Black, 3);
            g.DrawArc(pen, _startPosX.Value + 0, _startPosY.Value + 40, 20, 21, -270, 180);//контур гусениц
            g.DrawArc(pen, _startPosX.Value + 60, _startPosY.Value + 40, 20, 21, 270, 180);
            g.DrawLine(pen, _startPosX.Value + 10, _startPosY.Value + 61, _startPosX.Value + 70, _startPosY.Value + 61);
            Brush br = new SolidBrush(BodyColor);
            g.DrawEllipse(penBlack, _startPosX.Value + 3, _startPosY.Value + 43, 15, 15);//колеса гусениц
            g.DrawEllipse(penBlack, _startPosX.Value + 62, _startPosY.Value + 43, 15, 15);
            g.FillEllipse(br, _startPosX.Value + 3, _startPosY.Value + 43, 15, 15);
            g.FillEllipse(br, _startPosX.Value + 62, _startPosY.Value + 43, 15, 15);
            g.DrawEllipse(penBlack, _startPosX.Value + 30, _startPosY.Value + 42, 5, 5);
            g.DrawEllipse(penBlack, _startPosX.Value + 47, _startPosY.Value + 42, 5, 5);
            g.DrawEllipse(penBlack, _startPosX.Value + 37, _startPosY.Value + 51, 7, 7);
            g.DrawEllipse(penBlack, _startPosX.Value + 22, _startPosY.Value + 51, 7, 7);
            g.DrawEllipse(penBlack, _startPosX.Value + 52, _startPosY.Value + 51, 7, 7);
        }
        /// Установка позиции трактора
        public virtual void SetObject(float x, float y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// Изменение направления пермещения
        public bool MoveObject(Direction direction)
        {
            MoveTransport(direction);
            return _makeStep;
        }
        public void DrawObject(Graphics g)
        {
            DrawTransport(g);
        }
        /// Смена границ формы отрисовки
        public void ChangeBorders(int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (_startPosX + _BulldozerWidth > width)
            {
                _startPosX = width - _BulldozerWidth;
            }
            if (_startPosY + _BulldozerHeight > height)
            {
                _startPosY = height - _BulldozerHeight;
            }
        }
        /// Метод интерфейса IEquatable для класса Bulldozer
        public bool Equals(Bulldozer other)
        {
            // Продумать логику сравнения
            if (this.ToString() == other.ToString())
                return true;
            return false;
        }
    }
}