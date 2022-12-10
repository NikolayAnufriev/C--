// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int a;
int b;
double c;

Console.Write($"Введите первое число 'a': ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите второе число 'b': ");
int.TryParse(Console.ReadLine()!, out b);

Console.Write($"Ответ: {c = Math.Pow(a,b)}");