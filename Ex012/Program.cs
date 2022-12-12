// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.  


int a;
int b;       // остаток от деления на 10
int sum = 0;
int currentN;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

while (0 < a)
{
  b = a % 10;
  currentN = a / 10;
  a = a - a + currentN;
  sum += b;
}

Console.Write($"Сумма = {sum}");