// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
}

void PaintArray(double[] array)
{
    Console.Write("[ ");
    foreach (double item in array)
        Console.Write($"{item} ");
    Console.Write("]");
}

void Difference(double[] array)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max)
        {
            max = array[j];
        }
        if (array[j] < min)
        {
            min = array[j];
        }
    }
    Console.WriteLine($"=> {max} - {min} = {max - min}");
}

double[] array = new double[5];
FillArray(array);
PaintArray(array);
Difference(array);