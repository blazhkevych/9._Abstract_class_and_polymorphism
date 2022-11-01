using System.Drawing;

namespace task
{
    internal abstract class Shape
    {
        // Вывод на экран информации о фигуре.
        public abstract string Show();

        // Вычисление площади фигуры.
        public abstract string Area();

        // Сохранение фигуры в файл.
        public abstract void Save(StreamWriter sw);

        // Считывание фигуры из файла.
        public abstract void Load(StreamReader sr);

        protected double GetLength(Point x, Point y)
        {
            return Math.Sqrt(Math.Pow(y.X - x.X, 2) + Math.Pow(y.Y - x.Y, 2));
        }
    }
}
