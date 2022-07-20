// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] ArrayNormal(int m, int n)
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < array.GetLength(0) - 1; z++)
            {
                if (array[i, z] < array[i, z + 1])
                {
                    int temp = 0;
                    temp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = temp;
                }
            }

        }
    }
}    

    int[,] array1 = ArrayNormal(5, 5);
    Console.WriteLine("Массив : ");
    PrintArray(array1);
    SortArray(array1);
    Console.WriteLine();
    Console.WriteLine(" Отсортированный массив : ");
    PrintArray(array1);
    Console.WriteLine();
