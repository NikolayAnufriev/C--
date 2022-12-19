/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

int[,] array = new int[,] { {2, 4}, {3, 2} }; // Первая матрица
Console.WriteLine("Первая матрица:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Вторая матрица:");
int[,] array2 = new int[,] { {3, 4}, {3, 3} }; // Вторая матрица

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        Console.Write($"{array2[i, j]} ");
    }
    Console.WriteLine();
}

// Формула перемножения матриц (размер 2х2)
int s00 = 0; int s01 = 0;
int s10 = 0; int s11 = 0;
s00 = array[0,0] * array2[0,0] +  array[0,1] * array2[1,0]; 
s01 = array[0,0] * array2[0,1] +  array[0,1] * array2[1,1];
s10 = array[1,0] * array2[0,0] +  array[1,1] * array2[1,0];
s11 = array[1,0] * array2[0,1] +  array[1,1] * array2[1,1];

Console.WriteLine("Результат перемножения матриц:");
int[,] array3 = new int[,] { {s00, s01}, {s10, s11} }; // Выводим матрицу после перемножения
for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        Console.Write($"{array3[i, j]} ");
    }
    Console.WriteLine();
}
