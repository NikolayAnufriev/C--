// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int a;
int size;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
string number = a.ToString();
size = number.Length;

if (size < 3)
    Console.Write($"Третьей цифры нет");
else
    Console.Write($"Цифра = {number[2]}");
