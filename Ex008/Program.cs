// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

int i = 0;
int n = 1;

Console.Write("Введите ваше число ");
string array = (Console.ReadLine()!);
int size = array.Length;

while (i < 2) // т.к нам нужно сравнить индексы 2 раза (для пятизначного числа)
{
    if (array [i] == array[(size- n)])
        {
           i = i + 1;  n = n + 1;
        }   
    else
       {
           i = 2; 
           Console.Write("Данное число не палиндром"); 
       }
 
}
if (array[1] == array[3])
    Console.Write("Данное число палиндром");