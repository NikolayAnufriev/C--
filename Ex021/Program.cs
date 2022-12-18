/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце. */

int[,] array = new int[3, 4];

Console.WriteLine("Заданный двумерный массив: \n");

for (int i = 0; i < array.GetLength(0); i++) // Создание массива
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(11);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

double sum = 0;

for (int j = 0; j < array.GetLength(1); j++) // Вычисление среднего
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i,j];
    }
    Console.Write($"Среднее {j + 1} столбца = {Math.Round(sum / array.GetLength(0), 1)}  \n");
    sum = 0;
}