// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
 
int SumNumbers(int m, int n) 
{ 
    if (n < m) 
        return 0; 
    return n + SumNumbers(m, n - 1); 
}
 
System.Console.WriteLine("Введите нижнюю границу M"); 
int m = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите верхнюю границу N"); 
int n = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine(SumNumbers(m, n));