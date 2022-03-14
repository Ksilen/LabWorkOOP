using System.Drawing;

namespace WindowsFormsBulldozer
{
    /// Класс отрисовки гоночного автомобиля
    class SportCar : Bulldozer
    {
        /// Дополнительный цвет
        public Color DopColor { private set; get; }
        /// Признак наличия переднего спойлера
        public bool FrontBucket { private set; get; }
        /// Признак наличия боковых спойлеров
        public bool Flasher { private set; get; }
        /// Признак наличия заднего спойлера
        public bool BackBucket { private set; get; }
        /// Признак наличия гоночной полосы
        public bool SportLine { private set; get; }
        /// Инициализация свойств
        /// <param name="maxSpeed">Скорость</param>
        /// <param name="weight">Вес</param>
        /// <param name="bodyColor">Цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontBucket">Признак наличия переднего ковша</param>
        /// <param name="flasher">Признак наличия мигалки(проблескового маячка)</param>
        /// <param name="backBucket">Признак наличия заднего ковша</param>
        /// <param name="sportLine">Признак наличия гоночной полосы</param>
        public SportCar(int speed, float weight, Color bodyColor, Color dopColor,
        bool frontBucket, bool flasher, bool backBucket, bool sportLine) :
            base(speed, weight, bodyColor, 100, 60)
        {
            DopColor = dopColor;
            FrontBucket = frontBucket;
            Flasher = flasher;
            BackBucket = backBucket;
            SportLine = sportLine;
        }
        public override void MoveTransport(Direction direction, int leftIndent = 32, int topIndent = 5)
        {
            leftIndent = 32;
            topIndent = 5;
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
                    if (_startPosX - leftIndent - Step > 0)
                    {       
                        _startPosX -= Step;
                        _makeStep = true;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - topIndent - Step > 0)
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
        public override void SetObject(float x, float y, int width, int height)
        {
            _startPosX = x+16;
            _startPosY = y+2;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public override void DrawTransport(Graphics g)
        {
            if (!_startPosX.HasValue || !_startPosX.HasValue)
            {
                return;
            }
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            //  передний ковш
            if (FrontBucket)
            {             
                g.FillRectangle(dopBrush, _startPosX.Value + 70, _startPosY.Value + 30, 15, 10);
                g.FillRectangle(dopBrush, _startPosX.Value + 85, _startPosY.Value + 20, 5, 40);
                g.FillRectangle(dopBrush, _startPosX.Value + 90, _startPosY.Value + 55,10, 5);
                g.DrawRectangle(pen, _startPosX.Value + 70, _startPosY.Value + 30, 15, 10);
                g.DrawRectangle(pen, _startPosX.Value + 85, _startPosY.Value + 20, 5, 40);
                g.DrawRectangle(pen, _startPosX.Value + 90, _startPosY.Value + 55, 10, 5);
            }
            // рисуем задний ковш
            if (BackBucket)
            {                g.FillRectangle(dopBrush, _startPosX.Value-5, _startPosY.Value + 25, 20, 10);
                g.FillRectangle(dopBrush, _startPosX.Value - 15, _startPosY.Value + 30,10 , 20);
                g.DrawRectangle(pen, _startPosX.Value - 15, _startPosY.Value + 30, 10, 20);
                g.FillEllipse(dopBrush, _startPosX.Value - 32,_startPosY.Value + 32, 30, 30);
                g.DrawRectangle(pen, _startPosX.Value - 5, _startPosY.Value + 25, 20, 10);       
                g.DrawEllipse(pen, _startPosX.Value - 32, _startPosY.Value + 32, 30, 30);
            }
            // рисуем мигалку
            if (Flasher)
            {
                g.FillEllipse(dopBrush, _startPosX.Value+16, _startPosY.Value -5, 12, 30);
                g.DrawEllipse(pen, _startPosX.Value + 16, _startPosY.Value - 5, 12, 30);
            }
                base.DrawTransport(g);
            // рисуем гоночные полоски
                if (SportLine)
                {
                    g.FillRectangle(dopBrush, _startPosX.Value+10, _startPosY.Value + 23, 60, 1);
                    g.FillRectangle(dopBrush, _startPosX.Value + 10, _startPosY.Value + 25, 60, 1);
                    g.FillRectangle(dopBrush, _startPosX.Value + 50, _startPosY.Value + 28, 20, 1);
                    g.FillRectangle(dopBrush, _startPosX.Value + 50, _startPosY.Value + 31, 20, 1);
                    g.FillRectangle(dopBrush, _startPosX.Value + 50, _startPosY.Value + 34, 20, 1);
                }
            }
        }
    }
