// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int array = new Random().Next(0,20);
// Console.Write($"Итоговый массив = {array}\n");


int[] array = new int[8];

void Newarray(int[] array)
{
    int size = array.Length;
    int i  = 0;
    while (i < size)
    {
        array[i] = new Random().Next(0, 11); 
        i++;
    }
}

void PrintArray(int[] arrayprint)

{
    int sizearray = arrayprint.Length;
    int index = 0;
    while (index < sizearray)
    {
        Console.Write($"{arrayprint[index]} ");
        index++;
    }
}



Newarray(array);
PrintArray(array);
