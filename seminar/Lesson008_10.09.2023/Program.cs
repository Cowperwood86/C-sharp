// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-30, 31);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j],3}   ");
//         System.Console.WriteLine();
//     }
// }

// void ExchangeRowValue(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         (array[0, i], array[array.GetLength(0) - 1, i]) = (array[array.GetLength(0) - 1, i], array[0, i]);
//     }
// }

// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// ExchangeRowValue(array);
// PrintArray(array);

//  30    10     4
//   4   -11     1
//   9    21    27

//   9    21    27
//   4   -11     1   
//  30    10     4

// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-30, 31);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j],3}   ");
//         System.Console.WriteLine();
//     }
// }

// void ExchangeValueToCol(int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     {
//         System.Console.WriteLine("Замена не возможна");
//     }
//     else
//         for (int i = 0; i < array.GetLength(0); i++)
//         {    
//             for (int j = i; j < array.GetLength(1); j++)
//             {
//                 (array[i,j], array[j,i])  = (array[j,i], array[i,j]);
//             }
//         }
// }

// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// ExchangeValueToCol(array);
// PrintArray(array);

// -22    -5    11
//  -1     1   -30   
// -19     3   -16

// -22    -1   -19
//  -5     1     3   
//  11   -30   -16

// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             System.Console.Write($"{array[i, j],3}   ");
//         System.Console.WriteLine();
//     }
// }

// void CountDigits(int[,] array)
// {
//     int number = 0;
//     int result = 0;
//     while(number<10)
//     {
//         foreach (int item in array)
//         {
//             if (item == number) result++;
//         }
//         if(result > 0)
//         {    
//             System.Console.WriteLine($"Цифра {number} встречается {result} раз");
//         }
//         result = 0;
//         number++;
//     }

// }

// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// CountDigits(array);

// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
