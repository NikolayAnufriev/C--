/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. */

int n;
Console.Write("Введите размер массива   ");
int.TryParse(Console.ReadLine()!, out n);

double[] array = new double[n];

for (int i = 0; i < array.Length; i++)
{array[i] = new Random().Next(100) /10.0;}

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    else if (array[i] < min)
        min = array[i];
}
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.Write(" \n");
Console.Write($"Разница значений =  {max - min} ");