/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

int[,,] array = new int[2,2,2];

Console.WriteLine("Заданный трехмерный массив массив: \n");
int number = 13;
for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        for (int z = 0; z < array.GetLength(2); z++)
        {
            array[x, y, z] = number;
            number += 10;
            Console.Write($"{array[x, y, z]} ({x},{y},{z}) ");
        }
        Console.WriteLine();
    }    
}