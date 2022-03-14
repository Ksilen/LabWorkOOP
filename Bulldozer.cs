using System.Drawing;

namespace WindowsFormsBulldozer
{
    class Bulldozer
    {
        /// Скорость
        public int Speed { private set; get; }
        /// Вес автомобиля
        public float Weight { private set; get; }
        /// Цвет кузова
        public Color BodyColor { private set; get; }
        /// Левая координата отрисовки автомобиля
        private float? _startPosX = null;
        /// Верхняя кооридната отрисовки автомобиля
        private float? _startPosY = null;
        /// Ширина окна отрисовк
        private int? _pictureWidth = null;
        /// Высота окна отрисовки
        private int? _pictureHeight = null;
        /// Ширина отрисовки автомобиля
        protected readonly int _carWidth = 85;
        /// Высота отрисовки автомобиля
        protected readonly int _carHeight = 50;
        /// Инициализация свойств
        public void Init(int speed, float weight, Color bodyColor)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
        }
        /// Установка позиции автомобиля
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// Смена границ формы отрисовки
        public void ChangeBorders(int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (_startPosX + _carWidth > width)
            {
                _startPosX = width - _carWidth;
            }
            if (_startPosY + _carHeight > height)
            {
                _startPosY = height - _carHeight-20;
            }
        }
        /// Изменение направления пермещения
        public void MoveTransport(Direction direction)
        {
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            float step = Speed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + _carWidth + step < _pictureWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + _carHeight + step < _pictureHeight-step)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// Отрисовка трактора
        public void DrawTransport(Graphics g)
        {
            if (!_startPosX.HasValue || !_startPosY.HasValue)
            {
                return;
            }
            Pen pen = new Pen(Color.Black);
            Brush brBrown = new SolidBrush(Color.SaddleBrown);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBrown, _startPosX.Value + 10, _startPosY.Value + 5, 24, 20);//кабина
            g.DrawRectangle(pen, _startPosX.Value + 10, _startPosY.Value + 5, 24, 20);
            g.FillRectangle(brBlue, _startPosX.Value + 14, _startPosY.Value + 9, 16, 15);//стекло
            g.DrawRectangle(pen, _startPosX.Value + 14, _startPosY.Value + 9, 16, 15);
            g.FillRectangle(brBrown, _startPosX.Value + 10, _startPosY.Value + 25, 60, 20);//корпус
            g.DrawRectangle(pen, _startPosX.Value + 10, _startPosY.Value + 25, 60, 20);
            g.FillRectangle(brBrown, _startPosX.Value + 55, _startPosY.Value + 7, 7, 18);//труба
            g.DrawRectangle(pen, _startPosX.Value + 55, _startPosY.Value + 7, 7, 18);
            Pen penBlack = new Pen(Color.Black, 3);
            g.DrawArc(pen, _startPosX.Value + 0, _startPosY.Value + 45, 20, 21, -270, 180);//контур гусениц
            g.DrawArc(pen, _startPosX.Value + 60, _startPosY.Value + 45, 20, 21, 270, 180);
            g.DrawLine(pen, _startPosX.Value + 10, _startPosY.Value + 66, _startPosX.Value + 70, _startPosY.Value + 66);
            Brush br = new SolidBrush(BodyColor);
            g.DrawEllipse(penBlack, _startPosX.Value + 3, _startPosY.Value + 48, 15, 15);//колеса гусениц
            g.DrawEllipse(penBlack, _startPosX.Value + 62, _startPosY.Value + 48, 15, 15);
            g.FillEllipse(br, _startPosX.Value + 3, _startPosY.Value + 48, 15, 15);
            g.FillEllipse(br, _startPosX.Value + 62, _startPosY.Value + 48, 15, 15);
            g.DrawEllipse(penBlack, _startPosX.Value + 30, _startPosY.Value + 47, 5, 5);
            g.DrawEllipse(penBlack, _startPosX.Value + 47, _startPosY.Value + 47, 5, 5);
            g.DrawEllipse(penBlack, _startPosX.Value + 37, _startPosY.Value + 56, 7, 7);
            g.DrawEllipse(penBlack, _startPosX.Value + 22, _startPosY.Value + 56, 7, 7);
            g.DrawEllipse(penBlack, _startPosX.Value + 52, _startPosY.Value + 56, 7, 7);
        }
    }
}