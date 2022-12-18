/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива. */

double[,] array = new double[3, 4];

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

double max = array[0,0];
int count = 0; 
    for (int i = 0; i < array.GetLength(0); count++)
    {   
        if (count == array.GetLength(1))
            i = i + 1;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] > max)
            max = array[i,j];

        }
        Console.Write($"{max}");

    }
