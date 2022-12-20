/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. */

int[,] array = new int[4, 4];

int numbers = 10; 
int i = 0; int j = 0;
int n = 1; int s = 0; int d = 1; // вспомогательные переменные.

for(int m = 0; m < 2; m++) // 2 т.к нам нужно заполнить по кругу 2 раза.
{

  while (j < array.GetLength(1) - n) // Заполняем верхнюю строку
  {   
      array[i, j] = numbers;
      numbers++;
      j++;
  }
  while (i < array.GetLength(0) - n) // Заполняем правый столбец
  {   
      array[i, j] = numbers;
      numbers++;
      i++;
  }
  while (j >= s) // Заполняем нижнюю строку
  {   
    array[i, j] = numbers;
    numbers++;
    j--;
  }
  j++; i--;
  while (i >= d && n != 2) // Заполняем левую строку
  {   
     array[i, j] = numbers;
     numbers++;
     i--;
  }
  i++; j++;
  n++; s++; d--;
}

Console.WriteLine("Заданный двумерный массив 4х4 заполненный спирально: \n");

for (int k = 0; k < array.GetLength(0); k++) 
{
    for (int l = 0; l < array.GetLength(1); l++)
    {
        Console.Write($"{array[k, l]} ");
    }
    Console.WriteLine();
}

// Так же можно просто заполнить по очереди каждый элемент а после напечатать массив.

/* int[,] array = new int[4, 4];

int numbers = 10; 

array[0,0] = numbers; numbers++;    
array[0,1] = numbers; numbers++;    
array[0,2] = numbers; numbers++;    
array[0,3] = numbers; numbers++;    
array[1,3] = numbers; numbers++;    
array[2,3] = numbers; numbers++;    
array[3,3] = numbers; numbers++;   
array[3,2] = numbers; numbers++;    
array[3,1] = numbers; numbers++;    
array[3,0] = numbers; numbers++;   
array[2,0] = numbers; numbers++;     
array[1,0] = numbers; numbers++;   
array[1,1] = numbers; numbers++;    
array[1,2] = numbers; numbers++;    
array[2,2] = numbers; numbers++;     
array[2,1] = numbers; numbers++; 

Console.WriteLine("Заданный двумерный массив 4х4 заполненный спирально: \n");

for (int k = 0; k < array.GetLength(0); k++) 
{
    for (int l = 0; l < array.GetLength(1); l++)
    {
        Console.Write($"{array[k, l]} ");
    }
    Console.WriteLine();
} */