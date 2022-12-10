// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int a;
int n = 2;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

while (n <= a)
{
   if (n % 2 == 0)
   {
      Console.Write($"{n} ");
   }
   else 
   {
      Console.Write($" ");
   }
   n = n + 1;
}