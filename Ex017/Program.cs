/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. */

int m;
int count = 0;
Console.Write($"Введите количество чисел:  ");
int.TryParse(Console.ReadLine()!, out m);

int[] array = new int[m];

for(int i = 0; i < m; i++)
{Console.Write($"Число № {i} = "); 
int.TryParse(Console.ReadLine()!, out array[i]);}

for (int i = 0; i < m; i++)
{
    if (array[i] > 0)
      count++;
}
Console.Write($"Количество чисел больше 0 = {count} ");