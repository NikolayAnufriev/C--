/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов. */

int ix; int iy;

Console.WriteLine("Введите количество строк массива ");
int.TryParse(Console.ReadLine()!, out ix);
Console.WriteLine("Введите количество столбцов массива ");
int.TryParse(Console.ReadLine()!, out iy);

int[,] array = new int[ix, iy];

Console.WriteLine("Заданный двумерный массив: \n");

for (int i = 0; i < array.GetLength(0); i++)  // Генерируем двумерный массив
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
int sum = 0;
int[] array1 = new int[ix];
for (int i = 0; i < array.GetLength(0); i++) // Вычисление суммы строки 
{    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    } 
    array1[i] = sum;
    sum = 0;
}
Console.WriteLine();
int min = array1[0];
int number = 0;
for (int i = 0; i < array1.Length; i++) // Вычисление минимальной суммы 
{
    if (array1[i] < min)
    {
        min = array1[i];
        number = i + 1;
    }
}
Console.WriteLine($"Наименьшая сумма строки = {min} \nПренадлежит {number} строке ");