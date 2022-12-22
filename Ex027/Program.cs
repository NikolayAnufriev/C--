/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии. */

int n;

Console.Write($"Введите число:  ");
int.TryParse(Console.ReadLine()!, out n);

string array(int a, int b)
{
    if (a <= b)
       return a.ToString();
    return $"{a } {array(a - 1, b)}";
}

Console.Write($"{array(n, 1)}");