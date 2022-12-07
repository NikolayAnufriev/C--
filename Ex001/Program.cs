//  Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 0;
int b = a;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);

if (a > b)
{
    Console.Write($"Максимальное число = {a}\n");
    Console.Write($"Минимальное число = {b}");
}
else
{
    Console.Write($"Максимальное число = {b}\n");
    Console.Write($"Минимальное число = {a}");
}
