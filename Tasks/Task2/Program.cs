// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

int[,] numbers(int m, int n)
{
    int[,] Array = new int[m, n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 10);

        }
    }
    return Array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

void SortArray(int[,] array)
{
int sum = 0;
int minsum = int.MaxValue;
int indexMinLine = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    sum =0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexMinLine = i+1;
    }
    Console.WriteLine($"Сумма {i+1}-ой строки равна {sum}");
}
Console.WriteLine($"Строка с наименьшей суммой элементов под номером -  {indexMinLine}");
Console.WriteLine();
}

int[,] array1 = numbers(4, 4);
PrintArray(array1);
SortArray(array1);