namespace WindowsFormsBulldozer
{
    public class BordersTestObject : AbstractTestObject
    {
        public override string TestObject()
        {
            if (_object == null)
            {
                return "Объект не установлен";
            }
            else
            {
                _object.GetPosition();
            }
            while (_object.MoveObject(Direction.Right))
            {
                if (_object.GetRight() > _pictureWidth)
                {
                    return "Объект вышел за правый край";
                }
            }
            while (_object.MoveObject(Direction.Down))
            {
                if (_object.GetBottom() > _pictureHeight)
                {
                    return "Объект вышел за нижний край";
                }
            }
            while (_object.MoveObject(Direction.Left))
            {
                if (_object.GetLeft() < 0)
                {
                    return "Объект вышел за левый край";
                }
            }
            while (_object.MoveObject(Direction.Up))
            {
                if (_object.GetTop() < 0)
                {
                    return "Объект вышел за верхний край";
                }
            }
            return "Тест проверки выхода за границы пройден успешно";
        }
        public float pictureBoxForBulldozer { get; set; }
    }
}