﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным




int a;

Console.Write($"Введите число от 1 до 7: "); // т.к в неделе 7 дней 
int.TryParse(Console.ReadLine()!, out a);

if (a >= 6)
   Console.Write("Выходной день ");
else
   Console.Write("Рабочий день ");
   