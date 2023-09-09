// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// void FillArray(int[] array)//Заполняем массив случайными числами
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100,100);
// }

// void PaintArray(int[] array)//Печатаем массив
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// void ReverseArray(int[] array)//Переворачиваем массив
// {
//     // int buf;
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         // buf = array[i];
//         // array[i] = array[array.Length - 1 - i];
//         // array[array.Length - 1 - i] = buf;   
//         (array[i], array[array.Length - 1 - i]) = (array[array.Length - 1 - i], array[i]);//Тоже самое, только короче
//     }
// }

// System.Console.WriteLine("Введите количество элементов массива");
// int len = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[len];
// FillArray(array);
// PaintArray(array);
// ReverseArray(array);
// PaintArray(array);

// Задача 40: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с 
// сторонами такой длины. 
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

// bool Triangle(int a, int b, int c)
// {
//     bool result = false;
//     if (a<(b+c) && b<(a+c) && c<(c+b))
//         result = true;
// }

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Triangle (a, b, c));

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// string Binare(int number)
// {
//     string result = "";
//     while(number > 0)
//     {
//         result = (number % 2) + result;
//         number /= 2;
//     }
//     return result;
// }

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Binare(number));

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void Fibbonachi(int N)
// {
//     string fibb = "0 ";
//     int second = 0;
//     int first = 1;
//     int current;
//     if (N >= 2)
//         fibb = "0 1 ";
//     for (int i = 3; i <= N; i++)
//     {
//         current = first + second;
//         fibb = fibb + current + "";
//         second = first;
//         first = current;
//     }
//     System.Console.WriteLine(fibb);
// }

// System.Console.WriteLine("Введите число");
// int f = Convert.ToInt32(Console.ReadLine());
// Fibbonachi(f); 

// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.