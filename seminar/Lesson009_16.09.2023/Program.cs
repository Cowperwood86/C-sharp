// Посчитать сумму всех чисел от 1 до N, где N вводит пользователь.

// int SummaCycle(int n)
// {
//     int sum = 0;
//     while (true)
//         {
//             if (n == 0)
//                 break;
//             sum = sum + n;
//             n = n - 1;
//         }
//     return sum;
// }

// int SummaRec(int n)
// {
//     if (n  == 0)
//         return 0;
//     return n + SummaRec(n - 1);
// }

// //SummaRec(4)
// // 4 + (3 + (2 + ( 1 + 0)))
// // 4 + ( 3 + 3)
// // 10


// System.Console.WriteLine("Введите натуральное число ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SummaCycle(n));
// System.Console.WriteLine(SummaRec(n));

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// N = 5 -> "1, 2, 3, 4, 5" 
// N = 6 -> "1, 2, 3, 4, 5, 6" 

// string PrintNumbers(int n) 
// { 
//     if (n == 0) 
//         return ""; 
//     return PrintNumbers(n - 1) + $"{n} ";
// } 
 
// System.Console.WriteLine("Введите натуральное число "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine(PrintNumbers(n));

// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 6, 7, 8" 
 
// string PrintNumbers(int m, int n) 
// { 
//     if (n < m) 
//         return ""; 
//     return PrintNumbers(m, n - 1) + $"{n} "; 
// } 
 
// System.Console.WriteLine("Введите нижнюю границу M"); 
// int min = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите верхнюю границу N"); 
// int max = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine(PrintNumbers(min, max));

// Задача 67: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int SumDigits(int n) 
// { 
//     if (n == 0) 
//         return 0; 
//     return n % 10 + SumDigits(n / 10); 
// } 
 
// System.Console.WriteLine("Введите натуральное число "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine($"Сумма цифр числа равна: {SumDigits(n)}");

// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int Sqare(int a, int b) 
// { 
//     if (b == 1) 
//         return a; 
//     return a * Sqare(a, b-1); 
// } 
 
// System.Console.WriteLine("Введите натуральное число "); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите степень "); 
// int b = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine(Sqare(a, b));

//Найти число Фибоначи с помощью рекурсии

// int Fibonaci(int n) 
// { 
//     if (n == 1 || n == 2) 
//         return n - 1; 
//     return Fibonaci(n - 1) + Fibonaci(n - 2); 
// } 
 
// System.Console.WriteLine("Введите натуральное число "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine(Fibonaci(n));