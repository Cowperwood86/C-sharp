// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++) 
//             array[i,j] = new Random().Next(-30,31);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//             System.Console.Write($"{array[i,j], 3}   ");
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32 (Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32 (Console.ReadLine());
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++) 
//             array[i,j] = i + j;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//             System.Console.Write($"{array[i,j],3}   ");
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Введите количество строк m");
// int rows = Convert.ToInt32 (Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов n");
// int cols = Convert.ToInt32 (Console.ReadLine());
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечётные, и замените эти элементы на их
// квадраты.

// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++) 
//             array[i,j] = new Random().Next(0,101);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//             System.Console.Write($"{array[i,j],4}   ");
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindNumber (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++) 
//             if (i % 2 != 0 && j % 2 != 0)
//                 array [i,j] = array[i,j] * array [i,j];
// }

// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32 (Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32 (Console.ReadLine());
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);
// FindNumber(array);
// PrintArray(array);

// Задача 51: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++) 
//             array[i,j] = new Random().Next(0,11);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//             System.Console.Write($"{array[i,j],3}   ");
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int SumOfStraightDiagonal(int[,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         result += array[i,i];
//     }
//     return result;
// }

// int SumOfReserveDiagonal (int[,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         result += array[array.GetLength(0) - 1 - i, i];
//     }
//     return result;    
// }

// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32 (Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32 (Console.ReadLine());
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine(SumOfStraightDiagonal(array));
// System.Console.WriteLine(SumOfReserveDiagonal(array));