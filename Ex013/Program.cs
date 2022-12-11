/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

 --Можно сделать как показывали в лекции (если убрать слеши можно запустить программу)--

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

Немного модифицировав код можно делать так как показано ниже*/ 

int[] array = new int[8];

int i = 0;
int size = array.Length;

while (i < size)
{
  array[i] = new Random().Next(0, 11); 
  Console.Write($"Случайный массив = {array[i]} ");
  i++;
}
