// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8
// 12 -> 2
// 85 -> 8

// int num = new Random().Next(10, 100);
// System.Console.WriteLine($"Было сгенерировано число {num}");
// int digit1 = num / 10;
// int digit2 = num % 10;
// if (digit1 > digit2)
//     System.Console.WriteLine($"Наибольшая цифра этого числа это {digit1}");
// else if (digit1 == digit2)
//     System.Console.WriteLine("Обе цифры этого числа равны");
// else
//     System.Console.WriteLine($"Наибольшая цифра этого числа это {digit2}");

// for (int i = 0; i < 11; i++)
//     Console.Write($"{i} ");



// Напишите программу, которая выводит случайное трехзначное число и 
//удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100, 1000);
// System.Console.WriteLine($"Было сгенерировано трехзначное число {num}");
// int digit1 = num % 10;
// int digit2 = num / 100;
// int result = digit2 * 10 + digit1;
// System.Console.WriteLine(result);



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 % num2 == 0)
//     Console.WriteLine($"{num1} кратно {num2}");
// else
//     Console.WriteLine($"не кратно, остаток {num1 % num2}");



// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0)
//     System.Console.WriteLine("Да");
// else
//     System.Console.WriteLine("Нет");



// Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2 || num2  == num1 * num1)
//     System.Console.WriteLine("Да");
// else
//     System.Console.WriteLine("Нет");



// Напишите программу, которая выводит случайное трехзначное число и 
//удаляет вторую цифру этого числа.

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

while (num % 10 !=0)
System.Console.WriteLine(num % 10);
