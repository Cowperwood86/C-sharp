// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int square = num * num;
// Console.WriteLine(square);
// Console.WriteLine($"Квадрат введенного числа равен {square}");

// if (num > 0)
// {
//     Console.WriteLine("Это положительное число");
// }
// else if (num == 0)
//     Console.WriteLine("Это ноль");
// else
//     Console.WriteLine("Число отрицательное");

// int i = 1;
// while (i <= 10)
// {
//     Console.Write($"{i} ");
//     i = i + 1;
//     //i++
// }
// Console.WriteLine();

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int square = num2 * num2; //square - это переменная
// Console.WriteLine(square);

// if (num1 == square)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число");
// int numN = Convert.ToInt32(Console.ReadLine());
// int i = -numN;
// while(i <= numN)
// {
//     Console.Write($"{i} ");
//     i = i + 1;
// }
// Console.WriteLine();

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.WriteLine("Введите трёхзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num % 10}");