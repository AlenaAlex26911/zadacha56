// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = 4;
int cols = 4;
int[,] array = new int[rows, cols];
for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(3);
        Console.Write(array[i, j] + "\t");

    }
    Console.WriteLine();
}
int minRowSum = int.MaxValue;
int indexMinRow = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int Sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Sum += array[i, j];
    }
    if (Sum < minRowSum)
    {
        minRowSum = Sum;
        indexMinRow = i;
    }
}
Console.WriteLine($"Строка с минимальной суммой элементов {indexMinRow + 1}");
