namespace WindowsFormsBulldozer
{
    /// Класс с общей логикой тестирования объекта
    public abstract class AbstractTestObject
    {
        /// Ширина окна отрисовки
        protected int _pictureWidth;
        /// Высота окна отрисовки
        protected int _pictureHeight;
        /// Объект тестирования
        protected IDrawObject _object;
        /// Передача объекта
        public void Init(IDrawObject obj)
        {
            _object = obj;
        }
        /// Логика установки позиции объекта
        /// <returns>true - установка прошла успешно, false - не хватает данных
        //для установки</returns>
        public virtual bool SetPosition(int pictureWidth, int pictureHeight)
        {
            if (_object == null)
            {
                return false;
            }
            if (pictureWidth == 0 || pictureHeight == 0)
            {
                return false;
            }
            _object.SetObject(0, 0, pictureWidth, pictureHeight);
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
            return true;
        }
        /// Тестирование объекта
        /// <returns>Результат тестирования</returns>
        public abstract string TestObject();
    }
}