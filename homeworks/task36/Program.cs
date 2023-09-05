// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}

void PaintArray(int[] array)
{
    Console.Write("[ ");
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.Write("]");
}

void SumOddElements(int[] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j+=2)
        sum = sum + array[j];
    Console.WriteLine($" -> {sum} (сумма элементов, стоящих на нечетных позициях)");
}

int[] array = new int[4];
FillArray(array);
PaintArray(array);
SumOddElements(array);