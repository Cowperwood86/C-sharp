//17. Напишите программу, которая принимает на вход координаты точки 
//(X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в 
//которой находится эта точка.

// void CheckKoords(int x, int y)
// {
//     if (x > 0 && y > 0)
//         System.Console.WriteLine("это первая четверть");
//     else if (x > 0 && y < 0)
//         System.Console.WriteLine("это четвертая четверть");
//     else if (x < 0 && y < 0)
//         System.Console.WriteLine("это третья четверть");
//     else if (x < 0 && y > 0)
//         System.Console.WriteLine("это вторая четверть");
//     else
//         System.Console.WriteLine("точка лежит на координатной оси");
// }

// int CheckKoords2(int x, int y)
// {
//     int result = 0;
//     if (x > 0 && y > 0)
//         result = 1;
//     else if (x > 0 && y < 0)
//         result = 4;
//     else if (x < 0 && y < 0)
//         result = 3;
//     else if (x < 0 && y > 0)
//         result = 2;
//     return result;
// }

// System.Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// CheckKoords (x, y);
// System.Console.WriteLine( $"это четверть № {CheckKoords2(x,y)}");

// if (x > 0 && y > 0)
// System.Console.WriteLine("это первая четверть");
// else if (x > 0 && y < 0)
// System.Console.WriteLine("это четвертая четверть");
// else if (x < 0 && y < 0)
// System.Console.WriteLine("это третья четверть");
// else if (x < 0 && y > 0)
// System.Console.WriteLine("это вторая четверть");
// else
// System.Console.WriteLine("точка лежит на координатной оси");

// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

// string Range(int a)
// {
//     string result = "Введите нормальное значение";
//     if (a == 1)
//     result = "x > 0, y > 0";
//     else if (a == 2)
//     result = "x < 0, y > 0";
//     else if (a == 3)
//     result = "x < 0, y < 0";
//     else if (a == 4)
//     result = "x > 0, y < 0";
//     return result;
// }

// System.Console.WriteLine("Введите номер четверти");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Диапозон: {Range(a)}");

// if (a == 1)
//     System.Console.WriteLine("x > 0, y > 0");
// else if (a == 2)
//     System.Console.WriteLine("x < 0, y > 0");
// else if (a == 3)
//     System.Console.WriteLine("x < 0, y < 0");
// else if (a == 4)
//     System.Console.WriteLine("x > 0, y < 0");
// else if (a >= 5)
//     System.Console.WriteLine("Это не четверть");

// Задача 21: Напишите программу, которая
// принимает на вход координаты двух
// точек и находит расстояние между ними в
// 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// System.Console.WriteLine("Введите координаты первой точки x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координаты первой точки y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координаты второй точки x2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координаты второй точки y2");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double Distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
// System.Console.WriteLine($"Расстояние между точками равно {Distance}");


// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// void Squares(int N)
// {
//     for (int i = 1; i <= N; i++)
//     {
//         int square = i * i;
//         System.Console.Write(square);
//         if (i < N)
//         {
//             System.Console.Write(",");
//         }
//         else
//         {
//             System.Console.WriteLine(".");
//         }
//     }
// }
// System.Console.WriteLine("Введите целое число");
// int N = Convert.ToInt32(Console.ReadLine());
// Squares(N);