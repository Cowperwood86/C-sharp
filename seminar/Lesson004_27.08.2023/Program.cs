// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int SumNumbers(int upper)
// {
//     int res = 0;
//     for (int i = 1; i <= upper; i++)
//         res += i;
//     return res;
// }

// System.Console.WriteLine("Введите натуральное число ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма всех числе от 1 до {num} равна {SumNumbers(num)}");

// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int digitnum(int num)
// {
//     int count = 1;
//     while (num/10 != 0)
//     {
//         num = num/10;
//         count = count + 1;
//     }
//     return count;
// }

// System.Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(digitnum(num));

// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// double Factorial(int N)
// {
//     double result = 1;
//     for (int i = 1; i <= N; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{number} -> {Factorial(number)}");

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void fillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
// }

// void printArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }

// void printDifference(int[] array)
// {
//     int num0 = 0;
//     int num1 = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == 0) num0++;
//         else if (array[i] == 1) num1++;
//     }
//     if (num0 > num1) System.Console.WriteLine($"  Number of zero({num0}) more than one({num1})");
//     else if (num0 < num1) System.Console.WriteLine($" Number of one({num1}) more than zero({num0})");
//     else System.Console.WriteLine(" They are equal");
// }

// int[] zeroOne = new int[8];
// fillArray(zeroOne);
// printArray(zeroOne);
// printDifference(zeroOne);


// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }



// Console.Write("Введите пятизначное число: ");
// string number = Console.ReadLine();

// void CheckingNumber(string number)
// {
//     if (number[0] == number[4] || number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - True.");
//     }
//     else Console.WriteLine($"{number} - False.");
// }

// if (number.Length == 5)
// {
//     CheckingNumber(number);
// }
// else Console.WriteLine($"Число не пятизначное");