namespace task
{
    internal class Rectangle : Shape
    {
        private double _upperLeftCornerCoordinate_X;     // Координата левого верхнего угла X.
        private double _upperLeftCornerCoordinate_Y;     // Координата левого верхнего угла Y.
        private double _bottomRightCornerCoordinate_X;   // Координата правого нижнего угла X.
        private double _bottomRightCornerCoordinate_Y;   // Координата правого нижнего угла Y.

        public Rectangle(double upperLeftCornerCoordinateX, double upperLeftCornerCoordinateY,
            double bottomRightCornerCoordinateX, double bottomRightCornerCoordinateY)
        {
            _upperLeftCornerCoordinate_X = upperLeftCornerCoordinateX;
            _upperLeftCornerCoordinate_Y = upperLeftCornerCoordinateY;
            _bottomRightCornerCoordinate_X = bottomRightCornerCoordinateX;
            _bottomRightCornerCoordinate_Y = bottomRightCornerCoordinateY;
        }

        // Вывод на экран информации о фигуре.
        public override string Show()
        {
            string s = new($"Rectangle." +
                           $"\nКоордината левого верхнего угла: {_upperLeftCornerCoordinate_X}, {_upperLeftCornerCoordinate_Y}" +
                           $"\nКоордината правого нижнего угла: {_bottomRightCornerCoordinate_X}, {_bottomRightCornerCoordinate_Y}");
            return s;
        }

        // Вычисление площади фигуры.
        public override string Area()
        {
            double width = Math.Abs(_upperLeftCornerCoordinate_X - _bottomRightCornerCoordinate_X); // TODO:возможно нужно поменять местами
            double height = Math.Abs(_upperLeftCornerCoordinate_Y - _bottomRightCornerCoordinate_Y); // TODO:возможно нужно поменять местами
            string s = new($"Площадь: {width * height}");
            return s;
        }

        // Сохранение фигуры в файл.
        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("Rectangle");
            sw.WriteLine(_upperLeftCornerCoordinate_X);
            sw.WriteLine(_upperLeftCornerCoordinate_Y);
            sw.WriteLine(_bottomRightCornerCoordinate_X);
            sw.WriteLine(_bottomRightCornerCoordinate_Y);
        }

        // Считывание фигуры из файла.
        public override void Load(StreamReader sr)
        {
            _upperLeftCornerCoordinate_X = Convert.ToDouble(sr.ReadLine());
            _upperLeftCornerCoordinate_Y = Convert.ToDouble(sr.ReadLine());
            _bottomRightCornerCoordinate_X = Convert.ToDouble(sr.ReadLine());
            _bottomRightCornerCoordinate_Y = Convert.ToDouble(sr.ReadLine());
        }
    }
}
