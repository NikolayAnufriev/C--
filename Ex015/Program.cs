/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. */

int n;

Console.WriteLine("Введите размер массива ");
int.TryParse(Console.ReadLine()!, out n);

int[] array = new int[n];

int i = 0;
int j = 0;
int sum = 0;
int size = array.Length;

Console.Write($"Заданный массив ->  ");
while (i < size)
{
  array[i] = new Random().Next(0, 11); 
  Console.Write($"{array[i]} ");
  i++;
}
while (j < size)
{
  sum += array[j];
  j = j +2;
} 
Console.Write($" \n");
Console.Write($"Сумма элементов, стоящих на нечётных позициях. = {sum} ");