/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива. */

int[,] array = new int[4, 4];
int c = 0;
/* int c = 0; int n = 0;
int l = 1;
int max = 0; */

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
Console.WriteLine();
/* for(int i = 0; i < array.GetLength(0); i++)
{
    while (n < array.GetLength(0))
    {    
         if (array[c, n] > max)
             max = array[c,n];
         n++;
    }
    Console.Write($"{max} ");
    max = 0; 
    n = 0;
    n += l; 
    l++;
}
 */


int[] array1 = new int[array.GetLength(0)];

for (int i = 0; i < array1.Length; i++)
{
     array1[i] = array[c,i];
     Console.Write($"{array1[i]} ");
}
Console.WriteLine();
c = c + 1;
int[] array2 = new int[array.GetLength(0)];

for (int i = 0; i < array2.Length; i++)
{
     array2[i] = array[c,i];
     Console.Write($"{array1[i]} ");
}
Console.WriteLine();
Console.WriteLine($"{c} ");