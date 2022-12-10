// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Координаты первой точки(A) x1, y1, z1.  Координаты второй точки(B) x2, y2, z2.
int x1;  int y1;  int z1;
int x2;  int y2;  int z2;
int x;   int y;   int z;
double AB = 0;

Console.Write($"Введите координату x для первой точки ");
int.TryParse(Console.ReadLine()!, out x1);
Console.Write($"Введите координату y для первой точки ");
int.TryParse(Console.ReadLine()!, out y1);
Console.Write($"Введите координату z для первой точки ");
int.TryParse(Console.ReadLine()!, out z1);
Console.Write($"Введите координату x для второй точки ");
int.TryParse(Console.ReadLine()!, out x2);
Console.Write($"Введите координату y для второй точки ");
int.TryParse(Console.ReadLine()!, out y2);
Console.Write($"Введите координату z для второй точки ");
int.TryParse(Console.ReadLine()!, out z2);

x = x2 -x1;   y = y2 - y1;  z = z2 - z1;  x =(x*x); y = (y*y); z = (z*z); AB = (x+y+z); AB = Math.Sqrt(AB);

Console.Write($"Расстояние AB = {AB}\n");