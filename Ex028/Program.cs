/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. */

int m;
int n;

Console.Write($"Введите начальное значение:  ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите конечное значение:  ");
int.TryParse(Console.ReadLine()!, out n);

int sum(int a, int b)
{
    if (a >= b)
       return a;
    return a + sum(a + 1, b);
}

Console.Write($"Сумма натуральных элементов от {m} до {n} = {sum(m, n)}");