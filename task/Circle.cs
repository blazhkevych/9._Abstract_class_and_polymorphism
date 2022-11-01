namespace task
{
    internal class Circle : Shape
    {
        // Координата центра.
        private double _centerCoordinate_X;
        public double CenterCoordinate_X
        {
            get => _centerCoordinate_X;
            set => _centerCoordinate_X = value;
        }

        private double _centerCoordinate_Y;
        public double CenterCoordinate_Y
        {
            get => _centerCoordinate_X;
            set => _centerCoordinate_X = value;
        }

        // Радиус.
        private double _radius;
        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }

        // Конструктор с всеми параметрами.
        public Circle(double centerCoordinate_X, double centerCoordinate_Y, double radius)
        {
            _centerCoordinate_X = centerCoordinate_X;
            _centerCoordinate_Y = centerCoordinate_Y;
            _radius = radius;
        }

        // Вывод на экран информации о фигуре.
        public override string Show()
        {
            string s = new($"Circle." +
                           $"\nКоордината центра: {_centerCoordinate_X}, {_centerCoordinate_Y}" +
                           $"\nРадиус: {_radius}");
            return s;
        }

        // Вычисление площади фигуры.
        public override string Area()
        {
            string s = new($"Площадь: {Math.PI * Math.Pow(_radius, 2)}");
            return s;
        }

        // Сохранение фигуры в файл.
        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("Circle");
            sw.WriteLine(CenterCoordinate_X);
            sw.WriteLine(CenterCoordinate_Y);
            sw.WriteLine(Radius);
        }

        // Считывание фигуры из файла.
        public override void Load(StreamReader sr)
        {
            CenterCoordinate_X = Convert.ToDouble(sr.ReadLine());
            CenterCoordinate_Y = Convert.ToDouble(sr.ReadLine());
            Radius = Convert.ToDouble(sr.ReadLine());
        }
    }
}
