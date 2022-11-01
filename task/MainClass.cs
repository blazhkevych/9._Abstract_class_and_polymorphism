namespace task
{
    // Реализует пользовательский интерфейс приложения, и демонстрируюет работу с программой.
    internal class MainClass
    {
        // Массив ссылок типа Shape.
        private List<Shape> _listOfShapes = new List<Shape>(100);

        // Добавление фигуры в массив.
        private void AddShape(int shapeType)
        {
            switch (shapeType)
            {
                case 1: // Circle
                    double x, y, r;
                    Console.WriteLine("\nВведите координаты центра." +
                                      "\nX: ");
                    try
                    {
                        x = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        x = 0;
                    }

                    Console.WriteLine("\nY:");
                    try
                    {
                        y = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        y = 0;
                    }

                    Console.WriteLine("\nРадиус:");
                    try
                    {
                        r = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        r = 0;
                    }

                    _listOfShapes.Add(new Circle(x, y, r));
                    break;
                case 2: // Rectangle
                    double upperLeftCornerCoordinateX;
                    double upperLeftCornerCoordinateY;
                    double bottomRightCornerCoordinateX;
                    double bottomRightCornerCoordinateY;

                    Console.WriteLine("\nВведите координаты левого верхнего угла." +
                                      "\nX: ");
                    try
                    {
                        upperLeftCornerCoordinateX = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        upperLeftCornerCoordinateX = 0;
                    }
                    Console.WriteLine("\nY:");
                    try
                    {
                        upperLeftCornerCoordinateY = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        upperLeftCornerCoordinateY = 0;
                    }

                    Console.WriteLine("\nВведите координаты правого нижнего угла." +
                                      "\nX: ");
                    try
                    {
                        bottomRightCornerCoordinateX = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        bottomRightCornerCoordinateX = 0;
                    }
                    Console.WriteLine("\nY:");
                    try
                    {
                        bottomRightCornerCoordinateY = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        bottomRightCornerCoordinateY = 0;
                    }
                    _listOfShapes.Add(new Rectangle(upperLeftCornerCoordinateX, upperLeftCornerCoordinateY,
                        bottomRightCornerCoordinateX, bottomRightCornerCoordinateY));
                    break;

                case 3: // Triangle
                    double cat1;
                    double cat2;
                    double hypotenuse;
                    Console.WriteLine("\nВведите катеты." +
                                      "\n1-й катет: ");
                    try
                    {
                        cat1 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        cat1 = 0;
                    }
                    Console.WriteLine("\n2-й катет:");
                    try
                    {
                        cat2 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        cat2 = 0;
                    }
                    Console.WriteLine("\nГипотенуза:");
                    try
                    {
                        hypotenuse = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        hypotenuse = 0;
                    }
                    _listOfShapes.Add(new Triangle(cat1, cat2, hypotenuse));
                    break;
            }
        }

        // Удаление фигуры из массива.
        private void Delete(int index)
        {
            _listOfShapes.RemoveAt(index);
        }

        // Печать всех фигур. 
        private void PrintAll()
        {
            int counter = 0;
            foreach (Shape item in _listOfShapes)
            {
                if (item is Circle)
                {
                    Console.WriteLine($"Shape № {counter}");
                    Console.WriteLine((item as Circle)?.Show());
                    Console.WriteLine();
                    counter++;
                    continue;
                }
                if (item is Rectangle)
                {
                    Console.WriteLine($"Shape № {counter}");
                    Console.WriteLine((item as Rectangle)?.Show());
                    Console.WriteLine();
                    counter++;
                    continue;
                }
                if (item is Triangle)
                {
                    Console.WriteLine($"Shape № {counter}");
                    Console.WriteLine((item as Triangle)?.Show());
                    Console.WriteLine();
                    counter++;
                }
            }
            Console.WriteLine($"Распечатано {counter} фигур.");
        }

        // Печать фигур указанного типа.
        private void PrintByType(int typeNumber)
        {
            int counter = 0;
            foreach (Shape item in _listOfShapes)
            {
                if (item is Circle & typeNumber == 1)
                {
                    Console.WriteLine($"Shape № {counter}");
                    Console.WriteLine((item as Circle)?.Show());
                    Console.WriteLine();
                    counter++;
                    continue;
                }
                if (item is Rectangle & typeNumber == 2)
                {
                    Console.WriteLine((item as Rectangle)?.Show());
                    Console.WriteLine();
                    counter++;
                    continue;
                }
                if (item is Triangle & typeNumber == 3)
                {
                    Console.WriteLine((item as Triangle)?.Show());
                    Console.WriteLine();
                    counter++;
                }
            }

            Console.WriteLine($"Распечатано {counter} фигур.");
        }

        // Вычисление площади всех фигур.
        private void AreaAllShapes()
        {
            int counter = 0;
            foreach (Shape item in _listOfShapes)
            {
                if (item is Circle)
                {
                    Console.WriteLine((item as Circle)?.Show());
                    Console.WriteLine((item as Circle)?.Area());
                    Console.WriteLine();
                    counter++;
                    continue;
                }
                if (item is Rectangle)
                {
                    Console.WriteLine((item as Rectangle)?.Show());
                    Console.WriteLine((item as Rectangle)?.Area());
                    Console.WriteLine();
                    counter++;
                    continue;
                }
                if (item is Triangle)
                {
                    Console.WriteLine((item as Triangle)?.Show());
                    Console.WriteLine((item as Triangle)?.Area());
                    Console.WriteLine();
                    counter++;
                }
            }

            Console.WriteLine($"Распечатано {counter} фигур.");
        }

        // Вычисление площади фигур указанного типа(следует применять средства динамической идентификации типа).
        private void AreaShapesByType(int type)
        {
            int counter = 0;
            foreach (Shape item in _listOfShapes)
            {
                if (item is Circle && type == 1)
                {
                    Console.WriteLine((item as Circle)?.Show());
                    Console.WriteLine((item as Circle)?.Area());
                    Console.WriteLine();
                    counter++;
                    continue;
                }
                if (item is Rectangle && type == 2)
                {
                    Console.WriteLine((item as Rectangle)?.Show());
                    Console.WriteLine((item as Rectangle)?.Area());
                    Console.WriteLine();
                    counter++;
                    continue;
                }
                if (item is Triangle && type == 3)
                {
                    Console.WriteLine((item as Triangle)?.Show());
                    Console.WriteLine((item as Triangle)?.Area());
                    Console.WriteLine();
                    counter++;
                }
            }

            Console.WriteLine($"Распечатано {counter} фигур.");
        }

        // Сохранение фигур в файл.
        private void SaveToFile()
        {
            StreamWriter sw = new StreamWriter("Shapes.txt");

            sw.WriteLine(_listOfShapes.Count);

            foreach (Shape item in _listOfShapes)
            {
                if (item is Circle)
                {
                    (item as Circle)?.Save(sw);
                    continue;
                }
                if (item is Rectangle)
                {
                    (item as Rectangle)?.Save(sw);
                    continue;
                }
                if (item is Triangle)
                {
                    (item as Triangle)?.Save(sw);
                }
            }
            sw.Close();
        }

        // Загрузка фигур из файла.
        private void LoadFromFile()
        {
            StreamReader sr = new StreamReader("Shapes.txt");

            int count = int.Parse(sr.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string type = sr.ReadLine();
                switch (type)
                {
                    case "Circle":
                        Circle circle = new Circle(0, 0, 0);
                        circle.Load(sr);
                        _listOfShapes.Add(circle);
                        break;
                    case "Rectangle":
                        Rectangle rectangle = new Rectangle(0, 0, 0, 0);
                        rectangle.Load(sr);
                        _listOfShapes.Add(rectangle);
                        break;
                    case "Triangle":
                        Triangle triangle = new Triangle(0, 0, 0);
                        triangle.Load(sr);
                        _listOfShapes.Add(triangle);
                        break;
                }
            }
            sr.Close();
        }

        // Генератор фигур.
        private static Shape GeneratorOfFigures()
        {
            Random rnd = new Random();

            int n = rnd.Next(3);
            switch (n)
            {
                case 0:
                    return new Triangle(rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                case 1:
                    return new Rectangle(rnd.Next(1, 100), rnd.Next(1, 100),
                        rnd.Next(1, 100), rnd.Next(1, 100));
                case 2:
                    return new Circle(rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100));
                default:
                    return null;
            }
        }

        // Для продолжения нажмите любую клавишу.
        private void PressAnyKeyToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
        }

        // Меню.
        public void MainMenu()
        {
            string choice = "";
            LoadFromFile();
            do
            {
                Console.Clear();
                Console.WriteLine("\n1. Добавление фигуры в массив." +
                                  "\n2. Удаление фигуры из массива." +
                                  "\n3. Печать всех фигур." +
                                  "\n4. Печать фигур указанного типа." +
                                  "\n5. Вычисление площади всех фигур." +
                                  "\n6. Вычисление площади фигур указанного типа." +
                                  "\n7. Сгенерировать 10 фигур." +
                                  "\n8. Выход.");
                Console.WriteLine();
                Console.WriteLine("\nЯ выбираю: ");
                try
                {
                    choice = Convert.ToString(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                Console.WriteLine();
                switch (choice)
                {
                    case "1": // 1. Добавление фигуры в массив.
                        Console.WriteLine("1. Добавление фигуры в массив." +
                                          "\n\tКакую фигуру добавить ?" +
                                          "\n\t1. Circle" +
                                          "\n\t2. Rectangle" +
                                          "\n\t3. Triangle");
                        try
                        {
                            AddShape(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        PressAnyKeyToContinue();
                        break;

                    case "2": // 2. Удаление фигуры из массива.
                        Console.WriteLine("2. Удаление фигуры из массива.");
                        PrintAll();
                        Console.WriteLine("\nВведите номер удаляемого елемента.");
                        try
                        {
                            Delete(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        PressAnyKeyToContinue();
                        break;

                    case "3": // 3. Печать всех фигур.
                        Console.WriteLine("3. Печать всех фигур.\n");
                        PrintAll();
                        PressAnyKeyToContinue();
                        break;

                    case "4": // 4. Печать фигур указанного типа.
                        Console.WriteLine("4. Печать фигур указанного типа." +
                                          "\n\tКакие фигуры хотите вывести ?" +
                                          "\n\t1. Circle" +
                                          "\n\t2. Rectangle" +
                                          "\n\t3. Triangle");
                        try
                        {
                            PrintByType(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        PressAnyKeyToContinue();
                        break;

                    case "5": // 5. Вычисление площади всех фигур.
                        Console.WriteLine("5. Вычисление площади всех фигур.");
                        Console.WriteLine();
                        AreaAllShapes();
                        PressAnyKeyToContinue();
                        break;

                    case "6": // 6. Вычисление площади фигур указанного типа.
                        Console.WriteLine("6. Вычисление площади фигур указанного типа" +
                                          "\n\tВыберите тип:" +
                                          "\n\t1. Circle" +
                                          "\n\t2. Rectangle" +
                                          "\n\t3. Triangle");
                        try
                        {
                            AreaShapesByType(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        PressAnyKeyToContinue();
                        break;

                    case "7": // 7. Сгенерировать 20 фигур.
                        Console.WriteLine("7. Сгенерировать 10 фигур.");
                        for (int i = 0; i < 10; i++)
                            _listOfShapes.Add(GeneratorOfFigures());
                        Console.WriteLine();
                        Console.WriteLine("Сгенерировано 10 фигур.");
                        PressAnyKeyToContinue();
                        break;

                    case "8": // 8. Выход.
                        SaveToFile();
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}