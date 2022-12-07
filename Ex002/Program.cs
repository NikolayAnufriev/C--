string user1;
string user2;
int max;
int min;

Console.Write("Введите первое число:");
user1 = Console.Readline()!;

Console.Write("Введите второе число:");
user2 = Console.Readline()!;

if (user1 > user2) max = user1; min = user2;
if (user1 < user2) max = user2; min = user1;


Console.WriteLine($"Максимальное значение = {max}");
Console.WriteLine($"Минимальное значение = {min}");