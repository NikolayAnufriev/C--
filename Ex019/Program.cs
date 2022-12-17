/* Задача 47. Задайте двумерный массив размером mxn, заполненный случайными вещественными числами 
m = 3, n =4 */

double[,] array = new double[3, 4];

Console.WriteLine("Заданный двумерный массив: \n");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(100) / 10.0;
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();