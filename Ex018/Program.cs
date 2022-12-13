/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. */

double k1; double k2;
double b1; double b2;

Console.Write("введите значение b1 ");
double.TryParse(Console.ReadLine()!, out b1);
Console.Write("введите значение b2 ");
double.TryParse(Console.ReadLine()!, out b2);
Console.Write("введите значение k1 ");
double.TryParse(Console.ReadLine()!, out k1);
Console.Write("введите значение k2 ");
double.TryParse(Console.ReadLine()!, out k2);

double x = (b2 - b1) / (k1 - k2);
double y =  k1 * x + b1;

Console.Write($"Координаты пересечения:\n x = {x} \n y = {y}");