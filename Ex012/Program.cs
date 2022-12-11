// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.  string number = a.ToString();


double a = 0;
double b = 0;

Console.Write("Введите ваше число ");
double.TryParse(Console.ReadLine()!, out a);

if (a < 10)
   Console.Write($"Ответ: {a}");
else 
   a = (a / 10); 
   b = ((a % 10) * 10);

   Console.Write($"Ответ: {a}");
