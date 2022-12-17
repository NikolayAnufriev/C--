/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */

double[,] array = new double[3, 3];

Console.WriteLine("Заданный двумерный массив: \n");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-100, 101) / 10.0;
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int ix; int iy;
Console.Write($"Введите индекс строки: ");
int.TryParse(Console.ReadLine(), out ix);
Console.Write($"Введити индекс столбца: ");
int.TryParse(Console.ReadLine(), out iy);

if (ix >= 0 && ix < array.GetLength(0) && iy >= 0 && iy < array.GetLength(1))
   Console.Write($"Ваше число -> {array[ix, iy]} ");
else 
   Console.Write("*Ошибка* Индекс должен быть больше 0 и не больше размера массива! ");