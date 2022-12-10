// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.  string number = a.ToString();

int i = 0;
int a = 0;
int sum = 0;

Console.Write("Введите ваше число ");
int.TryParse(Console.ReadLine()!, out a);
string array = a.ToString();
int size = array.Length;

while (i < size)
{
sum = array[i] + a;
i = i + 1;
}
Console.Write($"Ответ: {sum}");