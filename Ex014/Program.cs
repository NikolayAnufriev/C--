/* Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int n;

Console.WriteLine("Введите размер массива ");
int.TryParse(Console.ReadLine()!, out n);

int[] array = new int[n];

int i = 0;
int j = 0;
int count = 0;
int size = array.Length;

while (i < size)
{
  array[i] = new Random().Next(100, 1000); 
  Console.Write($"{array[i]} ");
  i++;
}
while (j < size)
{
  if  (array[j] % 2 == 0) { j++; count = count + 1; }   

  else { j++; }     
} 
Console.Write($" \n");
Console.Write($"Количество чётных чисел в массиве = {count} ");