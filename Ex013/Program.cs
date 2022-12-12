/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */ 

int[] array = new int[8];

int i = 0;
int size = array.Length;

while (i < size)
{
  array[i] = new Random().Next(0, 11); 
  Console.Write($"{array[i]} ");
  i++;
}