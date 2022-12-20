/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива. */

int[,] array = new int[4, 4];

Console.WriteLine("Заданный двумерный массив: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int x = 0; x < array.GetLength(0); x++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int k = array[x, i];
        int j = i - 1;

        while (j >= 0 && array[x, j] < k)
        {
            array[x, j + 1] = array[x, j];
            array[x, j] = k;
            j--;
        }
    }    
}
Console.WriteLine("Отсортированный массив: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}