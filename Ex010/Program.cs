// Задача 23  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int a;
int n = 1;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

while (n <= a)
{
    Console.Write($"{n*n*n}, ");
    n = n + 1;
}