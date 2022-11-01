namespace task
{
    internal class Triangle : Shape
    {
        private double _cat1;          // Катет 1.
        private double _cat2;          // Катет 2.
        private double _hypotenuse;     // Гипотенуза.

        // Конструктор со всеми параметрами.
        public Triangle(double cat1, double cat2, double hypotenuse)
        {
            _cat1 = cat1;
            _cat2 = cat2;
            _hypotenuse = hypotenuse;
        }

        // Вывод на экран информации о фигуре.
        public override string Show()
        {
            string s = new($"Triangle." +
                           $"\nКатет 1: {_cat1}" +
                           $"\nКатет 2: {_cat2}" +
                           $"\nГипотенуза: {_hypotenuse}");
            return s;
        }

        // Вычисление площади фигуры.
        public override string Area()
        {
            double p = _cat1 + _cat2 + _hypotenuse; // Периметр.
            string s = new($"Площадь: {Math.Sqrt(p / 2 * (p / 2 - _cat1) * (p / 2 - _cat2) * (p / 2 - _hypotenuse))}"); //  проблема с формулой
            return s;
        }

        // Сохранение фигуры в файл.
        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("Triangle");
            sw.WriteLine(_cat1);
            sw.WriteLine(_cat2);
            sw.WriteLine(_hypotenuse);
        }

        // Считывание фигуры из файла.
        public override void Load(StreamReader sr)
        {
            _cat1 = double.Parse(sr.ReadLine());
            _cat2 = double.Parse(sr.ReadLine());
            _hypotenuse = double.Parse(sr.ReadLine());
        }
    }
}
