// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// void FillArray(int[] array)//Заполняем массив
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PaintArray(int[] array)//Печатаем массив
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// void FindSums(int[] array)//То что снизу, это такое же решение
// {
//     int sumP = 0;
//     int sumN = 0;
//     foreach (int item in array)
//         if (item > 0)
//             sumP += item;
//         else
//             sumN += item;
//     System.Console.WriteLine($"Сумма отрицательных элементов равна {sumN}");
//     System.Console.WriteLine($"Сумма положительных элементов равна {sumP}");       
// }

// int[] FindSums2(int[] array)//То что сверху, это такое же решение
// {
//     int sumP = 0;
//     int sumN = 0;
//     foreach (int item in array)
//         if (item > 0)
//             sumP += item;
//         else
//             sumN += item;  
//     int [] result = {sumN, sumP};
//     return result;
// }

// int [] array = new int [12];
// FillArray(array);
// PaintArray(array);
// FindSums(array);
// int[] sums = FindSums2(array);
// System.Console.WriteLine($"Сумма отрицательных элементов равна {sums[0]}");
// System.Console.WriteLine($"Сумма положительных элементов равна {sums[1]}");       

// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void FillArray(int[] array)//Заполняем массив случайными числами
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PaintArray(int[] array)//Печатаем массив
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// void Ineverse(int[] array)//Переворачиваем массив
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
// }

// int[] array = new int[10];
// FillArray(array);
// PaintArray(array);
// Ineverse(array);
// PaintArray(array);

// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// void FillArray(int[] array)//Заполняем массив случайными числами
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-5,5);
// }

// void PaintArray(int[] array)//Печатаем массив
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// bool FindNumber(int[] array, int number)//Находим число
// {
//     bool find = false;
//     foreach (int item in array)
//     if (item == number)
//     {
//         find = true;
//         break;
//     }
//     return find;
// }

// int[] array = new int[10];
// FillArray(array);
// PaintArray(array);
// System.Console.WriteLine(FindNumber(array, 4));

// Задача 35: Задайте одномерный массив из 15 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [-100,100].
// Пример для массива из 5, а не 15 элементов. В своём решении сделайте для 15
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

// void FindNumbers(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] >= 10 && array[i] <= 99)
//         count = count + 1;
//     System.Console.WriteLine($"Количество элементов {count}");
// }

// int[] array = new int[15];
// FillArray(array);
// PaintArray(array);
// FindNumbers(array);

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

// void FillArray(int[] array)//Заполняем массив случайными числами
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }

// void PaintArray(int[] array)//Печатаем массив
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// int [] ProductArray(int[] array)//Находим сумму
// {
//     int LengthArray = array.Length / 2 + array.Length % 2;
//     int[] arraySum = new int[LengthArray];
//     int even = array.Length % 2;
//         for (int i = 0; i < array.Length / 2; i++)
//         {
//             arraySum[i] = array[i] * array[array.Length - 1 - i];
//         }
//     if (even == 1) arraySum[^1] = array[array.Length/2];
//     return arraySum;
// }

// int[] array = new int[11];
// FillArray(array);
// PaintArray(array);
// int[] arraySum = ProductArray(array);
// PaintArray(arraySum);