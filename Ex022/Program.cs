/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива. */

int[,] array = new int[3, 4];

Console.WriteLine("Заданный двумерный массив: \n");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

/* for (int j = 0; j < array.GetLength(1); j++)
{
    int current = j;


if (array [i, j] )


} */

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int n = 0; n < array.GetLength(1); n++)
    {
        int max = array[i,j];
        for (int j = 0 + n; j < array.GetLength(1); j++)
            {
               if (array[i,j] > max)
               max = array[i,j];
            }
        Console.Write($"{max} ");
    }  
}   