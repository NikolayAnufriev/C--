/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. */

int m;
int n;

Console.Write($"Введите начальное значение:  ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите конечное значение:  ");
int.TryParse(Console.ReadLine()!, out n);

int Akk(int a, int b)
{
    if (a == 0)
       return b + 1;
    else if (b == 0)
       return Akk(a - 1, 1);
    else 
       return Akk(a - 1, Akk(a, b - 1));
}

Console.Write($"Ответ = {Akk(m, n)}");